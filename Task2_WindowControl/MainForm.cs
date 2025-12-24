using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Task2_WindowControl
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, StringBuilder lParam);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        // Константы для сообщений Windows
        private const uint WM_SETTEXT = 0x000C;
        private const uint WM_CLOSE = 0x0010;
        private const uint WM_SETFONT = 0x0030;
        private const uint WM_COMMAND = 0x0111;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFindWindow_Click(object sender, EventArgs e)
        {
            string windowTitle = txtWindowTitle.Text;
            if (string.IsNullOrEmpty(windowTitle))
            {
                MessageBox.Show("Введите заголовок окна для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IntPtr hWnd = FindWindow(null, windowTitle);
            if (hWnd != IntPtr.Zero)
            {
                lblStatus.Text = $"Окно найдено! Handle: {hWnd}";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                currentWindowHandle = hWnd;
            }
            else
            {
                lblStatus.Text = "Окно не найдено!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                currentWindowHandle = IntPtr.Zero;
            }
        }

        private IntPtr currentWindowHandle = IntPtr.Zero;

        private void btnChangeTitle_Click(object sender, EventArgs e)
        {
            if (currentWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Сначала найдите окно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newTitle = txtNewTitle.Text;
            if (string.IsNullOrEmpty(newTitle))
            {
                MessageBox.Show("Введите новый заголовок!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder sb = new StringBuilder(newTitle);
            SendMessage(currentWindowHandle, WM_SETTEXT, IntPtr.Zero, sb);
            MessageBox.Show($"Заголовок окна изменен на: {newTitle}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            if (currentWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Сначала найдите окно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите закрыть найденное окно?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                PostMessage(currentWindowHandle, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                MessageBox.Show("Сообщение о закрытии отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentWindowHandle = IntPtr.Zero;
                lblStatus.Text = "Окно закрыто";
            }
        }

        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            if (currentWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Сначала найдите окно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const uint WM_SYSCOMMAND = 0x0112;
            const uint SC_MINIMIZE = 0xF020;
            SendMessage(currentWindowHandle, WM_SYSCOMMAND, new IntPtr(SC_MINIMIZE), IntPtr.Zero);
            MessageBox.Show("Окно минимизировано!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

