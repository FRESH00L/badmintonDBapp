namespace BazyDanychBadminton._01_Presentation
{
    partial class frmPlayers
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
            lbx_ListOfPlayers = new ListBox();
            tbx_PlayerName = new TextBox();
            tbx_PlayerCountry = new TextBox();
            dbx_PlayerBirthDate = new DateTimePicker();
            lbl_PlayerName = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Insert = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Clear = new Button();
            SuspendLayout();
            // 
            // lbx_ListOfPlayers
            // 
            lbx_ListOfPlayers.FormattingEnabled = true;
            lbx_ListOfPlayers.ItemHeight = 25;
            lbx_ListOfPlayers.Location = new Point(12, 12);
            lbx_ListOfPlayers.Name = "lbx_ListOfPlayers";
            lbx_ListOfPlayers.Size = new Size(270, 529);
            lbx_ListOfPlayers.TabIndex = 0;
            lbx_ListOfPlayers.SelectedIndexChanged += lbx_ListOfPlayers_SelectedIndexChanged;
            // 
            // tbx_PlayerName
            // 
            tbx_PlayerName.Location = new Point(514, 90);
            tbx_PlayerName.Name = "tbx_PlayerName";
            tbx_PlayerName.Size = new Size(150, 31);
            tbx_PlayerName.TabIndex = 1;
            // 
            // tbx_PlayerCountry
            // 
            tbx_PlayerCountry.Location = new Point(514, 204);
            tbx_PlayerCountry.Name = "tbx_PlayerCountry";
            tbx_PlayerCountry.Size = new Size(150, 31);
            tbx_PlayerCountry.TabIndex = 3;
            // 
            // dbx_PlayerBirthDate
            // 
            dbx_PlayerBirthDate.Location = new Point(514, 146);
            dbx_PlayerBirthDate.Name = "dbx_PlayerBirthDate";
            dbx_PlayerBirthDate.Size = new Size(300, 31);
            dbx_PlayerBirthDate.TabIndex = 4;
            // 
            // lbl_PlayerName
            // 
            lbl_PlayerName.AutoSize = true;
            lbl_PlayerName.Location = new Point(414, 90);
            lbl_PlayerName.Name = "lbl_PlayerName";
            lbl_PlayerName.Size = new Size(63, 25);
            lbl_PlayerName.TabIndex = 5;
            lbl_PlayerName.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 146);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 6;
            label2.Text = "Birth Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 204);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 7;
            label3.Text = "Country:";
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(414, 279);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(112, 34);
            btn_Insert.TabIndex = 8;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Update
            // 
            btn_Update.Enabled = false;
            btn_Update.Location = new Point(552, 279);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(112, 34);
            btn_Update.TabIndex = 9;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Enabled = false;
            btn_Delete.Location = new Point(690, 279);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 34);
            btn_Delete.TabIndex = 10;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(819, 279);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(112, 34);
            btn_Clear.TabIndex = 11;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // frmPlayers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 617);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Insert);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_PlayerName);
            Controls.Add(dbx_PlayerBirthDate);
            Controls.Add(tbx_PlayerCountry);
            Controls.Add(tbx_PlayerName);
            Controls.Add(lbx_ListOfPlayers);
            Name = "frmPlayers";
            Text = "frmPlayers";
            Load += frmPlayers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_ListOfPlayers;
        private TextBox tbx_PlayerName;
        private TextBox tbx_PlayerCountry;
        private DateTimePicker dbx_PlayerBirthDate;
        private Label lbl_PlayerName;
        private Label label2;
        private Label label3;
        private Button btn_Insert;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Clear;
    }
}