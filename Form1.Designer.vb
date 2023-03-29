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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBoxFood = New System.Windows.Forms.GroupBox()
        Me.RdoBtnGourmetCheese = New System.Windows.Forms.RadioButton()
        Me.RBtnPinwheelWrap = New System.Windows.Forms.RadioButton()
        Me.RBtnVeggie = New System.Windows.Forms.RadioButton()
        Me.RBtnSausageAndCheese = New System.Windows.Forms.RadioButton()
        Me.RBtnFruit = New System.Windows.Forms.RadioButton()
        Me.GBoxPay = New System.Windows.Forms.GroupBox()
        Me.RBtnPrePay = New System.Windows.Forms.RadioButton()
        Me.RBtnPayOnPickup = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblShow = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GBoxFood.SuspendLayout()
        Me.GBoxPay.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Catering"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Star Market"
        '
        'GBoxFood
        '
        Me.GBoxFood.BackColor = System.Drawing.Color.Linen
        Me.GBoxFood.Controls.Add(Me.RBtnFruit)
        Me.GBoxFood.Controls.Add(Me.RBtnSausageAndCheese)
        Me.GBoxFood.Controls.Add(Me.RBtnVeggie)
        Me.GBoxFood.Controls.Add(Me.RBtnPinwheelWrap)
        Me.GBoxFood.Controls.Add(Me.RdoBtnGourmetCheese)
        Me.GBoxFood.Location = New System.Drawing.Point(70, 94)
        Me.GBoxFood.Name = "GBoxFood"
        Me.GBoxFood.Size = New System.Drawing.Size(293, 175)
        Me.GBoxFood.TabIndex = 2
        Me.GBoxFood.TabStop = False
        '
        'RdoBtnGourmetCheese
        '
        Me.RdoBtnGourmetCheese.AutoSize = True
        Me.RdoBtnGourmetCheese.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoBtnGourmetCheese.Location = New System.Drawing.Point(6, 21)
        Me.RdoBtnGourmetCheese.Name = "RdoBtnGourmetCheese"
        Me.RdoBtnGourmetCheese.Size = New System.Drawing.Size(198, 23)
        Me.RdoBtnGourmetCheese.TabIndex = 0
        Me.RdoBtnGourmetCheese.TabStop = True
        Me.RdoBtnGourmetCheese.Text = "Gourmet Cheese $49.99"
        Me.RdoBtnGourmetCheese.UseVisualStyleBackColor = True
        '
        'RBtnPinwheelWrap
        '
        Me.RBtnPinwheelWrap.AutoSize = True
        Me.RBtnPinwheelWrap.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnPinwheelWrap.Location = New System.Drawing.Point(6, 46)
        Me.RBtnPinwheelWrap.Name = "RBtnPinwheelWrap"
        Me.RBtnPinwheelWrap.Size = New System.Drawing.Size(193, 23)
        Me.RBtnPinwheelWrap.TabIndex = 1
        Me.RBtnPinwheelWrap.TabStop = True
        Me.RBtnPinwheelWrap.Text = "Pinwheel Wraps $59.99"
        Me.RBtnPinwheelWrap.UseVisualStyleBackColor = True
        '
        'RBtnVeggie
        '
        Me.RBtnVeggie.AutoSize = True
        Me.RBtnVeggie.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnVeggie.Location = New System.Drawing.Point(6, 75)
        Me.RBtnVeggie.Name = "RBtnVeggie"
        Me.RBtnVeggie.Size = New System.Drawing.Size(129, 23)
        Me.RBtnVeggie.TabIndex = 2
        Me.RBtnVeggie.TabStop = True
        Me.RBtnVeggie.Text = "Veggie $29.99"
        Me.RBtnVeggie.UseVisualStyleBackColor = True
        '
        'RBtnSausageAndCheese
        '
        Me.RBtnSausageAndCheese.AutoSize = True
        Me.RBtnSausageAndCheese.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnSausageAndCheese.Location = New System.Drawing.Point(6, 104)
        Me.RBtnSausageAndCheese.Name = "RBtnSausageAndCheese"
        Me.RBtnSausageAndCheese.Size = New System.Drawing.Size(218, 23)
        Me.RBtnSausageAndCheese.TabIndex = 3
        Me.RBtnSausageAndCheese.TabStop = True
        Me.RBtnSausageAndCheese.Text = "Sausage and Cheese $49.99"
        Me.RBtnSausageAndCheese.UseVisualStyleBackColor = True
        '
        'RBtnFruit
        '
        Me.RBtnFruit.AutoSize = True
        Me.RBtnFruit.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnFruit.Location = New System.Drawing.Point(6, 133)
        Me.RBtnFruit.Name = "RBtnFruit"
        Me.RBtnFruit.Size = New System.Drawing.Size(116, 23)
        Me.RBtnFruit.TabIndex = 4
        Me.RBtnFruit.TabStop = True
        Me.RBtnFruit.Text = "Fruit $29.99"
        Me.RBtnFruit.UseVisualStyleBackColor = True
        '
        'GBoxPay
        '
        Me.GBoxPay.BackColor = System.Drawing.Color.Linen
        Me.GBoxPay.Controls.Add(Me.RBtnPayOnPickup)
        Me.GBoxPay.Controls.Add(Me.RBtnPrePay)
        Me.GBoxPay.Location = New System.Drawing.Point(70, 275)
        Me.GBoxPay.Name = "GBoxPay"
        Me.GBoxPay.Size = New System.Drawing.Size(223, 102)
        Me.GBoxPay.TabIndex = 3
        Me.GBoxPay.TabStop = False
        '
        'RBtnPrePay
        '
        Me.RBtnPrePay.AutoSize = True
        Me.RBtnPrePay.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnPrePay.Location = New System.Drawing.Point(6, 21)
        Me.RBtnPrePay.Name = "RBtnPrePay"
        Me.RBtnPrePay.Size = New System.Drawing.Size(85, 23)
        Me.RBtnPrePay.TabIndex = 0
        Me.RBtnPrePay.TabStop = True
        Me.RBtnPrePay.Text = "Pre-Pay"
        Me.RBtnPrePay.UseVisualStyleBackColor = True
        '
        'RBtnPayOnPickup
        '
        Me.RBtnPayOnPickup.AutoSize = True
        Me.RBtnPayOnPickup.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnPayOnPickup.Location = New System.Drawing.Point(6, 60)
        Me.RBtnPayOnPickup.Name = "RBtnPayOnPickup"
        Me.RBtnPayOnPickup.Size = New System.Drawing.Size(147, 23)
        Me.RBtnPayOnPickup.TabIndex = 1
        Me.RBtnPayOnPickup.TabStop = True
        Me.RBtnPayOnPickup.Text = "Pay upon Pickup "
        Me.RBtnPayOnPickup.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Please Pay:"
        '
        'LblShow
        '
        Me.LblShow.AutoSize = True
        Me.LblShow.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShow.Location = New System.Drawing.Point(251, 396)
        Me.LblShow.Name = "LblShow"
        Me.LblShow.Size = New System.Drawing.Size(75, 23)
        Me.LblShow.TabIndex = 5
        Me.LblShow.Text = "$888.88"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(496, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Loyalty Points"
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(648, 240)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(38, 27)
        Me.txtPoints.TabIndex = 7
        Me.txtPoints.Text = "888"
        Me.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.Color.Linen
        Me.BtnCalculate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(465, 321)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(109, 27)
        Me.BtnCalculate.TabIndex = 8
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Linen
        Me.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClear.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(634, 321)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(108, 27)
        Me.BtnClear.TabIndex = 9
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(443, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnClear
        Me.ClientSize = New System.Drawing.Size(855, 477)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblShow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GBoxPay)
        Me.Controls.Add(Me.GBoxFood)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Catering"
        Me.GBoxFood.ResumeLayout(False)
        Me.GBoxFood.PerformLayout()
        Me.GBoxPay.ResumeLayout(False)
        Me.GBoxPay.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GBoxFood As GroupBox
    Friend WithEvents RBtnFruit As RadioButton
    Friend WithEvents RBtnSausageAndCheese As RadioButton
    Friend WithEvents RBtnVeggie As RadioButton
    Friend WithEvents RBtnPinwheelWrap As RadioButton
    Friend WithEvents RdoBtnGourmetCheese As RadioButton
    Friend WithEvents GBoxPay As GroupBox
    Friend WithEvents RBtnPayOnPickup As RadioButton
    Friend WithEvents RBtnPrePay As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents LblShow As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
