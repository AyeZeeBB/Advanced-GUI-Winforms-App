
namespace A_GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notificationpanel = new System.Windows.Forms.Panel();
            this.notificationpanelclose = new Guna.UI2.WinForms.Guna2Button();
            this.notificationlabel = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.toplabel = new System.Windows.Forms.Label();
            this.minimizebutton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maximizebutton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closebutton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.resizebox = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.settingsbutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.topicon = new System.Windows.Forms.PictureBox();
            this.notificationpanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicon)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationpanel
            // 
            this.notificationpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.notificationpanel.Controls.Add(this.notificationpanelclose);
            this.notificationpanel.Controls.Add(this.notificationlabel);
            this.notificationpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notificationpanel.Location = new System.Drawing.Point(0, 487);
            this.notificationpanel.Name = "notificationpanel";
            this.notificationpanel.Size = new System.Drawing.Size(1075, 28);
            this.notificationpanel.TabIndex = 0;
            this.notificationpanel.Visible = false;
            // 
            // notificationpanelclose
            // 
            this.notificationpanelclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationpanelclose.CheckedState.Parent = this.notificationpanelclose;
            this.notificationpanelclose.CustomImages.Parent = this.notificationpanelclose;
            this.notificationpanelclose.FillColor = System.Drawing.Color.Transparent;
            this.notificationpanelclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notificationpanelclose.ForeColor = System.Drawing.Color.Black;
            this.notificationpanelclose.HoverState.Parent = this.notificationpanelclose;
            this.notificationpanelclose.Location = new System.Drawing.Point(1051, 3);
            this.notificationpanelclose.Name = "notificationpanelclose";
            this.notificationpanelclose.ShadowDecoration.Parent = this.notificationpanelclose;
            this.notificationpanelclose.Size = new System.Drawing.Size(21, 22);
            this.notificationpanelclose.TabIndex = 2;
            this.notificationpanelclose.Text = "X";
            this.notificationpanelclose.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // notificationlabel
            // 
            this.notificationlabel.AutoSize = true;
            this.notificationlabel.Location = new System.Drawing.Point(12, 8);
            this.notificationlabel.Name = "notificationlabel";
            this.notificationlabel.Size = new System.Drawing.Size(58, 13);
            this.notificationlabel.TabIndex = 1;
            this.notificationlabel.Text = "Temp Text";
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.toppanel.Controls.Add(this.settingsbutton);
            this.toppanel.Controls.Add(this.toplabel);
            this.toppanel.Controls.Add(this.topicon);
            this.toppanel.Controls.Add(this.minimizebutton);
            this.toppanel.Controls.Add(this.maximizebutton);
            this.toppanel.Controls.Add(this.closebutton);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1075, 29);
            this.toppanel.TabIndex = 1;
            // 
            // toplabel
            // 
            this.toplabel.AutoSize = true;
            this.toplabel.Location = new System.Drawing.Point(36, 8);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(108, 13);
            this.toplabel.TabIndex = 4;
            this.toplabel.Text = "Advanced GUI Editor";
            // 
            // minimizebutton
            // 
            this.minimizebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebutton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizebutton.FillColor = System.Drawing.Color.Transparent;
            this.minimizebutton.HoverState.Parent = this.minimizebutton;
            this.minimizebutton.IconColor = System.Drawing.Color.Black;
            this.minimizebutton.Location = new System.Drawing.Point(961, 3);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.ShadowDecoration.Parent = this.minimizebutton;
            this.minimizebutton.Size = new System.Drawing.Size(37, 23);
            this.minimizebutton.TabIndex = 2;
            // 
            // maximizebutton
            // 
            this.maximizebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizebutton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximizebutton.FillColor = System.Drawing.Color.Transparent;
            this.maximizebutton.HoverState.Parent = this.maximizebutton;
            this.maximizebutton.IconColor = System.Drawing.Color.Black;
            this.maximizebutton.Location = new System.Drawing.Point(998, 3);
            this.maximizebutton.Name = "maximizebutton";
            this.maximizebutton.ShadowDecoration.Parent = this.maximizebutton;
            this.maximizebutton.Size = new System.Drawing.Size(37, 23);
            this.maximizebutton.TabIndex = 1;
            // 
            // closebutton
            // 
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebutton.FillColor = System.Drawing.Color.Transparent;
            this.closebutton.HoverState.Parent = this.closebutton;
            this.closebutton.IconColor = System.Drawing.Color.Black;
            this.closebutton.Location = new System.Drawing.Point(1035, 3);
            this.closebutton.Name = "closebutton";
            this.closebutton.ShadowDecoration.Parent = this.closebutton;
            this.closebutton.Size = new System.Drawing.Size(37, 23);
            this.closebutton.TabIndex = 0;
            // 
            // resizebox
            // 
            this.resizebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.resizebox.FillColor = System.Drawing.Color.White;
            this.resizebox.ForeColor = System.Drawing.Color.Empty;
            this.resizebox.Location = new System.Drawing.Point(1056, 495);
            this.resizebox.Name = "resizebox";
            this.resizebox.Size = new System.Drawing.Size(20, 20);
            this.resizebox.TabIndex = 2;
            this.resizebox.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.toppanel;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // settingsbutton
            // 
            this.settingsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsbutton.CheckedState.Parent = this.settingsbutton;
            this.settingsbutton.HoverState.Image = global::A_GUI.Properties.Resources.baseline_settings_black_24dp;
            this.settingsbutton.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.settingsbutton.HoverState.Parent = this.settingsbutton;
            this.settingsbutton.Image = global::A_GUI.Properties.Resources.baseline_settings_black_24dp;
            this.settingsbutton.Location = new System.Drawing.Point(929, 3);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.PressedState.Parent = this.settingsbutton;
            this.settingsbutton.Size = new System.Drawing.Size(29, 23);
            this.settingsbutton.TabIndex = 5;
            this.settingsbutton.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // topicon
            // 
            this.topicon.Image = global::A_GUI.Properties.Resources._83636;
            this.topicon.Location = new System.Drawing.Point(3, 3);
            this.topicon.Name = "topicon";
            this.topicon.Size = new System.Drawing.Size(31, 23);
            this.topicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topicon.TabIndex = 3;
            this.topicon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 515);
            this.Controls.Add(this.resizebox);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.notificationpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.notificationpanel.ResumeLayout(false);
            this.notificationpanel.PerformLayout();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label notificationlabel;
        public System.Windows.Forms.Panel notificationpanel;
        private System.Windows.Forms.Panel toppanel;
        private Guna.UI2.WinForms.Guna2Button notificationpanelclose;
        private Guna.UI2.WinForms.Guna2ResizeBox resizebox;
        private Guna.UI2.WinForms.Guna2ControlBox minimizebutton;
        private Guna.UI2.WinForms.Guna2ControlBox maximizebutton;
        private Guna.UI2.WinForms.Guna2ControlBox closebutton;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox topicon;
        private System.Windows.Forms.Label toplabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton settingsbutton;
    }
}

