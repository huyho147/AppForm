namespace AppForm
{
    partial class TinhptBac2
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
            SoATxt = new TextBox();
            SoBTxt = new TextBox();
            SoCTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            label5 = new Label();
            KetQuaLsB = new ListBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // SoATxt
            // 
            SoATxt.Font = new Font("Tahoma", 12F);
            SoATxt.Location = new Point(297, 89);
            SoATxt.Name = "SoATxt";
            SoATxt.Size = new Size(158, 27);
            SoATxt.TabIndex = 0;
            SoATxt.TextChanged += SoATxt_TextChanged;
            // 
            // SoBTxt
            // 
            SoBTxt.Font = new Font("Tahoma", 12F);
            SoBTxt.Location = new Point(297, 135);
            SoBTxt.Name = "SoBTxt";
            SoBTxt.Size = new Size(158, 27);
            SoBTxt.TabIndex = 0;
            // 
            // SoCTxt
            // 
            SoCTxt.Font = new Font("Tahoma", 12F);
            SoCTxt.Location = new Point(297, 181);
            SoCTxt.Name = "SoCTxt";
            SoCTxt.Size = new Size(158, 27);
            SoCTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(225, 97);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 1;
            label1.Text = "Số A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(225, 143);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 1;
            label2.Text = "Số B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(224, 189);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 1;
            label3.Text = "Số C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 18F);
            label4.Location = new Point(184, 32);
            label4.Name = "label4";
            label4.Size = new Size(441, 29);
            label4.TabIndex = 1;
            label4.Text = "Chương trình tính phương trình bậc 2 !!!";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F);
            button1.Location = new Point(320, 231);
            button1.Name = "button1";
            button1.Size = new Size(108, 48);
            button1.TabIndex = 2;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(496, 89);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = -100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(496, 135);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = -100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(104, 45);
            trackBar2.TabIndex = 3;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(496, 181);
            trackBar3.Maximum = 100;
            trackBar3.Minimum = -100;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(104, 45);
            trackBar3.TabIndex = 3;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(203, 296);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 4;
            label5.Text = "Kết Quả";
            // 
            // KetQuaLsB
            // 
            KetQuaLsB.Font = new Font("Tahoma", 12F);
            KetQuaLsB.FormattingEnabled = true;
            KetQuaLsB.ItemHeight = 19;
            KetQuaLsB.Location = new Point(297, 296);
            KetQuaLsB.Name = "KetQuaLsB";
            KetQuaLsB.Size = new Size(417, 99);
            KetQuaLsB.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F);
            button2.Location = new Point(496, 232);
            button2.Name = "button2";
            button2.Size = new Size(108, 48);
            button2.TabIndex = 2;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TinhptBac2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KetQuaLsB);
            Controls.Add(label5);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(SoCTxt);
            Controls.Add(SoBTxt);
            Controls.Add(SoATxt);
            Name = "TinhptBac2";
            Text = "TinhptBac2";
            Load += TinhptBac2_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox SoATxt;
        private TextBox SoBTxt;
        private TextBox SoCTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Label label5;
        private ListBox KetQuaLsB;
        private Button button2;
    }
}