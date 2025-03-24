namespace BazyDanychBadminton._01_Presentation
{
    partial class frmSeason
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
            lbx_ListOfSeasons = new ListBox();
            btn_GenerateSeason = new Button();
            btn_DeleteSeason = new Button();
            nud_SeasonYear = new NumericUpDown();
            nud_NumberOfTournament = new NumericUpDown();
            lbx_ListSelectedTournament = new ListBox();
            lbx_ListOfAllTournaments = new ListBox();
            chbx_GenerateRandomly = new CheckBox();
            chbx_ChoseRandomly = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            lbl_Year = new Label();
            lbl_NumberOfTournaments = new Label();
            lbl_SelectedTournaments = new Label();
            lbl_AllTournaments = new Label();
            lbl_ListOfSeasons = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_SeasonYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_NumberOfTournament).BeginInit();
            SuspendLayout();
            // 
            // lbx_ListOfSeasons
            // 
            lbx_ListOfSeasons.FormattingEnabled = true;
            lbx_ListOfSeasons.Location = new Point(10, 36);
            lbx_ListOfSeasons.Margin = new Padding(2);
            lbx_ListOfSeasons.Name = "lbx_ListOfSeasons";
            lbx_ListOfSeasons.Size = new Size(167, 644);
            lbx_ListOfSeasons.TabIndex = 0;
            // 
            // btn_GenerateSeason
            // 
            btn_GenerateSeason.Location = new Point(819, 34);
            btn_GenerateSeason.Margin = new Padding(2);
            btn_GenerateSeason.Name = "btn_GenerateSeason";
            btn_GenerateSeason.Size = new Size(90, 27);
            btn_GenerateSeason.TabIndex = 1;
            btn_GenerateSeason.Text = "Generate";
            btn_GenerateSeason.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteSeason
            // 
            btn_DeleteSeason.Location = new Point(819, 66);
            btn_DeleteSeason.Margin = new Padding(2);
            btn_DeleteSeason.Name = "btn_DeleteSeason";
            btn_DeleteSeason.Size = new Size(90, 27);
            btn_DeleteSeason.TabIndex = 2;
            btn_DeleteSeason.Text = "Delete";
            btn_DeleteSeason.UseVisualStyleBackColor = true;
            // 
            // nud_SeasonYear
            // 
            nud_SeasonYear.Location = new Point(224, 36);
            nud_SeasonYear.Margin = new Padding(2);
            nud_SeasonYear.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            nud_SeasonYear.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            nud_SeasonYear.Name = "nud_SeasonYear";
            nud_SeasonYear.Size = new Size(182, 27);
            nud_SeasonYear.TabIndex = 3;
            nud_SeasonYear.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // nud_NumberOfTournament
            // 
            nud_NumberOfTournament.Location = new Point(584, 36);
            nud_NumberOfTournament.Margin = new Padding(2);
            nud_NumberOfTournament.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            nud_NumberOfTournament.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            nud_NumberOfTournament.Name = "nud_NumberOfTournament";
            nud_NumberOfTournament.Size = new Size(182, 27);
            nud_NumberOfTournament.TabIndex = 4;
            nud_NumberOfTournament.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // lbx_ListSelectedTournament
            // 
            lbx_ListSelectedTournament.FormattingEnabled = true;
            lbx_ListSelectedTournament.Location = new Point(224, 105);
            lbx_ListSelectedTournament.Margin = new Padding(2);
            lbx_ListSelectedTournament.Name = "lbx_ListSelectedTournament";
            lbx_ListSelectedTournament.Size = new Size(182, 224);
            lbx_ListSelectedTournament.TabIndex = 5;
            // 
            // lbx_ListOfAllTournaments
            // 
            lbx_ListOfAllTournaments.FormattingEnabled = true;
            lbx_ListOfAllTournaments.Location = new Point(224, 423);
            lbx_ListOfAllTournaments.Margin = new Padding(2);
            lbx_ListOfAllTournaments.Name = "lbx_ListOfAllTournaments";
            lbx_ListOfAllTournaments.Size = new Size(182, 264);
            lbx_ListOfAllTournaments.TabIndex = 6;
            // 
            // chbx_GenerateRandomly
            // 
            chbx_GenerateRandomly.AutoSize = true;
            chbx_GenerateRandomly.Location = new Point(414, 59);
            chbx_GenerateRandomly.Margin = new Padding(2);
            chbx_GenerateRandomly.Name = "chbx_GenerateRandomly";
            chbx_GenerateRandomly.Size = new Size(162, 24);
            chbx_GenerateRandomly.TabIndex = 7;
            chbx_GenerateRandomly.Text = "Generate Randomly";
            chbx_GenerateRandomly.UseVisualStyleBackColor = true;
            // 
            // chbx_ChoseRandomly
            // 
            chbx_ChoseRandomly.AutoSize = true;
            chbx_ChoseRandomly.Location = new Point(251, 376);
            chbx_ChoseRandomly.Margin = new Padding(2);
            chbx_ChoseRandomly.Name = "chbx_ChoseRandomly";
            chbx_ChoseRandomly.Size = new Size(142, 24);
            chbx_ChoseRandomly.TabIndex = 8;
            chbx_ChoseRandomly.Text = "Chose Randomly";
            chbx_ChoseRandomly.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(224, 344);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(318, 344);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 10;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // lbl_Year
            // 
            lbl_Year.AutoSize = true;
            lbl_Year.Location = new Point(181, 38);
            lbl_Year.Margin = new Padding(2, 0, 2, 0);
            lbl_Year.Name = "lbl_Year";
            lbl_Year.Size = new Size(40, 20);
            lbl_Year.TabIndex = 11;
            lbl_Year.Text = "Year:";
            // 
            // lbl_NumberOfTournaments
            // 
            lbl_NumberOfTournaments.AutoSize = true;
            lbl_NumberOfTournaments.Location = new Point(414, 37);
            lbl_NumberOfTournaments.Margin = new Padding(2, 0, 2, 0);
            lbl_NumberOfTournaments.Name = "lbl_NumberOfTournaments";
            lbl_NumberOfTournaments.Size = new Size(170, 20);
            lbl_NumberOfTournaments.TabIndex = 12;
            lbl_NumberOfTournaments.Text = "Number of Tournaments";
            // 
            // lbl_SelectedTournaments
            // 
            lbl_SelectedTournaments.AutoSize = true;
            lbl_SelectedTournaments.Location = new Point(224, 82);
            lbl_SelectedTournaments.Margin = new Padding(2, 0, 2, 0);
            lbl_SelectedTournaments.Name = "lbl_SelectedTournaments";
            lbl_SelectedTournaments.Size = new Size(155, 20);
            lbl_SelectedTournaments.TabIndex = 13;
            lbl_SelectedTournaments.Text = "Selected Tournaments";
            // 
            // lbl_AllTournaments
            // 
            lbl_AllTournaments.AutoSize = true;
            lbl_AllTournaments.Location = new Point(224, 401);
            lbl_AllTournaments.Margin = new Padding(2, 0, 2, 0);
            lbl_AllTournaments.Name = "lbl_AllTournaments";
            lbl_AllTournaments.Size = new Size(116, 20);
            lbl_AllTournaments.TabIndex = 14;
            lbl_AllTournaments.Text = "All Tournaments";
            // 
            // lbl_ListOfSeasons
            // 
            lbl_ListOfSeasons.AutoSize = true;
            lbl_ListOfSeasons.Location = new Point(10, 14);
            lbl_ListOfSeasons.Margin = new Padding(2, 0, 2, 0);
            lbl_ListOfSeasons.Name = "lbl_ListOfSeasons";
            lbl_ListOfSeasons.Size = new Size(106, 20);
            lbl_ListOfSeasons.TabIndex = 15;
            lbl_ListOfSeasons.Text = "List of Seasons";
            // 
            // frmSeason
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 769);
            Controls.Add(lbl_ListOfSeasons);
            Controls.Add(lbl_AllTournaments);
            Controls.Add(lbl_SelectedTournaments);
            Controls.Add(lbl_NumberOfTournaments);
            Controls.Add(lbl_Year);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chbx_ChoseRandomly);
            Controls.Add(chbx_GenerateRandomly);
            Controls.Add(lbx_ListOfAllTournaments);
            Controls.Add(lbx_ListSelectedTournament);
            Controls.Add(nud_NumberOfTournament);
            Controls.Add(nud_SeasonYear);
            Controls.Add(btn_DeleteSeason);
            Controls.Add(btn_GenerateSeason);
            Controls.Add(lbx_ListOfSeasons);
            Margin = new Padding(2);
            Name = "frmSeason";
            Text = "FrmSeason";
            ((System.ComponentModel.ISupportInitialize)nud_SeasonYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_NumberOfTournament).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_ListOfSeasons;
        private Button btn_GenerateSeason;
        private Button btn_DeleteSeason;
        private NumericUpDown nud_SeasonYear;
        private NumericUpDown nud_NumberOfTournament;
        private ListBox lbx_ListSelectedTournament;
        private ListBox lbx_ListOfAllTournaments;
        private CheckBox chbx_GenerateRandomly;
        private CheckBox chbx_ChoseRandomly;
        private Button button1;
        private Button button2;
        private Label lbl_Year;
        private Label lbl_NumberOfTournaments;
        private Label lbl_SelectedTournaments;
        private Label lbl_AllTournaments;
        private Label lbl_ListOfSeasons;
    }
}