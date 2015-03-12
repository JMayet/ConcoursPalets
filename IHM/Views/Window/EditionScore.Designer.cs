namespace IHM
{
    partial class EditionScore
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelScoreB = new Telerik.WinControls.UI.RadTextBox();
            this.LabelTeamA = new System.Windows.Forms.Label();
            this.LabelTeamB = new System.Windows.Forms.Label();
            this.LabelScoreA = new Telerik.WinControls.UI.RadTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelField = new System.Windows.Forms.Label();
            this.ResetBtn = new Telerik.WinControls.UI.RadButton();
            this.ValidateBtn = new Telerik.WinControls.UI.RadButton();
            this.CancelBtn = new Telerik.WinControls.UI.RadButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelScoreB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelScoreA)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResetBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.83004F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01186F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 229);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.LabelScoreB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LabelTeamA, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelTeamB, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LabelScoreA, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 106);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LabelScoreB
            // 
            this.LabelScoreB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelScoreB.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreB.Location = new System.Drawing.Point(145, 54);
            this.LabelScoreB.Margin = new System.Windows.Forms.Padding(3, 6, 15, 6);
            this.LabelScoreB.Name = "LabelScoreB";
            this.LabelScoreB.Size = new System.Drawing.Size(314, 37);
            this.LabelScoreB.TabIndex = 8;
            this.LabelScoreB.Text = "0";
            this.LabelScoreB.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.ScoreChanging);
            // 
            // LabelEquipeA
            // 
            this.LabelTeamA.AutoSize = true;
            this.LabelTeamA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTeamA.Font = new System.Drawing.Font("Joan", 21.75F);
            this.LabelTeamA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTeamA.Location = new System.Drawing.Point(13, 0);
            this.LabelTeamA.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.LabelTeamA.Name = "LabelEquipeA";
            this.LabelTeamA.Size = new System.Drawing.Size(126, 48);
            this.LabelTeamA.TabIndex = 5;
            this.LabelTeamA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEquipeB
            // 
            this.LabelTeamB.AutoSize = true;
            this.LabelTeamB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTeamB.Font = new System.Drawing.Font("Joan", 21.75F);
            this.LabelTeamB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelTeamB.Location = new System.Drawing.Point(13, 48);
            this.LabelTeamB.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.LabelTeamB.Name = "LabelEquipeB";
            this.LabelTeamB.Size = new System.Drawing.Size(126, 48);
            this.LabelTeamB.TabIndex = 6;
            this.LabelTeamB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelScoreA
            // 
            this.LabelScoreA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelScoreA.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreA.Location = new System.Drawing.Point(145, 6);
            this.LabelScoreA.Margin = new System.Windows.Forms.Padding(3, 6, 15, 6);
            this.LabelScoreA.Name = "LabelScoreA";
            this.LabelScoreA.Size = new System.Drawing.Size(314, 37);
            this.LabelScoreA.TabIndex = 7;
            this.LabelScoreA.Text = "0";
            this.LabelScoreA.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.ScoreChanging);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.ResetBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ValidateBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CancelBtn, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 185);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(474, 41);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(474, 64);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.LabelField, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(278, 58);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // LabelTerrain
            // 
            this.LabelField.AutoSize = true;
            this.LabelField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelField.Font = new System.Drawing.Font("Joan", 27.75F);
            this.LabelField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelField.Location = new System.Drawing.Point(3, 0);
            this.LabelField.Name = "LabelTerrain";
            this.LabelField.Size = new System.Drawing.Size(272, 46);
            this.LabelField.TabIndex = 4;
            this.LabelField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ResetBtn.Image = global::IHM.Properties.Resources.Back;
            this.ResetBtn.Location = new System.Drawing.Point(172, 5);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.ResetBtn.Name = "ResetBtn";
            // 
            // 
            // 
            this.ResetBtn.RootElement.AccessibleDescription = null;
            this.ResetBtn.RootElement.AccessibleName = null;
            this.ResetBtn.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.ResetBtn.RootElement.AngleTransform = 0F;
            this.ResetBtn.RootElement.FlipText = false;
            this.ResetBtn.RootElement.Margin = new System.Windows.Forms.Padding(0);
            this.ResetBtn.RootElement.Text = null;
            this.ResetBtn.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.ResetBtn.Size = new System.Drawing.Size(127, 31);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResetBtn.ThemeName = "Office2010Black";
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ResetBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(28, 28);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ResetBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ResetBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValidateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValidateBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ValidateBtn.Image = global::IHM.Properties.Resources.Check;
            this.ValidateBtn.Location = new System.Drawing.Point(15, 5);
            this.ValidateBtn.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.ValidateBtn.Name = "ValidateBtn";
            // 
            // 
            // 
            this.ValidateBtn.RootElement.AccessibleDescription = null;
            this.ValidateBtn.RootElement.AccessibleName = null;
            this.ValidateBtn.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.ValidateBtn.RootElement.AngleTransform = 0F;
            this.ValidateBtn.RootElement.FlipText = false;
            this.ValidateBtn.RootElement.Margin = new System.Windows.Forms.Padding(0);
            this.ValidateBtn.RootElement.Text = null;
            this.ValidateBtn.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.ValidateBtn.Size = new System.Drawing.Size(127, 31);
            this.ValidateBtn.TabIndex = 3;
            this.ValidateBtn.Text = "VALIDER";
            this.ValidateBtn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValidateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ValidateBtn.ThemeName = "Office2010Black";
            this.ValidateBtn.Click += new System.EventHandler(this.ValidBtn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).Image = global::IHM.Properties.Resources.Check;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).Text = "VALIDER";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ValidateBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(28, 28);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ValidateBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ValidateBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.Image = global::IHM.Properties.Resources.cancel;
            this.CancelBtn.Location = new System.Drawing.Point(329, 5);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.CancelBtn.Name = "CancelBtn";
            // 
            // 
            // 
            this.CancelBtn.RootElement.AccessibleDescription = null;
            this.CancelBtn.RootElement.AccessibleName = null;
            this.CancelBtn.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.CancelBtn.RootElement.AngleTransform = 0F;
            this.CancelBtn.RootElement.FlipText = false;
            this.CancelBtn.RootElement.Margin = new System.Windows.Forms.Padding(0);
            this.CancelBtn.RootElement.Text = null;
            this.CancelBtn.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.CancelBtn.Size = new System.Drawing.Size(130, 31);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "ANNULER";
            this.CancelBtn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBtn.ThemeName = "Office2010Black";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.CancelBtn.GetChildAt(0))).Image = global::IHM.Properties.Resources.cancel;
            ((Telerik.WinControls.UI.RadButtonElement)(this.CancelBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.CancelBtn.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.CancelBtn.GetChildAt(0))).Text = "ANNULER";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.CancelBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(28, 28);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.CancelBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.CancelBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IHM.Properties.Resources.Sanstitre;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(287, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 58);
            this.panel1.TabIndex = 1;
            // 
            // EditionScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 229);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditionScore";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saisie Score";
            this.ThemeName = "Office2010Silver";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelScoreB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelScoreA)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResetBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelTeamA;
        private System.Windows.Forms.Label LabelTeamB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Telerik.WinControls.UI.RadButton ValidateBtn;
        private Telerik.WinControls.UI.RadButton CancelBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label LabelField;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadTextBox LabelScoreB;
        private Telerik.WinControls.UI.RadTextBox LabelScoreA;
        private Telerik.WinControls.UI.RadButton ResetBtn;

    }
}
