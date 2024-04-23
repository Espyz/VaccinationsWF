namespace VaccinationsWF
{
    partial class VaccinationsTable
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
            VaccinationView = new DataGridView();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)VaccinationView).BeginInit();
            SuspendLayout();
            // 
            // VaccinationView
            // 
            VaccinationView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VaccinationView.Location = new Point(12, 12);
            VaccinationView.Name = "VaccinationView";
            VaccinationView.ReadOnly = true;
            VaccinationView.RowTemplate.Height = 25;
            VaccinationView.Size = new Size(474, 426);
            VaccinationView.TabIndex = 0;
            VaccinationView.CellContentClick += VaccinationView_CellContentClick;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(578, 41);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(139, 44);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить запись";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // VaccinationsTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
            Controls.Add(VaccinationView);
            Name = "VaccinationsTable";
            Text = "VaccinationsTable";
            Load += VaccinationsTable_Load;
            ((System.ComponentModel.ISupportInitialize)VaccinationView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView VaccinationView;
        private Button AddButton;
    }
}