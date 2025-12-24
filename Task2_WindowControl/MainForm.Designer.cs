namespace Task2_WindowControl
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtWindowTitle;
        private System.Windows.Forms.Button btnFindWindow;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtNewTitle;
        private System.Windows.Forms.Button btnChangeTitle;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnMinimizeWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

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
            this.txtWindowTitle = new System.Windows.Forms.TextBox();
            this.btnFindWindow = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNewTitle = new System.Windows.Forms.TextBox();
            this.btnChangeTitle = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWindowTitle
            // 
            this.txtWindowTitle.Location = new System.Drawing.Point(12, 35);
            this.txtWindowTitle.Name = "txtWindowTitle";
            this.txtWindowTitle.Size = new System.Drawing.Size(360, 23);
            this.txtWindowTitle.TabIndex = 0;
            this.txtWindowTitle.Text = "TargetWindowApp";
            // 
            // btnFindWindow
            // 
            this.btnFindWindow.Location = new System.Drawing.Point(12, 64);
            this.btnFindWindow.Name = "btnFindWindow";
            this.btnFindWindow.Size = new System.Drawing.Size(360, 30);
            this.btnFindWindow.TabIndex = 1;
            this.btnFindWindow.Text = "Найти окно";
            this.btnFindWindow.UseVisualStyleBackColor = true;
            this.btnFindWindow.Click += new System.EventHandler(this.btnFindWindow_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 97);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Окно не найдено";
            // 
            // txtNewTitle
            // 
            this.txtNewTitle.Location = new System.Drawing.Point(12, 145);
            this.txtNewTitle.Name = "txtNewTitle";
            this.txtNewTitle.Size = new System.Drawing.Size(360, 23);
            this.txtNewTitle.TabIndex = 3;
            this.txtNewTitle.Text = "Новый заголовок";
            // 
            // btnChangeTitle
            // 
            this.btnChangeTitle.Location = new System.Drawing.Point(12, 174);
            this.btnChangeTitle.Name = "btnChangeTitle";
            this.btnChangeTitle.Size = new System.Drawing.Size(360, 30);
            this.btnChangeTitle.TabIndex = 4;
            this.btnChangeTitle.Text = "Изменить заголовок окна";
            this.btnChangeTitle.UseVisualStyleBackColor = true;
            this.btnChangeTitle.Click += new System.EventHandler(this.btnChangeTitle_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(12, 210);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(360, 30);
            this.btnCloseWindow.TabIndex = 5;
            this.btnCloseWindow.Text = "Закрыть окно";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.Location = new System.Drawing.Point(12, 246);
            this.btnMinimizeWindow.Name = "btnMinimizeWindow";
            this.btnMinimizeWindow.Size = new System.Drawing.Size(360, 30);
            this.btnMinimizeWindow.TabIndex = 6;
            this.btnMinimizeWindow.Text = "Свернуть окно (мой вариант)";
            this.btnMinimizeWindow.UseVisualStyleBackColor = true;
            this.btnMinimizeWindow.Click += new System.EventHandler(this.btnMinimizeWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Заголовок окна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Новый заголовок:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimizeWindow);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnChangeTitle);
            this.Controls.Add(this.txtNewTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnFindWindow);
            this.Controls.Add(this.txtWindowTitle);
            this.Name = "MainForm";
            this.Text = "Задание 2 - Управление окнами";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

