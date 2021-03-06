﻿Imports SkyEditor.Core.IO
Imports SkyEditor.IO.FileSystem

Namespace MysteryDungeon.PSMD
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks>Credit to Andibad for research.  http://projectpokemon.org/forums/showthread.php?46904-Pokemon-Super-Mystery-Dungeon-And-PMD-GTI-Research-And-Utilities&amp;p=211199&amp;viewfull=1#post211199
    ''' </remarks>

    Public Class ActXlWaza
        Implements IOpenableFile
        Public Class ActXlWazaEntry
            Public Property MoveActionIndex As UInt16
            Public Property MoveActionIndexTarget As UInt16
            Public Sub New(RawData As Byte())
                MoveActionIndex = BitConverter.ToUInt16(RawData, 0)
                MoveActionIndexTarget = BitConverter.ToUInt16(RawData, 2)
            End Sub
        End Class
        Public Property Entries As List(Of ActXlWazaEntry)

        Public Async Function OpenFile(Filename As String, Provider As IFileSystem) As Task Implements IOpenableFile.OpenFile
            Const entryLength = 8
            Using f As New GenericFile
                f.EnableInMemoryLoad = True
                Await f.OpenFile(Filename, Provider)

                For count = 0 To ((f.Length / entryLength) - 1)
                    Entries.Add(New ActXlWazaEntry(Await f.ReadAsync(count * entryLength, entryLength)))
                Next
            End Using
        End Function

        Public Sub New()
            Entries = New List(Of ActXlWazaEntry)
        End Sub
    End Class
End Namespace