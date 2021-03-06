﻿Imports System.Drawing
Imports System.IO
Imports System.Security.Cryptography
Imports DotNet3dsToolkit
Imports DotNetNdsToolkit
Imports SkyEditor.Core.IO
Imports SkyEditor.IO.FileSystem
Imports SkyEditor.ROMEditor.MysteryDungeon.Explorers
Imports SkyEditor.ROMEditor.Utilities

<TestClass()> Public Class EoSUTests

    Private Const EosTestCategory As String = "EOS (U) Files"

    Dim provider As IFileSystem

    <TestInitialize()> Public Sub TestInit()
        Using md5 As New MD5CryptoServiceProvider
            Dim hash = md5.ComputeHash(My.Resources.eos_u)
            If Not hash.SequenceEqual(My.Resources.EoS_U_MD5) Then
                Assert.Fail("Incorrect test ROM specified.  Should be a trimmed North America PMD: Explorers of Sky ROM.")
            End If
        End Using

        Dim nds As New NdsRom
        nds.OpenFileInMemory(My.Resources.eos_u).Wait()
        provider = nds
    End Sub

    <TestMethod> <TestCategory(EosTestCategory)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub Overlay13()
        Dim testFile = TestHelpers.GetAndTestFile(Of Overlay13)("/overlay/overlay_0013.bin", True, provider)
        'Starters
        'Bulbasaur
        Assert.AreEqual(CUShort(1), testFile.LonelyMale, "Incorrect starter for Lonely Male")
        Assert.AreEqual(CUShort(1 + 600), testFile.DocileFemale, "Incorrect starter for Docile Female")
        'Charamander
        Assert.AreEqual(CUShort(4), testFile.DocileMale, "Incorrect starter for Docile Male")
        Assert.AreEqual(CUShort(4 + 600), testFile.BraveFemale, "Incorrect starter for Brave Female")
        'Squirtle
        Assert.AreEqual(CUShort(7), testFile.QuirkyMale, "Incorrect starter for Quirky Male")
        Assert.AreEqual(CUShort(7 + 600), testFile.BoldFemale, "Incorrect starter for Bold Female")
        'Pikachu
        Assert.AreEqual(CUShort(25), testFile.BraveMale, "Incorrect starter for Brave Male")
        Assert.AreEqual(CUShort(25 + 600), testFile.HastyFemale, "Incorrect starter for Hasty Female")
        'Vulpix
        Assert.AreEqual(CUShort(37 + 600), testFile.RelaxedFemale, "Incorrect starter for Relaxed Female")
        'Eevee
        Assert.AreEqual(CUShort(133 + 600), testFile.JollyFemale, "Incorrect starter for Jolly Female")
        'Chikorita                 
        Assert.AreEqual(CUShort(152), testFile.CalmMale, "Incorrect starter for Calm Male")
        Assert.AreEqual(CUShort(152 + 600), testFile.QuietFemale, "Incorrect starter for Quiet Female")
        'Cyndaquil                 
        Assert.AreEqual(CUShort(155), testFile.TimidMale, "Incorrect starter for Timid Male")
        Assert.AreEqual(CUShort(155 + 600), testFile.CalmFemale, "Incorrect starter for Calm Female")
        'Totodile                  
        Assert.AreEqual(CUShort(158), testFile.JollyMale, "Incorrect starter for Jolly Male")
        Assert.AreEqual(CUShort(158 + 600), testFile.SassyFemale, "Incorrect starter for Sassy Female")
        'Phanpy                    
        Assert.AreEqual(CUShort(258), testFile.RelaxedMale, "Incorrect starter for Relaxed Male")
        'Treecko                   
        Assert.AreEqual(CUShort(280), testFile.QuietMale, "Incorrect starter for Quiet Male")
        Assert.AreEqual(CUShort(280 + 600), testFile.HardyFemale, "Incorrect starter for Hardy Female")
        'Torchic                   
        Assert.AreEqual(CUShort(283), testFile.HardyMale, "Incorrect starter for Hardy Male")
        Assert.AreEqual(CUShort(283 + 600), testFile.RashFemale, "Incorrect starter for Rash Female")
        'Mudkip                    
        Assert.AreEqual(CUShort(286), testFile.RashMale, "Incorrect starter for Rash Male")
        Assert.AreEqual(CUShort(286 + 600), testFile.LonelyFemale, "Incorrect starter for Lonely Female")
        'Skitty                    
        Assert.AreEqual(CUShort(328 + 600), testFile.NaiveFemale, "Incorrect starter for Naïve Female")
        'Turtwig                   
        Assert.AreEqual(CUShort(422), testFile.BoldMale, "Incorrect starter for Bold Male")
        Assert.AreEqual(CUShort(422 + 600), testFile.TimidFemale, "Incorrect starter for Timid Female")
        'Chimchar                  
        Assert.AreEqual(CUShort(425), testFile.NaiveMale, "Incorrect starter for Naïve Male")
        Assert.AreEqual(CUShort(425 + 600), testFile.ImpishFemale, "Incorrect starter for Impish Female")
        'Piplup                    
        Assert.AreEqual(CUShort(428), testFile.ImpishMale, "Incorrect starter for Impish Male")
        Assert.AreEqual(CUShort(428 + 600), testFile.QuirkyFemale, "Incorrect starter for Quirky Female")
        'Shinx                     
        Assert.AreEqual(CUShort(438), testFile.HastyMale, "Incorrect starter for Hasty Male")
        'Riolu                     
        Assert.AreEqual(CUShort(489), testFile.SassyMale, "Incorrect starter for Sassy Male")

        'Partners
        'Bulbasaur
        Assert.AreEqual(CUShort(1), testFile.Partner01, "Incorrect partner 01")
        'Charmander
        Assert.AreEqual(CUShort(4), testFile.Partner02, "Incorrect partner 02")
        'Squirtle
        Assert.AreEqual(CUShort(7), testFile.Partner03, "Incorrect partner 03")
        'Pikachu
        Assert.AreEqual(CUShort(25), testFile.Partner04, "Incorrect partner 04")
        'Vulpix
        Assert.AreEqual(CUShort(37 + 600), testFile.Partner18, "Incorrect partner 18")
        'Meowth
        Assert.AreEqual(CUShort(52), testFile.Partner20, "Incorrect partner 20")
        'Eevee
        Assert.AreEqual(CUShort(133 + 600), testFile.Partner14, "Incorrect partner 14")
        'Chikorita
        Assert.AreEqual(CUShort(752), testFile.Partner05, "Incorrect partner 05")
        'Cyndaquil
        Assert.AreEqual(CUShort(155), testFile.Partner06, "Incorrect partner 06")
        'Totodile
        Assert.AreEqual(CUShort(158), testFile.Partner07, "Incorrect partner 07")
        'Phanpy
        Assert.AreEqual(CUShort(258), testFile.Partner17, "Incorrect partner 17")
        'Treecko
        Assert.AreEqual(CUShort(280), testFile.Partner08, "Incorrect partner 08")
        'Torchic
        Assert.AreEqual(CUShort(283 + 600), testFile.Partner09, "Incorrect partner 09")
        'Mudkip
        Assert.AreEqual(CUShort(286), testFile.Partner10, "Incorrect partner 10")
        'Skitty
        Assert.AreEqual(CUShort(328 + 600), testFile.Partner19, "Incorrect partner 19")
        'Turtwig
        Assert.AreEqual(CUShort(422), testFile.Partner11, "Incorrect partner 11")
        'Chimchar
        Assert.AreEqual(CUShort(425), testFile.Partner12, "Incorrect partner 12")
        'Piplup
        Assert.AreEqual(CUShort(428), testFile.Partner13, "Incorrect partner 13")
        'Shinx
        Assert.AreEqual(CUShort(438), testFile.Partner15, "Incorrect partner 15")
        'Munchlax
        Assert.AreEqual(CUShort(488), testFile.Partner21, "Incorrect partner 21")
        'Riolu
        Assert.AreEqual(CUShort(489), testFile.Partner16, "Incorrect partner 16")
    End Sub

    <TestMethod> <TestCategory(EosTestCategory)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub item_p()
        Using testFile = TestHelpers.GetAndTestFile(Of item_p)("/data/balance/item_p.bin", True, provider)
            'Ensure data is at least somewhat valid
            Assert.AreEqual(1400, testFile.Items.Count, "Incorrect number of items")
        End Using
    End Sub

    <TestMethod> <TestCategory(EosTestCategory)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub item_s_p()
        Using testFile = TestHelpers.GetAndTestFile(Of item_s_p)("/data/balance/item_s_p.bin", True, provider)
            'Ensure data is at least somewhat valid
            Assert.AreEqual(956, testFile.Items.Count, "Incorrect number of items")
        End Using
    End Sub

    <TestMethod> <TestCategory(EosTestCategory)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub mappa_s()
        Using testFile = TestHelpers.GetAndTestFile(Of mappa)("/data/balance/mappa_s.bin", False, provider)
            'Ensure data is at least somewhat valid
            Assert.AreEqual(100, testFile.Dungeons.Count, "Incorrect number of items")
        End Using
    End Sub

    <TestMethod> <TestCategory(EosTestCategory)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub mappa_t()
        Using testFile = TestHelpers.GetAndTestFile(Of mappa)("/data/balance/mappa_t.bin", False, provider)
            'Ensure data is at least somewhat valid
            Assert.AreEqual(64, testFile.Dungeons.Count, "Incorrect number of items")
        End Using
    End Sub

    <TestMethod> <TestCategory(EosTestCategory)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub mappa_y()
        Using testFile = TestHelpers.GetAndTestFile(Of mappa)("data/balance/mappa_y.bin", False, provider)
            'Ensure data is at least somewhat valid
            Assert.AreEqual(64, testFile.Dungeons.Count, "Incorrect number of items")
        End Using
    End Sub

    <TestMethod> <TestCategory(EosTestCategory)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub waza_p()
        Using testFile = TestHelpers.GetAndTestFile(Of waza_p)("data/balance/waza_p.bin", False, provider)
            'Ensure data is at least somewhat valid
            Assert.AreEqual(559, testFile.Moves.Count, "Incorrect number of moves")
            Assert.AreEqual(553, testFile.PokemonLearnsets.Count, "Incorrect number of Pokemon moveset data")

            'Check Bulbasaur's learnset
            Assert.AreEqual(14, testFile.PokemonLearnsets(1).LevelUpMoves.Count, "Incorrect number of level-up moves.")
            Assert.AreEqual(30, testFile.PokemonLearnsets(1).TMMoves.Count, "Incorrect number of TM moves")
            Assert.AreEqual(12, testFile.PokemonLearnsets(1).EggMoves.Count, "Incorrect number of egg moves")
        End Using
    End Sub

    <TestMethod> <TestCategory(EosTestCategory)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub Kaomado()
        'Extract
        Dim kao1 As New Kaomado
        kao1.OpenFile("/data/font/kaomado.kao", provider).Wait()

        'Pack
        Dim kao2 As New Kaomado
        kao2.CreateNew()

        For pokemon = 0 To kao1.Portraits.Count - 1
            For portrait = 0 To kao1.Portraits(pokemon).Length - 1
                If kao1.Portraits(pokemon)(portrait) Is Nothing Then
                    Try
                        kao2.Portraits(pokemon)(portrait) = Nothing
                    Catch ex As Exception
                        Throw
                    End Try
                Else
                    kao2.Portraits(pokemon)(portrait) = kao1.Portraits(pokemon)(portrait).Clone
                End If
            Next
        Next

        'Extract Again
        Dim kao3 As New Kaomado
        kao3.Initialize(kao2.GetBytes.Result)

        'Compare
        Assert.AreEqual(kao1.Portraits.Count, kao3.Portraits.Count, "Number of Pokemon differs")
        For pokemon = 0 To kao1.Portraits.Count - 1
            Assert.AreEqual(kao1.Portraits(pokemon).Length, kao3.Portraits(pokemon).Length, "Portrait count for Pokemon " & pokemon & " differs.")
            For portrait = 0 To kao1.Portraits(pokemon).Length - 1
                Dim bitmap1 = kao1.Portraits(pokemon)(portrait)
                Dim bitmap2 = kao2.Portraits(pokemon)(portrait)

                'bitmap1 is allowed to be null, but bitmap2 can only be null if bitmap1 is null
                If bitmap1 Is Nothing Then
                    Assert.IsNull(bitmap2, "Portrait " & portrait & " for Pokemon " & pokemon & " added.")
                Else
                    Assert.IsNotNull(bitmap2, "Portrait " & portrait & " for Pokemon " & pokemon & " removed.")
                    Assert.IsTrue(GraphicsHelpers.AreBitmapsEquivalent(bitmap1, bitmap2), "Portrait " & portrait & " for Pokemon " & pokemon & " differs.")
                End If
            Next
        Next
    End Sub

#Region "Language Strings"
    <TestMethod> <TestCategory(EosTestCategory)> <TestCategory(TestHelpers.AutomatedTestCategory)> Public Sub LanguageString_FileOpenAndSave()
        Using testFile = TestHelpers.GetAndTestFile(Of LanguageString)(Path.Combine("data", "message", "text_e.str"), True, provider)
            'Ensure data is at least somewhat valid
            Assert.AreEqual(18451, testFile.Items.Count, "Incorrect number of items")
        End Using
    End Sub
#End Region

End Class