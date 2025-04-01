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
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            button1 = new Button();
            winner_name = new TextBox();
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
            tbx_TournamentName.Location = new Point(478, 34);
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
            cmb_TournamentCountry.Location = new Point(478, 118);
            cmb_TournamentCountry.Name = "cmb_TournamentCountry";
            cmb_TournamentCountry.Size = new Size(292, 28);
            cmb_TournamentCountry.TabIndex = 7;
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
            lbl_TournamentId.Location = new Point(429, 34);
            lbl_TournamentId.Name = "lbl_TournamentId";
            lbl_TournamentId.Size = new Size(0, 20);
            lbl_TournamentId.TabIndex = 12;
            lbl_TournamentId.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 209);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 13;
            label1.Text = "Tournament Editions";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(313, 234);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(178, 204);
            listBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 229);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 15;
            label2.Text = "Champion";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(681, 353);
            button1.Name = "button1";
            button1.Size = new Size(201, 29);
            button1.TabIndex = 16;
            button1.Text = "Show Edition Matches";
            button1.UseVisualStyleBackColor = true;
            // 
            // winner_name
            // 
            winner_name.Location = new Point(583, 268);
            winner_name.Name = "winner_name";
            winner_name.ReadOnly = true;
            winner_name.Size = new Size(221, 27);
            winner_name.TabIndex = 17;
            // 
            // frmTournaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
            Controls.Add(winner_name);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
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
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Button button1;
        private TextBox winner_name;
    }
}