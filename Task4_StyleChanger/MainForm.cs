using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Task4_StyleChanger
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, StringBuilder lParam);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern bool EnumChildWindows(IntPtr hWndParent, EnumChildProc lpEnumFunc, IntPtr lParam);

        public delegate bool EnumChildProc(IntPtr hWnd, IntPtr lParam);

        // Константы для сообщений Windows
        private const uint WM_SETTEXT = 0x000C;
        private const uint WM_SETFONT = 0x0030;
        private const uint WM_SETFOCUS = 0x0007;
        private const uint WM_ENABLE = 0x000A;
        private const uint EM_SETREADONLY = 0x00CF;
        private const uint BM_SETSTYLE = 0x00F4;
        private const uint BS_PUSHBUTTON = 0x0000;
        private const uint BS_DEFPUSHBUTTON = 0x0001;
        private const uint BS_FLAT = 0x8000;

        private IntPtr targetWindowHandle = IntPtr.Zero;
        private System.Collections.Generic.List<IntPtr> childControls = new System.Collections.Generic.List<IntPtr>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFindTargetApp_Click(object sender, EventArgs e)
        {
            string windowTitle = "TargetApp - Приложение с элементами управления";
            targetWindowHandle = FindWindow(null, windowTitle);

            if (targetWindowHandle != IntPtr.Zero)
            {
                lblStatus.Text = $"Окно найдено! Handle: {targetWindowHandle}";
                lblStatus.ForeColor = Color.Green;
                EnumerateChildControls();
                UpdateControlList();
            }
            else
            {
                lblStatus.Text = "Окно не найдено! Запустите TargetApp сначала.";
                lblStatus.ForeColor = Color.Red;
                childControls.Clear();
                UpdateControlList();
            }
        }

        private void EnumerateChildControls()
        {
            childControls.Clear();
            EnumChildWindows(targetWindowHandle, EnumChildWindowCallback, IntPtr.Zero);
        }

        private bool EnumChildWindowCallback(IntPtr hWnd, IntPtr lParam)
        {
            StringBuilder className = new StringBuilder(256);
            GetClassName(hWnd, className, className.Capacity);
            childControls.Add(hWnd);
            return true;
        }

        private void UpdateControlList()
        {
            listBoxControls.Items.Clear();
            foreach (var handle in childControls)
            {
                StringBuilder text = new StringBuilder(256);
                GetWindowText(handle, text, text.Capacity);
                StringBuilder className = new StringBuilder(256);
                GetClassName(handle, className, className.Capacity);
                listBoxControls.Items.Add($"{className} - {text}");
            }
        }

        private void btnChangeTextBoxStyle_Click(object sender, EventArgs e)
        {
            if (targetWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Сначала найдите окно TargetApp!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Находим TextBox
            IntPtr textBoxHandle = FindWindowEx(targetWindowHandle, IntPtr.Zero, "Edit", null);
            if (textBoxHandle != IntPtr.Zero)
            {
                // Изменяем текст
                StringBuilder newText = new StringBuilder("Измененный текст!");
                SendMessage(textBoxHandle, WM_SETTEXT, IntPtr.Zero, newText);
                
                // Делаем поле только для чтения
                SendMessage(textBoxHandle, EM_SETREADONLY, new IntPtr(1), IntPtr.Zero);
                
                MessageBox.Show("Стиль TextBox изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChangeButtonStyle_Click(object sender, EventArgs e)
        {
            if (targetWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Сначала найдите окно TargetApp!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Находим Button
            IntPtr buttonHandle = FindWindowEx(targetWindowHandle, IntPtr.Zero, "Button", null);
            if (buttonHandle != IntPtr.Zero)
            {
                // Изменяем текст кнопки
                StringBuilder newText = new StringBuilder("Измененная кнопка!");
                SendMessage(buttonHandle, WM_SETTEXT, IntPtr.Zero, newText);
                
                // Изменяем стиль кнопки на плоский
                SendMessage(buttonHandle, BM_SETSTYLE, new IntPtr(BS_FLAT), new IntPtr(1));
                
                MessageBox.Show("Стиль Button изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChangeLabelStyle_Click(object sender, EventArgs e)
        {
            if (targetWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Сначала найдите окно TargetApp!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Находим Label (Static)
            IntPtr labelHandle = FindWindowEx(targetWindowHandle, IntPtr.Zero, "Static", null);
            if (labelHandle != IntPtr.Zero)
            {
                // Изменяем текст метки
                StringBuilder newText = new StringBuilder("Измененная метка!");
                SendMessage(labelHandle, WM_SETTEXT, IntPtr.Zero, newText);
                
                MessageBox.Show("Стиль Label изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDisableControls_Click(object sender, EventArgs e)
        {
            if (targetWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Сначала найдите окно TargetApp!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Отключаем все дочерние элементы управления
            foreach (var handle in childControls)
            {
                SendMessage(handle, WM_ENABLE, new IntPtr(0), IntPtr.Zero);
            }
            
            MessageBox.Show("Все элементы управления отключены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEnableControls_Click(object sender, EventArgs e)
        {
            if (targetWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Сначала найдите окно TargetApp!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Включаем все дочерние элементы управления
            foreach (var handle in childControls)
            {
                SendMessage(handle, WM_ENABLE, new IntPtr(1), IntPtr.Zero);
            }
            
            MessageBox.Show("Все элементы управления включены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChangeComboBoxStyle_Click(object sender, EventArgs e)
        {
            if (targetWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Сначала найдите окно TargetApp!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Находим ComboBox
            IntPtr comboBoxHandle = FindWindowEx(targetWindowHandle, IntPtr.Zero, "ComboBox", null);
            if (comboBoxHandle != IntPtr.Zero)
            {
                // Отключаем ComboBox
                SendMessage(comboBoxHandle, WM_ENABLE, new IntPtr(0), IntPtr.Zero);
                
                MessageBox.Show("Стиль ComboBox изменен (отключен)!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

