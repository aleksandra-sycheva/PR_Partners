namespace PR4_Patners
{
    partial class FormMain
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
            panelSetting = new Panel();
            bttnHistory = new Button();
            bttnDelete = new Button();
            bttnUpdate = new Button();
            bttnCreate = new Button();
            panelPartners = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelSetting.SuspendLayout();
            SuspendLayout();
            // 
            // panelSetting
            // 
            panelSetting.Controls.Add(bttnHistory);
            panelSetting.Controls.Add(bttnDelete);
            panelSetting.Controls.Add(bttnUpdate);
            panelSetting.Controls.Add(bttnCreate);
            panelSetting.Dock = DockStyle.Top;
            panelSetting.Location = new Point(0, 0);
            panelSetting.Name = "panelSetting";
            panelSetting.Size = new Size(943, 103);
            panelSetting.TabIndex = 0;
            // 
            // bttnHistory
            // 
            bttnHistory.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bttnHistory.Location = new Point(701, 10);
            bttnHistory.Margin = new Padding(10);
            bttnHistory.Name = "bttnHistory";
            bttnHistory.Size = new Size(194, 76);
            bttnHistory.TabIndex = 5;
            bttnHistory.Text = "История";
            bttnHistory.UseVisualStyleBackColor = true;
            bttnHistory.Click += bttnHistory_Click;
            // 
            // bttnDelete
            // 
            bttnDelete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bttnDelete.Location = new Point(487, 10);
            bttnDelete.Margin = new Padding(10);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(194, 76);
            bttnDelete.TabIndex = 4;
            bttnDelete.Text = "Удалить";
            bttnDelete.UseVisualStyleBackColor = true;
            bttnDelete.Click += bttnDelete_Click;
            // 
            // bttnUpdate
            // 
            bttnUpdate.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bttnUpdate.Location = new Point(240, 10);
            bttnUpdate.Margin = new Padding(10);
            bttnUpdate.Name = "bttnUpdate";
            bttnUpdate.Size = new Size(227, 76);
            bttnUpdate.TabIndex = 3;
            bttnUpdate.Text = "Редактировать";
            bttnUpdate.UseVisualStyleBackColor = true;
            bttnUpdate.Click += bttnUpdate_Click;
            // 
            // bttnCreate
            // 
            bttnCreate.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bttnCreate.Location = new Point(26, 10);
            bttnCreate.Margin = new Padding(10);
            bttnCreate.Name = "bttnCreate";
            bttnCreate.Size = new Size(194, 76);
            bttnCreate.TabIndex = 2;
            bttnCreate.Text = "Создать";
            bttnCreate.UseVisualStyleBackColor = true;
            bttnCreate.Click += bttnCreate_Click;
            // 
            // panelPartners
            // 
            panelPartners.AutoScroll = true;
            panelPartners.Dock = DockStyle.Fill;
            panelPartners.Location = new Point(0, 103);
            panelPartners.Name = "panelPartners";
            panelPartners.Size = new Size(943, 749);
            panelPartners.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 852);
            Controls.Add(panelPartners);
            Controls.Add(panelSetting);
            MinimumSize = new Size(750, 255);
            Name = "FormMain";
            Text = "Список партнеров";
            panelSetting.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSetting;
        private Panel panelPartners;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bttnCreate;
        private Button bttnUpdate;
        private Button bttnHistory;
        private Button bttnDelete;
    }
}
