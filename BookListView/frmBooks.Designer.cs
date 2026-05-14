namespace BookListView
{
    partial class frmBooks
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.pnlTools = new System.Windows.Forms.Panel();
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.imgS = new System.Windows.Forms.ImageList(this.components);
            this.pnlView = new System.Windows.Forms.Panel();
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.pnlTools.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.grpView.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlTools.Controls.Add(this.grpBorrow);
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTools.Location = new System.Drawing.Point(583, 10);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(381, 613);
            this.pnlTools.TabIndex = 2;
            // 
            // grpBorrow
            // 
            this.grpBorrow.BackColor = System.Drawing.Color.SteelBlue;
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBorrow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpBorrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBorrow.Location = new System.Drawing.Point(0, 92);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Padding = new System.Windows.Forms.Padding(5);
            this.grpBorrow.Size = new System.Drawing.Size(381, 521);
            this.grpBorrow.TabIndex = 2;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單：";
            // 
            // lstBorrow
            // 
            this.lstBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 25;
            this.lstBorrow.Location = new System.Drawing.Point(5, 32);
            this.lstBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(371, 484);
            this.lstBorrow.TabIndex = 0;
            this.lstBorrow.DoubleClick += new System.EventHandler(this.lstBorrow_DoubleClick);
            // 
            // grpView
            // 
            this.grpView.BackColor = System.Drawing.Color.SteelBlue;
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpView.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpView.Location = new System.Drawing.Point(0, 0);
            this.grpView.Margin = new System.Windows.Forms.Padding(4);
            this.grpView.Name = "grpView";
            this.grpView.Padding = new System.Windows.Forms.Padding(4);
            this.grpView.Size = new System.Drawing.Size(381, 92);
            this.grpView.TabIndex = 1;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式：";
            // 
            // cmbView
            // 
            this.cmbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(8, 35);
            this.cmbView.Margin = new System.Windows.Forms.Padding(4);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(364, 33);
            this.cmbView.TabIndex = 0;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // imgL
            // 
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "1.png");
            this.imgL.Images.SetKeyName(1, "2.png");
            this.imgL.Images.SetKeyName(2, "3.png");
            this.imgL.Images.SetKeyName(3, "4.png");
            this.imgL.Images.SetKeyName(4, "5.png");
            this.imgL.Images.SetKeyName(5, "6.png");
            this.imgL.Images.SetKeyName(6, "7.png");
            this.imgL.Images.SetKeyName(7, "8.png");
            this.imgL.Images.SetKeyName(8, "9.png");
            this.imgL.Images.SetKeyName(9, "10.png");
            this.imgL.Images.SetKeyName(10, "11.png");
            this.imgL.Images.SetKeyName(11, "12.png");
            this.imgL.Images.SetKeyName(12, "13.png");
            // 
            // imgS
            // 
            this.imgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgS.ImageStream")));
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgS.Images.SetKeyName(0, "1.png");
            this.imgS.Images.SetKeyName(1, "2.png");
            this.imgS.Images.SetKeyName(2, "3.png");
            this.imgS.Images.SetKeyName(3, "4.png");
            this.imgS.Images.SetKeyName(4, "5.png");
            this.imgS.Images.SetKeyName(5, "6.png");
            this.imgS.Images.SetKeyName(6, "7.png");
            this.imgS.Images.SetKeyName(7, "8.png");
            this.imgS.Images.SetKeyName(8, "9.png");
            this.imgS.Images.SetKeyName(9, "10.png");
            this.imgS.Images.SetKeyName(10, "11.png");
            this.imgS.Images.SetKeyName(11, "12.png");
            this.imgS.Images.SetKeyName(12, "13.png");
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlView.Controls.Add(this.lvwBooks);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(10, 10);
            this.pnlView.Margin = new System.Windows.Forms.Padding(5);
            this.pnlView.Name = "pnlView";
            this.pnlView.Padding = new System.Windows.Forms.Padding(5);
            this.pnlView.Size = new System.Drawing.Size(573, 613);
            this.pnlView.TabIndex = 4;
            // 
            // lvwBooks
            // 
            this.lvwBooks.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvwBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.imgL;
            this.lvwBooks.Location = new System.Drawing.Point(5, 5);
            this.lvwBooks.Margin = new System.Windows.Forms.Padding(5);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(563, 603);
            this.lvwBooks.SmallImageList = this.imgS;
            this.lvwBooks.TabIndex = 7;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.ItemActivate += new System.EventHandler(this.lvwBooks_ItemActivate);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(974, 633);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlTools);
            this.Name = "frmBooks";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖書管理程式";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.pnlTools.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.grpView.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ImageList imgS;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.ListView lvwBooks;
    }
}

