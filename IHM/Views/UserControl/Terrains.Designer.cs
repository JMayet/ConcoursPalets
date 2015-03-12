namespace IHM.Pages
{
    partial class Terrains
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLTerrains = new System.Windows.Forms.TableLayoutPanel();
            this.TLColumn3 = new System.Windows.Forms.TableLayoutPanel();
            this.TLColumn4 = new System.Windows.Forms.TableLayoutPanel();
            this.TLColumn1 = new System.Windows.Forms.TableLayoutPanel();
            this.TLColumn2 = new System.Windows.Forms.TableLayoutPanel();
            this.TLTerrains.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLTerrains
            // 
            this.TLTerrains.ColumnCount = 4;
            this.TLTerrains.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLTerrains.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLTerrains.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLTerrains.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLTerrains.Controls.Add(this.TLColumn3, 2, 0);
            this.TLTerrains.Controls.Add(this.TLColumn4, 3, 0);
            this.TLTerrains.Controls.Add(this.TLColumn1, 0, 0);
            this.TLTerrains.Controls.Add(this.TLColumn2, 1, 0);
            this.TLTerrains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLTerrains.Location = new System.Drawing.Point(0, 0);
            this.TLTerrains.Name = "TLTerrains";
            this.TLTerrains.RowCount = 1;
            this.TLTerrains.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLTerrains.Size = new System.Drawing.Size(665, 493);
            this.TLTerrains.TabIndex = 0;
            // 
            // TLColumn3
            // 
            this.TLColumn3.ColumnCount = 1;
            this.TLColumn3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLColumn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLColumn3.Location = new System.Drawing.Point(335, 3);
            this.TLColumn3.Name = "TLColumn3";
            this.TLColumn3.RowCount = 1;
            this.TLColumn3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLColumn3.Size = new System.Drawing.Size(160, 487);
            this.TLColumn3.TabIndex = 2;
            // 
            // TLColumn4
            // 
            this.TLColumn4.ColumnCount = 1;
            this.TLColumn4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLColumn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLColumn4.Location = new System.Drawing.Point(501, 3);
            this.TLColumn4.Name = "TLColumn4";
            this.TLColumn4.RowCount = 1;
            this.TLColumn4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLColumn4.Size = new System.Drawing.Size(161, 487);
            this.TLColumn4.TabIndex = 3;
            // 
            // TLColumn1
            // 
            this.TLColumn1.ColumnCount = 1;
            this.TLColumn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLColumn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLColumn1.Location = new System.Drawing.Point(3, 3);
            this.TLColumn1.Name = "TLColumn1";
            this.TLColumn1.RowCount = 1;
            this.TLColumn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLColumn1.Size = new System.Drawing.Size(160, 487);
            this.TLColumn1.TabIndex = 0;
            // 
            // TLColumn2
            // 
            this.TLColumn2.ColumnCount = 1;
            this.TLColumn2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLColumn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLColumn2.Location = new System.Drawing.Point(169, 3);
            this.TLColumn2.Name = "TLColumn2";
            this.TLColumn2.RowCount = 1;
            this.TLColumn2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLColumn2.Size = new System.Drawing.Size(160, 487);
            this.TLColumn2.TabIndex = 1;
            // 
            // Terrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLTerrains);
            this.Name = "Terrains";
            this.Size = new System.Drawing.Size(665, 493);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.load);
            this.TLTerrains.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLTerrains;
        private System.Windows.Forms.TableLayoutPanel TLColumn3;
        private System.Windows.Forms.TableLayoutPanel TLColumn4;
        private System.Windows.Forms.TableLayoutPanel TLColumn1;
        private System.Windows.Forms.TableLayoutPanel TLColumn2;

    }
}
