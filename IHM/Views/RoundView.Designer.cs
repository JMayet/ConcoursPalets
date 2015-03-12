namespace IHM.Pages
{
    partial class RoundView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Fiels = new IHM.Pages.Terrains(BLL.Competition.Current.PlayersCount / 4);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.HomeBtn = new Telerik.WinControls.UI.RadButton();
            this.PrintBtn = new Telerik.WinControls.UI.RadButton();
            this.TirrageBtn = new Telerik.WinControls.UI.RadButton();
            this.NextBtn = new Telerik.WinControls.UI.RadButton();
            this.Title = new IHM.Pages.Title();
            this.bandeau1 = new IHM.Pages.Bandeau();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TirrageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.Fiels, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bandeau1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 504);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // terrains1
            // 
            this.Fiels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fiels.Location = new System.Drawing.Point(16, 78);
            this.Fiels.Name = "terrains1";
            this.Fiels.Size = new System.Drawing.Size(665, 397);
            this.Fiels.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(665, 69);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.HomeBtn, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.PrintBtn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TirrageBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.NextBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(501, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(161, 63);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeBtn.Image = global::IHM.Properties.Resources.Home;
            this.HomeBtn.Location = new System.Drawing.Point(90, 41);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(10);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(61, 12);
            this.HomeBtn.TabIndex = 8;
            this.HomeBtn.Text = "ACCUEIL";
            this.HomeBtn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.ThemeName = "Office2010Black";
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.HomeBtn.GetChildAt(0))).Image = global::IHM.Properties.Resources.Home;
            ((Telerik.WinControls.UI.RadButtonElement)(this.HomeBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.HomeBtn.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.HomeBtn.GetChildAt(0))).Text = "ACCUEIL";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.HomeBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(20, 20);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.HomeBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.HomeBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.HomeBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.HomeBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintBtn.Image = global::IHM.Properties.Resources.Printer_print_3d_vector_symbol_simple_pictogram;
            this.PrintBtn.Location = new System.Drawing.Point(10, 41);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(10);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(60, 12);
            this.PrintBtn.TabIndex = 5;
            this.PrintBtn.Text = "IMPRIMER";
            this.PrintBtn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintBtn.ThemeName = "Office2010Black";
            this.PrintBtn.Click += new System.EventHandler(PrintBtn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.PrintBtn.GetChildAt(0))).Image = global::IHM.Properties.Resources.Printer_print_3d_vector_symbol_simple_pictogram;
            ((Telerik.WinControls.UI.RadButtonElement)(this.PrintBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.PrintBtn.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.PrintBtn.GetChildAt(0))).Text = "IMPRIMER";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.PrintBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(20, 20);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.PrintBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.PrintBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.PrintBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.PrintBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TirrageBtn
            // 
            this.TirrageBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TirrageBtn.Image = global::IHM.Properties.Resources.Start;
            this.TirrageBtn.Location = new System.Drawing.Point(10, 10);
            this.TirrageBtn.Margin = new System.Windows.Forms.Padding(10);
            this.TirrageBtn.Name = "TirrageBtn";
            this.TirrageBtn.Size = new System.Drawing.Size(60, 11);
            this.TirrageBtn.TabIndex = 1;
            this.TirrageBtn.Text = "DEMARRER";
            this.TirrageBtn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TirrageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TirrageBtn.ThemeName = "Office2010Black";
            this.TirrageBtn.Click += new System.EventHandler(this.DrawingBtn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.TirrageBtn.GetChildAt(0))).Image = global::IHM.Properties.Resources.Start;
            ((Telerik.WinControls.UI.RadButtonElement)(this.TirrageBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.TirrageBtn.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.TirrageBtn.GetChildAt(0))).Text = "DEMARRER";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(20, 20);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.TirrageBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NextBtn
            // 
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextBtn.Image = global::IHM.Properties.Resources.Next;
            this.NextBtn.Location = new System.Drawing.Point(90, 10);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(10);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // 
            // 
            this.NextBtn.RootElement.AutoSize = false;
            this.NextBtn.Size = new System.Drawing.Size(61, 11);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "SUIVANT";
            this.NextBtn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NextBtn.ThemeName = "Office2010Black";
            ((Telerik.WinControls.UI.RadButtonElement)(this.NextBtn.GetChildAt(0))).Image = global::IHM.Properties.Resources.Next;
            ((Telerik.WinControls.UI.RadButtonElement)(this.NextBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.NextBtn.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.NextBtn.GetChildAt(0))).Text = "SUIVANT";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.NextBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.NextBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.NextBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(20, 20);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.NextBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.NextBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.NextBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.NextBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.NextBtn.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titre1
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Name = "titre1";
            this.Title.Size = new System.Drawing.Size(492, 63);
            this.Title.TabIndex = 4;
            // 
            // bandeau1
            // 
            this.bandeau1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandeau1.Location = new System.Drawing.Point(16, 481);
            this.bandeau1.Name = "bandeau1";
            this.bandeau1.Size = new System.Drawing.Size(665, 20);
            this.bandeau1.TabIndex = 6;
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Match";
            this.Size = new System.Drawing.Size(699, 504);
            this.Load += new System.EventHandler(this.Matchs_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TirrageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Terrains Fiels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Title Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Telerik.WinControls.UI.RadButton HomeBtn;
        private Telerik.WinControls.UI.RadButton PrintBtn;
        private Telerik.WinControls.UI.RadButton TirrageBtn;
        private Telerik.WinControls.UI.RadButton NextBtn;
        private Bandeau bandeau1;

    }
}
