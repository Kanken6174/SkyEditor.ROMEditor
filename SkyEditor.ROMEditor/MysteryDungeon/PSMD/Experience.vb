﻿Imports SkyEditor.Core.IO
Imports SkyEditor.IO.FileSystem

Namespace MysteryDungeon.PSMD
    Public Class Experience
        Implements IOpenableFile

        Public Class ExperienceEntry
            Public Property Exp As UInteger
            Public Property AddedHP As Byte
            Public Property AddedAttack As Byte
            Public Property AddedSpAttack As Byte
            Public Property AddedDefense As Byte
            Public Property AddedSpDefense As Byte
            Public Property AddedSpeed As Byte
            Public Sub New(RawData As Byte())
                Exp = BitConverter.ToUInt32(RawData, 0)
                AddedHP = RawData(4)
                AddedAttack = RawData(5)
                AddedSpAttack = RawData(6)
                AddedDefense = RawData(7)
                AddedSpDefense = RawData(8)
                AddedSpeed = RawData(9)
            End Sub
        End Class

        Public Property Entries As Dictionary(Of Integer, List(Of ExperienceEntry))

        Public Async Function OpenFile(Filename As String, Provider As IFileSystem) As Task Implements IOpenableFile.OpenFile
            Const entryLength = &HC
            Const tableLength = &H4C0
            Using f As New GenericFile
                f.EnableInMemoryLoad = True
                f.IsReadOnly = True
                Await f.OpenFile(Filename, Provider)
                For tableCount = 0 To (f.Length / tableLength) - 1
                    Dim localEntries As New List(Of ExperienceEntry)
                    For entryCount = 0 To 99 '100 entries
                        localEntries.Add(New ExperienceEntry(Await f.ReadAsync(tableCount * tableLength + entryCount * entryLength, entryLength)))
                    Next
                    Entries.Add(tableCount, localEntries)
                Next

            End Using
        End Function

        Public Sub New()
            Entries = New Dictionary(Of Integer, List(Of ExperienceEntry))
        End Sub
    End Class

End Namespace
