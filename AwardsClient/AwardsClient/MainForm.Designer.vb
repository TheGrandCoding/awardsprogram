﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.first_panel_load = New System.Windows.Forms.Panel()
        Me.lblFirstPanelDisplay = New System.Windows.Forms.Label()
        Me.contactServerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.second_panel_prompt = New System.Windows.Forms.Panel()
        Me.lblOpeningMessage = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblNumRemain = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblMaleDisplay = New System.Windows.Forms.Label()
        Me.lblFemaleDisplay = New System.Windows.Forms.Label()
        Me.lblQueryMale = New System.Windows.Forms.Label()
        Me.lblQueryFemale = New System.Windows.Forms.Label()
        Me.txtQueryMale = New System.Windows.Forms.TextBox()
        Me.txtQueryFemale = New System.Windows.Forms.TextBox()
        Me.maleDisplayPanel = New System.Windows.Forms.Panel()
        Me.femaleDisplayPanel = New System.Windows.Forms.Panel()
        Me.first_panel_load.SuspendLayout()
        Me.second_panel_prompt.SuspendLayout()
        Me.SuspendLayout()
        '
        'first_panel_load
        '
        Me.first_panel_load.Controls.Add(Me.lblFirstPanelDisplay)
        Me.first_panel_load.Location = New System.Drawing.Point(954, 12)
        Me.first_panel_load.Name = "first_panel_load"
        Me.first_panel_load.Size = New System.Drawing.Size(215, 175)
        Me.first_panel_load.TabIndex = 0
        '
        'lblFirstPanelDisplay
        '
        Me.lblFirstPanelDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFirstPanelDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstPanelDisplay.Location = New System.Drawing.Point(0, 0)
        Me.lblFirstPanelDisplay.Name = "lblFirstPanelDisplay"
        Me.lblFirstPanelDisplay.Size = New System.Drawing.Size(215, 175)
        Me.lblFirstPanelDisplay.TabIndex = 0
        Me.lblFirstPanelDisplay.Text = "Hey"
        Me.lblFirstPanelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'contactServerTimer
        '
        Me.contactServerTimer.Interval = 1000
        '
        'second_panel_prompt
        '
        Me.second_panel_prompt.Controls.Add(Me.lblOpeningMessage)
        Me.second_panel_prompt.Controls.Add(Me.btnStart)
        Me.second_panel_prompt.Location = New System.Drawing.Point(954, 193)
        Me.second_panel_prompt.Name = "second_panel_prompt"
        Me.second_panel_prompt.Size = New System.Drawing.Size(233, 175)
        Me.second_panel_prompt.TabIndex = 1
        '
        'lblOpeningMessage
        '
        Me.lblOpeningMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOpeningMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpeningMessage.Location = New System.Drawing.Point(0, 0)
        Me.lblOpeningMessage.Name = "lblOpeningMessage"
        Me.lblOpeningMessage.Size = New System.Drawing.Size(233, 147)
        Me.lblOpeningMessage.TabIndex = 1
        Me.lblOpeningMessage.Text = "Hello!"
        Me.lblOpeningMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnStart.Location = New System.Drawing.Point(0, 147)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(233, 28)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "I'm ready, lets begin"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(90, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(736, 40)
        Me.lblPrompt.TabIndex = 2
        Me.lblPrompt.Text = "Prompt"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumRemain
        '
        Me.lblNumRemain.Location = New System.Drawing.Point(12, 9)
        Me.lblNumRemain.Name = "lblNumRemain"
        Me.lblNumRemain.Size = New System.Drawing.Size(72, 23)
        Me.lblNumRemain.TabIndex = 3
        Me.lblNumRemain.Text = "99/99"
        Me.lblNumRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(709, 382)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(117, 56)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(12, 382)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(117, 56)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        Me.btnPrevious.Visible = False
        '
        'lblMaleDisplay
        '
        Me.lblMaleDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaleDisplay.Location = New System.Drawing.Point(12, 91)
        Me.lblMaleDisplay.Name = "lblMaleDisplay"
        Me.lblMaleDisplay.Size = New System.Drawing.Size(208, 17)
        Me.lblMaleDisplay.TabIndex = 6
        Me.lblMaleDisplay.Text = "Male"
        Me.lblMaleDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFemaleDisplay
        '
        Me.lblFemaleDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemaleDisplay.Location = New System.Drawing.Point(524, 91)
        Me.lblFemaleDisplay.Name = "lblFemaleDisplay"
        Me.lblFemaleDisplay.Size = New System.Drawing.Size(208, 17)
        Me.lblFemaleDisplay.TabIndex = 7
        Me.lblFemaleDisplay.Text = "Female"
        Me.lblFemaleDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblQueryMale
        '
        Me.lblQueryMale.AutoSize = True
        Me.lblQueryMale.Location = New System.Drawing.Point(226, 114)
        Me.lblQueryMale.Name = "lblQueryMale"
        Me.lblQueryMale.Size = New System.Drawing.Size(84, 17)
        Me.lblQueryMale.TabIndex = 9
        Me.lblQueryMale.Text = "Searching..."
        Me.lblQueryMale.Visible = False
        '
        'lblQueryFemale
        '
        Me.lblQueryFemale.AutoSize = True
        Me.lblQueryFemale.Location = New System.Drawing.Point(738, 114)
        Me.lblQueryFemale.Name = "lblQueryFemale"
        Me.lblQueryFemale.Size = New System.Drawing.Size(84, 17)
        Me.lblQueryFemale.TabIndex = 11
        Me.lblQueryFemale.Text = "Searching..."
        Me.lblQueryFemale.Visible = False
        '
        'txtQueryMale
        '
        Me.txtQueryMale.Location = New System.Drawing.Point(12, 111)
        Me.txtQueryMale.MaxLength = 20
        Me.txtQueryMale.Name = "txtQueryMale"
        Me.txtQueryMale.Size = New System.Drawing.Size(208, 22)
        Me.txtQueryMale.TabIndex = 12
        '
        'txtQueryFemale
        '
        Me.txtQueryFemale.Location = New System.Drawing.Point(524, 111)
        Me.txtQueryFemale.MaxLength = 20
        Me.txtQueryFemale.Name = "txtQueryFemale"
        Me.txtQueryFemale.Size = New System.Drawing.Size(208, 22)
        Me.txtQueryFemale.TabIndex = 13
        '
        'maleDisplayPanel
        '
        Me.maleDisplayPanel.AutoScroll = True
        Me.maleDisplayPanel.Location = New System.Drawing.Point(12, 139)
        Me.maleDisplayPanel.Name = "maleDisplayPanel"
        Me.maleDisplayPanel.Size = New System.Drawing.Size(298, 229)
        Me.maleDisplayPanel.TabIndex = 14
        '
        'femaleDisplayPanel
        '
        Me.femaleDisplayPanel.Location = New System.Drawing.Point(524, 139)
        Me.femaleDisplayPanel.Name = "femaleDisplayPanel"
        Me.femaleDisplayPanel.Size = New System.Drawing.Size(298, 229)
        Me.femaleDisplayPanel.TabIndex = 15
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 450)
        Me.Controls.Add(Me.femaleDisplayPanel)
        Me.Controls.Add(Me.maleDisplayPanel)
        Me.Controls.Add(Me.txtQueryFemale)
        Me.Controls.Add(Me.txtQueryMale)
        Me.Controls.Add(Me.lblQueryFemale)
        Me.Controls.Add(Me.lblQueryMale)
        Me.Controls.Add(Me.lblFemaleDisplay)
        Me.Controls.Add(Me.lblMaleDisplay)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblNumRemain)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.second_panel_prompt)
        Me.Controls.Add(Me.first_panel_load)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Y11 Awards"
        Me.first_panel_load.ResumeLayout(False)
        Me.second_panel_prompt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents first_panel_load As Panel
    Friend WithEvents lblFirstPanelDisplay As Label
    Friend WithEvents contactServerTimer As Timer
    Friend WithEvents second_panel_prompt As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents lblOpeningMessage As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblNumRemain As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblMaleDisplay As Label
    Friend WithEvents lblFemaleDisplay As Label
    Friend WithEvents lblQueryMale As Label
    Friend WithEvents lblQueryFemale As Label
    Friend WithEvents txtQueryMale As TextBox
    Friend WithEvents txtQueryFemale As TextBox
    Friend WithEvents maleDisplayPanel As Panel
    Friend WithEvents femaleDisplayPanel As Panel
End Class
