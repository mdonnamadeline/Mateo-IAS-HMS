﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doctorDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_change = New System.Windows.Forms.Button()
        Me.btn_viewdoctor = New System.Windows.Forms.Button()
        Me.btn_manageappointment = New System.Windows.Forms.Button()
        Me.btn_audit = New System.Windows.Forms.Button()
        Me.btn_managepayment = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.currentUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userRole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dateAndTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_managepatient = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_change
        '
        Me.btn_change.Location = New System.Drawing.Point(322, 140)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(132, 34)
        Me.btn_change.TabIndex = 14
        Me.btn_change.Text = "Change Info"
        Me.btn_change.UseVisualStyleBackColor = True
        '
        'btn_viewdoctor
        '
        Me.btn_viewdoctor.Location = New System.Drawing.Point(520, 140)
        Me.btn_viewdoctor.Name = "btn_viewdoctor"
        Me.btn_viewdoctor.Size = New System.Drawing.Size(132, 34)
        Me.btn_viewdoctor.TabIndex = 13
        Me.btn_viewdoctor.Text = "View Doctors"
        Me.btn_viewdoctor.UseVisualStyleBackColor = True
        '
        'btn_manageappointment
        '
        Me.btn_manageappointment.Location = New System.Drawing.Point(113, 180)
        Me.btn_manageappointment.Name = "btn_manageappointment"
        Me.btn_manageappointment.Size = New System.Drawing.Size(132, 55)
        Me.btn_manageappointment.TabIndex = 12
        Me.btn_manageappointment.Text = "Manage Appointments"
        Me.btn_manageappointment.UseVisualStyleBackColor = True
        '
        'btn_audit
        '
        Me.btn_audit.Location = New System.Drawing.Point(322, 180)
        Me.btn_audit.Name = "btn_audit"
        Me.btn_audit.Size = New System.Drawing.Size(132, 55)
        Me.btn_audit.TabIndex = 11
        Me.btn_audit.Text = "Audit"
        Me.btn_audit.UseVisualStyleBackColor = True
        '
        'btn_managepayment
        '
        Me.btn_managepayment.Location = New System.Drawing.Point(113, 140)
        Me.btn_managepayment.Name = "btn_managepayment"
        Me.btn_managepayment.Size = New System.Drawing.Size(132, 34)
        Me.btn_managepayment.TabIndex = 10
        Me.btn_managepayment.Text = "Manage Payments"
        Me.btn_managepayment.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.currentUser, Me.ToolStripStatusLabel2, Me.userRole, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.dateAndTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 26)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(93, 20)
        Me.ToolStripStatusLabel1.Text = "Current User:"
        '
        'currentUser
        '
        Me.currentUser.Name = "currentUser"
        Me.currentUser.Size = New System.Drawing.Size(15, 20)
        Me.currentUser.Text = "-"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(75, 20)
        Me.ToolStripStatusLabel2.Text = "User Role:"
        '
        'userRole
        '
        Me.userRole.Name = "userRole"
        Me.userRole.Size = New System.Drawing.Size(15, 20)
        Me.userRole.Text = "-"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 20)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(107, 20)
        Me.ToolStripStatusLabel4.Text = "Date and Time"
        Me.ToolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dateAndTime
        '
        Me.dateAndTime.Name = "dateAndTime"
        Me.dateAndTime.Size = New System.Drawing.Size(15, 20)
        Me.dateAndTime.Text = "-"
        '
        'btn_managepatient
        '
        Me.btn_managepatient.Location = New System.Drawing.Point(520, 180)
        Me.btn_managepatient.Name = "btn_managepatient"
        Me.btn_managepatient.Size = New System.Drawing.Size(132, 56)
        Me.btn_managepatient.TabIndex = 17
        Me.btn_managepatient.Text = "Manage Patients"
        Me.btn_managepatient.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(322, 279)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(132, 55)
        Me.btn_logout.TabIndex = 18
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'doctorDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_managepatient)
        Me.Controls.Add(Me.btn_change)
        Me.Controls.Add(Me.btn_viewdoctor)
        Me.Controls.Add(Me.btn_manageappointment)
        Me.Controls.Add(Me.btn_audit)
        Me.Controls.Add(Me.btn_managepayment)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "doctorDashboard"
        Me.Text = "doctorDashboard"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_change As Button
    Friend WithEvents btn_viewdoctor As Button
    Friend WithEvents btn_manageappointment As Button
    Friend WithEvents btn_audit As Button
    Friend WithEvents btn_managepayment As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents currentUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents userRole As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents dateAndTime As ToolStripStatusLabel
    Friend WithEvents btn_managepatient As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents Timer1 As Timer
End Class