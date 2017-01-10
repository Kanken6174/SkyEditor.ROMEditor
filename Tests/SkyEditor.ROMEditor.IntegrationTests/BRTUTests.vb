﻿Imports System.Drawing
Imports System.IO
Imports System.Security.Cryptography
Imports SkyEditor.Core.IO
Imports SkyEditor.Core.Windows.Providers
Imports SkyEditor.ROMEditor
Imports SkyEditor.ROMEditor.MysteryDungeon.Rescue
Imports SkyEditor.ROMEditor.Utilities

<TestClass> Public Class BRTUTests

    Private Const Category As String = "BRT (U) Files"

    'Files for all tests
    Dim romFilename As String = "brt-u.nds"
    Dim romDir As String = "extracted-BRT-U"

    Dim provider As IOProvider


    <TestInitialize()> Public Sub TestInit()
        'Set up
        provider = New WindowsIOProvider
        Try
            Using md5 As New MD5CryptoServiceProvider
                Dim hash = md5.ComputeHash(My.Resources.brt_u)
                If Not hash.SequenceEqual(My.Resources.BRT_U_MD5) Then
                    Assert.Inconclusive("Incorrect test ROM specified.  Should be a trimmed North America PMD: Blue Rescue Team ROM.")
                End If
            End Using

            provider.WriteAllBytes(romFilename, My.Resources.brt_u)
            Using nds As New GenericNDSRom
                nds.OpenFile(romFilename, provider).Wait()
                nds.Unpack(romDir, provider).Wait()
            End Using
        Catch ex As Exception
            Assert.Inconclusive("Failed to set up.  Exception message: " & ex.Message)
        End Try
    End Sub

    <TestCleanup> Public Sub Cleanup()
        If provider.FileExists(romFilename) Then
            provider.DeleteFile(romFilename)
        End If
        If provider.DirectoryExists(romDir) Then
            provider.DeleteDirectory(romDir)
        End If
    End Sub

    <TestMethod> <TestCategory(Category)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub SBinFileFormat()
        Dim dungeon = TestHelpers.GetAndTestFile(Of SBin)(Path.Combine(romDir, "data", "dungeon.sbin"), True, provider)
        Dim effect = TestHelpers.GetAndTestFile(Of SBin)(Path.Combine(romDir, "data", "effect.sbin"), True, provider)
        Dim ground = TestHelpers.GetAndTestFile(Of SBin)(Path.Combine(romDir, "data", "ground.sbin"), True, provider)
        Dim monster = TestHelpers.GetAndTestFile(Of SBin)(Path.Combine(romDir, "data", "monster.sbin"), True, provider)
        Dim ornament = TestHelpers.GetAndTestFile(Of SBin)(Path.Combine(romDir, "data", "ornament.sbin"), True, provider)
        Dim sample = TestHelpers.GetAndTestFile(Of SBin)(Path.Combine(romDir, "data", "sample.sbin"), True, provider)
        Dim system = TestHelpers.GetAndTestFile(Of SBin)(Path.Combine(romDir, "data", "system.sbin"), True, provider)
        Dim titlemenu = TestHelpers.GetAndTestFile(Of SBin)(Path.Combine(romDir, "data", "titlemenu.sbin"), True, provider)
    End Sub

    <TestMethod> <TestCategory(Category)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub MonsterKaoTest()
        Dim extractDir1 = "portraits-brt"
        Dim extractDir2 = "portraits-brt-repack"
        Dim repackFilename = "repack-monster.sbin"
        'Extract
        Dim monster1 As New SBin
        monster1.OpenFile(Path.Combine(romDir, "data", "monster.sbin"), provider).Wait()

        For Each item In monster1.Files.Where(Function(x) x.Key.StartsWith("kao"))
            Using kao As New KaoFile
                kao.Initialize(item.Value).Wait()
                For count = 0 To kao.Portraits.Count - 1
                    Dim targetFilename = Path.Combine(extractDir1, item.Key, count & ".png")
                    If Not Directory.Exists(Path.GetDirectoryName(targetFilename)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(targetFilename))
                    End If
                    kao.Portraits(count)?.Save(targetFilename, Drawing.Imaging.ImageFormat.Png)
                Next
            End Using
        Next

        'Repack
        For Each d In Directory.GetDirectories(extractDir1)
            Using kao As New KaoFile
                kao.CreateFile()
                kao.Portraits.Clear()

                For Each f In Directory.GetFiles(d, "*.png").Where(Function(x) IsNumeric(Path.GetFileNameWithoutExtension(x))).OrderBy(Function(x) CInt(Path.GetFileNameWithoutExtension(x)))
                    kao.Portraits.Add(Bitmap.FromFile(f))
                Next

                Dim kaoRawData = kao.GetRawData.Result
                File.WriteAllBytes(Path.Combine(d, repackFilename), kaoRawData)
                monster1.Files(Path.GetFileName(d)) = kaoRawData
            End Using
        Next
        monster1.Save(repackFilename, provider).Wait()


        'Extract again
        Dim monster2 As New SBin
        monster2.OpenFile(repackFilename, provider).Wait()

        For Each item In monster2.Files.Where(Function(x) x.Key.StartsWith("kao"))
            Using kao As New KaoFile
                kao.Initialize(item.Value).Wait()
                For count = 0 To kao.Portraits.Count - 1
                    Dim targetFilename = Path.Combine(extractDir2, item.Key, count & ".png")
                    If Not Directory.Exists(Path.GetDirectoryName(targetFilename)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(targetFilename))
                    End If
                    Try
                        kao.Portraits(count)?.Save(targetFilename, Drawing.Imaging.ImageFormat.Png)
                    Catch ex As Exception
                        Throw
                    End Try
                Next
            End Using
        Next

        'Compare
        For Each originalDirectory In Directory.GetDirectories(extractDir1)
            Dim repackDirectory = Path.Combine(extractDir2, Path.GetFileName(originalDirectory))
            Assert.IsTrue(Directory.Exists(repackDirectory), "Missing data for " & Path.GetFileName(originalDirectory) & " after repack.")
            For Each originalFile In Directory.GetFiles(originalDirectory, "*.png").OrderBy(Function(x) CInt(Path.GetFileNameWithoutExtension(x)))
                Dim repackFile = Path.Combine(repackDirectory, Path.GetFileName(originalFile))
                Using originalImage = Bitmap.FromFile(originalFile)
                    Using repackImage = Bitmap.FromFile(repackFile)
                        Assert.IsTrue(File.Exists(repackFile), $"Missing portrait {Path.GetFileNameWithoutExtension(originalFile)} in entry {Path.GetFileName(originalDirectory)}")
                        Assert.IsTrue(GraphicsHelpers.AreBitmapsEquivalent(originalImage, repackImage), $"Altered portrait {Path.GetFileNameWithoutExtension(originalFile)} in entry {Path.GetFileName(originalDirectory)}")
                    End Using
                End Using
            Next
        Next

        'Cleanup
        If Directory.Exists(extractDir1) Then
            Directory.Delete(extractDir1, True)
        End If
        If Directory.Exists(extractDir2) Then
            Directory.Delete(extractDir2, True)
        End If
        If File.Exists(repackFilename) Then
            File.Delete(repackFilename)
        End If
    End Sub

End Class
