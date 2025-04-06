﻿namespace BazyDanychBadminton._01_Presentation
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
            dbx_PlayerBirthDate = new DateTimePicker();
            lbl_PlayerName = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Insert = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Clear = new Button();
            lbl_ListOfPlayers = new Label();
            cmb_PlayerCountry = new ComboBox();
            lbl_PlayerId = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            listBox2 = new ListBox();
            label5 = new Label();
            year_elector = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            tournaments_column = new DataGridViewTextBoxColumn();
            result_column = new DataGridViewTextBoxColumn();
            rounds_column = new DataGridViewTextBoxColumn();
            rival_column = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbx_ListOfPlayers
            // 
            lbx_ListOfPlayers.FormattingEnabled = true;
            lbx_ListOfPlayers.Location = new Point(11, 34);
            lbx_ListOfPlayers.Margin = new Padding(2);
            lbx_ListOfPlayers.Name = "lbx_ListOfPlayers";
            lbx_ListOfPlayers.Size = new Size(278, 404);
            lbx_ListOfPlayers.TabIndex = 0;
            lbx_ListOfPlayers.SelectedIndexChanged += lbx_ListOfPlayers_SelectedIndexChanged;
            // 
            // tbx_PlayerName
            // 
            tbx_PlayerName.Location = new Point(412, 34);
            tbx_PlayerName.Margin = new Padding(2);
            tbx_PlayerName.Name = "tbx_PlayerName";
            tbx_PlayerName.Size = new Size(483, 27);
            tbx_PlayerName.TabIndex = 1;
            // 
            // dbx_PlayerBirthDate
            // 
            dbx_PlayerBirthDate.Location = new Point(412, 76);
            dbx_PlayerBirthDate.Margin = new Padding(2);
            dbx_PlayerBirthDate.Name = "dbx_PlayerBirthDate";
            dbx_PlayerBirthDate.Size = new Size(483, 27);
            dbx_PlayerBirthDate.TabIndex = 4;
            // 
            // lbl_PlayerName
            // 
            lbl_PlayerName.AutoSize = true;
            lbl_PlayerName.Location = new Point(329, 37);
            lbl_PlayerName.Margin = new Padding(2, 0, 2, 0);
            lbl_PlayerName.Name = "lbl_PlayerName";
            lbl_PlayerName.Size = new Size(52, 20);
            lbl_PlayerName.TabIndex = 5;
            lbl_PlayerName.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 83);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "Birth Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 124);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 7;
            label3.Text = "Country:";
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(350, 173);
            btn_Insert.Margin = new Padding(2);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(90, 27);
            btn_Insert.TabIndex = 8;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Update
            // 
            btn_Update.Enabled = false;
            btn_Update.Location = new Point(491, 173);
            btn_Update.Margin = new Padding(2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(90, 27);
            btn_Update.TabIndex = 9;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Enabled = false;
            btn_Delete.Location = new Point(635, 173);
            btn_Delete.Margin = new Padding(2);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(90, 27);
            btn_Delete.TabIndex = 10;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(774, 173);
            btn_Clear.Margin = new Padding(2);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(90, 27);
            btn_Clear.TabIndex = 11;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // lbl_ListOfPlayers
            // 
            lbl_ListOfPlayers.AutoSize = true;
            lbl_ListOfPlayers.Location = new Point(11, 9);
            lbl_ListOfPlayers.Name = "lbl_ListOfPlayers";
            lbl_ListOfPlayers.Size = new Size(100, 20);
            lbl_ListOfPlayers.TabIndex = 12;
            lbl_ListOfPlayers.Text = "List of players";
            // 
            // cmb_PlayerCountry
            // 
            cmb_PlayerCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_PlayerCountry.FormattingEnabled = true;
            cmb_PlayerCountry.Location = new Point(412, 121);
            cmb_PlayerCountry.Name = "cmb_PlayerCountry";
            cmb_PlayerCountry.Size = new Size(483, 28);
            cmb_PlayerCountry.TabIndex = 13;
            // 
            // lbl_PlayerId
            // 
            lbl_PlayerId.AutoSize = true;
            lbl_PlayerId.Location = new Point(334, -6);
            lbl_PlayerId.Name = "lbl_PlayerId";
            lbl_PlayerId.Size = new Size(0, 20);
            lbl_PlayerId.TabIndex = 14;
            lbl_PlayerId.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 231);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 15;
            label1.Text = "Tournaments played";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(310, 254);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 184);
            listBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 231);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 17;
            label4.Text = "Editions played";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(472, 254);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 184);
            listBox2.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 231);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 19;
            label5.Text = "Result";
            // 
            // year_elector
            // 
            year_elector.FormattingEnabled = true;
            year_elector.Location = new Point(657, 373);
            year_elector.Name = "year_elector";
            year_elector.Size = new Size(238, 28);
            year_elector.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(657, 409);
            button1.Name = "button1";
            button1.Size = new Size(238, 29);
            button1.TabIndex = 21;
            button1.Text = "Show Season Results";
            button1.UseVisualStyleBackColor = true;
            button1.Click += season_results_button;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(657, 281);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += player_result;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tournaments_column, result_column, rounds_column, rival_column });
            dataGridView1.Location = new Point(936, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(660, 262);
            dataGridView1.TabIndex = 23;
            // 
            // tournaments_column
            // 
            tournaments_column.HeaderText = "Tournaments";
            tournaments_column.MinimumWidth = 6;
            tournaments_column.Name = "tournaments_column";
            tournaments_column.ReadOnly = true;
            tournaments_column.Width = 125;
            // 
            // result_column
            // 
            result_column.HeaderText = "Result";
            result_column.MinimumWidth = 6;
            result_column.Name = "result_column";
            result_column.ReadOnly = true;
            result_column.Width = 125;
            // 
            // rounds_column
            // 
            rounds_column.HeaderText = "Round";
            rounds_column.MinimumWidth = 6;
            rounds_column.Name = "rounds_column";
            rounds_column.ReadOnly = true;
            rounds_column.Width = 125;
            // 
            // rival_column
            // 
            rival_column.HeaderText = "Rival";
            rival_column.MinimumWidth = 6;
            rival_column.Name = "rival_column";
            rival_column.ReadOnly = true;
            rival_column.Width = 125;
            // 
            // frmPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 449);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(year_elector);
            Controls.Add(label5);
            Controls.Add(listBox2);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(lbl_PlayerId);
            Controls.Add(cmb_PlayerCountry);
            Controls.Add(lbl_ListOfPlayers);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Insert);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_PlayerName);
            Controls.Add(dbx_PlayerBirthDate);
            Controls.Add(tbx_PlayerName);
            Controls.Add(lbx_ListOfPlayers);
            Margin = new Padding(2);
            Name = "frmPlayers";
            Text = "frmPlayers";
            Load += frmPlayers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_ListOfPlayers;
        private TextBox tbx_PlayerName;
        private DateTimePicker dbx_PlayerBirthDate;
        private Label lbl_PlayerName;
        private Label label2;
        private Label label3;
        private Button btn_Insert;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Clear;
        private Label lbl_ListOfPlayers;
        private ComboBox cmb_PlayerCountry;
        private Label lbl_PlayerId;
        private Label label1;
        private ListBox listBox1;
        private Label label4;
        private ListBox listBox2;
        private Label label5;
        private ComboBox year_elector;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tournaments_column;
        private DataGridViewTextBoxColumn result_column;
        private DataGridViewTextBoxColumn rounds_column;
        private DataGridViewTextBoxColumn rival_column;
    }
}