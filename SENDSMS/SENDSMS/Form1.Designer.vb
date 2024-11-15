<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtPhoneNumber = New TextBox()
        txtMessage = New TextBox()
        btnSendSMS = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(175, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 20)
        Label1.TabIndex = 0
        Label1.Text = "Phone Number"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(289, 64)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(296, 27)
        txtPhoneNumber.TabIndex = 1
        ' 
        ' txtMessage
        ' 
        txtMessage.Location = New Point(289, 124)
        txtMessage.Multiline = True
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Size(296, 27)
        txtMessage.TabIndex = 2
        ' 
        ' btnSendSMS
        ' 
        btnSendSMS.Location = New Point(342, 193)
        btnSendSMS.Name = "btnSendSMS"
        btnSendSMS.Size = New Size(94, 29)
        btnSendSMS.TabIndex = 3
        btnSendSMS.Text = "SEND SMS"
        btnSendSMS.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(175, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 4
        Label2.Text = "Message Mo : "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(btnSendSMS)
        Controls.Add(txtMessage)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSendSMS As Button
    Friend WithEvents Label2 As Label

End Class
