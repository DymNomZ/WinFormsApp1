using System;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer tmr;
        public static string GetRandomLineFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }

            int lineCount = File.ReadAllLines(filePath).Length;
            int randomLineNumber = new Random().Next(0, lineCount);
            System.Diagnostics.Debug.WriteLine(randomLineNumber);
            String lol = File.ReadLines(filePath).ElementAtOrDefault(randomLineNumber - 1); ;

            return lol;
        }

        public Form1()
        {
            InitializeComponent();
            string filePath = @"C:\Users\User\Desktop\C#\WinFormsApp1\READMe.txt";
            string randomLine = GetRandomLineFromFile(filePath);
            richTextBox1.Text = randomLine;
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate
            {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(10).TotalMilliseconds;
            tmr.Start();
        }
    }
}
