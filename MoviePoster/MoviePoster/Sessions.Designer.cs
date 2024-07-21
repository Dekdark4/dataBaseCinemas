namespace MoviePoster
{
    partial class SessionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionsForm));
            this.cbMovies = new System.Windows.Forms.ComboBox();
            this.cbCinemas = new System.Windows.Forms.ComboBox();
            this.dtDateTime = new System.Windows.Forms.DateTimePicker();
            this.dgSessions = new System.Windows.Forms.DataGridView();
            this.btnSessionAdd = new System.Windows.Forms.Button();
            this.cbCartoons = new System.Windows.Forms.ComboBox();
            this.checkBoxCartoons = new System.Windows.Forms.CheckBox();
            this.btnSessionRefresh = new System.Windows.Forms.Button();
            this.btnSessionRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMovies
            // 
            this.cbMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMovies.FormattingEnabled = true;
            this.cbMovies.Location = new System.Drawing.Point(461, 874);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(264, 28);
            this.cbMovies.TabIndex = 0;
            // 
            // cbCinemas
            // 
            this.cbCinemas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCinemas.FormattingEnabled = true;
            this.cbCinemas.Location = new System.Drawing.Point(63, 875);
            this.cbCinemas.Name = "cbCinemas";
            this.cbCinemas.Size = new System.Drawing.Size(264, 28);
            this.cbCinemas.TabIndex = 0;
            // 
            // dtDateTime
            // 
            this.dtDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtDateTime.Location = new System.Drawing.Point(850, 876);
            this.dtDateTime.Name = "dtDateTime";
            this.dtDateTime.Size = new System.Drawing.Size(381, 26);
            this.dtDateTime.TabIndex = 1;
            // 
            // dgSessions
            // 
            this.dgSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSessions.Location = new System.Drawing.Point(12, 12);
            this.dgSessions.Name = "dgSessions";
            this.dgSessions.Size = new System.Drawing.Size(1880, 773);
            this.dgSessions.TabIndex = 114;
            // 
            // btnSessionAdd
            // 
            this.btnSessionAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSessionAdd.Location = new System.Drawing.Point(850, 952);
            this.btnSessionAdd.Name = "btnSessionAdd";
            this.btnSessionAdd.Size = new System.Drawing.Size(123, 36);
            this.btnSessionAdd.TabIndex = 115;
            this.btnSessionAdd.Text = "Add";
            this.btnSessionAdd.UseVisualStyleBackColor = true;
            this.btnSessionAdd.Click += new System.EventHandler(this.btnSessionAdd_Click);
            // 
            // cbCartoons
            // 
            this.cbCartoons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCartoons.Enabled = false;
            this.cbCartoons.FormattingEnabled = true;
            this.cbCartoons.Location = new System.Drawing.Point(461, 874);
            this.cbCartoons.Name = "cbCartoons";
            this.cbCartoons.Size = new System.Drawing.Size(264, 28);
            this.cbCartoons.TabIndex = 0;
            this.cbCartoons.Visible = false;
            // 
            // checkBoxCartoons
            // 
            this.checkBoxCartoons.AutoSize = true;
            this.checkBoxCartoons.Location = new System.Drawing.Point(540, 908);
            this.checkBoxCartoons.Name = "checkBoxCartoons";
            this.checkBoxCartoons.Size = new System.Drawing.Size(101, 24);
            this.checkBoxCartoons.TabIndex = 116;
            this.checkBoxCartoons.Text = "Cartoons";
            this.checkBoxCartoons.UseVisualStyleBackColor = true;
            this.checkBoxCartoons.CheckedChanged += new System.EventHandler(this.checkBoxCartoons_CheckedChanged);
            // 
            // btnSessionRefresh
            // 
            this.btnSessionRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSessionRefresh.Location = new System.Drawing.Point(1108, 952);
            this.btnSessionRefresh.Name = "btnSessionRefresh";
            this.btnSessionRefresh.Size = new System.Drawing.Size(123, 36);
            this.btnSessionRefresh.TabIndex = 115;
            this.btnSessionRefresh.Text = "Refresh";
            this.btnSessionRefresh.UseVisualStyleBackColor = true;
            this.btnSessionRefresh.Click += new System.EventHandler(this.btnSessionRefresh_Click);
            // 
            // btnSessionRemove
            // 
            this.btnSessionRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSessionRemove.Location = new System.Drawing.Point(979, 952);
            this.btnSessionRemove.Name = "btnSessionRemove";
            this.btnSessionRemove.Size = new System.Drawing.Size(123, 36);
            this.btnSessionRemove.TabIndex = 115;
            this.btnSessionRemove.Text = "Remove";
            this.btnSessionRemove.UseVisualStyleBackColor = true;
            this.btnSessionRemove.Click += new System.EventHandler(this.btnSessionRemove_Click);
            // 
            // SessionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.checkBoxCartoons);
            this.Controls.Add(this.btnSessionRefresh);
            this.Controls.Add(this.btnSessionRemove);
            this.Controls.Add(this.btnSessionAdd);
            this.Controls.Add(this.dgSessions);
            this.Controls.Add(this.dtDateTime);
            this.Controls.Add(this.cbCinemas);
            this.Controls.Add(this.cbCartoons);
            this.Controls.Add(this.cbMovies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SessionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrivateSessionsForm_FormClosing);
            this.Load += new System.EventHandler(this.PrivateSessionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMovies;
        private System.Windows.Forms.ComboBox cbCinemas;
        private System.Windows.Forms.DateTimePicker dtDateTime;
        private System.Windows.Forms.DataGridView dgSessions;
        private System.Windows.Forms.Button btnSessionAdd;
        private System.Windows.Forms.ComboBox cbCartoons;
        private System.Windows.Forms.CheckBox checkBoxCartoons;
        private System.Windows.Forms.Button btnSessionRefresh;
        private System.Windows.Forms.Button btnSessionRemove;
    }
}