﻿Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports SkyEditor.Core
Imports SkyEditor.Core.IO
Imports SkyEditor.Core.UI
Imports SkyEditor.Core.Utilities
Imports SkyEditor.IO.FileSystem
Imports SkyEditor.ROMEditor.MysteryDungeon.PSMD
Imports SkyEditor.ROMEditor.MysteryDungeon.PSMD.Extensions
Imports SkyEditor.Utilities.AsyncFor

Namespace MenuActions
    Public Class GtiFarcSubstitutePsmdAnimations
        Inherits MenuAction

        Public Sub New(FileSystem As IFileSystem, appViewModel As ApplicationViewModel)
            MyBase.New({My.Resources.Language.MenuFarc, My.Resources.Language.MenuFarcSubstituteGtiAnimations})

            If FileSystem Is Nothing Then
                Throw New ArgumentNullException(NameOf(FileSystem))
            End If

            If appViewModel Is Nothing Then
                Throw New ArgumentNullException(NameOf(appViewModel))
            End If

            Dialog = New FolderBrowserDialog
            SortOrder = 5
            CurrentFileSystem = FileSystem
            CurrentApplicationViewModel = appViewModel
        End Sub

        Protected Property CurrentFileSystem As IFileSystem
        Protected Property CurrentApplicationViewModel As ApplicationViewModel

        Private WithEvents Dialog As FolderBrowserDialog

        Public Overrides Function GetSupportedTypes() As IEnumerable(Of TypeInfo)
            Return {GetType(Farc).GetTypeInfo}
        End Function

        Public Overrides Async Function SupportsObject(obj As Object) As Task(Of Boolean)
            Return Await MyBase.SupportsObject(obj) AndAlso TypeOf obj Is Farc AndAlso File.Exists(Path.Combine(Path.GetDirectoryName(DirectCast(obj, Farc).Filename), "pokemon_graphics_database.bin"))
        End Function

        Public Overrides Async Sub DoAction(Targets As IEnumerable(Of Object))
            Dim loadingTasks As New List(Of Task)
            For Each item As Farc In Targets

                Dim pgdbPath = Path.Combine(Path.GetDirectoryName(item.Filename), "pokemon_graphics_database.bin")

                If Not File.Exists(pgdbPath) Then
                    'We shouldn't get here since SupportsObject checks for it, but just in case
                    Throw New FileNotFoundException("Pokemon Graphics Database not found.", pgdbPath)
                End If

                Dim pgdb As New PGDB
                Await pgdb.OpenFile(pgdbPath, CurrentFileSystem)

                Dim token As New ProgressReportToken
                CurrentApplicationViewModel.ShowLoading(token)

                loadingTasks.Add(Task.Run(Function() item.SubstituteMissingAnimationsGti(pgdb, token)))
            Next

            'While the application view model is handling the extraction display, we need to wait here in case there's exceptions.
            'Otherwise, they'll be swallowed
            Await Task.WhenAll(loadingTasks)
        End Sub
    End Class
End Namespace

