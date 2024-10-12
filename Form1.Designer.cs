namespace Inventory_Management_System
{
    partial class Inventory
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
            InventoryManagementTitle = new Label();
            priceTextBox = new TextBox();
            InventoryGridView = new DataGridView();
            newButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            descriptionTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            skuTextBox = new TextBox();
            nameTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // InventoryManagementTitle
            // 
            InventoryManagementTitle.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryManagementTitle.Location = new Point(75, 5);
            InventoryManagementTitle.Name = "InventoryManagementTitle";
            InventoryManagementTitle.Size = new Size(841, 46);
            InventoryManagementTitle.TabIndex = 0;
            InventoryManagementTitle.Text = "INVENTORY MANAGEMENT SYSTEM";
            InventoryManagementTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(12, 121);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(275, 23);
            priceTextBox.TabIndex = 1;
            // 
            // InventoryGridView
            // 
            InventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryGridView.BackgroundColor = SystemColors.AppWorkspace;
            InventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGridView.Location = new Point(12, 187);
            InventoryGridView.Name = "InventoryGridView";
            InventoryGridView.Size = new Size(872, 311);
            InventoryGridView.TabIndex = 2;
            InventoryGridView.CellContentDoubleClick += InventoryGridView_CellContentDoubleClick;
            // 
            // newButton
            // 
            newButton.BackColor = SystemColors.ButtonFace;
            newButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newButton.Location = new Point(12, 152);
            newButton.Name = "newButton";
            newButton.Size = new Size(275, 25);
            newButton.TabIndex = 3;
            newButton.Text = "New";
            newButton.TextAlign = ContentAlignment.TopCenter;
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ButtonFace;
            saveButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(311, 152);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(275, 25);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.TextAlign = ContentAlignment.TopCenter;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ButtonFace;
            deleteButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(609, 152);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(275, 25);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.TextAlign = ContentAlignment.TopCenter;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(311, 121);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(275, 23);
            descriptionTextBox.TabIndex = 6;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(609, 121);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(275, 23);
            QuantityTextBox.TabIndex = 7;
            // 
            // skuTextBox
            // 
            skuTextBox.Location = new Point(12, 77);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(275, 23);
            skuTextBox.TabIndex = 8;
            skuTextBox.Text = "01";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(311, 77);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(275, 23);
            nameTextBox.TabIndex = 9;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "All", "Chinese", "Drinks", "Deserts" });
            categoryComboBox.Location = new Point(609, 77);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(275, 23);
            categoryComboBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(275, 15);
            label1.TabIndex = 11;
            label1.Text = "SKU :";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(311, 63);
            label2.Name = "label2";
            label2.Size = new Size(275, 15);
            label2.TabIndex = 12;
            label2.Text = "NAME :";
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(609, 63);
            label3.Name = "label3";
            label3.Size = new Size(275, 15);
            label3.TabIndex = 13;
            label3.Text = "CATEGORY :";
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(12, 108);
            label4.Name = "label4";
            label4.Size = new Size(275, 15);
            label4.TabIndex = 14;
            label4.Text = "PRICE :";
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(311, 107);
            label5.Name = "label5";
            label5.Size = new Size(275, 15);
            label5.TabIndex = 15;
            label5.Text = "DESCRIPTION :";
            // 
            // label6
            // 
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(609, 107);
            label6.Name = "label6";
            label6.Size = new Size(275, 15);
            label6.TabIndex = 16;
            label6.Text = "QYT :";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(896, 503);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(categoryComboBox);
            Controls.Add(nameTextBox);
            Controls.Add(skuTextBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(InventoryGridView);
            Controls.Add(priceTextBox);
            Controls.Add(InventoryManagementTitle);
            Name = "Inventory";
            Text = "Inventory Managment System";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InventoryManagementTitle;
        private TextBox priceTextBox;
        private DataGridView InventoryGridView;
        private Button newButton;
        private Button saveButton;
        private Button deleteButton;
        private TextBox descriptionTextBox;
        private TextBox QuantityTextBox;
        private TextBox skuTextBox;
        private TextBox nameTextBox;
        private ComboBox categoryComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
