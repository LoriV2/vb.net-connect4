﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ten kod został wygenerowany przez narzędzie.
'     Wersja wykonawcza:4.0.30319.42000
'
'     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
'     kod zostanie ponownie wygenerowany.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    'UWAGA: Ten plik został wygenerowany automatycznie; nie należy go bezpośrednio modyfikować.  Aby wprowadzić zmiany
    ' lub jeśli napotkasz w tym pliku błędy kompilacji, przejdź do Projektanta projektu
    ' (przejdź do obszaru Właściwości projektu lub kliknij dwukrotnie węzeł Mój Projekt w
    ' Eksploratorze rozwiązań) i wprowadź zmiany na karcie Aplikacja.
    '
    Partial Friend Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = connect4.frmLogin
        End Sub
    End Class
End Namespace
