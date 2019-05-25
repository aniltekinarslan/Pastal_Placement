namespace CuttingCSharpNew
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoPlace = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_productList = new System.Windows.Forms.DataGridView();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rotated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Startcoord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_totalArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_totalPlacedArea = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_DiffTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productCount = new System.Windows.Forms.TextBox();
            this.width1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.width2 = new System.Windows.Forms.TextBox();
            this.height2 = new System.Windows.Forms.TextBox();
            this.height1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoPlace
            // 
            this.DoPlace.Location = new System.Drawing.Point(9, 10);
            this.DoPlace.Margin = new System.Windows.Forms.Padding(2);
            this.DoPlace.Name = "DoPlace";
            this.DoPlace.Size = new System.Drawing.Size(114, 61);
            this.DoPlace.TabIndex = 0;
            this.DoPlace.Text = "Yerleştir";
            this.DoPlace.UseVisualStyleBackColor = true;
            this.DoPlace.Click += new System.EventHandler(this.DoPlace_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(128, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView_productList
            // 
            this.dataGridView_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.productID,
            this.W,
            this.H,
            this.X,
            this.Y,
            this.Rotated,
            this.Startcoord});
            this.dataGridView_productList.Location = new System.Drawing.Point(643, 10);
            this.dataGridView_productList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_productList.Name = "dataGridView_productList";
            this.dataGridView_productList.RowTemplate.Height = 24;
            this.dataGridView_productList.Size = new System.Drawing.Size(520, 405);
            this.dataGridView_productList.TabIndex = 2;
            // 
            // count
            // 
            this.count.HeaderText = "#";
            this.count.Name = "count";
            this.count.Width = 50;
            // 
            // productID
            // 
            this.productID.HeaderText = "Product";
            this.productID.Name = "productID";
            // 
            // W
            // 
            this.W.HeaderText = "Width";
            this.W.Name = "W";
            this.W.Width = 75;
            // 
            // H
            // 
            this.H.HeaderText = "Height";
            this.H.Name = "H";
            this.H.Width = 75;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 80;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Width = 80;
            // 
            // Rotated
            // 
            this.Rotated.HeaderText = "Rotated";
            this.Rotated.Name = "Rotated";
            this.Rotated.Width = 80;
            // 
            // Startcoord
            // 
            this.Startcoord.HeaderText = "Startcoord";
            this.Startcoord.Name = "Startcoord";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_totalArea);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_totalPlacedArea);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_DiffTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(114, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // label_totalArea
            // 
            this.label_totalArea.AutoSize = true;
            this.label_totalArea.Location = new System.Drawing.Point(4, 112);
            this.label_totalArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalArea.Name = "label_totalArea";
            this.label_totalArea.Size = new System.Drawing.Size(10, 13);
            this.label_totalArea.TabIndex = 14;
            this.label_totalArea.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Toplam Alan:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_totalPlacedArea
            // 
            this.label_totalPlacedArea.AutoSize = true;
            this.label_totalPlacedArea.Location = new System.Drawing.Point(4, 72);
            this.label_totalPlacedArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalPlacedArea.Name = "label_totalPlacedArea";
            this.label_totalPlacedArea.Size = new System.Drawing.Size(10, 13);
            this.label_totalPlacedArea.TabIndex = 12;
            this.label_totalPlacedArea.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "En Küçük Alan:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_DiffTime
            // 
            this.label_DiffTime.AutoSize = true;
            this.label_DiffTime.Location = new System.Drawing.Point(4, 32);
            this.label_DiffTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DiffTime.Name = "label_DiffTime";
            this.label_DiffTime.Size = new System.Drawing.Size(10, 13);
            this.label_DiffTime.TabIndex = 10;
            this.label_DiffTime.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hesaplanan Süre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.height2);
            this.groupBox2.Controls.Add(this.height1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.width2);
            this.groupBox2.Controls.Add(this.width1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.productCount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(9, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 89);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametreler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Sayısı:";
            // 
            // productCount
            // 
            this.productCount.Location = new System.Drawing.Point(69, 18);
            this.productCount.MaxLength = 3;
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(30, 20);
            this.productCount.TabIndex = 1;
            this.productCount.Text = "500";
            this.productCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // width1
            // 
            this.width1.Location = new System.Drawing.Point(52, 39);
            this.width1.MaxLength = 3;
            this.width1.Name = "width1";
            this.width1.Size = new System.Drawing.Size(30, 20);
            this.width1.TabIndex = 3;
            this.width1.Text = "25";
            this.width1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Genişlik:";
            // 
            // width2
            // 
            this.width2.Location = new System.Drawing.Point(83, 39);
            this.width2.MaxLength = 3;
            this.width2.Name = "width2";
            this.width2.Size = new System.Drawing.Size(30, 20);
            this.width2.TabIndex = 4;
            this.width2.Text = "100";
            this.width2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // height2
            // 
            this.height2.Location = new System.Drawing.Point(83, 60);
            this.height2.MaxLength = 3;
            this.height2.Name = "height2";
            this.height2.Size = new System.Drawing.Size(30, 20);
            this.height2.TabIndex = 7;
            this.height2.Text = "100";
            this.height2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // height1
            // 
            this.height1.Location = new System.Drawing.Point(52, 60);
            this.height1.MaxLength = 3;
            this.height1.Name = "height1";
            this.height1.Size = new System.Drawing.Size(30, 20);
            this.height1.TabIndex = 6;
            this.height1.Text = "25";
            this.height1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yükseklik:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_productList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DoPlace);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Cutting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoPlace;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView_productList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_totalPlacedArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_DiffTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rotated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startcoord;
        private System.Windows.Forms.Label label_totalArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox productCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox width2;
        private System.Windows.Forms.TextBox width1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox height2;
        private System.Windows.Forms.TextBox height1;
        private System.Windows.Forms.Label label6;
    }
}

