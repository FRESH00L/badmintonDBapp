namespace BazyDanychBadminton
{
    partial class frmCountries
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbx_Countries = new ListBox();
            lbl_ListOfCountries = new Label();
            tbx_CountryId = new TextBox();
            tbx_CountryName = new TextBox();
            lbl_CountryId = new Label();
            lbl_CoutryName = new Label();
            btn_Insert = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Clear = new Button();
            SuspendLayout();
            // 
            // lbx_Countries
            // 
            lbx_Countries.FormattingEnabled = true;
            lbx_Countries.ItemHeight = 25;
            lbx_Countries.Location = new Point(12, 45);
            lbx_Countries.Name = "lbx_Countries";
            lbx_Countries.Size = new Size(319, 479);
            lbx_Countries.TabIndex = 1;
            lbx_Countries.SelectedIndexChanged += lbx_Countries_SelectedIndexChanged;
            // 
            // lbl_ListOfCountries
            // 
            lbl_ListOfCountries.AutoSize = true;
            lbl_ListOfCountries.Location = new Point(12, 17);
            lbl_ListOfCountries.Name = "lbl_ListOfCountries";
            lbl_ListOfCountries.Size = new Size(137, 25);
            lbl_ListOfCountries.TabIndex = 2;
            lbl_ListOfCountries.Text = "List of countries";
            // 
            // tbx_CountryId
            // 
            tbx_CountryId.Location = new Point(533, 42);
            tbx_CountryId.Name = "tbx_CountryId";
            tbx_CountryId.ReadOnly = true;
            tbx_CountryId.Size = new Size(150, 31);
            tbx_CountryId.TabIndex = 3;
            // 
            // tbx_CountryName
            // 
            tbx_CountryName.Location = new Point(533, 92);
            tbx_CountryName.Name = "tbx_CountryName";
            tbx_CountryName.Size = new Size(218, 31);
            tbx_CountryName.TabIndex = 4;
            // 
            // lbl_CountryId
            // 
            lbl_CountryId.AutoSize = true;
            lbl_CountryId.Location = new Point(406, 45);
            lbl_CountryId.Name = "lbl_CountryId";
            lbl_CountryId.Size = new Size(90, 25);
            lbl_CountryId.TabIndex = 5;
            lbl_CountryId.Text = "Coutry Id:";
            // 
            // lbl_CoutryName
            // 
            lbl_CoutryName.AutoSize = true;
            lbl_CoutryName.Location = new Point(406, 95);
            lbl_CoutryName.Name = "lbl_CoutryName";
            lbl_CoutryName.Size = new Size(121, 25);
            lbl_CoutryName.TabIndex = 6;
            lbl_CoutryName.Text = "Coutry Name:";
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(406, 163);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(112, 34);
            btn_Insert.TabIndex = 7;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Update
            // 
            btn_Update.Enabled = false;
            btn_Update.Location = new Point(533, 163);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(112, 34);
            btn_Update.TabIndex = 8;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Enabled = false;
            btn_Delete.Location = new Point(660, 163);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 34);
            btn_Delete.TabIndex = 9;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(788, 163);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(112, 34);
            btn_Clear.TabIndex = 10;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            // 
            // frmCountries
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 564);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Insert);
            Controls.Add(lbl_CoutryName);
            Controls.Add(lbl_CountryId);
            Controls.Add(tbx_CountryName);
            Controls.Add(tbx_CountryId);
            Controls.Add(lbl_ListOfCountries);
            Controls.Add(lbx_Countries);
            Name = "frmCountries";
            Text = "Form1";
            Load += frmCountries_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_Countries;
        private Label lbl_ListOfCountries;
        private TextBox tbx_CountryId;
        private TextBox tbx_CountryName;
        private Label lbl_CountryId;
        private Label lbl_CoutryName;
        private Button btn_Insert;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Clear;
    }
}
