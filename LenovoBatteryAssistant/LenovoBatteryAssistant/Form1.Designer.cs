namespace LenovoBatteryAssistant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Start = new System.Windows.Forms.Label();
            this.label_Stop = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_Start = new MetroFramework.Controls.MetroCheckBox();
            this.trackBar_Start = new MetroFramework.Controls.MetroTrackBar();
            this.checkBox_Stop = new MetroFramework.Controls.MetroCheckBox();
            this.trackBar_Stop = new MetroFramework.Controls.MetroTrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Start
            // 
            this.label_Start.AutoSize = true;
            this.label_Start.Location = new System.Drawing.Point(511, 16);
            this.label_Start.Name = "label_Start";
            this.label_Start.Size = new System.Drawing.Size(35, 13);
            this.label_Start.TabIndex = 2;
            this.label_Start.Text = "label1";
            // 
            // label_Stop
            // 
            this.label_Stop.AutoSize = true;
            this.label_Stop.Location = new System.Drawing.Point(511, 14);
            this.label_Stop.Name = "label_Stop";
            this.label_Stop.Size = new System.Drawing.Size(35, 13);
            this.label_Stop.TabIndex = 5;
            this.label_Stop.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_Start
            // 
            this.checkBox_Start.AutoSize = true;
            this.checkBox_Start.Location = new System.Drawing.Point(12, 14);
            this.checkBox_Start.Name = "checkBox_Start";
            this.checkBox_Start.Size = new System.Drawing.Size(144, 15);
            this.checkBox_Start.TabIndex = 7;
            this.checkBox_Start.Text = "Custom start threshold";
            this.checkBox_Start.UseVisualStyleBackColor = true;
            this.checkBox_Start.CheckedChanged += new System.EventHandler(this.checkBox_Start_CheckedChanged);
            // 
            // trackBar_Start
            // 
            this.trackBar_Start.BackColor = System.Drawing.Color.Transparent;
            this.trackBar_Start.Location = new System.Drawing.Point(12, 40);
            this.trackBar_Start.Minimum = 10;
            this.trackBar_Start.Name = "trackBar_Start";
            this.trackBar_Start.Size = new System.Drawing.Size(534, 23);
            this.trackBar_Start.TabIndex = 8;
            this.trackBar_Start.Text = "metroTrackBar1";
            this.trackBar_Start.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar_Start_Scroll);
            // 
            // checkBox_Stop
            // 
            this.checkBox_Stop.AutoSize = true;
            this.checkBox_Stop.Location = new System.Drawing.Point(12, 14);
            this.checkBox_Stop.Name = "checkBox_Stop";
            this.checkBox_Stop.Size = new System.Drawing.Size(137, 15);
            this.checkBox_Stop.TabIndex = 9;
            this.checkBox_Stop.Text = "Custom stop thresold";
            this.checkBox_Stop.UseVisualStyleBackColor = true;
            this.checkBox_Stop.CheckedChanged += new System.EventHandler(this.checkBox_Stop_CheckedChanged);
            // 
            // trackBar_Stop
            // 
            this.trackBar_Stop.BackColor = System.Drawing.Color.Transparent;
            this.trackBar_Stop.Location = new System.Drawing.Point(12, 41);
            this.trackBar_Stop.Minimum = 11;
            this.trackBar_Stop.Name = "trackBar_Stop";
            this.trackBar_Stop.Size = new System.Drawing.Size(534, 23);
            this.trackBar_Stop.TabIndex = 10;
            this.trackBar_Stop.Text = "metroTrackBar2";
            this.trackBar_Stop.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar_Stop_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(585, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.label_Start);
            this.metroPanel1.Controls.Add(this.checkBox_Start);
            this.metroPanel1.Controls.Add(this.trackBar_Start);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(138, 149);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(563, 73);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.checkBox_Stop);
            this.metroPanel2.Controls.Add(this.trackBar_Stop);
            this.metroPanel2.Controls.Add(this.label_Stop);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(138, 241);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(563, 75);
            this.metroPanel2.TabIndex = 13;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 349);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "                Lenovo Battery Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Start;
        private System.Windows.Forms.Label label_Stop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroCheckBox checkBox_Start;
        private MetroFramework.Controls.MetroTrackBar trackBar_Start;
        private MetroFramework.Controls.MetroCheckBox checkBox_Stop;
        private MetroFramework.Controls.MetroTrackBar trackBar_Stop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}

