﻿Imports SkyEditor.Core.IO
Imports SkyEditor.IO.FileSystem

Namespace MysteryDungeon.PSMD
    Public Class WazaDataInfo
        Implements IOpenableFile

        Public Class WazaDataInfoEntry
            ''' <summary>
            ''' The move index in act_data_info.bin
            ''' </summary>
            ''' <returns></returns>
            Public Property ActDataInfoIndex As UInt16
            Public Sub New(RawData As Byte())
                ActDataInfoIndex = BitConverter.ToUInt16(RawData, &HC)
            End Sub
        End Class

        Public Property Entries As List(Of WazaDataInfoEntry)

        Public Async Function OpenFile(Filename As String, Provider As IFileSystem) As Task Implements IOpenableFile.OpenFile
            Const entryLength = 18
            Using f As New GenericFile
                f.EnableInMemoryLoad = True
                Await f.OpenFile(Filename, Provider)

                For count = 0 To ((f.Length / entryLength) - 1)
                    Entries.Add(New WazaDataInfoEntry(Await f.ReadAsync(count * entryLength, entryLength)))
                Next
            End Using
        End Function

        Public Sub New()
            Entries = New List(Of WazaDataInfoEntry)
        End Sub

    End Class

End Namespace
