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
using Telerik.Charting;

namespace IHM.Pages
{
    public partial class RankingView : MyUserControl
    {
        Competition _competitionToDisplay;

        public RankingView(Competition competitionToDisplay)
        {
            InitializeComponent();
            this.label2.Text = "(concours du " + competitionToDisplay.StartDate.ToShortDateString() + ")";
            _competitionToDisplay = competitionToDisplay;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            NavigateToStartView();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintRanking();
        }

        private void DetailBtn_Click(object sender, EventArgs e)
        {
            PreviousCompetitionMessageBox messageBox = new PreviousCompetitionMessageBox(Competition.GetPreviousCompetitionsNames());
            messageBox.ShowDialog();
            string previousCompetition = messageBox.GetPreviousCompetition();
            if(previousCompetition != null)
            {
                NavigateToRankingView(Competition.GetCompletedCompetitionByName(previousCompetition));                
            }            
        }

        private void Classement_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            UpdateCurrentTeam();
            InitGraphClassement();
            //UpdateRankingGraph();
        }

        private void RefreshGrid()
        {
            RankingGrid.DataSource = null;
            Dictionary<int, string> ranking = _competitionToDisplay.Rankings.Last();
            foreach (Team team in _competitionToDisplay.Teams)
            {
                team.Rank = ranking.First(t => t.Value == team.Name).Key;
            }
            RankingGrid.DataSource = _competitionToDisplay.Teams;
        }

        private void UpdateLabels(Team E)
        {
            if (E != null)
            {
                this.LabelEquipe.Text = E.Name + " : " + E.TeamMember1 + " / " + E.TeamMember2;
            }
            else
            {
                this.LabelEquipe.Text = "";
            }
        }

        private void UpdateGamesGrid(string team)
        {
            List<Game> games = _competitionToDisplay.GetGames(team);
            int gamesCount = _competitionToDisplay.Rounds.Count;
            GamesGrid.Rows.Clear();

            for (int i = 0; i < gamesCount; i++)
            {
                GamesGrid.Rows.AddNew();
                GamesGrid.Rows[i].Cells["Match"].Value = "Match " + (i + 1).ToString();

                if (games != null && i < games.Count)
                {
                    if (games[i].Team1 == team)
                    {
                        GamesGrid.Rows[i].Cells["Adversaire"].Value = games[i].Team2;
                        GamesGrid.Rows[i].Cells["PointsMarque"].Value = games[i].Scores[0];
                        GamesGrid.Rows[i].Cells["PointsEncaisse"].Value = games[i].Scores[1];
                    }
                    else if (games[i].Team2 == team)
                    {
                        GamesGrid.Rows[i].Cells["Adversaire"].Value = games[i].Team1;
                        GamesGrid.Rows[i].Cells["PointsMarque"].Value = games[i].Scores[1];
                        GamesGrid.Rows[i].Cells["PointsEncaisse"].Value = games[i].Scores[0];
                    }
                }
            }

            GamesGrid.AutoSizeRows = true;
        }

        private void InitGraphClassement()
        {
            this.RankingGraph.View.Margin = new Padding(10, 10, 20, 10);
            LinearAxis verticalAxis = this.RankingGraph.Axes.Get<LinearAxis>(1);
            verticalAxis.Maximum = _competitionToDisplay.Teams.Count + 1;
            verticalAxis.Minimum = 1;
            verticalAxis.HorizontalLocation = AxisHorizontalLocation.Left;
            verticalAxis.LabelInterval = 1;
            verticalAxis.LastLabelVisibility = AxisLastLabelVisibility.Visible;
            verticalAxis.LabelFormatProvider = new MyFormatProvider(_competitionToDisplay.Teams.Count);
            verticalAxis.ShowLabels = true;
        }

        private void UpdateRankingGraph(Dictionary<int, int> Evolution)
        {
            LineSeries Serie = new LineSeries();

            foreach (KeyValuePair<int, int> pair in Evolution)
            {
                Serie.DataPoints.Add(new CategoricalDataPoint(_competitionToDisplay.Teams.Count - pair.Value + 1, pair.Key));
            }

            this.RankingGraph.Series.Clear();
            this.RankingGraph.Series.Add(Serie);
        }

        private void UpdateCurrentTeam()
        {
            if (RankingGrid.SelectedRows.Count == 1)
            {
                string team = RankingGrid.SelectedRows[0].Cells["NomEquipe"].Value.ToString();
                Team E = _competitionToDisplay.GetTeam(team);

                UpdateLabels(E);
                UpdateGamesGrid(E.Name);
                UpdateRankingGraph(_competitionToDisplay.GetRankingEvolution(E.Name));
            }
            else
            {
                UpdateLabels(null);
                UpdateGamesGrid(null);
            }
        }

        private void RankingGrid_Click(object sender, EventArgs e)
        {
            UpdateCurrentTeam();
        }

        private void PrintRanking()
        {
            RadPrintDocument printer = new RadPrintDocument();
            printer.DefaultPageSettings.Landscape = false;
            printer.DefaultPageSettings.PrinterSettings.Copies = 1;
            printer.Margins.Top = 40;
            printer.HeaderFont = new Font("Arial", 20);
            printer.FooterHeight = 0;
            printer.MiddleHeader = "Classement du concours";
            printer.AssociatedObject = RankingGrid;

            RadPrintPreviewDialog printDialog = new RadPrintPreviewDialog(printer);
            printDialog.ThemeName = "Office2010Silver";
            printDialog.ShowDialog();
        }
    }

    public class MyFormatProvider : IFormatProvider, ICustomFormatter
    {
        private int _teamCount;
        public MyFormatProvider(int teamCount)
        {
            this._teamCount = teamCount;
        }

        public object GetFormat(Type formatType)
        {
            return this;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {            
            try
            {
                int rank = int.Parse(arg.ToString(), System.Globalization.NumberStyles.Integer);
                return (_teamCount - rank + 2) <= _teamCount ? (_teamCount - rank + 2).ToString() : _teamCount.ToString();
            }
            catch(Exception)
            {
                return arg.ToString();
            }            
        }
    }

}






