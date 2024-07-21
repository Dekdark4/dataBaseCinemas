namespace MoviePoster
{
    partial class MoviesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
            this.dgMovies = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMovieGenre = new System.Windows.Forms.TextBox();
            this.tbMovieCountry = new System.Windows.Forms.TextBox();
            this.tbMovieYear = new System.Windows.Forms.TextBox();
            this.tbMovieTitle = new System.Windows.Forms.TextBox();
            this.btnMovieRefresh = new System.Windows.Forms.Button();
            this.btnMovieRemove = new System.Windows.Forms.Button();
            this.btnMovieEdit = new System.Windows.Forms.Button();
            this.btnMovieAdd = new System.Windows.Forms.Button();
            this.tbMovieDirector = new System.Windows.Forms.TextBox();
            this.tbMovieAge = new System.Windows.Forms.TextBox();
            this.tbMovieLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMovies
            // 
            this.dgMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovies.Location = new System.Drawing.Point(12, 12);
            this.dgMovies.Name = "dgMovies";
            this.dgMovies.Size = new System.Drawing.Size(1880, 773);
            this.dgMovies.TabIndex = 113;
            this.dgMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovies_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 999);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 104;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 947);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 895);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 843);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "Title";
            // 
            // tbMovieGenre
            // 
            this.tbMovieGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMovieGenre.Location = new System.Drawing.Point(156, 996);
            this.tbMovieGenre.Name = "tbMovieGenre";
            this.tbMovieGenre.Size = new System.Drawing.Size(413, 26);
            this.tbMovieGenre.TabIndex = 3;
            // 
            // tbMovieCountry
            // 
            this.tbMovieCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMovieCountry.Location = new System.Drawing.Point(156, 944);
            this.tbMovieCountry.Name = "tbMovieCountry";
            this.tbMovieCountry.Size = new System.Drawing.Size(413, 26);
            this.tbMovieCountry.TabIndex = 2;
            // 
            // tbMovieYear
            // 
            this.tbMovieYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMovieYear.Location = new System.Drawing.Point(156, 892);
            this.tbMovieYear.Name = "tbMovieYear";
            this.tbMovieYear.Size = new System.Drawing.Size(413, 26);
            this.tbMovieYear.TabIndex = 1;
            // 
            // tbMovieTitle
            // 
            this.tbMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMovieTitle.Location = new System.Drawing.Point(156, 840);
            this.tbMovieTitle.Name = "tbMovieTitle";
            this.tbMovieTitle.Size = new System.Drawing.Size(413, 26);
            this.tbMovieTitle.TabIndex = 0;
            // 
            // btnMovieRefresh
            // 
            this.btnMovieRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovieRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMovieRefresh.Location = new System.Drawing.Point(1187, 993);
            this.btnMovieRefresh.Name = "btnMovieRefresh";
            this.btnMovieRefresh.Size = new System.Drawing.Size(93, 26);
            this.btnMovieRefresh.TabIndex = 10;
            this.btnMovieRefresh.Text = "Refresh";
            this.btnMovieRefresh.UseVisualStyleBackColor = true;
            this.btnMovieRefresh.Click += new System.EventHandler(this.btnMovieRefresh_Click);
            // 
            // btnMovieRemove
            // 
            this.btnMovieRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovieRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMovieRemove.Location = new System.Drawing.Point(1187, 944);
            this.btnMovieRemove.Name = "btnMovieRemove";
            this.btnMovieRemove.Size = new System.Drawing.Size(93, 26);
            this.btnMovieRemove.TabIndex = 9;
            this.btnMovieRemove.Text = "Remove";
            this.btnMovieRemove.UseVisualStyleBackColor = true;
            this.btnMovieRemove.Click += new System.EventHandler(this.btnMovieRemove_Click);
            // 
            // btnMovieEdit
            // 
            this.btnMovieEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovieEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMovieEdit.Location = new System.Drawing.Point(1187, 892);
            this.btnMovieEdit.Name = "btnMovieEdit";
            this.btnMovieEdit.Size = new System.Drawing.Size(93, 26);
            this.btnMovieEdit.TabIndex = 8;
            this.btnMovieEdit.Text = "Edit";
            this.btnMovieEdit.UseVisualStyleBackColor = true;
            this.btnMovieEdit.Click += new System.EventHandler(this.btnMovieEdit_Click);
            // 
            // btnMovieAdd
            // 
            this.btnMovieAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovieAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMovieAdd.Location = new System.Drawing.Point(1187, 840);
            this.btnMovieAdd.Name = "btnMovieAdd";
            this.btnMovieAdd.Size = new System.Drawing.Size(93, 26);
            this.btnMovieAdd.TabIndex = 7;
            this.btnMovieAdd.Text = "Add";
            this.btnMovieAdd.UseVisualStyleBackColor = true;
            this.btnMovieAdd.Click += new System.EventHandler(this.btnMovieAdd_Click);
            // 
            // tbMovieDirector
            // 
            this.tbMovieDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMovieDirector.Location = new System.Drawing.Point(741, 840);
            this.tbMovieDirector.Name = "tbMovieDirector";
            this.tbMovieDirector.Size = new System.Drawing.Size(413, 26);
            this.tbMovieDirector.TabIndex = 4;
            // 
            // tbMovieAge
            // 
            this.tbMovieAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMovieAge.Location = new System.Drawing.Point(741, 892);
            this.tbMovieAge.Name = "tbMovieAge";
            this.tbMovieAge.Size = new System.Drawing.Size(413, 26);
            this.tbMovieAge.TabIndex = 5;
            // 
            // tbMovieLength
            // 
            this.tbMovieLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMovieLength.Location = new System.Drawing.Point(741, 944);
            this.tbMovieLength.Name = "tbMovieLength";
            this.tbMovieLength.Size = new System.Drawing.Size(413, 26);
            this.tbMovieLength.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(618, 843);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 107;
            this.label5.Text = "Director";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(618, 895);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 106;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(618, 947);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 105;
            this.label7.Text = "Length";
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dgMovies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMovieGenre);
            this.Controls.Add(this.tbMovieLength);
            this.Controls.Add(this.tbMovieCountry);
            this.Controls.Add(this.tbMovieAge);
            this.Controls.Add(this.tbMovieYear);
            this.Controls.Add(this.tbMovieDirector);
            this.Controls.Add(this.tbMovieTitle);
            this.Controls.Add(this.btnMovieRefresh);
            this.Controls.Add(this.btnMovieRemove);
            this.Controls.Add(this.btnMovieEdit);
            this.Controls.Add(this.btnMovieAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoviesForm_FormClosing);
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMovies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMovieGenre;
        private System.Windows.Forms.TextBox tbMovieCountry;
        private System.Windows.Forms.TextBox tbMovieYear;
        private System.Windows.Forms.TextBox tbMovieTitle;
        private System.Windows.Forms.Button btnMovieRefresh;
        private System.Windows.Forms.Button btnMovieRemove;
        private System.Windows.Forms.Button btnMovieEdit;
        private System.Windows.Forms.Button btnMovieAdd;
        private System.Windows.Forms.TextBox tbMovieDirector;
        private System.Windows.Forms.TextBox tbMovieAge;
        private System.Windows.Forms.TextBox tbMovieLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}