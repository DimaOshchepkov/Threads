using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex1
{/*
    class WriteThread : BackgroundWorker
    {
        Object lockObj { get; set; }
        String filePath { get; set; }
        bool isThread1Paused {  get; set; }

        public WriteThread(Object lockObj, String path)
        {
            this.lockObj = lockObj;
            this.DoWork += Write;
            this.filePath = path;
        }

        public void Write(object sender, DoWorkEventArgs e)
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
                        List<string> arrayFileContent;
                        using (StreamReader sr = File.OpenText(filePath))
                        {
                            arrayFileContent = sr.ReadToEnd().Split().ToList();
                        }

                        arrayFileContent.Add(i.ToString()); //добавление в массив
                        this.Invoke((MethodInvoker)(() => textBoxFileContent.Text = string.Join(" ", arrayFileContent)));
                    }
                }
                int sleepDuration = (int)this.trackBarThread1.Invoke((Func<int>)(() => this.trackBarThread1.Value));
                Thread.Sleep(sleepDuration);
            }
        }
    }*/
}
