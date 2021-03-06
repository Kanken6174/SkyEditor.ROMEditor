﻿Imports SkyEditor.Core.IO
Imports SkyEditor.IO.FileSystem

Namespace MysteryDungeon.PSMD
    Public Class DungeonDataInfo
        Implements IOpenableFile
        Private Const EntryLength As Integer = &H18

        Public Class DungeonDataInfoEntry
            Private Property RawData As Byte()
            Public ReadOnly Property DungeonID As UInt16
                Get
                    Return BitConverter.ToUInt16(RawData, 0)
                End Get
            End Property
            Private ReadOnly Property Unknown As UInt16
                Get
                    Return BitConverter.ToUInt16(RawData, 4)
                End Get
            End Property
            Public Function ToBytes() As Byte()
                Return RawData
            End Function
            Public Sub New(RawData As Byte())
                Me.RawData = RawData
            End Sub
        End Class

        Public Property Entries As List(Of DungeonDataInfoEntry)

        Public Async Function OpenFile(Filename As String, Provider As IFileSystem) As Task Implements IOpenableFile.OpenFile
            Using f As New GenericFile
                Await f.OpenFile(Filename, Provider)

                Dim numEntries = Math.Floor(f.Length / EntryLength)

                For count = 0 To numEntries - 1
                    Entries.Add(New DungeonDataInfoEntry(Await f.ReadAsync(count * EntryLength, EntryLength)))
                Next
            End Using
        End Function

        Public Sub New()
            Entries = New List(Of DungeonDataInfoEntry)
        End Sub


    End Class
End Namespace
