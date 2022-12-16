namespace RestaurantBillingSystem
{
    partial class addItems_UC1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.additembtn = new System.Windows.Forms.Button();
            this.categorybox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itembox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item List";
            // 
            // additembtn
            // 
            this.additembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additembtn.Location = new System.Drawing.Point(297, 427);
            this.additembtn.Name = "additembtn";
            this.additembtn.Size = new System.Drawing.Size(159, 34);
            this.additembtn.TabIndex = 1;
            this.additembtn.Text = "Add Item";
            this.additembtn.UseVisualStyleBackColor = true;
            this.additembtn.Click += new System.EventHandler(this.additembtn_Click);
            // 
            // categorybox
            // 
            this.categorybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybox.ForeColor = System.Drawing.Color.Black;
            this.categorybox.FormattingEnabled = true;
            this.categorybox.Items.AddRange(new object[] {
            "Appetizer",
            "Main Course",
            "Dessert",
            "Drinks"});
            this.categorybox.Location = new System.Drawing.Point(212, 157);
            this.categorybox.Name = "categorybox";
            this.categorybox.Size = new System.Drawing.Size(305, 28);
            this.categorybox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // itembox
            // 
            this.itembox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itembox.ForeColor = System.Drawing.Color.Black;
            this.itembox.Location = new System.Drawing.Point(214, 241);
            this.itembox.Name = "itembox";
            this.itembox.Size = new System.Drawing.Size(303, 26);
            this.itembox.TabIndex = 6;
            // 
            // pricebox
            // 
            this.pricebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebox.ForeColor = System.Drawing.Color.Black;
            this.pricebox.Location = new System.Drawing.Point(214, 334);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(303, 26);
            this.pricebox.TabIndex = 7;
            // 
            // addItems_UC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.itembox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categorybox);
            this.Controls.Add(this.additembtn);
            this.Controls.Add(this.label1);
            this.Name = "addItems_UC1";
            this.Size = new System.Drawing.Size(781, 514);
            this.Leave += new System.EventHandler(this.addItems_UC1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button additembtn;
        private System.Windows.Forms.ComboBox categorybox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itembox;
        private System.Windows.Forms.TextBox pricebox;
    }
}
