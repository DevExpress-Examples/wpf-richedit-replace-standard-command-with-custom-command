Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.XtraRichEdit
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.Xpf.Core

Namespace DXApplication36
    Partial Public Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            InitializeComponent()
            AddHandler richEditControl1.Loaded, AddressOf richEditControl1_Loaded
        End Sub
        #Region "#replace"
        Private Sub richEditControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ReplaceRichEditCommandFactoryService(richEditControl1)
        End Sub

        Private Sub ReplaceRichEditCommandFactoryService(ByVal control As RichEditControl)
            control.ApplyTemplate()
            Dim service As IRichEditCommandFactoryService = control.GetService(Of IRichEditCommandFactoryService)()
            control.ReplaceService(Of IRichEditCommandFactoryService)(New CustomRichEditCommandFactoryService(control, service))
        End Sub
        #End Region ' #replace
    End Class







End Namespace
