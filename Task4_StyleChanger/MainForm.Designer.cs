namespace Task4_StyleChanger
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnFindTargetApp;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnChangeTextBoxStyle;
        private System.Windows.Forms.Button btnChangeButtonStyle;
        private System.Windows.Forms.Button btnChangeLabelStyle;
        private System.Windows.Forms.Button btnDisableControls;
        private System.Windows.Forms.Button btnEnableControls;
        private System.Windows.Forms.ListBox listBoxControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeComboBoxStyle;

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
            this.btnFindTargetApp = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnChangeTextBoxStyle = new System.Windows.Forms.Button();
            this.btnChangeButtonStyle = new System.Windows.Forms.Button();
            this.btnChangeLabelStyle = new System.Windows.Forms.Button();
            this.btnDisableControls = new System.Windows.Forms.Button();
            this.btnEnableControls = new System.Windows.Forms.Button();
            this.listBoxControls = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeComboBoxStyle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindTargetApp
            // 
            this.btnFindTargetApp.Location = new System.Drawing.Point(12, 12);
            this.btnFindTargetApp.Name = "btnFindTargetApp";
            this.btnFindTargetApp.Size = new System.Drawing.Size(360, 30);
            this.btnFindTargetApp.TabIndex = 0;
            this.btnFindTargetApp.Text = "Найти TargetApp";
            this.btnFindTargetApp.UseVisualStyleBackColor = true;
            this.btnFindTargetApp.Click += new System.EventHandler(this.btnFindTargetApp_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Окно не найдено";
            // 
            // btnChangeTextBoxStyle
            // 
            this.btnChangeTextBoxStyle.Location = new System.Drawing.Point(12, 70);
            this.btnChangeTextBoxStyle.Name = "btnChangeTextBoxStyle";
            this.btnChangeTextBoxStyle.Size = new System.Drawing.Size(175, 30);
            this.btnChangeTextBoxStyle.TabIndex = 2;
            this.btnChangeTextBoxStyle.Text = "Изменить TextBox";
            this.btnChangeTextBoxStyle.UseVisualStyleBackColor = true;
            this.btnChangeTextBoxStyle.Click += new System.EventHandler(this.btnChangeTextBoxStyle_Click);
            // 
            // btnChangeButtonStyle
            // 
            this.btnChangeButtonStyle.Location = new System.Drawing.Point(197, 70);
            this.btnChangeButtonStyle.Name = "btnChangeButtonStyle";
            this.btnChangeButtonStyle.Size = new System.Drawing.Size(175, 30);
            this.btnChangeButtonStyle.TabIndex = 3;
            this.btnChangeButtonStyle.Text = "Изменить Button";
            this.btnChangeButtonStyle.UseVisualStyleBackColor = true;
            this.btnChangeButtonStyle.Click += new System.EventHandler(this.btnChangeButtonStyle_Click);
            // 
            // btnChangeLabelStyle
            // 
            this.btnChangeLabelStyle.Location = new System.Drawing.Point(12, 106);
            this.btnChangeLabelStyle.Name = "btnChangeLabelStyle";
            this.btnChangeLabelStyle.Size = new System.Drawing.Size(175, 30);
            this.btnChangeLabelStyle.TabIndex = 4;
            this.btnChangeLabelStyle.Text = "Изменить Label";
            this.btnChangeLabelStyle.UseVisualStyleBackColor = true;
            this.btnChangeLabelStyle.Click += new System.EventHandler(this.btnChangeLabelStyle_Click);
            // 
            // btnDisableControls
            // 
            this.btnDisableControls.Location = new System.Drawing.Point(12, 178);
            this.btnDisableControls.Name = "btnDisableControls";
            this.btnDisableControls.Size = new System.Drawing.Size(175, 30);
            this.btnDisableControls.TabIndex = 5;
            this.btnDisableControls.Text = "Отключить все";
            this.btnDisableControls.UseVisualStyleBackColor = true;
            this.btnDisableControls.Click += new System.EventHandler(this.btnDisableControls_Click);
            // 
            // btnEnableControls
            // 
            this.btnEnableControls.Location = new System.Drawing.Point(197, 178);
            this.btnEnableControls.Name = "btnEnableControls";
            this.btnEnableControls.Size = new System.Drawing.Size(175, 30);
            this.btnEnableControls.TabIndex = 6;
            this.btnEnableControls.Text = "Включить все";
            this.btnEnableControls.UseVisualStyleBackColor = true;
            this.btnEnableControls.Click += new System.EventHandler(this.btnEnableControls_Click);
            // 
            // listBoxControls
            // 
            this.listBoxControls.FormattingEnabled = true;
            this.listBoxControls.ItemHeight = 15;
            this.listBoxControls.Location = new System.Drawing.Point(12, 250);
            this.listBoxControls.Name = "listBoxControls";
            this.listBoxControls.Size = new System.Drawing.Size(360, 139);
            this.listBoxControls.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Найденные элементы:";
            // 
            // btnChangeComboBoxStyle
            // 
            this.btnChangeComboBoxStyle.Location = new System.Drawing.Point(197, 106);
            this.btnChangeComboBoxStyle.Name = "btnChangeComboBoxStyle";
            this.btnChangeComboBoxStyle.Size = new System.Drawing.Size(175, 30);
            this.btnChangeComboBoxStyle.TabIndex = 9;
            this.btnChangeComboBoxStyle.Text = "Изменить ComboBox";
            this.btnChangeComboBoxStyle.UseVisualStyleBackColor = true;
            this.btnChangeComboBoxStyle.Click += new System.EventHandler(this.btnChangeComboBoxStyle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.btnChangeComboBoxStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxControls);
            this.Controls.Add(this.btnEnableControls);
            this.Controls.Add(this.btnDisableControls);
            this.Controls.Add(this.btnChangeLabelStyle);
            this.Controls.Add(this.btnChangeButtonStyle);
            this.Controls.Add(this.btnChangeTextBoxStyle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnFindTargetApp);
            this.Name = "MainForm";
            this.Text = "Задание 4 - Изменение стилей элементов управления";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

