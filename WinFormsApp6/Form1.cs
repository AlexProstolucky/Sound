namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private Thread soundThread;
        private bool stopSound;
        private void PlaySound(int frequency, int time)
        {
            Console.Beep(frequency, time);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int frequency = 47;
            int time = 500;
            stopSound = false;
            soundThread = new Thread(() =>
            {
                for (int i = 1; i < 10; i++)
                {
                    if (stopSound == false)
                    {
                        PlaySound(frequency, time);
                    }
                    frequency += 2200;
                    time += 55;
                }
            });
            soundThread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopSound = true;
        }
    }
}