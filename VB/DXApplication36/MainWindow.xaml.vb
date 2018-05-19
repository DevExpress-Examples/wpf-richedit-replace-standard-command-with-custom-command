Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.XtraRichEdit
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit.Services


Namespace DXApplication36
	Partial Public Class MainWindow
		Inherits DXRibbonWindow
		Public Sub New()
			InitializeComponent()
			ribbonControl1.SelectedPage = pageHome
			AddHandler richEditControl1.Loaded, AddressOf richEditControl1_Loaded
		End Sub

		Private Sub richEditControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			ReplaceRichEditCommandFactoryService(richEditControl1)
		End Sub

		Private Sub ReplaceRichEditCommandFactoryService(ByVal control As RichEditControl)
			control.ApplyTemplate()
			Dim service As IRichEditCommandFactoryService = control.GetService(Of IRichEditCommandFactoryService)()
			control.ReplaceService(Of IRichEditCommandFactoryService)(New CustomRichEditCommandFactoryService(control, service))
		End Sub
		Private Sub richEditControl1_StartHeaderFooterEditing(ByVal sender As Object, ByVal e As HeaderFooterEditingEventArgs)
			catHeaderFooterTools.IsVisible = True
			ribbonControl1.SelectedPage = pageHeaderFooterToolsDesign
		End Sub

		Private Sub richEditControl1_FinishHeaderFooterEditing(ByVal sender As Object, ByVal e As HeaderFooterEditingEventArgs)
			catHeaderFooterTools.IsVisible = False
		End Sub

		Private Sub richEditControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim isSelectionInTable As Boolean = richEditControl1.IsSelectionInTable()
			If catTableTools.IsVisible <> isSelectionInTable Then
				catTableTools.IsVisible = isSelectionInTable
				If isSelectionInTable Then
					ribbonControl1.SelectedPage = pageTableToolsDesign
				End If
			End If

			Dim isSelectionInFloatingObject As Boolean = richEditControl1.IsFloatingObjectSelected
			If catPictureTools.IsVisible <> isSelectionInFloatingObject Then
				catPictureTools.IsVisible = isSelectionInFloatingObject
				If isSelectionInFloatingObject Then
					ribbonControl1.SelectedPage = pagePictureToolsFormat
				End If
			End If
		End Sub

	End Class







End Namespace
