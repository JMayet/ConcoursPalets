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
using Telerik.WinControls.UI;

namespace IHM.Views.UserControl
{
    public partial class HiddenGamesGrid : MyUserControl
    {
        public HiddenGamesGrid()
        {
            InitializeComponent();

            this.GamesGrid.DataSource = null;
            this.GamesGrid.DataSource = Competition.Current.CurrentRound.Games;
        }

        public RadGridView GetGrid()
        {
            return this.GamesGrid;
        }
    }
}
