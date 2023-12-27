using static System.Windows.Forms.LinkLabel;

namespace Ex1
{
    //сделать управление идет конкретно потоками
    //получаетс€ один записывает другой провер€ет текущий
    public partial class MainForm : Form
    {
        private string filePath = "numbers.txt";
        private object lockObj = new object();
        private bool isThread1Paused = false;
        private bool isThread2Paused = false;
        public List<int> arrayFileContent = new List<int>();
        Thread thread1;
        Thread thread2;
        bool isStartClicked = false;

        public MainForm()
        {
            InitializeComponent();
            thread1 = new Thread(Thread1Method);
            thread2 = new Thread(Thread2Method);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, string.Empty);
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (isStartClicked) {
                ResumeThreads();
                return; 
            }
            isStartClicked = true;
            thread1.Start();
            thread2.Start();
        }

        private void buttonPauseThread1_Click(object sender, EventArgs e)
        {
            isThread1Paused = !isThread1Paused;
        }

        private void buttonPauseThread2_Click(object sender, EventArgs e)
        {
            isThread2Paused = !isThread2Paused;
        }

        private void Thread1Method()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                lock (lockObj) 
                { 
                    if (!isThread1Paused)
                    {
                        using (StreamWriter sw = File.AppendText(filePath)) //запись в файл
                        {
                            sw.Write(i + " ");
                        }

                        arrayFileContent.Add(i); //добавление в массив
                        this.Invoke((MethodInvoker)(() => textBoxFileContent.Text = string.Join(" ", arrayFileContent)));
                    }
            }
                int sleepDuration = (int)this.trackBarThread1.Invoke((Func<int>)(() => this.trackBarThread1.Value));
                Thread.Sleep(sleepDuration);
            }
        }

        private void Thread2Method() //изменить на получение только последнего элемента и его изменение, все
        {
            int i = 0;
            while (true)
            {
                lock (lockObj)
                {

                    if (!isThread2Paused)
                    {
                        var file = new StreamReader(filePath);
                        string[] lines = file.ReadLine().Split(' ');
                        int number = 4;
                        try
                        {

                            number = int.Parse(lines[i]);
                            if (number % 4 != 0 && number % 3 != 0)
                            {
                                lines[i] = "0";
                                arrayFileContent[i] = 0;
                            }
                            i++;
                        }
                        catch { }
                        file.Close();

                        // ѕерезаписываем файл с новыми строками
                        File.WriteAllText(filePath, string.Join(" ", lines));
                        this.Invoke((MethodInvoker)(() => textBoxFileContent.Text = string.Join(" ", arrayFileContent)));
                    }

                }
                int sleepDuration = (int)this.trackBarThread2.Invoke((Func<int>)(() => this.trackBarThread2.Value));
                Thread.Sleep(sleepDuration);

            }
        }

        private void textBoxFileContent_TextChanged(object sender, EventArgs e)
        {
            // ѕолучить текст из файла
            string[] lines = File.ReadAllLines(filePath);

            // ќбновить текст в textBox
            textBoxFileContent.Text = string.Join(" ", lines);
        }
        public void StopThreads()
        {
            isThread1Paused = true;
            isThread2Paused = true;
        }

        public void ResumeThreads()
        {
            isThread1Paused = false;
            isThread2Paused = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopThreads();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            ResumeThreads();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopThreads();
        }
    }
}