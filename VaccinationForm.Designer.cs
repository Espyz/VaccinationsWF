namespace VaccinationsWF
{
    partial class VaccinationForm
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
            EmployersTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)EmployersTable).BeginInit();
            SuspendLayout();
            // 
            // EmployersTable
            // 
            EmployersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployersTable.Location = new Point(12, 12);
            EmployersTable.Name = "EmployersTable";
            EmployersTable.ReadOnly = true;
            EmployersTable.RowTemplate.Height = 25;
            EmployersTable.Size = new Size(776, 424);
            EmployersTable.TabIndex = 0;
            EmployersTable.CellContentClick += EmployersTable_CellContentClick;
            // 
            // VaccinationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(EmployersTable);
            Name = "VaccinationForm";
            Load += VaccinationForm_Load;
            ((System.ComponentModel.ISupportInitialize)EmployersTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView EmployersTable;
    }
}