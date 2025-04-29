namespace BazyDanychBadminton._01_Presentation
{
    partial class frmSeasons
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
            btn_Add = new Button();
            btn_Clear = new Button();
            lbl_Year = new Label();
            lbl_NumberOfTournaments = new Label();
            lbl_SelectedTournaments = new Label();
            lbl_AllTournaments = new Label();
            lbl_ListOfSeasons = new Label();
            quarterfinals_label = new Label();
            q_first_player = new Label();
            q_second_player = new Label();
            q_third_player = new Label();
            q_fourth_player = new Label();
            q_fifth_player = new Label();
            q_sixth_player = new Label();
            q_seventh_player = new Label();
            q_eighth_player = new Label();
            semifinals_label = new Label();
            s_first_player = new Label();
            s_second_player = new Label();
            s_third_player = new Label();
            s_fourth_player = new Label();
            finals_label = new Label();
            f_first_player = new Label();
            f_second_player = new Label();
            label1 = new Label();
            winner_player = new Label();
            q_score_first_player = new Label();
            q_score_second_player = new Label();
            q_score_third_player = new Label();
            q_score_fourth_player = new Label();
            q_score_fifth_player = new Label();
            q_score_sixth_player = new Label();
            q_score_seventh_player = new Label();
            q_score_eightth_player = new Label();
            s_score_first_player = new Label();
            s_score_second_player = new Label();
            s_score_third_player = new Label();
            s_score_fourth_player = new Label();
            f_score_first_player = new Label();
            f_score_second_player = new Label();
            winner_score = new Label();
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
            lbx_ListOfSeasons.SelectedIndexChanged += lbx_ListOfSeasons_SelectedIndexChanged;
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
            btn_GenerateSeason.Click += btn_GenerateSeason_Click;
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
            btn_DeleteSeason.Click += btn_DeleteSeason_Click;
            // 
            // nud_SeasonYear
            // 
            nud_SeasonYear.Location = new Point(224, 36);
            nud_SeasonYear.Margin = new Padding(2);
            nud_SeasonYear.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            nud_SeasonYear.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            nud_SeasonYear.Name = "nud_SeasonYear";
            nud_SeasonYear.ReadOnly = true;
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
            nud_NumberOfTournament.ReadOnly = true;
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
            chbx_GenerateRandomly.CheckedChanged += chbx_GenerateRandomly_CheckedChanged;
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
            chbx_ChoseRandomly.CheckedChanged += chbx_ChoseRandomly_CheckedChanged;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(208, 338);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(112, 34);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(326, 338);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(112, 34);
            btn_Clear.TabIndex = 10;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
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
            // quarterfinals_label
            // 
            quarterfinals_label.AutoSize = true;
            quarterfinals_label.BorderStyle = BorderStyle.FixedSingle;
            quarterfinals_label.Location = new Point(490, 105);
            quarterfinals_label.Name = "quarterfinals_label";
            quarterfinals_label.Size = new Size(96, 22);
            quarterfinals_label.TabIndex = 16;
            quarterfinals_label.Text = "Quarterfinals";
            // 
            // q_first_player
            // 
            q_first_player.AutoSize = true;
            q_first_player.Location = new Point(536, 151);
            q_first_player.Name = "q_first_player";
            q_first_player.Size = new Size(50, 20);
            q_first_player.TabIndex = 17;
            q_first_player.Text = "label2";
            q_first_player.Click += q_first_player_Click;
            // 
            // q_second_player
            // 
            q_second_player.AutoSize = true;
            q_second_player.Location = new Point(716, 151);
            q_second_player.Name = "q_second_player";
            q_second_player.Size = new Size(50, 20);
            q_second_player.TabIndex = 18;
            q_second_player.Text = "label3";
            q_second_player.Click += q_second_player_Click;
            // 
            // q_third_player
            // 
            q_third_player.AutoSize = true;
            q_third_player.Location = new Point(536, 191);
            q_third_player.Name = "q_third_player";
            q_third_player.Size = new Size(50, 20);
            q_third_player.TabIndex = 19;
            q_third_player.Text = "label4";
            q_third_player.Click += q_third_player_Click;
            // 
            // q_fourth_player
            // 
            q_fourth_player.AutoSize = true;
            q_fourth_player.Location = new Point(716, 191);
            q_fourth_player.Name = "q_fourth_player";
            q_fourth_player.Size = new Size(50, 20);
            q_fourth_player.TabIndex = 20;
            q_fourth_player.Text = "label5";
            q_fourth_player.Click += q_fourth_player_Click;
            // 
            // q_fifth_player
            // 
            q_fifth_player.AutoSize = true;
            q_fifth_player.Location = new Point(536, 253);
            q_fifth_player.Name = "q_fifth_player";
            q_fifth_player.Size = new Size(50, 20);
            q_fifth_player.TabIndex = 21;
            q_fifth_player.Text = "label6";
            q_fifth_player.Click += q_fifth_player_Click;
            // 
            // q_sixth_player
            // 
            q_sixth_player.AutoSize = true;
            q_sixth_player.Location = new Point(716, 253);
            q_sixth_player.Name = "q_sixth_player";
            q_sixth_player.Size = new Size(50, 20);
            q_sixth_player.TabIndex = 22;
            q_sixth_player.Text = "label7";
            q_sixth_player.Click += q_sixth_player_Click;
            // 
            // q_seventh_player
            // 
            q_seventh_player.AutoSize = true;
            q_seventh_player.Location = new Point(536, 291);
            q_seventh_player.Name = "q_seventh_player";
            q_seventh_player.Size = new Size(50, 20);
            q_seventh_player.TabIndex = 23;
            q_seventh_player.Text = "label8";
            q_seventh_player.Click += q_seventh_player_Click;
            // 
            // q_eighth_player
            // 
            q_eighth_player.AutoSize = true;
            q_eighth_player.Location = new Point(716, 291);
            q_eighth_player.Name = "q_eighth_player";
            q_eighth_player.Size = new Size(50, 20);
            q_eighth_player.TabIndex = 24;
            q_eighth_player.Text = "label9";
            q_eighth_player.Click += q_eighth_player_Click;
            // 
            // semifinals_label
            // 
            semifinals_label.AutoSize = true;
            semifinals_label.BorderStyle = BorderStyle.FixedSingle;
            semifinals_label.Location = new Point(490, 350);
            semifinals_label.Name = "semifinals_label";
            semifinals_label.Size = new Size(79, 22);
            semifinals_label.TabIndex = 25;
            semifinals_label.Text = "Semifinals";
            // 
            // s_first_player
            // 
            s_first_player.AutoSize = true;
            s_first_player.Location = new Point(536, 401);
            s_first_player.Name = "s_first_player";
            s_first_player.Size = new Size(58, 20);
            s_first_player.TabIndex = 26;
            s_first_player.Text = "label10";
            s_first_player.Click += s_first_player_Click;
            // 
            // s_second_player
            // 
            s_second_player.AutoSize = true;
            s_second_player.Location = new Point(716, 401);
            s_second_player.Name = "s_second_player";
            s_second_player.Size = new Size(58, 20);
            s_second_player.TabIndex = 27;
            s_second_player.Text = "label11";
            s_second_player.Click += s_second_player_Click;
            // 
            // s_third_player
            // 
            s_third_player.AutoSize = true;
            s_third_player.Location = new Point(536, 444);
            s_third_player.Name = "s_third_player";
            s_third_player.Size = new Size(58, 20);
            s_third_player.TabIndex = 28;
            s_third_player.Text = "label12";
            s_third_player.Click += s_third_player_Click;
            // 
            // s_fourth_player
            // 
            s_fourth_player.AutoSize = true;
            s_fourth_player.Location = new Point(716, 444);
            s_fourth_player.Name = "s_fourth_player";
            s_fourth_player.Size = new Size(58, 20);
            s_fourth_player.TabIndex = 29;
            s_fourth_player.Text = "label13";
            s_fourth_player.Click += s_fourth_player_Click;
            // 
            // finals_label
            // 
            finals_label.AutoSize = true;
            finals_label.BorderStyle = BorderStyle.FixedSingle;
            finals_label.Location = new Point(490, 501);
            finals_label.Name = "finals_label";
            finals_label.Size = new Size(48, 22);
            finals_label.TabIndex = 30;
            finals_label.Text = "Finals";
            // 
            // f_first_player
            // 
            f_first_player.AutoSize = true;
            f_first_player.Location = new Point(536, 551);
            f_first_player.Name = "f_first_player";
            f_first_player.Size = new Size(58, 20);
            f_first_player.TabIndex = 31;
            f_first_player.Text = "label14";
            f_first_player.Click += f_first_player_Click;
            // 
            // f_second_player
            // 
            f_second_player.AutoSize = true;
            f_second_player.Location = new Point(716, 551);
            f_second_player.Name = "f_second_player";
            f_second_player.Size = new Size(58, 20);
            f_second_player.TabIndex = 32;
            f_second_player.Text = "label15";
            f_second_player.Click += f_second_player_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(490, 634);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 33;
            label1.Text = "Winner";
            label1.Click += label1_Click;
            // 
            // winner_player
            // 
            winner_player.AutoSize = true;
            winner_player.Location = new Point(490, 667);
            winner_player.Name = "winner_player";
            winner_player.Size = new Size(58, 20);
            winner_player.TabIndex = 34;
            winner_player.Text = "label16";
            winner_player.Click += winner_player_Click;
            // 
            // q_score_first_player
            // 
            q_score_first_player.AutoSize = true;
            q_score_first_player.Location = new Point(592, 151);
            q_score_first_player.Name = "q_score_first_player";
            q_score_first_player.Size = new Size(58, 20);
            q_score_first_player.TabIndex = 35;
            q_score_first_player.Text = "label17";
            // 
            // q_score_second_player
            // 
            q_score_second_player.AutoSize = true;
            q_score_second_player.Location = new Point(772, 151);
            q_score_second_player.Name = "q_score_second_player";
            q_score_second_player.Size = new Size(58, 20);
            q_score_second_player.TabIndex = 36;
            q_score_second_player.Text = "label18";
            // 
            // q_score_third_player
            // 
            q_score_third_player.AutoSize = true;
            q_score_third_player.Location = new Point(592, 191);
            q_score_third_player.Name = "q_score_third_player";
            q_score_third_player.Size = new Size(58, 20);
            q_score_third_player.TabIndex = 37;
            q_score_third_player.Text = "label19";
            // 
            // q_score_fourth_player
            // 
            q_score_fourth_player.AutoSize = true;
            q_score_fourth_player.Location = new Point(772, 191);
            q_score_fourth_player.Name = "q_score_fourth_player";
            q_score_fourth_player.Size = new Size(58, 20);
            q_score_fourth_player.TabIndex = 38;
            q_score_fourth_player.Text = "label20";
            // 
            // q_score_fifth_player
            // 
            q_score_fifth_player.AutoSize = true;
            q_score_fifth_player.Location = new Point(592, 253);
            q_score_fifth_player.Name = "q_score_fifth_player";
            q_score_fifth_player.Size = new Size(58, 20);
            q_score_fifth_player.TabIndex = 39;
            q_score_fifth_player.Text = "label21";
            // 
            // q_score_sixth_player
            // 
            q_score_sixth_player.AutoSize = true;
            q_score_sixth_player.Location = new Point(772, 253);
            q_score_sixth_player.Name = "q_score_sixth_player";
            q_score_sixth_player.Size = new Size(58, 20);
            q_score_sixth_player.TabIndex = 40;
            q_score_sixth_player.Text = "label22";
            // 
            // q_score_seventh_player
            // 
            q_score_seventh_player.AutoSize = true;
            q_score_seventh_player.Location = new Point(592, 291);
            q_score_seventh_player.Name = "q_score_seventh_player";
            q_score_seventh_player.Size = new Size(58, 20);
            q_score_seventh_player.TabIndex = 41;
            q_score_seventh_player.Text = "label23";
            // 
            // q_score_eightth_player
            // 
            q_score_eightth_player.AutoSize = true;
            q_score_eightth_player.Location = new Point(772, 291);
            q_score_eightth_player.Name = "q_score_eightth_player";
            q_score_eightth_player.Size = new Size(58, 20);
            q_score_eightth_player.TabIndex = 42;
            q_score_eightth_player.Text = "label24";
            // 
            // s_score_first_player
            // 
            s_score_first_player.AutoSize = true;
            s_score_first_player.Location = new Point(600, 401);
            s_score_first_player.Name = "s_score_first_player";
            s_score_first_player.Size = new Size(58, 20);
            s_score_first_player.TabIndex = 43;
            s_score_first_player.Text = "label25";
            // 
            // s_score_second_player
            // 
            s_score_second_player.AutoSize = true;
            s_score_second_player.Location = new Point(780, 401);
            s_score_second_player.Name = "s_score_second_player";
            s_score_second_player.Size = new Size(58, 20);
            s_score_second_player.TabIndex = 44;
            s_score_second_player.Text = "label26";
            // 
            // s_score_third_player
            // 
            s_score_third_player.AutoSize = true;
            s_score_third_player.Location = new Point(600, 444);
            s_score_third_player.Name = "s_score_third_player";
            s_score_third_player.Size = new Size(58, 20);
            s_score_third_player.TabIndex = 45;
            s_score_third_player.Text = "label27";
            // 
            // s_score_fourth_player
            // 
            s_score_fourth_player.AutoSize = true;
            s_score_fourth_player.Location = new Point(780, 444);
            s_score_fourth_player.Name = "s_score_fourth_player";
            s_score_fourth_player.Size = new Size(58, 20);
            s_score_fourth_player.TabIndex = 46;
            s_score_fourth_player.Text = "label28";
            // 
            // f_score_first_player
            // 
            f_score_first_player.AutoSize = true;
            f_score_first_player.Location = new Point(600, 551);
            f_score_first_player.Name = "f_score_first_player";
            f_score_first_player.Size = new Size(58, 20);
            f_score_first_player.TabIndex = 47;
            f_score_first_player.Text = "label29";
            // 
            // f_score_second_player
            // 
            f_score_second_player.AutoSize = true;
            f_score_second_player.Location = new Point(780, 551);
            f_score_second_player.Name = "f_score_second_player";
            f_score_second_player.Size = new Size(58, 20);
            f_score_second_player.TabIndex = 48;
            f_score_second_player.Text = "label30";
            // 
            // winner_score
            // 
            winner_score.AutoSize = true;
            winner_score.Location = new Point(554, 667);
            winner_score.Name = "winner_score";
            winner_score.Size = new Size(58, 20);
            winner_score.TabIndex = 49;
            winner_score.Text = "label31";
            // 
            // frmSeasons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 769);
            Controls.Add(winner_score);
            Controls.Add(f_score_second_player);
            Controls.Add(f_score_first_player);
            Controls.Add(s_score_fourth_player);
            Controls.Add(s_score_third_player);
            Controls.Add(s_score_second_player);
            Controls.Add(s_score_first_player);
            Controls.Add(q_score_eightth_player);
            Controls.Add(q_score_seventh_player);
            Controls.Add(q_score_sixth_player);
            Controls.Add(q_score_fifth_player);
            Controls.Add(q_score_fourth_player);
            Controls.Add(q_score_third_player);
            Controls.Add(q_score_second_player);
            Controls.Add(q_score_first_player);
            Controls.Add(winner_player);
            Controls.Add(label1);
            Controls.Add(f_second_player);
            Controls.Add(f_first_player);
            Controls.Add(finals_label);
            Controls.Add(s_fourth_player);
            Controls.Add(s_third_player);
            Controls.Add(s_second_player);
            Controls.Add(s_first_player);
            Controls.Add(semifinals_label);
            Controls.Add(q_eighth_player);
            Controls.Add(q_seventh_player);
            Controls.Add(q_sixth_player);
            Controls.Add(q_fifth_player);
            Controls.Add(q_fourth_player);
            Controls.Add(q_third_player);
            Controls.Add(q_second_player);
            Controls.Add(q_first_player);
            Controls.Add(quarterfinals_label);
            Controls.Add(lbl_ListOfSeasons);
            Controls.Add(lbl_AllTournaments);
            Controls.Add(lbl_SelectedTournaments);
            Controls.Add(lbl_NumberOfTournaments);
            Controls.Add(lbl_Year);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Add);
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
            Name = "frmSeasons";
            Text = "frmSeasons";
            Load += frmSeason_Load;
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
        private Button btn_Add;
        private Button btn_Clear;
        private Label lbl_Year;
        private Label lbl_NumberOfTournaments;
        private Label lbl_SelectedTournaments;
        private Label lbl_AllTournaments;
        private Label lbl_ListOfSeasons;
        private Label quarterfinals_label;
        private Label q_first_player;
        private Label q_second_player;
        private Label q_third_player;
        private Label q_fourth_player;
        private Label q_fifth_player;
        private Label q_sixth_player;
        private Label q_seventh_player;
        private Label q_eighth_player;
        private Label semifinals_label;
        private Label s_first_player;
        private Label s_second_player;
        private Label s_third_player;
        private Label s_fourth_player;
        private Label finals_label;
        private Label f_first_player;
        private Label f_second_player;
        private Label label1;
        private Label winner_player;
        private Label q_score_first_player;
        private Label q_score_second_player;
        private Label q_score_third_player;
        private Label q_score_fourth_player;
        private Label q_score_fifth_player;
        private Label q_score_sixth_player;
        private Label q_score_seventh_player;
        private Label q_score_eightth_player;
        private Label s_score_first_player;
        private Label s_score_second_player;
        private Label s_score_third_player;
        private Label s_score_fourth_player;
        private Label f_score_first_player;
        private Label f_score_second_player;
        private Label winner_score;
    }
}