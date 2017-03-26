using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SelfMailer.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CreateDefaultTab();
        }
       
        /// <summary>
        /// 
        /// </summary>
        public void CreateDefaultTab()
        {
            Controls.MailProperties MP = new Controls.MailProperties();
            MP.Name = "mailPropeties";
            MP.Dock = DockStyle.Fill;
            TabPage tp = new TabPage ("[aucune langue]");
            tp.Controls.Add(MP);
            TabControl tc = new TabControl();
            tc.TabPages.Add(tp);


            //MainMenuStrip.TabPages.Add(tp);           
           //MP.Controls.Add(tp);
           

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MailServeurMenu_Click(object sender, EventArgs e)
        {
            new MailServerSettings().Show();
        }
    }
}
