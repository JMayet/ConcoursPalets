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
    public partial class Terrains : MyUserControl
    {        
        private int gamesCount;

        #region Constructor
        public Terrains(int gamesCount)
        {
            InitializeComponent();            
            this.gamesCount = gamesCount;
        }
        
        #endregion
       
        private void load(object sender, PaintEventArgs e)
        {
            try
            {
                this.Visible = false;
                
                int tmp = gamesCount;
                int val = tmp % 4;
                if (val != 0)
                {
                    tmp += 4 - val;
                }

                tmp = tmp / 4;

                if (TLColumn1.Controls.Count == 0)
                {                   
                    for (int i = 0; i < tmp; i++)
                    {
                        RowStyle newRowStyle = new RowStyle();
                        newRowStyle.SizeType = SizeType.Percent;
                        newRowStyle.Height = 100 / tmp;
                        TLColumn1.RowStyles.Insert(i, newRowStyle);
                        Field T = new Field(i + 1 + 0 * tmp);
                        this.TLColumn1.Controls.Add(T, 0, i);
                    }
                }

                if (TLColumn2.Controls.Count == 0)
                {                    
                    for (int j = 0; j < tmp; j++)
                    {
                        RowStyle newRowStyle = new RowStyle();
                        newRowStyle.SizeType = SizeType.Percent;
                        newRowStyle.Height = 100 / tmp;
                        TLColumn2.RowStyles.Insert(j, newRowStyle);
                        Field T = new Field(j + 1 + 1 * tmp);
                        this.TLColumn2.Controls.Add(T, 0, j);
                    }
                }

                if (TLColumn3.Controls.Count == 0)
                {
                    for (int k = 0; k < tmp; k++)
                    {
                        RowStyle newRowStyle = new RowStyle();
                        newRowStyle.SizeType = SizeType.Percent;
                        newRowStyle.Height = 100 / tmp;
                        TLColumn3.RowStyles.Insert(k, newRowStyle);
                        Field T = new Field(k + 1 + 2 * tmp);
                        this.TLColumn3.Controls.Add(T, 0, k);
                    }
                }

                if (TLColumn4.Controls.Count == 0)
                {
                    for (int l = 0; l < tmp; l++)
                    {
                        RowStyle newRowStyle = new RowStyle();
                        newRowStyle.SizeType = SizeType.Percent;
                        newRowStyle.Height = 100 / tmp;
                        TLColumn4.RowStyles.Insert(l, newRowStyle);                        
                        Field T = new Field(l + 1 + 3 * tmp);
                        this.TLColumn4.Controls.Add(T, 0, l);
                    }
                }

                this.Visible = true;
            }
            catch(Exception ex)
            {                
                throw ex;
            }                       
        }

        public void StartGames()
        {
            foreach (Field field in GetFields())
           {
               field.UpdateView();
               field.Refresh();
               System.Threading.Thread.Sleep(500);
           }           
        }       

        private List<Field> GetFields()
        {
            List<Field> ret = new List<Field>();

            int tmp = gamesCount;
            int val = tmp % 4;
            if (val != 0)
            {
                tmp += 4 - val;
            }

            tmp = tmp / 4;

            for (int i = 1; i < gamesCount+1; i++)
            {
                if (i > 0 && i <= tmp)
                {
                    ret.Add((Field)TLColumn1.Controls[i - 1]);                    
                }
                else if (i > tmp && i <= (2 * tmp))
                {
                    ret.Add((Field)TLColumn2.Controls[i - 1 - tmp]);                    
                }
                else if (i > (2 * tmp) && i <= (3 * tmp))
                {
                    ret.Add((Field)TLColumn3.Controls[i - 1 - (2 * tmp)]);                   
                }
                else if (i > (3 * tmp) && i <= (4 * tmp))
                {
                    ret.Add((Field)TLColumn4.Controls[i - 1 - (3 * tmp)]);                    
                }                
            }
            return ret;
        }
    }
}
