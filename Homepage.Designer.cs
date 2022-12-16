namespace RestaurantBillingSystem
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.LinkLabel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.removeitembtn = new System.Windows.Forms.Button();
            this.updateitembtn = new System.Windows.Forms.Button();
            this.additembtn = new System.Windows.Forms.Button();
            this.orderbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateitems_UC1 = new RestaurantBillingSystem.updateitems_UC();
            this.placeorder_uc1 = new RestaurantBillingSystem.placeorder_uc();
            this.addItems_UC11 = new RestaurantBillingSystem.addItems_UC1();
            this.removeItem_UC1 = new RestaurantBillingSystem.RemoveItem_UC();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Controls.Add(this.removeitembtn);
            this.panel1.Controls.Add(this.updateitembtn);
            this.panel1.Controls.Add(this.additembtn);
            this.panel1.Controls.Add(this.orderbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            // 
            // logoutbtn
            // 
            this.logoutbtn.AutoSize = true;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutbtn.LinkColor = System.Drawing.Color.Black;
            this.logoutbtn.Location = new System.Drawing.Point(68, 483);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(60, 16);
            this.logoutbtn.TabIndex = 7;
            this.logoutbtn.TabStop = true;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutbtn_LinkClicked);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(0, 0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(20, 21);
            this.exitbtn.TabIndex = 6;
            this.exitbtn.Text = "X";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // removeitembtn
            // 
            this.removeitembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeitembtn.Location = new System.Drawing.Point(30, 342);
            this.removeitembtn.Name = "removeitembtn";
            this.removeitembtn.Size = new System.Drawing.Size(170, 39);
            this.removeitembtn.TabIndex = 5;
            this.removeitembtn.Text = "Remove Items";
            this.removeitembtn.UseVisualStyleBackColor = true;
            this.removeitembtn.Click += new System.EventHandler(this.removeitembtn_Click);
            // 
            // updateitembtn
            // 
            this.updateitembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateitembtn.Location = new System.Drawing.Point(30, 261);
            this.updateitembtn.Name = "updateitembtn";
            this.updateitembtn.Size = new System.Drawing.Size(170, 39);
            this.updateitembtn.TabIndex = 4;
            this.updateitembtn.Text = "Update Items";
            this.updateitembtn.UseVisualStyleBackColor = true;
            this.updateitembtn.Click += new System.EventHandler(this.updateitembtn_Click);
            // 
            // additembtn
            // 
            this.additembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additembtn.Location = new System.Drawing.Point(30, 175);
            this.additembtn.Name = "additembtn";
            this.additembtn.Size = new System.Drawing.Size(170, 39);
            this.additembtn.TabIndex = 3;
            this.additembtn.Text = "Add Items";
            this.additembtn.UseVisualStyleBackColor = true;
            this.additembtn.Click += new System.EventHandler(this.additembtn_Click);
            // 
            // orderbtn
            // 
            this.orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbtn.Location = new System.Drawing.Point(30, 93);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(170, 39);
            this.orderbtn.TabIndex = 2;
            this.orderbtn.Text = "Order";
            this.orderbtn.UseVisualStyleBackColor = true;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.removeItem_UC1);
            this.panel3.Controls.Add(this.updateitems_UC1);
            this.panel3.Controls.Add(this.placeorder_uc1);
            this.panel3.Controls.Add(this.addItems_UC11);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(212, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 514);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // updateitems_UC1
            // 
            this.updateitems_UC1.BackColor = System.Drawing.Color.White;
            this.updateitems_UC1.Location = new System.Drawing.Point(-2, 0);
            this.updateitems_UC1.Name = "updateitems_UC1";
            this.updateitems_UC1.Size = new System.Drawing.Size(781, 514);
            this.updateitems_UC1.TabIndex = 4;
            // 
            // placeorder_uc1
            // 
            this.placeorder_uc1.BackColor = System.Drawing.Color.White;
            this.placeorder_uc1.Location = new System.Drawing.Point(-1, 0);
            this.placeorder_uc1.Name = "placeorder_uc1";
            this.placeorder_uc1.Size = new System.Drawing.Size(781, 514);
            this.placeorder_uc1.TabIndex = 3;
            // 
            // addItems_UC11
            // 
            this.addItems_UC11.BackColor = System.Drawing.Color.White;
            this.addItems_UC11.Location = new System.Drawing.Point(-1, 0);
            this.addItems_UC11.Name = "addItems_UC11";
            this.addItems_UC11.Size = new System.Drawing.Size(781, 514);
            this.addItems_UC11.TabIndex = 2;
            // 
            // removeItem_UC1
            // 
            this.removeItem_UC1.BackColor = System.Drawing.Color.White;
            this.removeItem_UC1.Location = new System.Drawing.Point(-1, 0);
            this.removeItem_UC1.Name = "removeItem_UC1";
            this.removeItem_UC1.Size = new System.Drawing.Size(781, 514);
            this.removeItem_UC1.TabIndex = 5;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button removeitembtn;
        private System.Windows.Forms.Button updateitembtn;
        private System.Windows.Forms.Button additembtn;
        private System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.LinkLabel logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private addItems_UC1 addItems_UC11;
        private placeorder_uc placeorder_uc1;
        private updateitems_UC updateitems_UC1;
        private RemoveItem_UC removeItem_UC1;
    }
}