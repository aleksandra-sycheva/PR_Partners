namespace PR4_Patners
{
    partial class FormCreate
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
            TypeLabel = new Label();
            TypeComboBox = new ComboBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            LegalAdressLabel = new Label();
            LegalAdressTextBox = new TextBox();
            TINTextBox = new Label();
            IINTextBox = new TextBox();
            DirectorLabel = new Label();
            DirectorTextBox = new TextBox();
            PhoneLabel = new Label();
            PhoneTextBox = new TextBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            RatingLabel = new Label();
            RatingTextBox = new TextBox();
            bttnConfirm = new Button();
            SuspendLayout();
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TypeLabel.Location = new Point(12, 21);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(199, 31);
            TypeLabel.TabIndex = 0;
            TypeLabel.Text = "Тип организации:";
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Location = new Point(254, 24);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(187, 28);
            TypeComboBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(12, 68);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(176, 31);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Наименование:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(254, 74);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(368, 27);
            NameTextBox.TabIndex = 3;
            // 
            // LegalAdressLabel
            // 
            LegalAdressLabel.AutoSize = true;
            LegalAdressLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LegalAdressLabel.Location = new Point(12, 116);
            LegalAdressLabel.Name = "LegalAdressLabel";
            LegalAdressLabel.Size = new Size(236, 31);
            LegalAdressLabel.TabIndex = 4;
            LegalAdressLabel.Text = "Юридический адрес:";
            // 
            // LegalAdressTextBox
            // 
            LegalAdressTextBox.Location = new Point(254, 122);
            LegalAdressTextBox.Name = "LegalAdressTextBox";
            LegalAdressTextBox.Size = new Size(368, 27);
            LegalAdressTextBox.TabIndex = 5;
            // 
            // TINTextBox
            // 
            TINTextBox.AutoSize = true;
            TINTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TINTextBox.Location = new Point(12, 166);
            TINTextBox.Name = "TINTextBox";
            TINTextBox.Size = new Size(68, 31);
            TINTextBox.TabIndex = 6;
            TINTextBox.Text = "ИНН:";
            // 
            // IINTextBox
            // 
            IINTextBox.Location = new Point(253, 172);
            IINTextBox.Name = "IINTextBox";
            IINTextBox.Size = new Size(368, 27);
            IINTextBox.TabIndex = 7;
            // 
            // DirectorLabel
            // 
            DirectorLabel.AutoSize = true;
            DirectorLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DirectorLabel.Location = new Point(12, 215);
            DirectorLabel.Name = "DirectorLabel";
            DirectorLabel.Size = new Size(187, 31);
            DirectorLabel.TabIndex = 8;
            DirectorLabel.Text = "ФИО директора:";
            // 
            // DirectorTextBox
            // 
            DirectorTextBox.Location = new Point(254, 219);
            DirectorTextBox.Name = "DirectorTextBox";
            DirectorTextBox.Size = new Size(368, 27);
            DirectorTextBox.TabIndex = 9;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PhoneLabel.Location = new Point(12, 267);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(195, 31);
            PhoneLabel.TabIndex = 10;
            PhoneLabel.Text = "Номер телефона:";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(254, 273);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.PlaceholderText = "000 000 00 00";
            PhoneTextBox.Size = new Size(368, 27);
            PhoneTextBox.TabIndex = 11;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EmailLabel.Location = new Point(12, 315);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(75, 31);
            EmailLabel.TabIndex = 12;
            EmailLabel.Text = "Email:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(254, 321);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(368, 27);
            EmailTextBox.TabIndex = 13;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RatingLabel.Location = new Point(12, 365);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(101, 31);
            RatingLabel.TabIndex = 14;
            RatingLabel.Text = "Рейтинг:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(254, 369);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(187, 27);
            RatingTextBox.TabIndex = 15;
            // 
            // bttnConfirm
            // 
            bttnConfirm.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bttnConfirm.Location = new Point(100, 464);
            bttnConfirm.Name = "bttnConfirm";
            bttnConfirm.Size = new Size(450, 55);
            bttnConfirm.TabIndex = 16;
            bttnConfirm.Text = "Подтведить";
            bttnConfirm.UseVisualStyleBackColor = true;
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 544);
            Controls.Add(bttnConfirm);
            Controls.Add(RatingTextBox);
            Controls.Add(RatingLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(DirectorTextBox);
            Controls.Add(DirectorLabel);
            Controls.Add(IINTextBox);
            Controls.Add(TINTextBox);
            Controls.Add(LegalAdressTextBox);
            Controls.Add(LegalAdressLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(TypeComboBox);
            Controls.Add(TypeLabel);
            Name = "FormCreate";
            Text = "Добавление";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TypeLabel;
        private ComboBox TypeComboBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label LegalAdressLabel;
        private TextBox LegalAdressTextBox;
        private Label TINTextBox;
        private TextBox IINTextBox;
        private Label DirectorLabel;
        private TextBox DirectorTextBox;
        private Label PhoneLabel;
        private TextBox PhoneTextBox;
        private Label EmailLabel;
        private TextBox EmailTextBox;
        private Label RatingLabel;
        private TextBox RatingTextBox;
        private Button bttnConfirm;
    }
}