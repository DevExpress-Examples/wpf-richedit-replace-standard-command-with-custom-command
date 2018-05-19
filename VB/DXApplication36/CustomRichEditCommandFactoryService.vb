Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.Utils

Namespace DXApplication36

    #Region "#CustomRichEditCommandFactoryService"
    Public Class CustomRichEditCommandFactoryService
        Implements IRichEditCommandFactoryService

        Private ReadOnly service As IRichEditCommandFactoryService
        Private ReadOnly control As RichEditControl

        Public Sub New(ByVal control As RichEditControl, ByVal service As IRichEditCommandFactoryService)
            Guard.ArgumentNotNull(control, "control")
            Guard.ArgumentNotNull(service, "service")
            Me.control = control
            Me.service = service
        End Sub

        Public Function CreateCommand(ByVal id As RichEditCommandId) As RichEditCommand Implements IRichEditCommandFactoryService.CreateCommand
            If id = RichEditCommandId.FileSave Then
                Return New CustomSaveDocumentCommand(control)
            End If

            Return service.CreateCommand(id)
        End Function
    End Class
    #End Region ' #CustomRichEditCommandFactoryService

    #Region "#customsavedocumentcommand"
    Public Class CustomSaveDocumentCommand
        Inherits SaveDocumentCommand

        Public Sub New(ByVal control As IRichEditControl)
            MyBase.New(control)
        End Sub
        Protected Overrides Sub ExecuteCore()
              MyBase.ExecuteCore()
              MessageBox.Show("Custom SaveDocument command was executed")
        End Sub
    End Class
    #End Region ' #customsavedocumentcommand
End Namespace
