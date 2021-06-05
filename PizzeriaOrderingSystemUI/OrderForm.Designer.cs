
namespace PizzeriaOrderingSystemUI
{
    partial class OrderForm
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
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addToBasketLabel = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.selectAdditionLabel = new System.Windows.Forms.Label();
            this.selectDishLabel = new System.Windows.Forms.Label();
            this.additionListBox = new System.Windows.Forms.ListBox();
            this.dishesListBox = new System.Windows.Forms.ListBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.basketGroupBox = new System.Windows.Forms.GroupBox();
            this.completeOrderButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.orderNoteLabel = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.orderedItemsListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.basketGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Controls.Add(this.numericUpDown);
            this.orderGroupBox.Controls.Add(this.quantityLabel);
            this.orderGroupBox.Controls.Add(this.priceTextBox);
            this.orderGroupBox.Controls.Add(this.addToBasketLabel);
            this.orderGroupBox.Controls.Add(this.priceLabel);
            this.orderGroupBox.Controls.Add(this.selectAdditionLabel);
            this.orderGroupBox.Controls.Add(this.selectDishLabel);
            this.orderGroupBox.Controls.Add(this.additionListBox);
            this.orderGroupBox.Controls.Add(this.dishesListBox);
            this.orderGroupBox.Controls.Add(this.categoryLabel);
            this.orderGroupBox.Controls.Add(this.categoryComboBox);
            this.orderGroupBox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderGroupBox.Location = new System.Drawing.Point(-5, 0);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(480, 474);
            this.orderGroupBox.TabIndex = 1;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Make your order";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown.Location = new System.Drawing.Point(100, 344);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(68, 29);
            this.numericUpDown.TabIndex = 10;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(17, 346);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(77, 21);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(94, 405);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(102, 46);
            this.priceTextBox.TabIndex = 8;
            // 
            // addToBasketLabel
            // 
            this.addToBasketLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.addToBasketLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addToBasketLabel.Location = new System.Drawing.Point(239, 368);
            this.addToBasketLabel.Name = "addToBasketLabel";
            this.addToBasketLabel.Size = new System.Drawing.Size(192, 83);
            this.addToBasketLabel.TabIndex = 7;
            this.addToBasketLabel.Text = "Add to Basket";
            this.addToBasketLabel.UseVisualStyleBackColor = false;
            this.addToBasketLabel.Click += new System.EventHandler(this.addToBasketLabel_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(17, 414);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(71, 32);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price";
            // 
            // selectAdditionLabel
            // 
            this.selectAdditionLabel.AutoSize = true;
            this.selectAdditionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectAdditionLabel.Location = new System.Drawing.Point(249, 111);
            this.selectAdditionLabel.Name = "selectAdditionLabel";
            this.selectAdditionLabel.Size = new System.Drawing.Size(127, 21);
            this.selectAdditionLabel.TabIndex = 5;
            this.selectAdditionLabel.Text = "Select Addition";
            // 
            // selectDishLabel
            // 
            this.selectDishLabel.AutoSize = true;
            this.selectDishLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectDishLabel.Location = new System.Drawing.Point(17, 111);
            this.selectDishLabel.Name = "selectDishLabel";
            this.selectDishLabel.Size = new System.Drawing.Size(94, 21);
            this.selectDishLabel.TabIndex = 4;
            this.selectDishLabel.Text = "Select Dish";
            // 
            // additionListBox
            // 
            this.additionListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.additionListBox.FormattingEnabled = true;
            this.additionListBox.ItemHeight = 21;
            this.additionListBox.Location = new System.Drawing.Point(249, 135);
            this.additionListBox.Name = "additionListBox";
            this.additionListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.additionListBox.Size = new System.Drawing.Size(182, 193);
            this.additionListBox.TabIndex = 3;
            this.additionListBox.SelectedIndexChanged += new System.EventHandler(this.additionListBox_SelectedIndexChanged);
            // 
            // dishesListBox
            // 
            this.dishesListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dishesListBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dishesListBox.FormattingEnabled = true;
            this.dishesListBox.ItemHeight = 21;
            this.dishesListBox.Location = new System.Drawing.Point(17, 135);
            this.dishesListBox.Name = "dishesListBox";
            this.dishesListBox.Size = new System.Drawing.Size(192, 193);
            this.dishesListBox.TabIndex = 2;
            this.dishesListBox.SelectedIndexChanged += new System.EventHandler(this.dishesListBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(17, 53);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(80, 21);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Pizza",
            "Main Dish",
            "Soup",
            "Drink"});
            this.categoryComboBox.Location = new System.Drawing.Point(100, 50);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(153, 29);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // basketGroupBox
            // 
            this.basketGroupBox.Controls.Add(this.completeOrderButton);
            this.basketGroupBox.Controls.Add(this.noteTextBox);
            this.basketGroupBox.Controls.Add(this.orderNoteLabel);
            this.basketGroupBox.Controls.Add(this.totalPriceTextBox);
            this.basketGroupBox.Controls.Add(this.totalPriceLabel);
            this.basketGroupBox.Controls.Add(this.removeSelectedButton);
            this.basketGroupBox.Controls.Add(this.orderedItemsListBox);
            this.basketGroupBox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.basketGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.basketGroupBox.Location = new System.Drawing.Point(481, 0);
            this.basketGroupBox.Name = "basketGroupBox";
            this.basketGroupBox.Size = new System.Drawing.Size(635, 576);
            this.basketGroupBox.TabIndex = 2;
            this.basketGroupBox.TabStop = false;
            this.basketGroupBox.Text = "Basket";
            // 
            // completeOrderButton
            // 
            this.completeOrderButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.completeOrderButton.Location = new System.Drawing.Point(356, 482);
            this.completeOrderButton.Name = "completeOrderButton";
            this.completeOrderButton.Size = new System.Drawing.Size(273, 88);
            this.completeOrderButton.TabIndex = 6;
            this.completeOrderButton.Text = "Complete Order";
            this.completeOrderButton.UseVisualStyleBackColor = false;
            this.completeOrderButton.Click += new System.EventHandler(this.completeOrderButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteTextBox.Location = new System.Drawing.Point(8, 318);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(388, 89);
            this.noteTextBox.TabIndex = 5;
            // 
            // orderNoteLabel
            // 
            this.orderNoteLabel.AutoSize = true;
            this.orderNoteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderNoteLabel.Location = new System.Drawing.Point(6, 294);
            this.orderNoteLabel.Name = "orderNoteLabel";
            this.orderNoteLabel.Size = new System.Drawing.Size(102, 21);
            this.orderNoteLabel.TabIndex = 4;
            this.orderNoteLabel.Text = "Order Notes";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalPriceTextBox.Location = new System.Drawing.Point(8, 490);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(194, 71);
            this.totalPriceTextBox.TabIndex = 3;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceLabel.Location = new System.Drawing.Point(8, 447);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(160, 40);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "Total Price";
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.removeSelectedButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedButton.Location = new System.Drawing.Point(417, 45);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(155, 72);
            this.removeSelectedButton.TabIndex = 1;
            this.removeSelectedButton.Text = "Remove Selected Item";
            this.removeSelectedButton.UseVisualStyleBackColor = false;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // orderedItemsListBox
            // 
            this.orderedItemsListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderedItemsListBox.FormattingEnabled = true;
            this.orderedItemsListBox.ItemHeight = 15;
            this.orderedItemsListBox.Location = new System.Drawing.Point(6, 45);
            this.orderedItemsListBox.Name = "orderedItemsListBox";
            this.orderedItemsListBox.Size = new System.Drawing.Size(390, 229);
            this.orderedItemsListBox.TabIndex = 0;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 599);
            this.Controls.Add(this.basketGroupBox);
            this.Controls.Add(this.orderGroupBox);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Order";
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.basketGroupBox.ResumeLayout(false);
            this.basketGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ListBox dishesListBox;
        private System.Windows.Forms.ListBox additionListBox;
        private System.Windows.Forms.Label selectAdditionLabel;
        private System.Windows.Forms.Label selectDishLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button addToBasketLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.GroupBox basketGroupBox;
        private System.Windows.Forms.ListBox orderedItemsListBox;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button completeOrderButton;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label orderNoteLabel;
    }
}