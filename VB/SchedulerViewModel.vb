Imports System
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands
Imports System.Collections.ObjectModel

Namespace VisualDayViewExample
    Public Class SchedulerViewModel
        Private privateAppointments As ObservableCollection(Of ModelAppointment)
        Public Property Appointments() As ObservableCollection(Of ModelAppointment)
            Get
                Return privateAppointments
            End Get
            Private Set(ByVal value As ObservableCollection(Of ModelAppointment))
                privateAppointments = value
            End Set
        End Property
        Private privateResources As ObservableCollection(Of ModelResource)
        Public Property Resources() As ObservableCollection(Of ModelResource)
            Get
                Return privateResources
            End Get
            Private Set(ByVal value As ObservableCollection(Of ModelResource))
                privateResources = value
            End Set
        End Property

        Public Sub New()
            Appointments = New ObservableCollection(Of ModelAppointment)()
            Resources = New ObservableCollection(Of ModelResource)()
            AddTestData()
        End Sub
        Private Sub AddTestData()
            Dim res1 As New ModelResource() With {.Id = 0, .Name = "Resource 1", .Color = &Hebecf0}

            Dim res2 As New ModelResource() With {.Id = 1, .Name = "Resource 2", .Color = &Hc1c5d6}

            Dim res3 As New ModelResource() With {.Id = 2, .Name = "Resource 3", .Color = &H787fa0}

            Resources.Add(res1)
            Resources.Add(res2)
            Resources.Add(res3)

            Dim baseTime As Date = Date.Now

            Dim apt1 As New ModelAppointment() With {.StartTime = baseTime.AddHours(1), .EndTime = baseTime.AddHours(2), .Subject = "Test", .Location = "Office", .Description = "Test procedure", .Price = 10D, .ResourceId = 1}

            Dim apt2 As New ModelAppointment() With {.StartTime = baseTime.AddHours(2), .EndTime = baseTime.AddHours(3), .Subject = "Test2", .Location = "Office", .Description = "Test procedure", .ResourceId = 2}

            Appointments.Add(apt1)
            Appointments.Add(apt2)
        End Sub
    End Class
End Namespace