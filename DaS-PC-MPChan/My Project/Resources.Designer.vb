﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
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
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DSCM.Resources", GetType(Resources).Assembly)
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
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to NamedNodes:
        '''mov eax,[esp+10]
        '''push eax
        '''mov eax, ebx
        '''mov ebx, ecx
        '''and ebx, fc00
        '''cmp ebx, fc00
        '''mov ebx, eax
        '''je stackPassed
        '''jmp codeSkip
        '''
        '''stackPassed:
        '''mov ebx, [ebx-30]
        '''cmp ebx, 0
        '''je ptrFail
        '''mov ebx, [ebx+14]
        '''cmp ebx, 0
        '''je ptrFail
        '''add ebx, 30
        '''jmp ptrSuccess
        '''
        '''ptrFail:
        '''mov ebx, eax
        '''jmp codeSkip
        '''
        '''ptrSuccess:
        '''push eax
        '''mov eax,0
        '''
        '''loopStart:
        '''cmp eax,20
        '''je loopExit
        '''mov dl,[ebx]
        '''mov [edi],dl
        '''inc eax
        '''inc ebx
        '''inc edi
        '''Jmp loopStart
        '''
        '''loopExit:
        '''sub ebx, 20
        '''sub edi, 20
        '''pop eax
        '''
        '''codeSkip:
        '''pop eax
        '''push esi
        '''jmp darksouls.exe +  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ASM_NamedNodes() As String
            Get
                Return ResourceManager.GetString("ASM_NamedNodes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to NodeDump:
        '''push eax
        '''push ebx
        '''push ecx
        '''push edx
        '''push esi
        '''push edi
        '''mov edi,NodeDump+200
        '''mov eax,0
        '''mov ebx,0
        '''mov ecx,0
        '''mov edx,0
        '''
        '''StartLoop:
        '''mov bl,[edi]
        '''cmp bl,0
        '''je CopyLoop
        '''
        '''CmpLoop:
        '''mov al,[esi]
        '''mov bl,[edi]
        '''inc esi
        '''inc edi
        '''inc ecx
        '''cmp al,bl
        '''jne FailCmpLoop
        '''cmp ecx,11
        '''jne CmpLoop
        '''sub esi,ecx
        '''sub edi,ecx
        '''mov ecx,0
        '''jmp CopyLoop
        '''
        '''FailCmpLoop:
        '''sub esi,ecx
        '''sub edi,ecx
        '''mov ecx,0
        '''add edi,30
        '''jmp StartLoop
        '''
        '''CopyLoop:
        '''mov bl,[esi]
        '''mov [edi],bl
        '''inc esi
        '''inc edi
        '''inc ecx
        '''cmp ecx,30
        '''je ExitLoop
        '''jmp CopyLoop
        '''
        '''ExitLoop:
        '''pop  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ASM_NodeDump() As String
            Get
                Return ResourceManager.GetString("ASM_NodeDump", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to **Disclaimer:** Use this software at your own risk. By using this software, you
        '''agree that we are not liable for any possible issues your game or computer may
        '''experience.
        '''
        '''Instructions
        '''============
        '''
        '''1. Start DSCM
        '''2. Start Dark Souls
        '''3. Enjoy Dark Souls Multiplayer :)
        '''
        '''Automatic node finding
        '''----------------------
        '''While DSCM-Net is active, it will automatically connect to players in the same
        '''are and in coop level range. Just have it running and enjoy working Dark Souls
        '''multiplayer.
        '''
        '''Manual Connecting
        '''------- [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Readme() As String
            Get
                Return ResourceManager.GetString("Readme", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
