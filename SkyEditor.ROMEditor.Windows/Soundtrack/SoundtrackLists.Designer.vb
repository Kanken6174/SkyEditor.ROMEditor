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
    Friend Class SoundtrackLists
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SkyEditor.ROMEditor.Windows.SoundtrackLists", GetType(SoundtrackLists).Assembly)
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
        '''  Looks up a localized string similar to BGM_SYS_MENU=001 Main Menu
        '''BGM_EVE_METAMORPHOSIS=002 I Look Like a Pokémon
        '''BGM_EVE_HAPPY=003 Our First Meeting
        '''BGM_DUN_01=004 Ragged Mountain
        '''BGM_EVE_CLEAR=005 Great Job
        '''BGM_MAP_PARADISE_01=006 Pokémon Paradise
        '''BGM_MAP_TOWN_01=007 Come on in to Post Town
        '''BGM_EVE_NAZO_02=008 The Carpenter of Post Town
        '''BGM_DUN_02=009 Stony Cave
        '''BGM_EVE_NAZO_03=010 That Is Odd...
        '''BGM_DUN_03=011 Hazy Pass
        '''BGM_EVE_NAZO_01=012 The Voice in the Dreams
        '''BGM_EVE_FEAR_01=013 The Coming Danger
        '''BGM_EVE_BOSS_01=014 Battling  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property GTI() As String
            Get
                Return ResourceManager.GetString("GTI", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to BGM_SYS_MAIN_THEME=001 Main Theme
        '''BGM_SYS_TOPMENU=002 Main Menu
        '''BGM_EVE_SHINPI=003 Welcome to the World of Pokemon!
        '''BGM_EVE_UNIVERSE_02=004 Things That Live on This Planet
        '''BGM_EVE_TENSION_01=005 Why, All of a Sudden?
        '''BGM_DUN_01=006 Open Pass
        '''BGM_DUN_02=007 Lush Forest
        '''BGM_EVE_CALM_01=008 At Just Such a Moment
        '''BGM_EVE_ZANNEN_03=009 It Is What It Is...
        '''BGM_EVE_SCENERY=010 Over the Mountains
        '''BGM_EVE_TITLECATCH=011 Title Theme
        '''BGM_EVE_KONOHANANOIE=012 Nuzleaf&apos;s House
        '''BGM_EVE_CHILDREN_01=013 Children [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property PSMD() As String
            Get
                Return ResourceManager.GetString("PSMD", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
