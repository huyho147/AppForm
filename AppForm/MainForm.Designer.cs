namespace AppForm
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            tiệnÍchToolStripMenuItem = new ToolStripMenuItem();
            tínhPhươngTrìnhBậc2ToolStripMenuItem = new ToolStripMenuItem();
            đồngHồĐếmGiờToolStripMenuItem = new ToolStripMenuItem();
            kiểmTraSốNguyênTốToolStripMenuItem = new ToolStripMenuItem();
            tínhToánTrênDãySốToolStripMenuItem = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tahoma", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiệnÍchToolStripMenuItem, hỗTrợToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1029, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiệnÍchToolStripMenuItem
            // 
            tiệnÍchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tínhPhươngTrìnhBậc2ToolStripMenuItem, đồngHồĐếmGiờToolStripMenuItem, kiểmTraSốNguyênTốToolStripMenuItem, tínhToánTrênDãySốToolStripMenuItem });
            tiệnÍchToolStripMenuItem.Font = new Font("Tahoma", 12F);
            tiệnÍchToolStripMenuItem.Name = "tiệnÍchToolStripMenuItem";
            tiệnÍchToolStripMenuItem.Size = new Size(77, 23);
            tiệnÍchToolStripMenuItem.Text = "Tiện ích";
            // 
            // tínhPhươngTrìnhBậc2ToolStripMenuItem
            // 
            tínhPhươngTrìnhBậc2ToolStripMenuItem.Name = "tínhPhươngTrìnhBậc2ToolStripMenuItem";
            tínhPhươngTrìnhBậc2ToolStripMenuItem.Size = new Size(251, 24);
            tínhPhươngTrìnhBậc2ToolStripMenuItem.Text = "Tính phương trình bậc 2";
            tínhPhươngTrìnhBậc2ToolStripMenuItem.Click += tínhPhươngTrìnhBậc2ToolStripMenuItem_Click;
            // 
            // đồngHồĐếmGiờToolStripMenuItem
            // 
            đồngHồĐếmGiờToolStripMenuItem.Name = "đồngHồĐếmGiờToolStripMenuItem";
            đồngHồĐếmGiờToolStripMenuItem.Size = new Size(251, 24);
            đồngHồĐếmGiờToolStripMenuItem.Text = "Đồng hồ đếm giờ";
            đồngHồĐếmGiờToolStripMenuItem.Click += đồngHồĐếmGiờToolStripMenuItem_Click;
            // 
            // kiểmTraSốNguyênTốToolStripMenuItem
            // 
            kiểmTraSốNguyênTốToolStripMenuItem.Name = "kiểmTraSốNguyênTốToolStripMenuItem";
            kiểmTraSốNguyênTốToolStripMenuItem.Size = new Size(251, 24);
            kiểmTraSốNguyênTốToolStripMenuItem.Text = "Kiểm tra số nguyên tố";
            kiểmTraSốNguyênTốToolStripMenuItem.Click += kiểmTraSốNguyênTốToolStripMenuItem_Click;
            // 
            // tínhToánTrênDãySốToolStripMenuItem
            // 
            tínhToánTrênDãySốToolStripMenuItem.Name = "tínhToánTrênDãySốToolStripMenuItem";
            tínhToánTrênDãySốToolStripMenuItem.Size = new Size(251, 24);
            tínhToánTrênDãySốToolStripMenuItem.Text = "Tính toán trên dãy số";
            tínhToánTrênDãySốToolStripMenuItem.Click += tínhToánTrênDãySốToolStripMenuItem_Click;
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(66, 23);
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(119, 24);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 570);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 12F);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Chương trình tiện ích";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiệnÍchToolStripMenuItem;
        private ToolStripMenuItem tínhPhươngTrìnhBậc2ToolStripMenuItem;
        private ToolStripMenuItem hỗTrợToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem đồngHồĐếmGiờToolStripMenuItem;
        private ToolStripMenuItem kiểmTraSốNguyênTốToolStripMenuItem;
        private ToolStripMenuItem tínhToánTrênDãySốToolStripMenuItem;
    }
}
