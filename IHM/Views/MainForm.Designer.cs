namespace IHM.Form
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel = new Telerik.WinControls.UI.RadPanel();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            resources.ApplyResources(this.Panel, "Panel");
            this.Panel.Name = "Panel";
            // 
            // 
            // 
            this.Panel.RootElement.AccessibleDescription = resources.GetString("Panel.RootElement.AccessibleDescription");
            this.Panel.RootElement.AccessibleName = resources.GetString("Panel.RootElement.AccessibleName");
            this.Panel.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("Panel.RootElement.Alignment")));
            this.Panel.RootElement.AngleTransform = ((float)(resources.GetObject("Panel.RootElement.AngleTransform")));
            this.Panel.RootElement.FlipText = ((bool)(resources.GetObject("Panel.RootElement.FlipText")));
            this.Panel.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("Panel.RootElement.Margin")));
            this.Panel.RootElement.Text = resources.GetString("Panel.RootElement.Text");
            this.Panel.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("Panel.RootElement.TextOrientation")));
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.AccessibleDescription = resources.GetString("MainForm.RootElement.AccessibleDescription");
            this.RootElement.AccessibleName = resources.GetString("MainForm.RootElement.AccessibleName");
            this.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("MainForm.RootElement.Alignment")));
            this.RootElement.AngleTransform = ((float)(resources.GetObject("MainForm.RootElement.AngleTransform")));
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.FlipText = ((bool)(resources.GetObject("MainForm.RootElement.FlipText")));
            this.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("MainForm.RootElement.Margin")));
            this.RootElement.Text = resources.GetString("MainForm.RootElement.Text");
            this.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("MainForm.RootElement.TextOrientation")));
            this.ThemeName = "Office2010Silver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel Panel;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
    }
}
