namespace PR4_Patners
{
    partial class FormHistory
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
            panelHistory = new Panel();
            dataGridViewHistory = new DataGridView();
            panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // panelHistory
            // 
            panelHistory.Controls.Add(dataGridViewHistory);
            panelHistory.Dock = DockStyle.Fill;
            panelHistory.Location = new Point(0, 0);
            panelHistory.Name = "panelHistory";
            panelHistory.Padding = new Padding(11, 13, 11, 13);
            panelHistory.Size = new Size(861, 552);
            panelHistory.TabIndex = 0;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.BackgroundColor = SystemColors.Control;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Dock = DockStyle.Fill;
            dataGridViewHistory.Location = new Point(11, 13);
            dataGridViewHistory.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.Size = new Size(839, 526);
            dataGridViewHistory.TabIndex = 0;
            // 
            // FormHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 552);
            Controls.Add(panelHistory);
            Name = "FormHistory";
            Text = "История реализации";
            panelHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHistory;
        private DataGridView dataGridViewHistory;
    }
}