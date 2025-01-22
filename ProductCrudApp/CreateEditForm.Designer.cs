namespace ProductCrudApp
{
    partial class CreateEditForm
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
            label1 = new Label();
            lblID = new Label();
            label2 = new Label();
            tbProdName = new TextBox();
            tbQnty = new TextBox();
            label3 = new Label();
            tbPrice = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(554, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Product";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 72);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Product ID";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(213, 72);
            lblID.Name = "lblID";
            lblID.Size = new Size(10, 15);
            lblID.TabIndex = 2;
            lblID.Text = "l";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 98);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "Product Name";
            // 
            // tbProdName
            // 
            tbProdName.Location = new Point(213, 95);
            tbProdName.Name = "tbProdName";
            tbProdName.Size = new Size(212, 23);
            tbProdName.TabIndex = 4;
            // 
            // tbQnty
            // 
            tbQnty.Location = new Point(213, 124);
            tbQnty.Name = "tbQnty";
            tbQnty.Size = new Size(212, 23);
            tbQnty.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 127);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity In Stock";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(213, 153);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(212, 23);
            tbPrice.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 156);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(213, 182);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(294, 182);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 235);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbPrice);
            Controls.Add(label4);
            Controls.Add(tbQnty);
            Controls.Add(label3);
            Controls.Add(tbProdName);
            Controls.Add(label2);
            Controls.Add(lblID);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "CreateEditForm";
            Text = "Create Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblID;
        private Label label2;
        private TextBox tbProdName;
        private TextBox tbQnty;
        private Label label3;
        private TextBox tbPrice;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
    }
}