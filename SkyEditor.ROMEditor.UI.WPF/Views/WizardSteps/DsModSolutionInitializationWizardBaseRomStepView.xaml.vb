﻿Imports SkyEditor.UI.WPF
Public Class DsModSolutionInitializationWizardBaseRomStepView
    Private Async Sub btnExtract_Click(sender As Object, e As RoutedEventArgs) Handles btnExtract.Click
        Await DirectCast(ViewModel, DsModSolutionInitializationWizard.BaseRomStep).ExtractRom()
    End Sub

    Private Sub btnBrowseFile_Click(sender As Object, e As RoutedEventArgs) Handles btnBrowseFile.Click
        Dim d = CurrentApplicationViewModel.GetOpenFileDialog({"*.nds", "*.3ds", "*.cci", "*.cxi", "*.cia"}, False)
        If d.ShowDialog = Forms.DialogResult.OK Then
            DirectCast(ViewModel, DsModSolutionInitializationWizard.BaseRomStep).RomFilename = d.FileName
        End If
    End Sub
End Class
