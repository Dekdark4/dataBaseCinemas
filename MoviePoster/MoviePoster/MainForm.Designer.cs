namespace MoviePoster
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowCinemas = new System.Windows.Forms.Button();
            this.btnShowMovies = new System.Windows.Forms.Button();
            this.btnShowCartoons = new System.Windows.Forms.Button();
            this.btnShowSessions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnShowCinemas
            // 
            this.btnShowCinemas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCinemas.Location = new System.Drawing.Point(17, 48);
            this.btnShowCinemas.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowCinemas.Name = "btnShowCinemas";
            this.btnShowCinemas.Size = new System.Drawing.Size(477, 50);
            this.btnShowCinemas.TabIndex = 0;
            this.btnShowCinemas.Text = "Cinemas";
            this.btnShowCinemas.UseVisualStyleBackColor = true;
            this.btnShowCinemas.Click += new System.EventHandler(this.btnShowCinemas_Click);
            // 
            // btnShowMovies
            // 
            this.btnShowMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMovies.Location = new System.Drawing.Point(17, 128);
            this.btnShowMovies.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowMovies.Name = "btnShowMovies";
            this.btnShowMovies.Size = new System.Drawing.Size(477, 50);
            this.btnShowMovies.TabIndex = 1;
            this.btnShowMovies.Text = "Movies";
            this.btnShowMovies.UseVisualStyleBackColor = true;
            this.btnShowMovies.Click += new System.EventHandler(this.btnShowMovies_Click);
            // 
            // btnShowCartoons
            // 
            this.btnShowCartoons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCartoons.Location = new System.Drawing.Point(17, 208);
            this.btnShowCartoons.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowCartoons.Name = "btnShowCartoons";
            this.btnShowCartoons.Size = new System.Drawing.Size(477, 50);
            this.btnShowCartoons.TabIndex = 2;
            this.btnShowCartoons.Text = "Cartoons";
            this.btnShowCartoons.UseVisualStyleBackColor = true;
            this.btnShowCartoons.Click += new System.EventHandler(this.btnShowCartoons_Click);
            // 
            // btnShowSessions
            // 
            this.btnShowSessions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSessions.Location = new System.Drawing.Point(17, 288);
            this.btnShowSessions.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowSessions.Name = "btnShowSessions";
            this.btnShowSessions.Size = new System.Drawing.Size(477, 50);
            this.btnShowSessions.TabIndex = 3;
            this.btnShowSessions.Text = "Sessions";
            this.btnShowSessions.UseVisualStyleBackColor = true;
            this.btnShowSessions.Click += new System.EventHandler(this.btnShowSessions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 374);
            this.Controls.Add(this.btnShowSessions);
            this.Controls.Add(this.btnShowCartoons);
            this.Controls.Add(this.btnShowMovies);
            this.Controls.Add(this.btnShowCinemas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Киноафиша";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnShowCinemas;
        private System.Windows.Forms.Button btnShowMovies;
        private System.Windows.Forms.Button btnShowCartoons;
        private System.Windows.Forms.Button btnShowSessions;
    }
}

