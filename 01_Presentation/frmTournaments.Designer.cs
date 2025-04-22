namespace BazyDanychBadminton._01_Presentation
{
    partial class frmTournaments
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
            lbl_ListOfTournaments = new Label();
            lbx_Tournaments = new ListBox();
            lbl_TournamentName = new Label();
            lbl_TournamentCity = new Label();
            lbl_TournamentCountry = new Label();
            tbx_TournamentName = new TextBox();
            tbx_TournamentCity = new TextBox();
            cmb_TournamentCountry = new ComboBox();
            btn_Insert = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Clear = new Button();
            lbl_TournamentId = new Label();
            lbl_TouEdi = new Label();
            lbx_TouEdi = new ListBox();
            lbl_Champion = new Label();
            btn_show = new Button();
            tbx_Winner = new TextBox();
            SuspendLayout();
            // 
            // lbl_ListOfTournaments
            // 
            lbl_ListOfTournaments.AutoSize = true;
            lbl_ListOfTournaments.Location = new Point(11, 9);
            lbl_ListOfTournaments.Name = "lbl_ListOfTournaments";
            lbl_ListOfTournaments.Size = new Size(138, 20);
            lbl_ListOfTournaments.TabIndex = 0;
            lbl_ListOfTournaments.Text = "List of Tournaments";
            // 
            // lbx_Tournaments
            // 
            lbx_Tournaments.FormattingEnabled = true;
            lbx_Tournaments.Location = new Point(11, 35);
            lbx_Tournaments.Name = "lbx_Tournaments";
            lbx_Tournaments.Size = new Size(277, 404);
            lbx_Tournaments.TabIndex = 1;
            lbx_Tournaments.SelectedIndexChanged += lbx_Tournaments_SelectedIndexChanged;
            // 
            // lbl_TournamentName
            // 
            lbl_TournamentName.AutoSize = true;
            lbl_TournamentName.Location = new Point(326, 37);
            lbl_TournamentName.Name = "lbl_TournamentName";
            lbl_TournamentName.Size = new Size(135, 20);
            lbl_TournamentName.TabIndex = 2;
            lbl_TournamentName.Text = "Tournament Name:";
            // 
            // lbl_TournamentCity
            // 
            lbl_TournamentCity.AutoSize = true;
            lbl_TournamentCity.Location = new Point(326, 79);
            lbl_TournamentCity.Name = "lbl_TournamentCity";
            lbl_TournamentCity.Size = new Size(120, 20);
            lbl_TournamentCity.TabIndex = 3;
            lbl_TournamentCity.Text = "Tournament City:";
            // 
            // lbl_TournamentCountry
            // 
            lbl_TournamentCountry.AutoSize = true;
            lbl_TournamentCountry.Location = new Point(326, 121);
            lbl_TournamentCountry.Name = "lbl_TournamentCountry";
            lbl_TournamentCountry.Size = new Size(146, 20);
            lbl_TournamentCountry.TabIndex = 4;
            lbl_TournamentCountry.Text = "Tournament Country:";
            // 
            // tbx_TournamentName
            // 
            tbx_TournamentName.Location = new Point(478, 35);
            tbx_TournamentName.Name = "tbx_TournamentName";
            tbx_TournamentName.Size = new Size(292, 27);
            tbx_TournamentName.TabIndex = 5;
            // 
            // tbx_TournamentCity
            // 
            tbx_TournamentCity.Location = new Point(478, 76);
            tbx_TournamentCity.Name = "tbx_TournamentCity";
            tbx_TournamentCity.Size = new Size(292, 27);
            tbx_TournamentCity.TabIndex = 6;
            // 
            // cmb_TournamentCountry
            // 
            cmb_TournamentCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TournamentCountry.FormattingEnabled = true;
            cmb_TournamentCountry.Location = new Point(478, 117);
            cmb_TournamentCountry.Name = "cmb_TournamentCountry";
            cmb_TournamentCountry.Size = new Size(292, 28);
            cmb_TournamentCountry.TabIndex = 7;
            cmb_TournamentCountry.SelectedIndexChanged += cmb_TournamentCountry_SelectedIndexChanged;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(327, 164);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(94, 29);
            btn_Insert.TabIndex = 8;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Update
            // 
            btn_Update.Enabled = false;
            btn_Update.Location = new Point(478, 164);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 9;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Enabled = false;
            btn_Delete.Location = new Point(630, 164);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 10;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.UseWaitCursor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(781, 164);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(94, 29);
            btn_Clear.TabIndex = 11;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // lbl_TournamentId
            // 
            lbl_TournamentId.AutoSize = true;
            lbl_TournamentId.Location = new Point(429, 35);
            lbl_TournamentId.Name = "lbl_TournamentId";
            lbl_TournamentId.Size = new Size(0, 20);
            lbl_TournamentId.TabIndex = 12;
            lbl_TournamentId.Visible = false;
            // 
            // lbl_TouEdi
            // 
            lbl_TouEdi.AutoSize = true;
            lbl_TouEdi.Location = new Point(313, 209);
            lbl_TouEdi.Name = "lbl_TouEdi";
            lbl_TouEdi.Size = new Size(145, 20);
            lbl_TouEdi.TabIndex = 13;
            lbl_TouEdi.Text = "Tournament Editions";
            // 
            // lbx_TouEdi
            // 
            lbx_TouEdi.FormattingEnabled = true;
            lbx_TouEdi.Location = new Point(313, 235);
            lbx_TouEdi.Name = "lbx_TouEdi";
            lbx_TouEdi.Size = new Size(178, 204);
            lbx_TouEdi.TabIndex = 14;
            lbx_TouEdi.SelectedIndexChanged += lbx_TouEdi_SelectedIndexChanged;
            // 
            // lbl_Champion
            // 
            lbl_Champion.AutoSize = true;
            lbl_Champion.Location = new Point(546, 229);
            lbl_Champion.Name = "lbl_Champion";
            lbl_Champion.Size = new Size(77, 20);
            lbl_Champion.TabIndex = 15;
            lbl_Champion.Text = "Champion";
            lbl_Champion.Click += label2_Click;
            // 
            // btn_show
            // 
            btn_show.Enabled = false;
            btn_show.Location = new Point(681, 353);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(201, 29);
            btn_show.TabIndex = 16;
            btn_show.Text = "Show Edition Matches";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += show_edition_matches;
            // 
            // tbx_Winner
            // 
            tbx_Winner.Location = new Point(583, 268);
            tbx_Winner.Name = "tbx_Winner";
            tbx_Winner.ReadOnly = true;
            tbx_Winner.Size = new Size(221, 27);
            tbx_Winner.TabIndex = 17;
            tbx_Winner.TextChanged += winner_name_TextChanged;
            // 
            // frmTournaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 451);
            Controls.Add(tbx_Winner);
            Controls.Add(btn_show);
            Controls.Add(lbl_Champion);
            Controls.Add(lbx_TouEdi);
            Controls.Add(lbl_TouEdi);
            Controls.Add(lbl_TournamentId);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Insert);
            Controls.Add(cmb_TournamentCountry);
            Controls.Add(tbx_TournamentCity);
            Controls.Add(tbx_TournamentName);
            Controls.Add(lbl_TournamentCountry);
            Controls.Add(lbl_TournamentCity);
            Controls.Add(lbl_TournamentName);
            Controls.Add(lbx_Tournaments);
            Controls.Add(lbl_ListOfTournaments);
            Name = "frmTournaments";
            Text = "Show edition tournaments";
            Load += frmTournaments_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ListOfTournaments;
        private ListBox lbx_Tournaments;
        private Label lbl_TournamentName;
        private Label lbl_TournamentCity;
        private Label lbl_TournamentCountry;
        private TextBox tbx_TournamentName;
        private TextBox tbx_TournamentCity;
        private ComboBox cmb_TournamentCountry;
        private Button btn_Insert;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Clear;
        private Label lbl_TournamentId;
        private Label lbl_TouEdi;
        private ListBox lbx_TouEdi;
        private Label lbl_Champion;
        private Button btn_show;
        private TextBox tbx_Winner;
    }
}