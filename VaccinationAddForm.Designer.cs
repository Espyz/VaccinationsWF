namespace VaccinationsWF
{
    partial class VaccinationAddForm
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
            NameLabel = new Label();
            TypeBox = new ComboBox();
            TypeLabel = new Label();
            DateLabel = new Label();
            DatePicker = new DateTimePicker();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(37, 45);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(298, 37);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Добавление прививки";
            // 
            // TypeBox
            // 
            TypeBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TypeBox.FormattingEnabled = true;
            TypeBox.Location = new Point(12, 157);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(157, 23);
            TypeBox.TabIndex = 1;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TypeLabel.Location = new Point(0, 112);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(157, 30);
            TypeLabel.TabIndex = 2;
            TypeLabel.Text = "Тип прививки";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(197, 112);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(165, 30);
            DateLabel.TabIndex = 3;
            DateLabel.Text = "Дата прививки";
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(197, 157);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(140, 23);
            DatePicker.TabIndex = 4;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmButton.Location = new Point(84, 225);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(194, 72);
            ConfirmButton.TabIndex = 5;
            ConfirmButton.Text = "Добавить";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // VaccinationAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 336);
            Controls.Add(ConfirmButton);
            Controls.Add(DatePicker);
            Controls.Add(DateLabel);
            Controls.Add(TypeLabel);
            Controls.Add(TypeBox);
            Controls.Add(NameLabel);
            Name = "VaccinationAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private ComboBox TypeBox;
        private Label TypeLabel;
        private Label DateLabel;
        private DateTimePicker DatePicker;
        private Button ConfirmButton;
    }
}