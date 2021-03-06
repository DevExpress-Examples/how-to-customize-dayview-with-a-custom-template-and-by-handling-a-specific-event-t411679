﻿Imports System

Namespace VisualDayViewExample
    #Region "#models    "
    Public Class ModelAppointment
        Public Property StartTime() As Date
        Public Property EndTime() As Date
        Public Property Subject() As String
        Public Property Status() As Integer
        Public Property Description() As String
        Public Property Label() As Long
        Public Property Location() As String
        Public Property AllDay() As Boolean
        Public Property EventType() As Integer
        Public Property RecurrenceInfo() As String
        Public Property ReminderInfo() As String
        Public Property ResourceId() As Object
        Public Property Price() As Decimal

        Public Sub New()
        End Sub
    End Class

    Public Class ModelResource
        Public Property Id() As Integer
        Public Property Name() As String
        Public Property Color() As Integer

        Public Sub New()
        End Sub
    End Class
#End Region ' #models
End Namespace
