﻿Imports SkyEditor.Core.ConsoleCommands
Imports SkyEditor.ROMEditor.MysteryDungeon.PSMD

Namespace Windows.ConsoleCommands
    Public Class PackFarc
        Inherits ConsoleCommand

        Public Overrides Async Function MainAsync(Arguments() As String) As Task
            If Arguments.Count > 1 Then
                If IO.Directory.Exists(Arguments(0)) Then
                    Await Farc.Pack(Arguments(0), Arguments(1), CurrentApplicationViewModel.CurrentIOProvider)
                Else
                    Console.WriteLine("Directory does not exist: " & Arguments(0))
                End If
            Else
                Console.WriteLine("Usage: PackFarc <Input Directory> <Output Filename>")
            End If
        End Function
    End Class

End Namespace
