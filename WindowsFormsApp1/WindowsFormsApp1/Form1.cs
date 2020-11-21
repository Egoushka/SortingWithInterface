using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
 
        private Thread progressThread = null;
        private string fname = null;
        object locker = new object();
        public Form1()
        {
            InitializeComponent();
            ViewController.SetForm(this);
        }
        private void SortType_CheckedChanged(object sender, EventArgs e)
        {
            Controller.st = (SortType)Enum.Parse(typeof(SortType), (sender as RadioButton).Name);
        }

        private void SortMethod_CheckedChanged(object sender, EventArgs e)
        {
            Controller.sm = (SortMethod)Enum.Parse(typeof(SortType), (sender as RadioButton).Name);

        }
        private void start_Click(object sender, EventArgs e)
        {
            //strs = System.IO.File.ReadAllLines(fname);

            progressThread = new Thread(
               Controller.Sort
            );
            progressThread?.Start();
        }   
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}