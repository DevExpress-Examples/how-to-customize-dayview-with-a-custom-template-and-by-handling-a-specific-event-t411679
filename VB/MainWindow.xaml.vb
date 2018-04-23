Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.Scheduler.Drawing
Imports System
Imports System.Windows

Namespace VisualDayViewExample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            schedulerControl1.Start = Date.Today
            schedulerControl1.ActiveView.SelectAppointment(schedulerControl1.Storage.AppointmentStorage(0))
        End Sub

        Private Sub btnApplyCustomStyle_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'            #Region "#ApplyCustomStyle"
            Dim visualDayViewElement As VisualDayViewGroupByResource = TryCast(LayoutHelper.FindElementByType(schedulerControl1, GetType(VisualDayViewGroupByResource)), VisualDayViewGroupByResource)
            If visualDayViewElement IsNot Nothing Then
                visualDayViewElement.Style = TryCast(Me.Resources.MergedDictionaries(2)("CustomDayViewGroupByResourceStyle"), System.Windows.Style)
            End If
'            #End Region ' #ApplyCustomStyle
        End Sub

        #Region "#CustomizeVisualViewInfo"
        Private Sub schedulerControl1_CustomizeVisualViewInfo(ByVal sender As Object, ByVal e As DevExpress.Xpf.Scheduler.CustomizeVisualViewInfoEventArgs)
            ' Determine whether the currently active view is the Day View and appointments are grouped by resource.
            If TypeOf e.VisualViewInfo Is VisualDayViewGroupByResource Then
                Dim dayViewByResource As VisualDayViewGroupByResource = CType(e.VisualViewInfo, VisualDayViewGroupByResource)
                ' Hide day headers.
               dayViewByResource.ShowDayHeaders = False
                ' Hide time ruler headers.
                dayViewByResource.ShowTimeRulerHeader = False
            End If
        End Sub
        #End Region ' #CustomizeVisualViewInfo
    End Class
End Namespace
