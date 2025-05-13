using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace gerenciadordeappemexe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            var process = Process.GetProcesses();

            foreach (var processos in process)
            {
                try
                {
                    var starttime = processos.StartTime;
                    cuiListbox1.Items.Add($"{processos.ProcessName} - {starttime}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cuiListbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
