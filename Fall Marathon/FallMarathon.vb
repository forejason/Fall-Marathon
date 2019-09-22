﻿' Program: Fall Marathon
' Author:   Jason Fore
' Date:     September 20, 2019
' Purpose:  This application displays details about the Fall Marathon's 
'time,place,and date.
'         
Public Class Main

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        btnDetail.Enabled = False

        lblDetails.Text = "May 30, 2017 
Ryan Park
Start Time: 8:00am
For more information, view the Fall Marathon Facebook Page"
    End Sub
End Class
