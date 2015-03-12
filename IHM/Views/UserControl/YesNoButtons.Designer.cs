namespace IHM.Views.UserControl
{
    partial class YesNoButtons
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
            this.TLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.ResetBtn = new Telerik.WinControls.UI.RadButton();
            this.ValidateBtn = new Telerik.WinControls.UI.RadButton();
            this.TLP_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResetBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP_Buttons
            // 
            this.TLP_Buttons.ColumnCount = 4;
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLP_Buttons.Controls.Add(this.ResetBtn, 1, 0);
            this.TLP_Buttons.Controls.Add(this.ValidateBtn, 1, 0);
            this.TLP_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Buttons.Location = new System.Drawing.Point(0, 0);
            this.TLP_Buttons.Name = "TLP_Buttons";
            this.TLP_Buttons.RowCount = 1;
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Buttons.Size = new System.Drawing.Size(324, 150);
            this.TLP_Buttons.TabIndex = 3;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ResetBtn.Location = new System.Drawing.Point(176, 5);
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
            this.ResetBtn.Size = new System.Drawing.Size(83, 140);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "Non";
            this.ResetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ResetBtn.ThemeName = "Office2010Black";
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.ResetBtn.GetChildAt(0))).Image = null;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ResetBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ResetBtn.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ResetBtn.GetChildAt(0))).Text = "Non";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ResetBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(28, 28);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ResetBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ResetBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValidateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValidateBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.ValidateBtn.Location = new System.Drawing.Point(63, 5);
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
            this.ValidateBtn.Size = new System.Drawing.Size(83, 140);
            this.ValidateBtn.TabIndex = 3;
            this.ValidateBtn.Text = "Oui";
            this.ValidateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ValidateBtn.ThemeName = "Office2010Black";
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).Image = null;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.ValidateBtn.GetChildAt(0))).Text = "Oui";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ValidateBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ScaleSize = new System.Drawing.Size(28, 28);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ValidateBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.ValidateBtn.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            // 
            // YesNoButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLP_Buttons);
            this.Name = "YesNoButtons";
            this.Size = new System.Drawing.Size(324, 150);
            this.TLP_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResetBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Buttons;
        private Telerik.WinControls.UI.RadButton ResetBtn;
        private Telerik.WinControls.UI.RadButton ValidateBtn;
    }
}
