
namespace PizzeriaOrderingSystemUI
{
    partial class MenuForm
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
            this.createOrderButton = new System.Windows.Forms.Button();
            this.orderHistoryButton = new System.Windows.Forms.Button();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.menuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createOrderButton
            // 
            this.createOrderButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.createOrderButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createOrderButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createOrderButton.Location = new System.Drawing.Point(105, 89);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(220, 58);
            this.createOrderButton.TabIndex = 6;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = false;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // orderHistoryButton
            // 
            this.orderHistoryButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.orderHistoryButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderHistoryButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderHistoryButton.Location = new System.Drawing.Point(105, 162);
            this.orderHistoryButton.Name = "orderHistoryButton";
            this.orderHistoryButton.Size = new System.Drawing.Size(220, 58);
            this.orderHistoryButton.TabIndex = 7;
            this.orderHistoryButton.Text = "Order History";
            this.orderHistoryButton.UseVisualStyleBackColor = false;
            this.orderHistoryButton.Click += new System.EventHandler(this.orderHistoryButton_Click);
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.quitButton);
            this.menuGroupBox.Controls.Add(this.helloLabel);
            this.menuGroupBox.Controls.Add(this.createOrderButton);
            this.menuGroupBox.Controls.Add(this.orderHistoryButton);
            this.menuGroupBox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuGroupBox.Location = new System.Drawing.Point(12, 12);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(447, 410);
            this.menuGroupBox.TabIndex = 8;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu";
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.quitButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.quitButton.Location = new System.Drawing.Point(105, 236);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(220, 58);
            this.quitButton.TabIndex = 9;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helloLabel.Location = new System.Drawing.Point(6, 42);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(52, 21);
            this.helloLabel.TabIndex = 8;
            this.helloLabel.Text = "label1";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 424);
            this.Controls.Add(this.menuGroupBox);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.menuGroupBox.ResumeLayout(false);
            this.menuGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button orderHistoryButton;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Button quitButton;
    }
}