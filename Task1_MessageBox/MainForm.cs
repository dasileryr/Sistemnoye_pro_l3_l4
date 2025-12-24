using System;
using System.Windows.Forms;

namespace Task1_MessageBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Отображаем информацию о пользователе в нескольких MessageBox
            ShowUserInfo();
        }

        private void ShowUserInfo()
        {
            // Первое сообщение - имя и фамилия
            Program.MessageBox(
                IntPtr.Zero,
                "Имя: Иван\nФамилия: Иванов",
                "Информация о пользователе - Часть 1",
                0x00000040 // MB_ICONINFORMATION
            );

            // Второе сообщение - возраст и город
            Program.MessageBox(
                IntPtr.Zero,
                "Возраст: 20 лет\nГород: Москва",
                "Информация о пользователе - Часть 2",
                0x00000040
            );

            // Третье сообщение - учебное заведение
            Program.MessageBox(
                IntPtr.Zero,
                "Учебное заведение: Колледж\nСпециальность: Программирование",
                "Информация о пользователе - Часть 3",
                0x00000040
            );

            // Четвертое сообщение - хобби
            Program.MessageBox(
                IntPtr.Zero,
                "Хобби: Программирование, чтение книг\nЛюбимый язык программирования: C#",
                "Информация о пользователе - Часть 4",
                0x00000040
            );
        }
    }
}

