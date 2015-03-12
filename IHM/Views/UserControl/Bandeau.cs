using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using BLL;

namespace IHM.Pages
{
    public partial class Bandeau : MyUserControl
    {
        delegate void UpdateTimeCallback();

        public Bandeau()
        {
            InitializeComponent();
        }
        
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                UpdateTime();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UpdateTime()
        {
            try
            {
                if (this.LabelTime.InvokeRequired)
                {
                    UpdateTimeCallback ATC = UpdateLabelTime;
                    this.Invoke(ATC);
                }
                else UpdateLabelTime();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UpdateLabelTime()
        {
            try
            {
                this.LabelTime.Text = DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Bandeau_Load(object sender, EventArgs e)
        {
            UpdateTime();

            System.Timers.Timer T = new System.Timers.Timer(1000);
            T.Elapsed += OnTimerElapsed;
            T.Start();           
        }
    }
}
