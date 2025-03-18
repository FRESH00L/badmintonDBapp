namespace BazyDanychBadminton._01_Presentation
{
    partial class frmMain
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
            btn_Countries = new Button();
            btn_Players = new Button();
            btn_Tournaments = new Button();
            btn_Seasons = new Button();
            SuspendLayout();
            // 
            // btn_Countries
            // 
            btn_Countries.Location = new Point(246, 116);
            btn_Countries.Margin = new Padding(2);
            btn_Countries.Name = "btn_Countries";
            btn_Countries.Size = new Size(164, 70);
            btn_Countries.TabIndex = 0;
            btn_Countries.Text = "Countries";
            btn_Countries.UseVisualStyleBackColor = true;
            btn_Countries.Click += btn_Countries_Click;
            // 
            // btn_Players
            // 
            btn_Players.Location = new Point(246, 229);
            btn_Players.Margin = new Padding(2);
            btn_Players.Name = "btn_Players";
            btn_Players.Size = new Size(164, 70);
            btn_Players.TabIndex = 1;
            btn_Players.Text = "Players";
            btn_Players.UseVisualStyleBackColor = true;
            btn_Players.Click += btn_Players_Click;
            // 
            // btn_Tournaments
            // 
            btn_Tournaments.Location = new Point(510, 116);
            btn_Tournaments.Margin = new Padding(2);
            btn_Tournaments.Name = "btn_Tournaments";
            btn_Tournaments.Size = new Size(164, 70);
            btn_Tournaments.TabIndex = 2;
            btn_Tournaments.Text = "Tournaments";
            btn_Tournaments.UseVisualStyleBackColor = true;
            btn_Tournaments.Click += btn_Tournaments_Click;
            // 
            // btn_Seasons
            // 
            btn_Seasons.Location = new Point(510, 229);
            btn_Seasons.Name = "btn_Seasons";
            btn_Seasons.Size = new Size(164, 70);
            btn_Seasons.TabIndex = 3;
            btn_Seasons.Text = "Seasons";
            btn_Seasons.UseVisualStyleBackColor = true;
            btn_Seasons.Click += btn_Seasons_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 451);
            Controls.Add(btn_Seasons);
            Controls.Add(btn_Tournaments);
            Controls.Add(btn_Players);
            Controls.Add(btn_Countries);
            Margin = new Padding(2);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Countries;
        private Button btn_Players;
        private Button btn_Tournaments;
        private Button btn_Seasons;
    }
}