using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process ResetCorel = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo ResetCorelInfo = new System.Diagnostics.ProcessStartInfo();

            ResetCorelInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            ResetCorelInfo.FileName = "REG.exe";
            ResetCorelInfo.Arguments = "DELETE HKCU\\Software\\Corel /f";

            ResetCorel.StartInfo = ResetCorelInfo;
            ResetCorel.Start();

            DialogResult StartCorel = MessageBox.Show("Deseja iniciar o CorelDRAW?", "Reset concluído", MessageBoxButtons.YesNo);

            if (StartCorel == DialogResult.Yes)
            {
                System.Diagnostics.Process CorelDRW = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo CorelDRWInfo = new System.Diagnostics.ProcessStartInfo();

                CorelDRWInfo.FileName = "CorelDRW";

                CorelDRW.StartInfo = CorelDRWInfo;
                CorelDRW.Start();
                Application.Exit();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process CorelDRW = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo CorelDRWInfo = new System.Diagnostics.ProcessStartInfo();

            CorelDRWInfo.FileName = "CorelDRW";

            CorelDRW.StartInfo = CorelDRWInfo;
            CorelDRW.Start();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://flaviomoreira.16mb.com");
        }

    }
}
