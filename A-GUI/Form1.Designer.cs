
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
            Guna.UI2.AnimatorNS.Animation animation6 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notificationpanel = new System.Windows.Forms.Panel();
            this.notificationpanelclose = new Guna.UI2.WinForms.Guna2Button();
            this.notificationlabel = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.settingsbutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.toplabel = new System.Windows.Forms.Label();
            this.topicon = new System.Windows.Forms.PictureBox();
            this.minimizebutton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maximizebutton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closebutton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.resizebox = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.notificationpanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationpanel
            // 
            this.notificationpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.notificationpanel.Controls.Add(this.notificationpanelclose);
            this.notificationpanel.Controls.Add(this.notificationlabel);
            this.guna2Transition1.SetDecoration(this.notificationpanel, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.guna2Transition1.SetDecoration(this.notificationpanelclose, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.guna2Transition1.SetDecoration(this.notificationlabel, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.guna2Transition1.SetDecoration(this.toppanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1075, 29);
            this.toppanel.TabIndex = 1;
            // 
            // settingsbutton
            // 
            this.settingsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsbutton.CheckedState.Parent = this.settingsbutton;
            this.guna2Transition1.SetDecoration(this.settingsbutton, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // toplabel
            // 
            this.toplabel.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.toplabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toplabel.Location = new System.Drawing.Point(36, 8);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(108, 13);
            this.toplabel.TabIndex = 4;
            this.toplabel.Text = "Advanced GUI Editor";
            // 
            // topicon
            // 
            this.guna2Transition1.SetDecoration(this.topicon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.topicon.Image = global::A_GUI.Properties.Resources._83636;
            this.topicon.Location = new System.Drawing.Point(3, 3);
            this.topicon.Name = "topicon";
            this.topicon.Size = new System.Drawing.Size(31, 23);
            this.topicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topicon.TabIndex = 3;
            this.topicon.TabStop = false;
            // 
            // minimizebutton
            // 
            this.minimizebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebutton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.minimizebutton, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.guna2Transition1.SetDecoration(this.maximizebutton, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.guna2Transition1.SetDecoration(this.closebutton, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.guna2Transition1.SetDecoration(this.resizebox, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.guna2CheckBox2);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.guna2CheckBox1);
            this.panel2.Controls.Add(this.label2);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 90);
            this.panel2.TabIndex = 7;
            // 
            // guna2Separator1
            // 
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.Location = new System.Drawing.Point(3, 29);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(188, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.Animated = true;
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 1;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox1.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2Transition1.SetDecoration(this.guna2CheckBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(3, 45);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(153, 17);
            this.guna2CheckBox1.TabIndex = 6;
            this.guna2CheckBox1.Text = "Use Development Website";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 1;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox1.UseVisualStyleBackColor = true;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.label2.Location = new System.Drawing.Point(64, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Settings";
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation6;
            this.guna2Transition1.TimeStep = 0.05F;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.panel2);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(842, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 94);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.Animated = true;
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CheckBox2.CheckedState.BorderThickness = 1;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox2.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2Transition1.SetDecoration(this.guna2CheckBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox2.Location = new System.Drawing.Point(3, 68);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(189, 17);
            this.guna2CheckBox2.TabIndex = 9;
            this.guna2CheckBox2.Text = "Auto Save Files To Projects Folder";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 1;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox2.UseVisualStyleBackColor = true;
            this.guna2CheckBox2.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resizebox);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.notificationpanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
    }
}

