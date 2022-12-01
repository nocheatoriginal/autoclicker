
namespace Autoclicker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cb_Toggle = new System.Windows.Forms.CheckBox();
            this.tb_cps = new System.Windows.Forms.TrackBar();
            this.l_cps = new System.Windows.Forms.Label();
            this.RightClicker = new System.Windows.Forms.Timer(this.components);
            this.b_Hotkey = new System.Windows.Forms.Button();
            this.Bind = new System.Windows.Forms.Timer(this.components);
            this.textBox_CPS = new System.Windows.Forms.TextBox();
            this.rb_Leftclick = new System.Windows.Forms.RadioButton();
            this.rb_Rightclick = new System.Windows.Forms.RadioButton();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_credits = new System.Windows.Forms.Label();
            this.label_Hotkey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_cps)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Toggle
            // 
            this.cb_Toggle.AutoSize = true;
            this.cb_Toggle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_Toggle.Location = new System.Drawing.Point(238, 71);
            this.cb_Toggle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cb_Toggle.Name = "cb_Toggle";
            this.cb_Toggle.Size = new System.Drawing.Size(122, 31);
            this.cb_Toggle.TabIndex = 0;
            this.cb_Toggle.Text = "Enabled";
            this.cb_Toggle.UseVisualStyleBackColor = true;
            this.cb_Toggle.CheckedChanged += new System.EventHandler(this.cb_Toggle_CheckedChanged);
            // 
            // tb_cps
            // 
            this.tb_cps.Location = new System.Drawing.Point(12, 147);
            this.tb_cps.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tb_cps.Maximum = 20;
            this.tb_cps.Minimum = 1;
            this.tb_cps.Name = "tb_cps";
            this.tb_cps.Size = new System.Drawing.Size(348, 45);
            this.tb_cps.TabIndex = 1;
            this.tb_cps.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tb_cps.Value = 15;
            this.tb_cps.Scroll += new System.EventHandler(this.tb_cps_Scroll);
            // 
            // l_cps
            // 
            this.l_cps.AutoSize = true;
            this.l_cps.Location = new System.Drawing.Point(7, 114);
            this.l_cps.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.l_cps.Name = "l_cps";
            this.l_cps.Size = new System.Drawing.Size(103, 27);
            this.l_cps.TabIndex = 2;
            this.l_cps.Text = "CPS: 15";
            this.l_cps.Click += new System.EventHandler(this.l_cps_Click);
            // 
            // RightClicker
            // 
            this.RightClicker.Enabled = true;
            this.RightClicker.Tick += new System.EventHandler(this.RightClicker_Tick);
            // 
            // b_Hotkey
            // 
            this.b_Hotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Hotkey.Location = new System.Drawing.Point(116, 66);
            this.b_Hotkey.Name = "b_Hotkey";
            this.b_Hotkey.Size = new System.Drawing.Size(112, 39);
            this.b_Hotkey.TabIndex = 3;
            this.b_Hotkey.Text = "none";
            this.b_Hotkey.UseVisualStyleBackColor = true;
            this.b_Hotkey.Click += new System.EventHandler(this.b_Hotkey_Click);
            this.b_Hotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.b_Hotkey_KeyUp);
            // 
            // Bind
            // 
            this.Bind.Enabled = true;
            this.Bind.Interval = 150;
            this.Bind.Tick += new System.EventHandler(this.Bind_Tick);
            // 
            // textBox_CPS
            // 
            this.textBox_CPS.Location = new System.Drawing.Point(134, 111);
            this.textBox_CPS.Name = "textBox_CPS";
            this.textBox_CPS.Size = new System.Drawing.Size(85, 35);
            this.textBox_CPS.TabIndex = 4;
            this.textBox_CPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_CPS.Visible = false;
            this.textBox_CPS.TextChanged += new System.EventHandler(this.textBox_CPS_TextChanged);
            this.textBox_CPS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_CPS_KeyDown);
            // 
            // rb_Leftclick
            // 
            this.rb_Leftclick.AutoSize = true;
            this.rb_Leftclick.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Leftclick.Location = new System.Drawing.Point(12, 210);
            this.rb_Leftclick.Name = "rb_Leftclick";
            this.rb_Leftclick.Size = new System.Drawing.Size(147, 31);
            this.rb_Leftclick.TabIndex = 5;
            this.rb_Leftclick.TabStop = true;
            this.rb_Leftclick.Text = "LeftClick";
            this.rb_Leftclick.UseVisualStyleBackColor = true;
            this.rb_Leftclick.Click += new System.EventHandler(this.rb_Leftclick_Click);
            // 
            // rb_Rightclick
            // 
            this.rb_Rightclick.AutoSize = true;
            this.rb_Rightclick.Checked = true;
            this.rb_Rightclick.Location = new System.Drawing.Point(200, 210);
            this.rb_Rightclick.Name = "rb_Rightclick";
            this.rb_Rightclick.Size = new System.Drawing.Size(160, 31);
            this.rb_Rightclick.TabIndex = 6;
            this.rb_Rightclick.TabStop = true;
            this.rb_Rightclick.Text = "RightClick";
            this.rb_Rightclick.UseVisualStyleBackColor = true;
            this.rb_Rightclick.Click += new System.EventHandler(this.rb_Rightclick_Click);
            // 
            // button_Start
            // 
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Location = new System.Drawing.Point(12, 247);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(348, 41);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_credits
            // 
            this.label_credits.AutoSize = true;
            this.label_credits.Location = new System.Drawing.Point(7, 9);
            this.label_credits.Name = "label_credits";
            this.label_credits.Size = new System.Drawing.Size(207, 27);
            this.label_credits.TabIndex = 1;
            this.label_credits.Text = "nocheatoriginal";
            this.label_credits.Click += new System.EventHandler(this.label_credits_Click);
            // 
            // label_Hotkey
            // 
            this.label_Hotkey.AutoSize = true;
            this.label_Hotkey.Location = new System.Drawing.Point(7, 72);
            this.label_Hotkey.Name = "label_Hotkey";
            this.label_Hotkey.Size = new System.Drawing.Size(103, 27);
            this.label_Hotkey.TabIndex = 9;
            this.label_Hotkey.Text = "Hotkey:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 299);
            this.Controls.Add(this.label_Hotkey);
            this.Controls.Add(this.label_credits);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.rb_Rightclick);
            this.Controls.Add(this.rb_Leftclick);
            this.Controls.Add(this.textBox_CPS);
            this.Controls.Add(this.b_Hotkey);
            this.Controls.Add(this.l_cps);
            this.Controls.Add(this.tb_cps);
            this.Controls.Add(this.cb_Toggle);
            this.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximumSize = new System.Drawing.Size(389, 338);
            this.MinimumSize = new System.Drawing.Size(389, 338);
            this.Name = "Form1";
            this.Text = "autoclicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_cps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Toggle;
        private System.Windows.Forms.TrackBar tb_cps;
        private System.Windows.Forms.Label l_cps;
        private System.Windows.Forms.Timer RightClicker;
        private System.Windows.Forms.Button b_Hotkey;
        private System.Windows.Forms.Timer Bind;
        private System.Windows.Forms.TextBox textBox_CPS;
        private System.Windows.Forms.RadioButton rb_Leftclick;
        private System.Windows.Forms.RadioButton rb_Rightclick;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_credits;
        private System.Windows.Forms.Label label_Hotkey;
    }
}

