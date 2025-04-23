namespace Näyttötyö_peli
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            Keksit = new Label();
            KauppaBtn = new Button();
            panel1 = new Panel();
            BoostLabel = new Label();
            Boostbtn = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            closeBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            robotti = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            SaveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.purepng_com_cookiecookieamericandelicioussnacksweetyummybiscuit_215258865264pxyk;
            pictureBox1.Location = new Point(212, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.DoubleClick += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Keksit
            // 
            Keksit.BackColor = Color.Transparent;
            Keksit.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Keksit.ForeColor = Color.White;
            Keksit.Location = new Point(35, 28);
            Keksit.Name = "Keksit";
            Keksit.Size = new Size(133, 53);
            Keksit.TabIndex = 1;
            Keksit.Text = "🍪: 0";
            Keksit.Click += Keksit_Click;
            // 
            // KauppaBtn
            // 
            KauppaBtn.AutoSize = true;
            KauppaBtn.BackColor = Color.Transparent;
            KauppaBtn.Cursor = Cursors.Hand;
            KauppaBtn.FlatAppearance.BorderColor = Color.White;
            KauppaBtn.FlatStyle = FlatStyle.Flat;
            KauppaBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KauppaBtn.ForeColor = Color.White;
            KauppaBtn.Location = new Point(657, 23);
            KauppaBtn.Name = "KauppaBtn";
            KauppaBtn.Size = new Size(100, 77);
            KauppaBtn.TabIndex = 2;
            KauppaBtn.Text = "Kauppa";
            KauppaBtn.UseVisualStyleBackColor = false;
            KauppaBtn.Click += KauppaBtn_Click;
            KauppaBtn.MouseEnter += KauppaBtn_MouseEnter;
            KauppaBtn.MouseLeave += KauppaBtn_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(BoostLabel);
            panel1.Controls.Add(Boostbtn);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 452);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // BoostLabel
            // 
            BoostLabel.AutoSize = true;
            BoostLabel.Font = new Font("Segoe UI", 15F);
            BoostLabel.Location = new Point(351, 189);
            BoostLabel.Name = "BoostLabel";
            BoostLabel.Size = new Size(165, 28);
            BoostLabel.TabIndex = 11;
            BoostLabel.Text = "Autoclicker Boost";
            BoostLabel.TextAlign = ContentAlignment.TopCenter;
            BoostLabel.Visible = false;
            // 
            // Boostbtn
            // 
            Boostbtn.Location = new Point(371, 225);
            Boostbtn.Name = "Boostbtn";
            Boostbtn.Size = new Size(115, 23);
            Boostbtn.TabIndex = 10;
            Boostbtn.Text = "10,000 keksiä";
            Boostbtn.UseVisualStyleBackColor = true;
            Boostbtn.Visible = false;
            Boostbtn.Click += Boostbtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(586, 224);
            button3.Name = "button3";
            button3.Size = new Size(132, 24);
            button3.TabIndex = 9;
            button3.Text = "10,000 keksiä";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(371, 225);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 8;
            button2.Text = "100 keksiä";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(94, 225);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 7;
            button1.Text = "1000 keksiä";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Red;
            closeBtn.Font = new Font("Segoe UI", 20F);
            closeBtn.Location = new Point(704, 15);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(73, 56);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(578, 183);
            label3.Name = "label3";
            label3.Size = new Size(164, 34);
            label3.TabIndex = 5;
            label3.Text = "Auttaja robotti";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(352, 188);
            label2.Name = "label2";
            label2.Size = new Size(164, 34);
            label2.TabIndex = 4;
            label2.Text = "Auto clicker";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(75, 188);
            label1.Name = "label1";
            label1.Size = new Size(164, 34);
            label1.TabIndex = 3;
            label1.Text = "Keksi kerroin +1";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.pngtree_chatbot_icon_chat_bot_robot_png_image_4841963;
            pictureBox4.Location = new Point(598, 64);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 121);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.Update_PNG_Image;
            pictureBox3.Location = new Point(94, 59);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.hands_click_png_icon_5;
            pictureBox2.Location = new Point(371, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.pngtree_chatbot_icon_chat_bot_robot_png_image_4841963;
            pictureBox5.Location = new Point(657, 157);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(77, 79);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(653, 242);
            button4.Name = "button4";
            button4.Size = new Size(104, 41);
            button4.TabIndex = 5;
            button4.Text = "Käynnistä Robotti";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // robotti
            // 
            robotti.Interval = 30000;
            robotti.Tick += robotti_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(KauppaBtn);
            panel2.Controls.Add(Keksit);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 452);
            panel2.TabIndex = 12;
            // 
            // SaveBtn
            // 
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.Location = new Point(23, 415);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Keksit;
        private Button KauppaBtn;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button closeBtn;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label BoostLabel;
        private Button Boostbtn;
        private PictureBox pictureBox5;
        private Button button4;
        private System.Windows.Forms.Timer robotti;
        private Panel panel2;
        private Button SaveBtn;
    }
}
