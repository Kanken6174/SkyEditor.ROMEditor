﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Language
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SkyEditor.ROMEditor.Language", GetType(Language).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to All Files.
        '''</summary>
        Friend Shared ReadOnly Property AllFiles() As String
            Get
                Return ResourceManager.GetString("AllFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Complete.
        '''</summary>
        Friend Shared ReadOnly Property Complete() As String
            Get
                Return ResourceManager.GetString("Complete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to CTE Image Files.
        '''</summary>
        Friend Shared ReadOnly Property CTEImageFiles() As String
            Get
                Return ResourceManager.GetString("CTEImageFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unable to find the language &quot;{0}&quot;..
        '''</summary>
        Friend Shared ReadOnly Property ErrorLocalizedPsmdLanguageFileLanguageNotFound() As String
            Get
                Return ResourceManager.GetString("ErrorLocalizedPsmdLanguageFileLanguageNotFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The given system type &quot;{0}&quot; is not supported..
        '''</summary>
        Friend Shared ReadOnly Property ErrorModPackTypeNotSupported() As String
            Get
                Return ResourceManager.GetString("ErrorModPackTypeNotSupported", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The property with the CommandParameter Attribute was not applied to the correct type..
        '''</summary>
        Friend Shared ReadOnly Property ErrorScriptCommandAttributeInvalidType() As String
            Get
                Return ResourceManager.GetString("ErrorScriptCommandAttributeInvalidType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extracting files....
        '''</summary>
        Friend Shared ReadOnly Property FarcLoadingExtract() As String
            Get
                Return ResourceManager.GetString("FarcLoadingExtract", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pokémon Alpha Sapphire.
        '''</summary>
        Friend Shared ReadOnly Property Game_AS() As String
            Get
                Return ResourceManager.GetString("Game_AS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pokémon Mystery Dungeon: Gates to Infinity.
        '''</summary>
        Friend Shared ReadOnly Property Game_GTI() As String
            Get
                Return ResourceManager.GetString("Game_GTI", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pokémon Omega Ruby.
        '''</summary>
        Friend Shared ReadOnly Property Game_OR() As String
            Get
                Return ResourceManager.GetString("Game_OR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pokémon Super Mystery Dungeon.
        '''</summary>
        Friend Shared ReadOnly Property Game_PSMD() As String
            Get
                Return ResourceManager.GetString("Game_PSMD", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pokémon X.
        '''</summary>
        Friend Shared ReadOnly Property Game_X() As String
            Get
                Return ResourceManager.GetString("Game_X", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pokémon Y.
        '''</summary>
        Friend Shared ReadOnly Property Game_Y() As String
            Get
                Return ResourceManager.GetString("Game_Y", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pokémon Mystery Dungeon: Gates to Infinity.
        '''</summary>
        Friend Shared ReadOnly Property GTISoundTrackAlbum() As String
            Get
                Return ResourceManager.GetString("GTISoundTrackAlbum", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Chunsoft.
        '''</summary>
        Friend Shared ReadOnly Property GTISoundTrackArtist() As String
            Get
                Return ResourceManager.GetString("GTISoundTrackArtist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Adding files....
        '''</summary>
        Friend Shared ReadOnly Property LoadingAddingFiles() As String
            Get
                Return ResourceManager.GetString("LoadingAddingFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Analyzing files....
        '''</summary>
        Friend Shared ReadOnly Property LoadingAnalzingFiles() As String
            Get
                Return ResourceManager.GetString("LoadingAnalzingFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Applying patch....
        '''</summary>
        Friend Shared ReadOnly Property LoadingApplyingPatch() As String
            Get
                Return ResourceManager.GetString("LoadingApplyingPatch", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Building language files....
        '''</summary>
        Friend Shared ReadOnly Property LoadingBuildingLanguageFiles() As String
            Get
                Return ResourceManager.GetString("LoadingBuildingLanguageFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Comparing files....
        '''</summary>
        Friend Shared ReadOnly Property LoadingComparingFiles() As String
            Get
                Return ResourceManager.GetString("LoadingComparingFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Compiling scripts....
        '''</summary>
        Friend Shared ReadOnly Property LoadingCompilingScripts() As String
            Get
                Return ResourceManager.GetString("LoadingCompilingScripts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Computing hashes....
        '''</summary>
        Friend Shared ReadOnly Property LoadingComputingHashes() As String
            Get
                Return ResourceManager.GetString("LoadingComputingHashes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Converting backgrounds....
        '''</summary>
        Friend Shared ReadOnly Property LoadingConvertingBackgrounds() As String
            Get
                Return ResourceManager.GetString("LoadingConvertingBackgrounds", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Converting languages....
        '''</summary>
        Friend Shared ReadOnly Property LoadingConvertingLanguages() As String
            Get
                Return ResourceManager.GetString("LoadingConvertingLanguages", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Converting personality test....
        '''</summary>
        Friend Shared ReadOnly Property LoadingConvertingPersonalityTest() As String
            Get
                Return ResourceManager.GetString("LoadingConvertingPersonalityTest", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Converting Soundtrack ({0} of {1}).
        '''</summary>
        Friend Shared ReadOnly Property LoadingConvertingSoundtrackXofY() As String
            Get
                Return ResourceManager.GetString("LoadingConvertingSoundtrackXofY", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Copying files....
        '''</summary>
        Friend Shared ReadOnly Property LoadingCopyingFiles() As String
            Get
                Return ResourceManager.GetString("LoadingCopyingFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Decompiling scripts....
        '''</summary>
        Friend Shared ReadOnly Property LoadingDecompilingScripts() As String
            Get
                Return ResourceManager.GetString("LoadingDecompilingScripts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extracting languages....
        '''</summary>
        Friend Shared ReadOnly Property LoadingExtractingLanguages() As String
            Get
                Return ResourceManager.GetString("LoadingExtractingLanguages", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extracting NDS ROM... ({0} of {1}).
        '''</summary>
        Friend Shared ReadOnly Property LoadingExtractingNDSRomXofY() As String
            Get
                Return ResourceManager.GetString("LoadingExtractingNDSRomXofY", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Generating patch....
        '''</summary>
        Friend Shared ReadOnly Property LoadingGeneratingPatch() As String
            Get
                Return ResourceManager.GetString("LoadingGeneratingPatch", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Loading languages....
        '''</summary>
        Friend Shared ReadOnly Property LoadingLanguages() As String
            Get
                Return ResourceManager.GetString("LoadingLanguages", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Packing....
        '''</summary>
        Friend Shared ReadOnly Property LoadingPacking() As String
            Get
                Return ResourceManager.GetString("LoadingPacking", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Patching Scripts....
        '''</summary>
        Friend Shared ReadOnly Property LoadingPatchingScripts() As String
            Get
                Return ResourceManager.GetString("LoadingPatchingScripts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unpacking....
        '''</summary>
        Friend Shared ReadOnly Property LoadingUnpacking() As String
            Get
                Return ResourceManager.GetString("LoadingUnpacking", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to us.
        '''</summary>
        Friend Shared ReadOnly Property LocalizedPsmdLanguageFileLanguage() As String
            Get
                Return ResourceManager.GetString("LocalizedPsmdLanguageFileLanguage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Development.
        '''</summary>
        Friend Shared ReadOnly Property MenuDev() As String
            Get
                Return ResourceManager.GetString("MenuDev", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to _Deploy.
        '''</summary>
        Friend Shared ReadOnly Property MenuDevDeploy() As String
            Get
                Return ResourceManager.GetString("MenuDevDeploy", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extract NDS.
        '''</summary>
        Friend Shared ReadOnly Property MenuDevExtractNDS() As String
            Get
                Return ResourceManager.GetString("MenuDevExtractNDS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Nintendo DS ROMs.
        '''</summary>
        Friend Shared ReadOnly Property NDSRomFile() As String
            Get
                Return ResourceManager.GetString("NDSRomFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .
        '''</summary>
        Friend Shared ReadOnly Property PluginAuthor() As String
            Get
                Return ResourceManager.GetString("PluginAuthor", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Rom Editor Credits:
        '''psy_commando (Pokemon portraits, most of the research)
        '''Grovyle91 (Language strings)
        '''evandixon (Personality test, bgp files).
        '''</summary>
        Friend Shared ReadOnly Property PluginCredits() As String
            Get
                Return ResourceManager.GetString("PluginCredits", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ROM Editor.
        '''</summary>
        Friend Shared ReadOnly Property PluginName() As String
            Get
                Return ResourceManager.GetString("PluginName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Pokémon Super Mystery Dungeon.
        '''</summary>
        Friend Shared ReadOnly Property PSMDSoundTrackAlbum() As String
            Get
                Return ResourceManager.GetString("PSMDSoundTrackAlbum", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Chunsoft.
        '''</summary>
        Friend Shared ReadOnly Property PSMDSoundTrackArtist() As String
            Get
                Return ResourceManager.GetString("PSMDSoundTrackArtist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Nintendo 3DS ROMs.
        '''</summary>
        Friend Shared ReadOnly Property ThreeDSRomFile() As String
            Get
                Return ResourceManager.GetString("ThreeDSRomFile", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
