namespace ProductCrudApp
{
    partial class Form1
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
            label1 = new Label();
            btnAddProd = new Button();
            btnEditProd = new Button();
            btnDeleteProd = new Button();
            productsTable = new DataGridView();
            label2 = new Label();
            lbltval = new Label();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(783, 21);
            label1.TabIndex = 0;
            label1.Text = "List of Products";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddProd
            // 
            btnAddProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddProd.Location = new Point(12, 56);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(113, 59);
            btnAddProd.TabIndex = 1;
            btnAddProd.Text = "Add Product";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // btnEditProd
            // 
            btnEditProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditProd.Location = new Point(137, 56);
            btnEditProd.Name = "btnEditProd";
            btnEditProd.Size = new Size(113, 59);
            btnEditProd.TabIndex = 2;
            btnEditProd.Text = "Edit Product";
            btnEditProd.UseVisualStyleBackColor = true;
            btnEditProd.Click += btnEditProd_Click;
            // 
            // btnDeleteProd
            // 
            btnDeleteProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteProd.Location = new Point(669, 56);
            btnDeleteProd.Name = "btnDeleteProd";
            btnDeleteProd.Size = new Size(113, 59);
            btnDeleteProd.TabIndex = 3;
            btnDeleteProd.Text = "Delete Product";
            btnDeleteProd.UseVisualStyleBackColor = true;
            btnDeleteProd.Click += btnDeleteProd_Click;
            // 
            // productsTable
            // 
            productsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsTable.Location = new Point(12, 123);
            productsTable.MultiSelect = false;
            productsTable.Name = "productsTable";
            productsTable.RowHeadersVisible = false;
            productsTable.RowTemplate.Height = 25;
            productsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsTable.Size = new Size(770, 325);
            productsTable.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 78);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Total Value: ";
            // 
            // lbltval
            // 
            lbltval.AutoSize = true;
            lbltval.Location = new Point(375, 78);
            lbltval.Name = "lbltval";
            lbltval.Size = new Size(0, 15);
            lbltval.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 460);
            Controls.Add(lbltval);
            Controls.Add(label2);
            Controls.Add(productsTable);
            Controls.Add(btnDeleteProd);
            Controls.Add(btnEditProd);
            Controls.Add(btnAddProd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Product Interface";
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddProd;
        private Button btnEditProd;
        private Button btnDeleteProd;
        private DataGridView productsTable;
        private Label label2;
        private Label lbltval;
    }
}
