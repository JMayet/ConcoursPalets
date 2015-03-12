using IHM.Pages;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace IHM.Form
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {  
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateView(new StartView());                      
        }

        public void UpdateView(UserControl Control)
        {
            this.Panel.Controls.Clear();
            this.Panel.Controls.Add(Control);
            this.Panel.Controls[0].Dock = DockStyle.Fill;  
        }
    }
}
