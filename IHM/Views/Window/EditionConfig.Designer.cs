namespace IHM
{
    partial class EditSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RankingRoundsNumberTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.RandomRoundsNumberTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.LabelManchesClassement = new System.Windows.Forms.Label();
            this.LabelNbPlanches = new System.Windows.Forms.Label();
            this.LabelManchesAleatoires = new System.Windows.Forms.Label();
            this.FieldsNumberTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ValidateBtn = new Telerik.WinControls.UI.RadButton();
            this.CancelBtn = new Telerik.WinControls.UI.RadButton();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RankingRoundsNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomRoundsNumberTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsNumberTextBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.RankingRoundsNumberTextBox, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.RandomRoundsNumberTextBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.LabelManchesClassement, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LabelNbPlanches, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelManchesAleatoires, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.FieldsNumberTextBox, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // TB_Manches_Classement
            // 
            resources.ApplyResources(this.RankingRoundsNumberTextBox, "TB_Manches_Classement");
            this.RankingRoundsNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RankingRoundsNumberTextBox.Name = "TB_Manches_Classement";
            // 
            // 
            // 
            this.RankingRoundsNumberTextBox.RootElement.AccessibleDescription = resources.GetString("TB_Manches_Classement.RootElement.AccessibleDescription");
            this.RankingRoundsNumberTextBox.RootElement.AccessibleName = resources.GetString("TB_Manches_Classement.RootElement.AccessibleName");
            this.RankingRoundsNumberTextBox.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("TB_Manches_Classement.RootElement.Alignment")));
            this.RankingRoundsNumberTextBox.RootElement.AngleTransform = ((float)(resources.GetObject("TB_Manches_Classement.RootElement.AngleTransform")));
            this.RankingRoundsNumberTextBox.RootElement.FlipText = ((bool)(resources.GetObject("TB_Manches_Classement.RootElement.FlipText")));
            this.RankingRoundsNumberTextBox.RootElement.KeyTip = resources.GetString("TB_Manches_Classement.RootElement.KeyTip");
            this.RankingRoundsNumberTextBox.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("TB_Manches_Classement.RootElement.Margin")));
            this.RankingRoundsNumberTextBox.RootElement.Text = resources.GetString("TB_Manches_Classement.RootElement.Text");
            this.RankingRoundsNumberTextBox.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("TB_Manches_Classement.RootElement.TextOrientation")));
            this.RankingRoundsNumberTextBox.RootElement.ToolTipText = resources.GetString("TB_Manches_Classement.RootElement.ToolTipText");
            this.RankingRoundsNumberTextBox.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.radTextBox1_TextChanging);
            // 
            // TB_Manches_Aleatoires
            // 
            resources.ApplyResources(this.RandomRoundsNumberTextBox, "TB_Manches_Aleatoires");
            this.RandomRoundsNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RandomRoundsNumberTextBox.Name = "TB_Manches_Aleatoires";
            // 
            // 
            // 
            this.RandomRoundsNumberTextBox.RootElement.AccessibleDescription = resources.GetString("TB_Manches_Aleatoires.RootElement.AccessibleDescription");
            this.RandomRoundsNumberTextBox.RootElement.AccessibleName = resources.GetString("TB_Manches_Aleatoires.RootElement.AccessibleName");
            this.RandomRoundsNumberTextBox.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("TB_Manches_Aleatoires.RootElement.Alignment")));
            this.RandomRoundsNumberTextBox.RootElement.AngleTransform = ((float)(resources.GetObject("TB_Manches_Aleatoires.RootElement.AngleTransform")));
            this.RandomRoundsNumberTextBox.RootElement.FlipText = ((bool)(resources.GetObject("TB_Manches_Aleatoires.RootElement.FlipText")));
            this.RandomRoundsNumberTextBox.RootElement.KeyTip = resources.GetString("TB_Manches_Aleatoires.RootElement.KeyTip");
            this.RandomRoundsNumberTextBox.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("TB_Manches_Aleatoires.RootElement.Margin")));
            this.RandomRoundsNumberTextBox.RootElement.Text = resources.GetString("TB_Manches_Aleatoires.RootElement.Text");
            this.RandomRoundsNumberTextBox.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("TB_Manches_Aleatoires.RootElement.TextOrientation")));
            this.RandomRoundsNumberTextBox.RootElement.ToolTipText = resources.GetString("TB_Manches_Aleatoires.RootElement.ToolTipText");
            this.RandomRoundsNumberTextBox.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.radTextBox1_TextChanging);
            // 
            // LabelManchesClassement
            // 
            resources.ApplyResources(this.LabelManchesClassement, "LabelManchesClassement");
            this.LabelManchesClassement.Name = "LabelManchesClassement";
            // 
            // LabelNbPlanches
            // 
            resources.ApplyResources(this.LabelNbPlanches, "LabelNbPlanches");
            this.LabelNbPlanches.Name = "LabelNbPlanches";
            // 
            // LabelManchesAleatoires
            // 
            resources.ApplyResources(this.LabelManchesAleatoires, "LabelManchesAleatoires");
            this.LabelManchesAleatoires.Name = "LabelManchesAleatoires";
            // 
            // TB_Nb_Planches
            // 
            resources.ApplyResources(this.FieldsNumberTextBox, "TB_Nb_Planches");
            this.FieldsNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FieldsNumberTextBox.Name = "TB_Nb_Planches";
            // 
            // 
            // 
            this.FieldsNumberTextBox.RootElement.AccessibleDescription = resources.GetString("TB_Nb_Planches.RootElement.AccessibleDescription");
            this.FieldsNumberTextBox.RootElement.AccessibleName = resources.GetString("TB_Nb_Planches.RootElement.AccessibleName");
            this.FieldsNumberTextBox.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("TB_Nb_Planches.RootElement.Alignment")));
            this.FieldsNumberTextBox.RootElement.AngleTransform = ((float)(resources.GetObject("TB_Nb_Planches.RootElement.AngleTransform")));
            this.FieldsNumberTextBox.RootElement.FlipText = ((bool)(resources.GetObject("TB_Nb_Planches.RootElement.FlipText")));
            this.FieldsNumberTextBox.RootElement.KeyTip = resources.GetString("TB_Nb_Planches.RootElement.KeyTip");
            this.FieldsNumberTextBox.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("TB_Nb_Planches.RootElement.Margin")));
            this.FieldsNumberTextBox.RootElement.Text = resources.GetString("TB_Nb_Planches.RootElement.Text");
            this.FieldsNumberTextBox.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("TB_Nb_Planches.RootElement.TextOrientation")));
            this.FieldsNumberTextBox.RootElement.ToolTipText = resources.GetString("TB_Nb_Planches.RootElement.ToolTipText");
            this.FieldsNumberTextBox.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.radTextBox1_TextChanging);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.ValidateBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.CancelBtn, 2, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // ValidateBtn
            // 
            resources.ApplyResources(this.ValidateBtn, "ValidateBtn");
            this.ValidateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValidateBtn.Image = global::IHM.Properties.Resources.Check;
            this.ValidateBtn.Name = "ValidateBtn";
            // 
            // 
            // 
            this.ValidateBtn.RootElement.AccessibleDescription = resources.GetString("ValidateBtn.RootElement.AccessibleDescription");
            this.ValidateBtn.RootElement.AccessibleName = resources.GetString("ValidateBtn.RootElement.AccessibleName");
            this.ValidateBtn.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("ValidateBtn.RootElement.Alignment")));
            this.ValidateBtn.RootElement.AngleTransform = ((float)(resources.GetObject("ValidateBtn.RootElement.AngleTransform")));
            this.ValidateBtn.RootElement.FlipText = ((bool)(resources.GetObject("ValidateBtn.RootElement.FlipText")));
            this.ValidateBtn.RootElement.KeyTip = resources.GetString("ValidateBtn.RootElement.KeyTip");
            this.ValidateBtn.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("ValidateBtn.RootElement.Margin")));
            this.ValidateBtn.RootElement.Text = resources.GetString("ValidateBtn.RootElement.Text");
            this.ValidateBtn.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("ValidateBtn.RootElement.TextOrientation")));
            this.ValidateBtn.RootElement.ToolTipText = resources.GetString("ValidateBtn.RootElement.ToolTipText");
            this.ValidateBtn.ThemeName = "Office2010Black";
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).Image = global::IHM.Properties.Resources.Check;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).TextAlignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlignment")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ValidateBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ValidateBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ValidateBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.CancelBtn, "CancelBtn");
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Image = global::IHM.Properties.Resources.cancel;
            this.CancelBtn.Name = "CancelBtn";
            // 
            // 
            // 
            this.CancelBtn.RootElement.AccessibleDescription = resources.GetString("CancelBtn.RootElement.AccessibleDescription");
            this.CancelBtn.RootElement.AccessibleName = resources.GetString("CancelBtn.RootElement.AccessibleName");
            this.CancelBtn.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("CancelBtn.RootElement.Alignment")));
            this.CancelBtn.RootElement.AngleTransform = ((float)(resources.GetObject("CancelBtn.RootElement.AngleTransform")));
            this.CancelBtn.RootElement.FlipText = ((bool)(resources.GetObject("CancelBtn.RootElement.FlipText")));
            this.CancelBtn.RootElement.KeyTip = resources.GetString("CancelBtn.RootElement.KeyTip");
            this.CancelBtn.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("CancelBtn.RootElement.Margin")));
            this.CancelBtn.RootElement.Text = resources.GetString("CancelBtn.RootElement.Text");
            this.CancelBtn.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("CancelBtn.RootElement.TextOrientation")));
            this.CancelBtn.RootElement.ToolTipText = resources.GetString("CancelBtn.RootElement.ToolTipText");
            this.CancelBtn.ThemeName = "Office2010Black";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.CancelBtn.GetChildAt(0))).Image = global::IHM.Properties.Resources.cancel;
            ((Telerik.WinControls.UI.RadButtonElement)(this.CancelBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.CancelBtn.GetChildAt(0))).TextAlignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlignment1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.CancelBtn.GetChildAt(0))).Text = resources.GetString("resource.Text1");
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.CancelBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.CancelBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.CancelBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin1")));
            // 
            // EditionConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditionConfig";
            // 
            // 
            // 
            this.RootElement.AccessibleDescription = resources.GetString("EditionConfig.RootElement.AccessibleDescription");
            this.RootElement.AccessibleName = resources.GetString("EditionConfig.RootElement.AccessibleName");
            this.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("EditionConfig.RootElement.Alignment")));
            this.RootElement.AngleTransform = ((float)(resources.GetObject("EditionConfig.RootElement.AngleTransform")));
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.FlipText = ((bool)(resources.GetObject("EditionConfig.RootElement.FlipText")));
            this.RootElement.KeyTip = resources.GetString("EditionConfig.RootElement.KeyTip");
            this.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("EditionConfig.RootElement.Margin")));
            this.RootElement.Text = resources.GetString("EditionConfig.RootElement.Text");
            this.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("EditionConfig.RootElement.TextOrientation")));
            this.RootElement.ToolTipText = resources.GetString("EditionConfig.RootElement.ToolTipText");
            this.ThemeName = "Office2010Silver";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RankingRoundsNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomRoundsNumberTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsNumberTextBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValidateBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadTextBoxControl RankingRoundsNumberTextBox;
        private Telerik.WinControls.UI.RadTextBoxControl RandomRoundsNumberTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Telerik.WinControls.UI.RadButton ValidateBtn;
        private Telerik.WinControls.UI.RadButton CancelBtn;
        private System.Windows.Forms.Label LabelNbPlanches;
        private System.Windows.Forms.Label LabelManchesClassement;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.Label LabelManchesAleatoires;
        private Telerik.WinControls.UI.RadTextBoxControl FieldsNumberTextBox;
    }
}
