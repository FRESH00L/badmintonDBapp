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
            SuspendLayout();
            // 
            // lbl_ListOfTournaments
            // 
            lbl_ListOfTournaments.AutoSize = true;
            lbl_ListOfTournaments.Location = new Point(12, 9);
            lbl_ListOfTournaments.Name = "lbl_ListOfTournaments";
            lbl_ListOfTournaments.Size = new Size(138, 20);
            lbl_ListOfTournaments.TabIndex = 0;
            lbl_ListOfTournaments.Text = "List of Tournaments";
            // 
            // lbx_Tournaments
            // 
            lbx_Tournaments.FormattingEnabled = true;
            lbx_Tournaments.Location = new Point(12, 34);
            lbx_Tournaments.Name = "lbx_Tournaments";
            lbx_Tournaments.Size = new Size(277, 404);
            lbx_Tournaments.TabIndex = 1;
            lbx_Tournaments.SelectedIndexChanged += lbx_Tournaments_SelectedIndexChanged;
            // 
            // lbl_TournamentName
            // 
            lbl_TournamentName.AutoSize = true;
            lbl_TournamentName.Location = new Point(429, 92);
            lbl_TournamentName.Name = "lbl_TournamentName";
            lbl_TournamentName.Size = new Size(135, 20);
            lbl_TournamentName.TabIndex = 2;
            lbl_TournamentName.Text = "Tournament Name:";
            // 
            // lbl_TournamentCity
            // 
            lbl_TournamentCity.AutoSize = true;
            lbl_TournamentCity.Location = new Point(429, 148);
            lbl_TournamentCity.Name = "lbl_TournamentCity";
            lbl_TournamentCity.Size = new Size(120, 20);
            lbl_TournamentCity.TabIndex = 3;
            lbl_TournamentCity.Text = "Tournament City:";
            // 
            // lbl_TournamentCountry
            // 
            lbl_TournamentCountry.AutoSize = true;
            lbl_TournamentCountry.Location = new Point(429, 197);
            lbl_TournamentCountry.Name = "lbl_TournamentCountry";
            lbl_TournamentCountry.Size = new Size(146, 20);
            lbl_TournamentCountry.TabIndex = 4;
            lbl_TournamentCountry.Text = "Tournament Country:";
            // 
            // tbx_TournamentName
            // 
            tbx_TournamentName.Location = new Point(581, 89);
            tbx_TournamentName.Name = "tbx_TournamentName";
            tbx_TournamentName.Size = new Size(187, 27);
            tbx_TournamentName.TabIndex = 5;
            // 
            // tbx_TournamentCity
            // 
            tbx_TournamentCity.Location = new Point(581, 145);
            tbx_TournamentCity.Name = "tbx_TournamentCity";
            tbx_TournamentCity.Size = new Size(187, 27);
            tbx_TournamentCity.TabIndex = 6;
            // 
            // cmb_TournamentCountry
            // 
            cmb_TournamentCountry.FormattingEnabled = true;
            cmb_TournamentCountry.Location = new Point(581, 194);
            cmb_TournamentCountry.Name = "cmb_TournamentCountry";
            cmb_TournamentCountry.Size = new Size(187, 28);
            cmb_TournamentCountry.TabIndex = 7;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(342, 308);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(94, 29);
            btn_Insert.TabIndex = 8;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(493, 308);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 9;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(645, 308);
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
            btn_Clear.Location = new Point(796, 308);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(94, 29);
            btn_Clear.TabIndex = 11;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // frmTournaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
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
            Text = "frmTournaments";
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
    }
}