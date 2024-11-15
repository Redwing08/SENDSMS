Imports System.IO.Ports
Imports System.Threading

Public Class Form1
    Private WithEvents serialPort As New SerialPort()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        serialPort.PortName = "COM3" ' Change this to your modem's COM port
        serialPort.BaudRate = 9600
        serialPort.Parity = Parity.None
        serialPort.DataBits = 8
        serialPort.StopBits = StopBits.One
        serialPort.Handshake = Handshake.None
        serialPort.RtsEnable = True
        serialPort.DtrEnable = True

        Try
            serialPort.Open()
            MessageBox.Show("Modem Connected")
        Catch ex As Exception
            MessageBox.Show("Could not connect to modem: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSendSMS_Click(sender As Object, e As EventArgs) Handles btnSendSMS.Click
        Dim phoneNumber As String = txtPhoneNumber.Text
        Dim message As String = txtMessage.Text

        ' Basic input validation
        If String.IsNullOrEmpty(phoneNumber) Or String.IsNullOrEmpty(message) Then
            MessageBox.Show("Please enter both a phone number and a message.")
            Return
        End If

        ' Validate Philippine phone number format
        If Not phoneNumber.StartsWith("+63") OrElse phoneNumber.Length <> 13 Then
            MessageBox.Show("Please enter a valid Philippine phone number in international format (+63XXXXXXXXXXX).")
            Return
        End If

        Try
            ' Set the modem to text mode
            serialPort.Write("AT+CMGF=1" & vbCrLf)
            Thread.Sleep(1000)

            ' Specify the phone number to send the message to
            serialPort.Write("AT+CMGS=""" & phoneNumber & """" & vbCrLf)
            Thread.Sleep(1000)

            ' Write the message followed by Ctrl+Z (ASCII 26) to send
            serialPort.Write(message & Chr(26))
            MessageBox.Show("Message sent successfully.")

        Catch ex As Exception
            MessageBox.Show("Failed to send message: " & ex.Message)
        End Try
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If serialPort.IsOpen Then
            serialPort.Close()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
