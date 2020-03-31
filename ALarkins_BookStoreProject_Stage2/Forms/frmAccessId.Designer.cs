namespace ALarkins_BookStoreProject_Stage2
{
    partial class frmAccessID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccessID));
            this.txtAccessId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAccessId = new System.Windows.Forms.Label();
            this.pictureLibrary = new System.Windows.Forms.PictureBox();
            this.lblToAccessABook = new System.Windows.Forms.Label();
            this.lblWelcome3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAccessId
            // 
            this.txtAccessId.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccessId.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtAccessId.Location = new System.Drawing.Point(331, 355);
            this.txtAccessId.Multiline = true;
            this.txtAccessId.Name = "txtAccessId";
            this.txtAccessId.Size = new System.Drawing.Size(217, 81);
            this.txtAccessId.TabIndex = 1;
            this.txtAccessId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(554, 355);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 80);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblWelcome.Location = new System.Drawing.Point(26, 84);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(165, 31);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome To";
            // 
            // lblAccessId
            // 
            this.lblAccessId.AutoSize = true;
            this.lblAccessId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessId.ForeColor = System.Drawing.Color.Navy;
            this.lblAccessId.Location = new System.Drawing.Point(27, 380);
            this.lblAccessId.Name = "lblAccessId";
            this.lblAccessId.Size = new System.Drawing.Size(288, 26);
            this.lblAccessId.TabIndex = 4;
            this.lblAccessId.Text = "Enter Your 5 digit Access Id:";
            // 
            // pictureLibrary
            // 
            this.pictureLibrary.Image = ((System.Drawing.Image)(resources.GetObject("pictureLibrary.Image")));
            this.pictureLibrary.Location = new System.Drawing.Point(367, 40);
            this.pictureLibrary.Name = "pictureLibrary";
            this.pictureLibrary.Size = new System.Drawing.Size(371, 299);
            this.pictureLibrary.TabIndex = 5;
            this.pictureLibrary.TabStop = false;
            // 
            // lblToAccessABook
            // 
            this.lblToAccessABook.AutoSize = true;
            this.lblToAccessABook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToAccessABook.ForeColor = System.Drawing.Color.Navy;
            this.lblToAccessABook.Location = new System.Drawing.Point(27, 337);
            this.lblToAccessABook.Name = "lblToAccessABook";
            this.lblToAccessABook.Size = new System.Drawing.Size(254, 26);
            this.lblToAccessABook.TabIndex = 6;
            this.lblToAccessABook.Text = "To Access The Database";
            // 
            // lblWelcome3
            // 
            this.lblWelcome3.AutoSize = true;
            this.lblWelcome3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome3.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblWelcome3.Location = new System.Drawing.Point(144, 206);
            this.lblWelcome3.Name = "lblWelcome3";
            this.lblWelcome3.Size = new System.Drawing.Size(196, 31);
            this.lblWelcome3.TabIndex = 7;
            this.lblWelcome3.Text = "Book Inventory";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(650, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 78);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome2
            // 
            this.lblWelcome2.AutoSize = true;
            this.lblWelcome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome2.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblWelcome2.Location = new System.Drawing.Point(85, 142);
            this.lblWelcome2.Name = "lblWelcome2";
            this.lblWelcome2.Size = new System.Drawing.Size(151, 31);
            this.lblWelcome2.TabIndex = 11;
            this.lblWelcome2.Text = "The Library";
            // 
            // frmAccessID
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWelcome3);
            this.Controls.Add(this.lblToAccessABook);
            this.Controls.Add(this.pictureLibrary);
            this.Controls.Add(this.lblAccessId);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtAccessId);
            this.Name = "frmAccessID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Access Id Page";
            this.Load += new System.EventHandler(this.frmAccessID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccessId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAccessId;
        private System.Windows.Forms.PictureBox pictureLibrary;
        private System.Windows.Forms.Label lblToAccessABook;
        private System.Windows.Forms.Label lblWelcome3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcome2;
    }
}

