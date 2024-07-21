namespace MoviePoster
{
    partial class CartoonsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartoonsForm));
            this.dgCartoons = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCartoonGenre = new System.Windows.Forms.TextBox();
            this.tbCartoonLength = new System.Windows.Forms.TextBox();
            this.tbCartoonCountry = new System.Windows.Forms.TextBox();
            this.tbCartoonAge = new System.Windows.Forms.TextBox();
            this.tbCartoonYear = new System.Windows.Forms.TextBox();
            this.tbCartoonDirector = new System.Windows.Forms.TextBox();
            this.tbCartoonTitle = new System.Windows.Forms.TextBox();
            this.btnCartoonRefresh = new System.Windows.Forms.Button();
            this.btnCartoonRemove = new System.Windows.Forms.Button();
            this.btnCartoonEdit = new System.Windows.Forms.Button();
            this.btnCartoonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCartoons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCartoons
            // 
            this.dgCartoons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCartoons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgCartoons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCartoons.Location = new System.Drawing.Point(12, 12);
            this.dgCartoons.Name = "dgCartoons";
            this.dgCartoons.Size = new System.Drawing.Size(1890, 773);
            this.dgCartoons.TabIndex = 126;
            this.dgCartoons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCartoons_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 999);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 138;
            this.label4.Text = "Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(618, 947);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 140;
            this.label7.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 947);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 139;
            this.label3.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(618, 895);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 142;
            this.label6.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 895);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 141;
            this.label2.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(618, 843);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 143;
            this.label5.Text = "Director";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 843);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 144;
            this.label1.Text = "Title";
            // 
            // tbCartoonGenre
            // 
            this.tbCartoonGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCartoonGenre.Location = new System.Drawing.Point(156, 996);
            this.tbCartoonGenre.Name = "tbCartoonGenre";
            this.tbCartoonGenre.Size = new System.Drawing.Size(413, 26);
            this.tbCartoonGenre.TabIndex = 3;
            // 
            // tbCartoonLength
            // 
            this.tbCartoonLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCartoonLength.Location = new System.Drawing.Point(741, 944);
            this.tbCartoonLength.Name = "tbCartoonLength";
            this.tbCartoonLength.Size = new System.Drawing.Size(413, 26);
            this.tbCartoonLength.TabIndex = 6;
            // 
            // tbCartoonCountry
            // 
            this.tbCartoonCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCartoonCountry.Location = new System.Drawing.Point(156, 944);
            this.tbCartoonCountry.Name = "tbCartoonCountry";
            this.tbCartoonCountry.Size = new System.Drawing.Size(413, 26);
            this.tbCartoonCountry.TabIndex = 2;
            // 
            // tbCartoonAge
            // 
            this.tbCartoonAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCartoonAge.Location = new System.Drawing.Point(741, 892);
            this.tbCartoonAge.Name = "tbCartoonAge";
            this.tbCartoonAge.Size = new System.Drawing.Size(413, 26);
            this.tbCartoonAge.TabIndex = 5;
            // 
            // tbCartoonYear
            // 
            this.tbCartoonYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCartoonYear.Location = new System.Drawing.Point(156, 892);
            this.tbCartoonYear.Name = "tbCartoonYear";
            this.tbCartoonYear.Size = new System.Drawing.Size(413, 26);
            this.tbCartoonYear.TabIndex = 1;
            // 
            // tbCartoonDirector
            // 
            this.tbCartoonDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCartoonDirector.Location = new System.Drawing.Point(741, 840);
            this.tbCartoonDirector.Name = "tbCartoonDirector";
            this.tbCartoonDirector.Size = new System.Drawing.Size(413, 26);
            this.tbCartoonDirector.TabIndex = 4;
            // 
            // tbCartoonTitle
            // 
            this.tbCartoonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCartoonTitle.Location = new System.Drawing.Point(156, 840);
            this.tbCartoonTitle.Name = "tbCartoonTitle";
            this.tbCartoonTitle.Size = new System.Drawing.Size(413, 26);
            this.tbCartoonTitle.TabIndex = 0;
            // 
            // btnCartoonRefresh
            // 
            this.btnCartoonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartoonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCartoonRefresh.Location = new System.Drawing.Point(1187, 993);
            this.btnCartoonRefresh.Name = "btnCartoonRefresh";
            this.btnCartoonRefresh.Size = new System.Drawing.Size(93, 26);
            this.btnCartoonRefresh.TabIndex = 10;
            this.btnCartoonRefresh.Text = "Refresh";
            this.btnCartoonRefresh.UseVisualStyleBackColor = true;
            this.btnCartoonRefresh.Click += new System.EventHandler(this.btnCartoonRefresh_Click);
            // 
            // btnCartoonRemove
            // 
            this.btnCartoonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartoonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCartoonRemove.Location = new System.Drawing.Point(1187, 944);
            this.btnCartoonRemove.Name = "btnCartoonRemove";
            this.btnCartoonRemove.Size = new System.Drawing.Size(93, 26);
            this.btnCartoonRemove.TabIndex = 9;
            this.btnCartoonRemove.Text = "Remove";
            this.btnCartoonRemove.UseVisualStyleBackColor = true;
            this.btnCartoonRemove.Click += new System.EventHandler(this.btnCartoonRemove_Click);
            // 
            // btnCartoonEdit
            // 
            this.btnCartoonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartoonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCartoonEdit.Location = new System.Drawing.Point(1187, 892);
            this.btnCartoonEdit.Name = "btnCartoonEdit";
            this.btnCartoonEdit.Size = new System.Drawing.Size(93, 26);
            this.btnCartoonEdit.TabIndex = 8;
            this.btnCartoonEdit.Text = "Edit";
            this.btnCartoonEdit.UseVisualStyleBackColor = true;
            this.btnCartoonEdit.Click += new System.EventHandler(this.btnCartoonEdit_Click);
            // 
            // btnCartoonAdd
            // 
            this.btnCartoonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCartoonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCartoonAdd.Location = new System.Drawing.Point(1187, 840);
            this.btnCartoonAdd.Name = "btnCartoonAdd";
            this.btnCartoonAdd.Size = new System.Drawing.Size(93, 26);
            this.btnCartoonAdd.TabIndex = 7;
            this.btnCartoonAdd.Text = "Add";
            this.btnCartoonAdd.UseVisualStyleBackColor = true;
            this.btnCartoonAdd.Click += new System.EventHandler(this.btnCartoonAdd_Click);
            // 
            // CartoonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1041);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCartoonGenre);
            this.Controls.Add(this.tbCartoonLength);
            this.Controls.Add(this.tbCartoonCountry);
            this.Controls.Add(this.tbCartoonAge);
            this.Controls.Add(this.tbCartoonYear);
            this.Controls.Add(this.tbCartoonDirector);
            this.Controls.Add(this.tbCartoonTitle);
            this.Controls.Add(this.btnCartoonRefresh);
            this.Controls.Add(this.btnCartoonRemove);
            this.Controls.Add(this.btnCartoonEdit);
            this.Controls.Add(this.btnCartoonAdd);
            this.Controls.Add(this.dgCartoons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "CartoonsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartoons";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CartoonsForm_FormClosing);
            this.Load += new System.EventHandler(this.CartoonsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCartoons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCartoons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCartoonGenre;
        private System.Windows.Forms.TextBox tbCartoonLength;
        private System.Windows.Forms.TextBox tbCartoonCountry;
        private System.Windows.Forms.TextBox tbCartoonAge;
        private System.Windows.Forms.TextBox tbCartoonYear;
        private System.Windows.Forms.TextBox tbCartoonDirector;
        private System.Windows.Forms.TextBox tbCartoonTitle;
        private System.Windows.Forms.Button btnCartoonRefresh;
        private System.Windows.Forms.Button btnCartoonRemove;
        private System.Windows.Forms.Button btnCartoonEdit;
        private System.Windows.Forms.Button btnCartoonAdd;
    }
}