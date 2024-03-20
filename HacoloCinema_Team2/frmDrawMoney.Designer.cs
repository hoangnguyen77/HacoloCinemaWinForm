namespace HacoloCinema_Team2
{
    partial class frmDrawMoney
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
            btnDrawMoney = new Button();
            label3 = new Label();
            txtMoney = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDrawMoney
            // 
            btnDrawMoney.Location = new Point(155, 149);
            btnDrawMoney.Name = "btnDrawMoney";
            btnDrawMoney.Size = new Size(94, 29);
            btnDrawMoney.TabIndex = 8;
            btnDrawMoney.Text = "Draw";
            btnDrawMoney.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 75);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 7;
            label3.Text = "Total money:";
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(105, 107);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(182, 27);
            txtMoney.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 5;
            label1.Text = "Curent total balance: ";
            // 
            // frmDrawMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 207);
            Controls.Add(btnDrawMoney);
            Controls.Add(label3);
            Controls.Add(txtMoney);
            Controls.Add(label1);
            Name = "frmDrawMoney";
            Text = "Draw your money";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDrawMoney;
        private Label label3;
        private TextBox txtMoney;
        private Label label1;
    }
}