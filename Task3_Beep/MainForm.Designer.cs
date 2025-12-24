namespace Task3_Beep
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStartBeeps;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSingleBeep;
        private System.Windows.Forms.Button btnMessageBeep;

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
            this.btnStartBeeps = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSingleBeep = new System.Windows.Forms.Button();
            this.btnMessageBeep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartBeeps
            // 
            this.btnStartBeeps.Location = new System.Drawing.Point(12, 12);
            this.btnStartBeeps.Name = "btnStartBeeps";
            this.btnStartBeeps.Size = new System.Drawing.Size(360, 50);
            this.btnStartBeeps.TabIndex = 0;
            this.btnStartBeeps.Text = "Запустить последовательность звуковых сигналов";
            this.btnStartBeeps.UseVisualStyleBackColor = true;
            this.btnStartBeeps.Click += new System.EventHandler(this.btnStartBeeps_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Готово";
            // 
            // btnSingleBeep
            // 
            this.btnSingleBeep.Location = new System.Drawing.Point(12, 68);
            this.btnSingleBeep.Name = "btnSingleBeep";
            this.btnSingleBeep.Size = new System.Drawing.Size(175, 30);
            this.btnSingleBeep.TabIndex = 2;
            this.btnSingleBeep.Text = "Одиночный Beep";
            this.btnSingleBeep.UseVisualStyleBackColor = true;
            this.btnSingleBeep.Click += new System.EventHandler(this.btnSingleBeep_Click);
            // 
            // btnMessageBeep
            // 
            this.btnMessageBeep.Location = new System.Drawing.Point(197, 68);
            this.btnMessageBeep.Name = "btnMessageBeep";
            this.btnMessageBeep.Size = new System.Drawing.Size(175, 30);
            this.btnMessageBeep.TabIndex = 3;
            this.btnMessageBeep.Text = "MessageBeep";
            this.btnMessageBeep.UseVisualStyleBackColor = true;
            this.btnMessageBeep.Click += new System.EventHandler(this.btnMessageBeep_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 164);
            this.Controls.Add(this.btnMessageBeep);
            this.Controls.Add(this.btnSingleBeep);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStartBeeps);
            this.Name = "MainForm";
            this.Text = "Задание 3 - Звуковые сигналы";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

