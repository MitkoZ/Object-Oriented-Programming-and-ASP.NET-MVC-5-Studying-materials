using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
            backgroundWorker1.ReportProgress(10);
            Thread.Sleep(2000);
            backgroundWorker1.ReportProgress(20);
            Thread.Sleep(2000);
            backgroundWorker1.ReportProgress(30);
            Thread.Sleep(2000);
            backgroundWorker1.ReportProgress(40);
            Thread.Sleep(2000);
            backgroundWorker1.ReportProgress(50);
            Thread.Sleep(4000);
            backgroundWorker1.ReportProgress(100);
            e.Result = "This is the result of all our hard work!";
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());
        }
    }
}
