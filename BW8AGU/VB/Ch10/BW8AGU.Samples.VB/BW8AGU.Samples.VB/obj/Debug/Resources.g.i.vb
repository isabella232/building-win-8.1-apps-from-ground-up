﻿

#ExternalChecksum("C:\Users\AntonioTuribbio\Source\Workspaces\BuildingWindows8AppsFromTheGroundUp\VB\BW8AGU.Samples.VB-Ch10\BW8AGU.Samples.VB\BW8AGU.Samples.VB\Resources.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "F8270BA29DF660FD33A14F17D3EBA8D0")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


Namespace Global.BW8AGU.Samples.VB

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Class ResourceAccess
        Inherits Global.Windows.UI.Xaml.Controls.Page

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents pageRoot As Global.Windows.UI.Xaml.Controls.Page
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents contentRegion As Global.Windows.UI.Xaml.Controls.Grid
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents ResourceValue As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents WelcomeLabel As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents ErrorLabel As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents backButton As Global.Windows.UI.Xaml.Controls.AppBarButton
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents pageTitle As Global.Windows.UI.Xaml.Controls.TextBlock

        Private _contentLoaded As Boolean

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true

            Dim uri As New Global.System.Uri("ms-appx:///Resources.xaml")
            Global.Windows.UI.Xaml.Application.LoadComponent(Me, uri, Global.Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application)

            pageRoot = CType(Me.FindName("pageRoot"), Global.Windows.UI.Xaml.Controls.Page)
            contentRegion = CType(Me.FindName("contentRegion"), Global.Windows.UI.Xaml.Controls.Grid)
            ResourceValue = CType(Me.FindName("ResourceValue"), Global.Windows.UI.Xaml.Controls.TextBlock)
            WelcomeLabel = CType(Me.FindName("WelcomeLabel"), Global.Windows.UI.Xaml.Controls.TextBlock)
            ErrorLabel = CType(Me.FindName("ErrorLabel"), Global.Windows.UI.Xaml.Controls.TextBlock)
            backButton = CType(Me.FindName("backButton"), Global.Windows.UI.Xaml.Controls.AppBarButton)
            pageTitle = CType(Me.FindName("pageTitle"), Global.Windows.UI.Xaml.Controls.TextBlock)
        End Sub
    End Class

End Namespace


