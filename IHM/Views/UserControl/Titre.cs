using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace IHM.Pages
{
    public partial class Title : MyUserControl
    {        
        public Title()
        {
            InitializeComponent();
        }

        public void SetTitle(string Title)
        {
            this.label1.Text = Title;
        }
    }
}
