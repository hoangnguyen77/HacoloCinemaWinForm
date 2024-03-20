namespace HacoloCinema_Team2
{
    partial class frmViewTransactions
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
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(34, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(368, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Total of your transactions: ";
            // 
            // frmViewTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 290);
            Controls.Add(lblTitle);
            Name = "frmViewTransactions";
            Text = "View history transactions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
    }
}