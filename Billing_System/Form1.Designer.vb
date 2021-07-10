<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NumBread = New System.Windows.Forms.NumericUpDown()
        Me.lblBread = New System.Windows.Forms.Label()
        Me.lblIBread = New System.Windows.Forms.Label()
        Me.NumRice = New System.Windows.Forms.NumericUpDown()
        Me.lblRice = New System.Windows.Forms.Label()
        Me.lblIRice = New System.Windows.Forms.Label()
        Me.NumBeans = New System.Windows.Forms.NumericUpDown()
        Me.lblBeans = New System.Windows.Forms.Label()
        Me.lblIBeans = New System.Windows.Forms.Label()
        Me.NumHoppers = New System.Windows.Forms.NumericUpDown()
        Me.lblHoppers = New System.Windows.Forms.Label()
        Me.lblIHoppers = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.NumSandwich = New System.Windows.Forms.NumericUpDown()
        Me.lblSandwich = New System.Windows.Forms.Label()
        Me.lblISandwich = New System.Windows.Forms.Label()
        Me.lblNumItem = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtReceipt = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumBread, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBeans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumHoppers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumSandwich, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1345, 725)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.btnExit)
        Me.Panel5.Controls.Add(Me.btnReset)
        Me.Panel5.Controls.Add(Me.btnReceipt)
        Me.Panel5.Controls.Add(Me.btnTotal)
        Me.Panel5.Location = New System.Drawing.Point(13, 595)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1317, 80)
        Me.Panel5.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnExit.Location = New System.Drawing.Point(1132, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(156, 50)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Black
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReset.Location = New System.Drawing.Point(767, 15)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(156, 50)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.Black
        Me.btnReceipt.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReceipt.Location = New System.Drawing.Point(381, 15)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(156, 50)
        Me.btnReceipt.TabIndex = 1
        Me.btnReceipt.Text = "Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.Black
        Me.btnTotal.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTotal.Location = New System.Drawing.Point(28, 15)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(156, 50)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(13, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1317, 80)
        Me.Panel4.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 75)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Biling Management System"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.rtReceipt)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(869, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(461, 491)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.lblNumItem)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblCost)
        Me.Panel2.Controls.Add(Me.NumSandwich)
        Me.Panel2.Controls.Add(Me.lblSandwich)
        Me.Panel2.Controls.Add(Me.lblISandwich)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.NumBeans)
        Me.Panel2.Controls.Add(Me.lblBeans)
        Me.Panel2.Controls.Add(Me.lblIBeans)
        Me.Panel2.Controls.Add(Me.NumHoppers)
        Me.Panel2.Controls.Add(Me.lblHoppers)
        Me.Panel2.Controls.Add(Me.lblIHoppers)
        Me.Panel2.Controls.Add(Me.NumRice)
        Me.Panel2.Controls.Add(Me.lblRice)
        Me.Panel2.Controls.Add(Me.lblIRice)
        Me.Panel2.Controls.Add(Me.NumBread)
        Me.Panel2.Controls.Add(Me.lblBread)
        Me.Panel2.Controls.Add(Me.lblIBread)
        Me.Panel2.Location = New System.Drawing.Point(13, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(850, 491)
        Me.Panel2.TabIndex = 0
        '
        'NumBread
        '
        Me.NumBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumBread.Location = New System.Drawing.Point(233, 62)
        Me.NumBread.Name = "NumBread"
        Me.NumBread.Size = New System.Drawing.Size(134, 35)
        Me.NumBread.TabIndex = 2
        Me.NumBread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBread
        '
        Me.lblBread.BackColor = System.Drawing.Color.White
        Me.lblBread.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBread.Location = New System.Drawing.Point(476, 61)
        Me.lblBread.Name = "lblBread"
        Me.lblBread.Size = New System.Drawing.Size(193, 35)
        Me.lblBread.TabIndex = 1
        Me.lblBread.Text = "Rs.0.00"
        Me.lblBread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIBread
        '
        Me.lblIBread.AutoSize = True
        Me.lblIBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIBread.Location = New System.Drawing.Point(51, 68)
        Me.lblIBread.Name = "lblIBread"
        Me.lblIBread.Size = New System.Drawing.Size(83, 29)
        Me.lblIBread.TabIndex = 0
        Me.lblIBread.Text = "Bread"
        '
        'NumRice
        '
        Me.NumRice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumRice.Location = New System.Drawing.Point(233, 133)
        Me.NumRice.Name = "NumRice"
        Me.NumRice.Size = New System.Drawing.Size(134, 35)
        Me.NumRice.TabIndex = 5
        Me.NumRice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRice
        '
        Me.lblRice.BackColor = System.Drawing.Color.White
        Me.lblRice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRice.Location = New System.Drawing.Point(476, 132)
        Me.lblRice.Name = "lblRice"
        Me.lblRice.Size = New System.Drawing.Size(193, 35)
        Me.lblRice.TabIndex = 4
        Me.lblRice.Text = "Rs.0.00"
        Me.lblRice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIRice
        '
        Me.lblIRice.AutoSize = True
        Me.lblIRice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIRice.Location = New System.Drawing.Point(51, 139)
        Me.lblIRice.Name = "lblIRice"
        Me.lblIRice.Size = New System.Drawing.Size(66, 29)
        Me.lblIRice.TabIndex = 3
        Me.lblIRice.Text = "Rice"
        '
        'NumBeans
        '
        Me.NumBeans.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumBeans.Location = New System.Drawing.Point(233, 277)
        Me.NumBeans.Name = "NumBeans"
        Me.NumBeans.Size = New System.Drawing.Size(134, 35)
        Me.NumBeans.TabIndex = 11
        Me.NumBeans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBeans
        '
        Me.lblBeans.BackColor = System.Drawing.Color.White
        Me.lblBeans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBeans.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeans.Location = New System.Drawing.Point(476, 276)
        Me.lblBeans.Name = "lblBeans"
        Me.lblBeans.Size = New System.Drawing.Size(193, 35)
        Me.lblBeans.TabIndex = 10
        Me.lblBeans.Text = "Rs.0.00"
        Me.lblBeans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIBeans
        '
        Me.lblIBeans.AutoSize = True
        Me.lblIBeans.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIBeans.Location = New System.Drawing.Point(51, 283)
        Me.lblIBeans.Name = "lblIBeans"
        Me.lblIBeans.Size = New System.Drawing.Size(86, 29)
        Me.lblIBeans.TabIndex = 9
        Me.lblIBeans.Text = "Beans"
        '
        'NumHoppers
        '
        Me.NumHoppers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumHoppers.Location = New System.Drawing.Point(233, 206)
        Me.NumHoppers.Name = "NumHoppers"
        Me.NumHoppers.Size = New System.Drawing.Size(134, 35)
        Me.NumHoppers.TabIndex = 8
        Me.NumHoppers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHoppers
        '
        Me.lblHoppers.BackColor = System.Drawing.Color.White
        Me.lblHoppers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHoppers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoppers.Location = New System.Drawing.Point(476, 205)
        Me.lblHoppers.Name = "lblHoppers"
        Me.lblHoppers.Size = New System.Drawing.Size(193, 35)
        Me.lblHoppers.TabIndex = 7
        Me.lblHoppers.Text = "Rs.0.00"
        Me.lblHoppers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIHoppers
        '
        Me.lblIHoppers.AutoSize = True
        Me.lblIHoppers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIHoppers.Location = New System.Drawing.Point(51, 212)
        Me.lblIHoppers.Name = "lblIHoppers"
        Me.lblIHoppers.Size = New System.Drawing.Size(113, 29)
        Me.lblIHoppers.TabIndex = 6
        Me.lblIHoppers.Text = "Hoppers"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(58, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 29)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Items"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(493, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 29)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Cost of Item"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(206, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 29)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Number of Item"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(476, 418)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(193, 35)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Rs.0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(51, 425)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(133, 29)
        Me.lblCost.TabIndex = 18
        Me.lblCost.Text = "Total Cost"
        '
        'NumSandwich
        '
        Me.NumSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumSandwich.Location = New System.Drawing.Point(233, 348)
        Me.NumSandwich.Name = "NumSandwich"
        Me.NumSandwich.Size = New System.Drawing.Size(134, 35)
        Me.NumSandwich.TabIndex = 17
        Me.NumSandwich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSandwich
        '
        Me.lblSandwich.BackColor = System.Drawing.Color.White
        Me.lblSandwich.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSandwich.Location = New System.Drawing.Point(476, 347)
        Me.lblSandwich.Name = "lblSandwich"
        Me.lblSandwich.Size = New System.Drawing.Size(193, 35)
        Me.lblSandwich.TabIndex = 16
        Me.lblSandwich.Text = "Rs.0.00"
        Me.lblSandwich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblISandwich
        '
        Me.lblISandwich.AutoSize = True
        Me.lblISandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISandwich.Location = New System.Drawing.Point(51, 354)
        Me.lblISandwich.Name = "lblISandwich"
        Me.lblISandwich.Size = New System.Drawing.Size(154, 29)
        Me.lblISandwich.TabIndex = 15
        Me.lblISandwich.Text = "Sandwiches"
        '
        'lblNumItem
        '
        Me.lblNumItem.BackColor = System.Drawing.Color.White
        Me.lblNumItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumItem.Location = New System.Drawing.Point(233, 418)
        Me.lblNumItem.Name = "lblNumItem"
        Me.lblNumItem.Size = New System.Drawing.Size(134, 35)
        Me.lblNumItem.TabIndex = 20
        Me.lblNumItem.Text = "0"
        Me.lblNumItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(182, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 29)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Cost of Item"
        '
        'rtReceipt
        '
        Me.rtReceipt.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtReceipt.Location = New System.Drawing.Point(16, 61)
        Me.rtReceipt.Name = "rtReceipt"
        Me.rtReceipt.Size = New System.Drawing.Size(426, 392)
        Me.rtReceipt.TabIndex = 22
        Me.rtReceipt.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumBread, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBeans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumHoppers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumSandwich, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnReceipt As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblBread As Label
    Friend WithEvents lblIBread As Label
    Friend WithEvents NumBread As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumBeans As NumericUpDown
    Friend WithEvents lblBeans As Label
    Friend WithEvents lblIBeans As Label
    Friend WithEvents NumHoppers As NumericUpDown
    Friend WithEvents lblHoppers As Label
    Friend WithEvents lblIHoppers As Label
    Friend WithEvents NumRice As NumericUpDown
    Friend WithEvents lblRice As Label
    Friend WithEvents lblIRice As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents NumSandwich As NumericUpDown
    Friend WithEvents lblSandwich As Label
    Friend WithEvents lblISandwich As Label
    Friend WithEvents lblNumItem As Label
    Friend WithEvents rtReceipt As RichTextBox
    Friend WithEvents Label3 As Label
End Class
