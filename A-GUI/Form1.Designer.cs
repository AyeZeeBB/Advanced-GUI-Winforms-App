
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsbutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.topicon = new System.Windows.Forms.PictureBox();
            this.notificationpanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicon)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationpanel
            // 
            this.notificationpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.notificationpanel.Controls.Add(this.panel3);
            this.notificationpanel.Location = new System.Drawing.Point(567, 270);
            this.notificationpanel.Name = "notificationpanel";
            this.notificationpanel.Size = new System.Drawing.Size(221, 118);
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
            this.notificationpanelclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.notificationpanelclose.HoverState.Parent = this.notificationpanelclose;
            this.notificationpanelclose.Location = new System.Drawing.Point(191, 3);
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
            this.notificationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notificationlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.notificationlabel.Location = new System.Drawing.Point(3, 3);
            this.notificationlabel.Name = "notificationlabel";
            this.notificationlabel.Size = new System.Drawing.Size(97, 17);
            this.notificationlabel.TabIndex = 1;
            this.notificationlabel.Text = "Success/Error";
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
            this.toppanel.Size = new System.Drawing.Size(800, 29);
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
            this.minimizebutton.Location = new System.Drawing.Point(686, 3);
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
            this.maximizebutton.Location = new System.Drawing.Point(723, 3);
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
            this.closebutton.Location = new System.Drawing.Point(760, 3);
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
            this.resizebox.Location = new System.Drawing.Point(781, 380);
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
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.guna2CheckBox2);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.guna2CheckBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 88);
            this.panel2.TabIndex = 7;
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
            // guna2Separator1
            // 
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.label2.Location = new System.Drawing.Point(64, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(567, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.notificationpanel;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.guna2Separator2);
            this.panel3.Controls.Add(this.notificationpanelclose);
            this.panel3.Controls.Add(this.notificationlabel);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 112);
            this.panel3.TabIndex = 1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            this.guna2Elipse3.TargetControl = this.panel3;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(3, 23);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(209, 10);
            this.guna2Separator2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 72);
            this.label1.TabIndex = 9;
            this.label1.Text = "Message";
            // 
            // settingsbutton
            // 
            this.settingsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsbutton.CheckedState.Parent = this.settingsbutton;
            this.settingsbutton.HoverState.Image = global::A_GUI.Properties.Resources.baseline_settings_black_24dp;
            this.settingsbutton.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.settingsbutton.HoverState.Parent = this.settingsbutton;
            this.settingsbutton.Image = global::A_GUI.Properties.Resources.baseline_settings_black_24dp;
            this.settingsbutton.Location = new System.Drawing.Point(654, 3);
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
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resizebox);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.notificationpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.notificationpanel.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}

