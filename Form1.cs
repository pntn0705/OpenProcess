using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using KAutoHelper;




namespace AutoControllApplicationPC
{
    public partial class Form1 : Form
    {
        Process FO4 = new Process();
        Process VS = new Process();
        Process garena = new Process();
        Process cmd = new Process();
        Process pts = new Process();
        Process Word = new Process();
        Process PP = new Process();
        Process DevC = new Process();
        Process fifa = new Process();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGarena_Click(object sender, EventArgs e)
        {
            
            garena.StartInfo.FileName = "E:\\DesktopFile\\Garena";
            garena.Start();
            Application.Exit();
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            string cmdcommand = "ping regis.agu.edu.vn";
            
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd";
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;

            cmd.StartInfo = startInfo;
            cmd.Start();

            cmd.StandardInput.WriteLine(cmdcommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            string OutPut = cmd.StandardOutput.ReadToEnd();
            MessageBox.Show(OutPut);
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;

            EMouseKey mousekey = new EMouseKey();

            if (cbRightMouse.Checked)
            {
                if (cbDoubleClick.Checked)               
                    mousekey = EMouseKey.DOUBLE_RIGHT;                
                else
                    mousekey = EMouseKey.RIGHT;
            }
            else
            {
                if (cbDoubleClick.Checked)
                    mousekey = EMouseKey.DOUBLE_LEFT;
                else
                    mousekey = EMouseKey.LEFT;
            }

            //Cursor.Position = new Point(x, y);
            AutoControl.MouseClick(x, y,mousekey);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(tbClickApp.Text, null);
            
            var pointToClick = AutoControl.GetGlobalPoint(hWnd, x, y);



            EMouseKey mousekey = EMouseKey.LEFT;

            if (cbRightMouse.Checked)
            {
                if (cbDoubleClick.Checked)
                    mousekey = EMouseKey.DOUBLE_RIGHT;
                else
                    mousekey = EMouseKey.RIGHT;
            }
            else
            {
                if (cbDoubleClick.Checked)
                    mousekey = EMouseKey.DOUBLE_LEFT;
            }


            AutoControl.BringToFront(hWnd);
            //Cursor.Position = new Point(x, y);
            AutoControl.MouseClick(pointToClick, mousekey);
        }

        private void btnPts_Click(object sender, EventArgs e)
        {
            
            pts.StartInfo.FileName = "E:\\FileDesktop\\pts";
            pts.Start();
            Application.Exit();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            
            Word.StartInfo.FileName = "E:\\FileDesktop\\Word";
            Word.Start();
            Application.Exit();
        }

        private void btnPP_Click(object sender, EventArgs e)
        {
            
            PP.StartInfo.FileName = "E:\\FileDesktop\\PowerPoint";
            PP.Start();
            Application.Exit();
        }

        private void btnDevC_Click(object sender, EventArgs e)
        {
            
            DevC.StartInfo.FileName = "E:\\FileDesktop\\DevC";
            DevC.Start();
            Application.Exit();
        }

        private void btnVS_Click(object sender, EventArgs e)
        {
            
            VS.StartInfo.FileName = "E:\\FileDesktop\\VisualStudio";
            VS.Start();
            Application.Exit();
        }

       

        private void btnFo4_Click_1(object sender, EventArgs e)
        {
            FO4.StartInfo.FileName = "E:\\FileDesktop\\FOT4";
            FO4.Start();
            FO4.StartInfo.FileName = "E:\\FileDesktop\\Garena";
            FO4.Start();
            FO4.WaitForInputIdle();

            
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(tbClickApp.Text, null);

            var pointToClick = AutoControl.GetGlobalPoint(hWnd, 600, 430);



            EMouseKey mousekey = EMouseKey.LEFT;

            if (cbRightMouse.Checked)
            {
                if (cbDoubleClick.Checked)
                    mousekey = EMouseKey.DOUBLE_RIGHT;
                else
                    mousekey = EMouseKey.RIGHT;
            }
            else
            {
                if (cbDoubleClick.Checked)
                    mousekey = EMouseKey.DOUBLE_LEFT;
            }


            AutoControl.BringToFront(hWnd);
            //Cursor.Position = new Point(x, y);
            AutoControl.MouseClick(pointToClick, mousekey);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FO4.Kill();
            Application.Exit();
        }
    }
}
