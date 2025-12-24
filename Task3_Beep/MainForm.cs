using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_Beep
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(uint dwFreq, uint dwDuration);

        [DllImport("user32.dll")]
        public static extern bool MessageBeep(uint uType);

        // Константы для MessageBeep
        private const uint MB_OK = 0x00000000;
        private const uint MB_ICONHAND = 0x00000010;
        private const uint MB_ICONQUESTION = 0x00000020;
        private const uint MB_ICONEXCLAMATION = 0x00000030;
        private const uint MB_ICONASTERISK = 0x00000040;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnStartBeeps_Click(object sender, EventArgs e)
        {
            btnStartBeeps.Enabled = false;
            lblStatus.Text = "Генерация звуковых сигналов...";

            await Task.Run(() => GenerateBeepSequence());

            btnStartBeeps.Enabled = true;
            lblStatus.Text = "Готово!";
        }

        private void GenerateBeepSequence()
        {
            // Последовательность звуковых сигналов через определенные промежутки времени
            int delay = 1000; // 1 секунда между сигналами

            // 1. Beep - низкая частота
            Beep(200, 500);
            Thread.Sleep(delay);

            // 2. Beep - средняя частота
            Beep(500, 500);
            Thread.Sleep(delay);

            // 3. Beep - высокая частота
            Beep(1000, 500);
            Thread.Sleep(delay);

            // 4. MessageBeep - стандартный звук
            MessageBeep(MB_OK);
            Thread.Sleep(delay);

            // 5. Beep - мелодия (три ноты)
            Beep(523, 300); // До
            Thread.Sleep(100);
            Beep(659, 300); // Ми
            Thread.Sleep(100);
            Beep(784, 300); // Соль
            Thread.Sleep(delay);

            // 6. MessageBeep - звук ошибки
            MessageBeep(MB_ICONHAND);
            Thread.Sleep(delay);

            // 7. Beep - восходящая последовательность
            for (int i = 200; i <= 800; i += 100)
            {
                Beep((uint)i, 200);
                Thread.Sleep(100);
            }
            Thread.Sleep(delay);

            // 8. MessageBeep - звук вопроса
            MessageBeep(MB_ICONQUESTION);
            Thread.Sleep(delay);

            // 9. MessageBeep - звук предупреждения
            MessageBeep(MB_ICONEXCLAMATION);
            Thread.Sleep(delay);

            // 10. MessageBeep - звук информации
            MessageBeep(MB_ICONASTERISK);
            Thread.Sleep(delay);

            // 11. Beep - финальная последовательность
            Beep(400, 200);
            Thread.Sleep(100);
            Beep(600, 200);
            Thread.Sleep(100);
            Beep(800, 400);
        }

        private void btnSingleBeep_Click(object sender, EventArgs e)
        {
            Beep(800, 500);
        }

        private void btnMessageBeep_Click(object sender, EventArgs e)
        {
            MessageBeep(MB_OK);
        }
    }
}

