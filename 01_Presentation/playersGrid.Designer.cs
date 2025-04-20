namespace BazyDanychBadminton._01_Presentation
{
    partial class playersGrid
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
            dataGridView1 = new DataGridView();
            tournaments_column = new DataGridViewTextBoxColumn();
            result_column = new DataGridViewTextBoxColumn();
            rounds_column = new DataGridViewTextBoxColumn();
            rival_column = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tournaments_column, result_column, rounds_column, rival_column });
            dataGridView1.Location = new Point(-1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(707, 350);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // playersGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 346);
            Controls.Add(dataGridView1);
            Name = "playersGrid";
            Text = "playersGrid";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tournaments_column;
        private DataGridViewTextBoxColumn result_column;
        private DataGridViewTextBoxColumn rounds_column;
        private DataGridViewTextBoxColumn rival_column;
    }
}