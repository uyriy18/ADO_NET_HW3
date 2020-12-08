namespace ADO_NET_HW3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbx_FirstStream = new System.Windows.Forms.TextBox();
            this.txbx_SecondStream = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.txbx_Result = new System.Windows.Forms.TextBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_Books = new System.Windows.Forms.Label();
            this.lbl_Authors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txbx_FirstStream
            // 
            this.txbx_FirstStream.Location = new System.Drawing.Point(12, 42);
            this.txbx_FirstStream.Name = "txbx_FirstStream";
            this.txbx_FirstStream.ReadOnly = true;
            this.txbx_FirstStream.Size = new System.Drawing.Size(298, 20);
            this.txbx_FirstStream.TabIndex = 0;
            // 
            // txbx_SecondStream
            // 
            this.txbx_SecondStream.Location = new System.Drawing.Point(12, 85);
            this.txbx_SecondStream.Name = "txbx_SecondStream";
            this.txbx_SecondStream.ReadOnly = true;
            this.txbx_SecondStream.Size = new System.Drawing.Size(298, 20);
            this.txbx_SecondStream.TabIndex = 1;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Crimson;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start.Location = new System.Drawing.Point(345, 42);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 63);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txbx_Result
            // 
            this.txbx_Result.Location = new System.Drawing.Point(448, 41);
            this.txbx_Result.Multiline = true;
            this.txbx_Result.Name = "txbx_Result";
            this.txbx_Result.ReadOnly = true;
            this.txbx_Result.Size = new System.Drawing.Size(179, 64);
            this.txbx_Result.TabIndex = 3;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(445, 26);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(108, 13);
            this.lbl_Info.TabIndex = 4;
            this.lbl_Info.Text = "Result of two streams";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 220);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 373);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(615, 115);
            this.dataGridView2.TabIndex = 6;
            // 
            // lbl_Books
            // 
            this.lbl_Books.AutoSize = true;
            this.lbl_Books.Location = new System.Drawing.Point(9, 114);
            this.lbl_Books.Name = "lbl_Books";
            this.lbl_Books.Size = new System.Drawing.Size(108, 13);
            this.lbl_Books.TabIndex = 7;
            this.lbl_Books.Text = "Book\'s  dataGridView";
            // 
            // lbl_Authors
            // 
            this.lbl_Authors.AutoSize = true;
            this.lbl_Authors.Location = new System.Drawing.Point(15, 356);
            this.lbl_Authors.Name = "lbl_Authors";
            this.lbl_Authors.Size = new System.Drawing.Size(114, 13);
            this.lbl_Authors.TabIndex = 8;
            this.lbl_Authors.Text = "Author\'s  dataGridView";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 489);
            this.Controls.Add(this.lbl_Authors);
            this.Controls.Add(this.lbl_Books);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.txbx_Result);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txbx_SecondStream);
            this.Controls.Add(this.txbx_FirstStream);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_FirstStream;
        private System.Windows.Forms.TextBox txbx_SecondStream;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txbx_Result;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_Books;
        private System.Windows.Forms.Label lbl_Authors;
    }
}

