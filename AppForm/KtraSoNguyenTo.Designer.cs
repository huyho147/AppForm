namespace AppForm
{
    partial class KtraSoNguyenTo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            KtraTxt = new TextBox();
            SNhonNTxt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            SoSNTnhoNTxt = new TextBox();
            TongSNTTxt = new TextBox();
            SoNCcB = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(185, 29);
            label1.Name = "label1";
            label1.Size = new Size(358, 33);
            label1.TabIndex = 0;
            label1.Text = "Kiểm tra và tìm số nguyên tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 1;
            label2.Text = "Nhập số n:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(171, 19);
            label3.TabIndex = 1;
            label3.Text = "Kiểm tra số nguyên tố:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(187, 19);
            label4.TabIndex = 1;
            label4.Text = "Số nguyên tố nhỏ hơn n:";
            // 
            // KtraTxt
            // 
            KtraTxt.Font = new Font("Tahoma", 12F);
            KtraTxt.Location = new Point(253, 97);
            KtraTxt.Name = "KtraTxt";
            KtraTxt.Size = new Size(390, 27);
            KtraTxt.TabIndex = 2;
            // 
            // SNhonNTxt
            // 
            SNhonNTxt.Font = new Font("Tahoma", 12F);
            SNhonNTxt.Location = new Point(253, 130);
            SNhonNTxt.Name = "SNhonNTxt";
            SNhonNTxt.Size = new Size(390, 27);
            SNhonNTxt.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F);
            button1.Location = new Point(253, 241);
            button1.Name = "button1";
            button1.Size = new Size(106, 40);
            button1.TabIndex = 4;
            button1.Text = "Kiểm tra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F);
            button2.Location = new Point(537, 241);
            button2.Name = "button2";
            button2.Size = new Size(106, 40);
            button2.TabIndex = 4;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(12, 171);
            label5.Name = "label5";
            label5.Size = new Size(222, 19);
            label5.TabIndex = 1;
            label5.Text = "Có bao nhiêu SNT nhỏ hơn n:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(12, 204);
            label6.Name = "label6";
            label6.Size = new Size(192, 19);
            label6.TabIndex = 1;
            label6.Text = "Tổng các SNT nhỏ hơn n:";
            // 
            // SoSNTnhoNTxt
            // 
            SoSNTnhoNTxt.Font = new Font("Tahoma", 12F);
            SoSNTnhoNTxt.Location = new Point(253, 163);
            SoSNTnhoNTxt.Name = "SoSNTnhoNTxt";
            SoSNTnhoNTxt.Size = new Size(390, 27);
            SoSNTnhoNTxt.TabIndex = 2;
            // 
            // TongSNTTxt
            // 
            TongSNTTxt.Font = new Font("Tahoma", 12F);
            TongSNTTxt.Location = new Point(253, 196);
            TongSNTTxt.Name = "TongSNTTxt";
            TongSNTTxt.Size = new Size(390, 27);
            TongSNTTxt.TabIndex = 2;
            // 
            // SoNCcB
            // 
            SoNCcB.Font = new Font("Tahoma", 12F);
            SoNCcB.FormattingEnabled = true;
            SoNCcB.Location = new Point(253, 65);
            SoNCcB.MaxDropDownItems = 100;
            SoNCcB.Name = "SoNCcB";
            SoNCcB.Size = new Size(152, 27);
            SoNCcB.TabIndex = 5;
            SoNCcB.SelectedIndexChanged += SoNCcB_SelectedIndexChanged;
            // 
            // KtraSoNguyenTo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 346);
            Controls.Add(SoNCcB);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TongSNTTxt);
            Controls.Add(SoSNTnhoNTxt);
            Controls.Add(SNhonNTxt);
            Controls.Add(KtraTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KtraSoNguyenTo";
            Text = "KtraSoNguyenTo";
            Load += KtraSoNguyenTo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox KtraTxt;
        private TextBox SNhonNTxt;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox SoSNTnhoNTxt;
        private TextBox TongSNTTxt;
        private ComboBox SoNCcB;
    }
}