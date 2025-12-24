using System;
using System.Windows.Forms;

namespace Task4_TargetApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка была нажата!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

