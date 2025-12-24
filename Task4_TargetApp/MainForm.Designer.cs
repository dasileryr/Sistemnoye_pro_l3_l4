namespace Task4_TargetApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(360, 23);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "Текстовое поле";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(12, 41);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(360, 30);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Кнопка";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 74);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(38, 15);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Метка";
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(12, 102);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(83, 19);
            this.chkBox.TabIndex = 3;
            this.chkBox.Text = "Чекбокс";
            this.chkBox.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 127);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Радиокнопка 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 152);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Радиокнопка 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Элемент 1",
            "Элемент 2",
            "Элемент 3"});
            this.comboBox1.Location = new System.Drawing.Point(12, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txtInput);
            this.Name = "MainForm";
            this.Text = "TargetApp - Приложение с элементами управления";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

