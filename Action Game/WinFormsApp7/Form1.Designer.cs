namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.HPB = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Player.Location = new System.Drawing.Point(225, 367);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 100);
            this.Player.TabIndex = 0;
            this.Player.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 100);
            this.label2.TabIndex = 2;
            this.label2.Tag = "Enemy";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseHover);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 14);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 34);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(508, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Enemy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(617, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 154);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "Enemy";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 100);
            this.label1.TabIndex = 2;
            this.label1.Tag = "Enemy";
            this.label1.MouseEnter += new System.EventHandler(this.label2_MouseHover);
            this.label1.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(0, 14);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 34);
            this.progressBar2.TabIndex = 5;
            this.progressBar2.Value = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.progressBar3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(726, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 154);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "Enemy";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 100);
            this.label3.TabIndex = 2;
            this.label3.Tag = "Enemy";
            this.label3.MouseEnter += new System.EventHandler(this.label2_MouseHover);
            this.label3.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(0, 14);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 34);
            this.progressBar3.TabIndex = 5;
            this.progressBar3.Value = 100;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.progressBar4);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(723, -3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 154);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "Enemy";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(0, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 100);
            this.label4.TabIndex = 2;
            this.label4.Tag = "Enemy";
            this.label4.MouseEnter += new System.EventHandler(this.label2_MouseHover);
            this.label4.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(0, 14);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(100, 34);
            this.progressBar4.TabIndex = 5;
            this.progressBar4.Value = 100;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.progressBar5);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(835, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(103, 154);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Tag = "Enemy";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 100);
            this.label5.TabIndex = 2;
            this.label5.Tag = "Enemy";
            this.label5.MouseEnter += new System.EventHandler(this.label2_MouseHover);
            this.label5.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(0, 14);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(100, 34);
            this.progressBar5.TabIndex = 5;
            this.progressBar5.Value = 100;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.progressBar6);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Location = new System.Drawing.Point(944, 140);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(103, 154);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Tag = "Enemy";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 100);
            this.label6.TabIndex = 2;
            this.label6.Tag = "Enemy";
            this.label6.MouseEnter += new System.EventHandler(this.label2_MouseHover);
            this.label6.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(0, 14);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(100, 34);
            this.progressBar6.TabIndex = 5;
            this.progressBar6.Value = 100;
            // 
            // HPB
            // 
            this.HPB.Location = new System.Drawing.Point(225, 330);
            this.HPB.Name = "HPB";
            this.HPB.Size = new System.Drawing.Size(100, 34);
            this.HPB.TabIndex = 6;
            this.HPB.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.HPB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label2;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private ProgressBar progressBar2;
        private GroupBox groupBox3;
        private Label label3;
        private ProgressBar progressBar3;
        private GroupBox groupBox4;
        private Label label4;
        private ProgressBar progressBar4;
        private GroupBox groupBox5;
        private Label label5;
        private ProgressBar progressBar5;
        private GroupBox groupBox6;
        private Label label6;
        private ProgressBar progressBar6;
        private ProgressBar HPB;
    }
}