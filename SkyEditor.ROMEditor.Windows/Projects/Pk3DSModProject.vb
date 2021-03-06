﻿Imports System.IO
Imports SkyEditor.Core
Imports SkyEditor.Core.Utilities

Namespace Projects
    Public Class Pk3DSModProject
        Inherits GenericModProject
        Public Overrides Function GetSupportedGameCodes() As IEnumerable(Of String)
            Return {GameStrings.PokemonXCode, GameStrings.PokemonYCode, GameStrings.ORCode, GameStrings.ASCode}
        End Function

        Public Overrides Async Function Initialize() As Task
            Await MyBase.Initialize
            File.Copy(Core.Utilities.EnvironmentPaths.GetResourceName("pk3DS.exe"), Path.Combine(GetRootDirectory, "pk3DS.exe"))
            Me.AddExistingFile("", Path.Combine(GetRootDirectory, "pk3DS.exe"), CurrentPluginManager.CurrentFileSystem)
            File.WriteAllText(Path.Combine(GetRootDirectory, "config.ini"), Path.GetFileName(Me.GetRawFilesDir))
        End Function
    End Class
End Namespace

