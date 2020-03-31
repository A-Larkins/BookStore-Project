namespace ALarkins_BookStoreProject_Stage2.Forms
{
    partial class frmBook
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
            this.btnDone = new System.Windows.Forms.Button();
            this.txtDataDate = new System.Windows.Forms.TextBox();
            this.txtDataOnHand = new System.Windows.Forms.TextBox();
            this.txtDataPrice = new System.Windows.Forms.TextBox();
            this.txtDataAuthor = new System.Windows.Forms.TextBox();
            this.txtDataTitle = new System.Windows.Forms.TextBox();
            this.txtDataISBN = new System.Windows.Forms.TextBox();
            this.lblDataTransactionDate = new System.Windows.Forms.Label();
            this.lblDataOnHand = new System.Windows.Forms.Label();
            this.lblDataPrice = new System.Windows.Forms.Label();
            this.lblDataAuthor = new System.Windows.Forms.Label();
            this.lblDataTitle = new System.Windows.Forms.Label();
            this.lblDataISBN = new System.Windows.Forms.Label();
            this.lblEnterBookData = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblSelectTransaction = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtISBNRight = new System.Windows.Forms.TextBox();
            this.lblHyphen = new System.Windows.Forms.Label();
            this.txtISBNLeft = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Red;
            this.btnDone.Location = new System.Drawing.Point(630, 399);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(113, 65);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtDataDate
            // 
            this.txtDataDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataDate.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtDataDate.Location = new System.Drawing.Point(630, 341);
            this.txtDataDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataDate.Multiline = true;
            this.txtDataDate.Name = "txtDataDate";
            this.txtDataDate.Size = new System.Drawing.Size(113, 35);
            this.txtDataDate.TabIndex = 12;
            this.txtDataDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataDate.Visible = false;
            // 
            // txtDataOnHand
            // 
            this.txtDataOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataOnHand.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtDataOnHand.Location = new System.Drawing.Point(630, 294);
            this.txtDataOnHand.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataOnHand.Multiline = true;
            this.txtDataOnHand.Name = "txtDataOnHand";
            this.txtDataOnHand.Size = new System.Drawing.Size(113, 35);
            this.txtDataOnHand.TabIndex = 11;
            this.txtDataOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataOnHand.Visible = false;
            // 
            // txtDataPrice
            // 
            this.txtDataPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPrice.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtDataPrice.Location = new System.Drawing.Point(630, 244);
            this.txtDataPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataPrice.Multiline = true;
            this.txtDataPrice.Name = "txtDataPrice";
            this.txtDataPrice.Size = new System.Drawing.Size(113, 32);
            this.txtDataPrice.TabIndex = 10;
            this.txtDataPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataPrice.Visible = false;
            // 
            // txtDataAuthor
            // 
            this.txtDataAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAuthor.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtDataAuthor.Location = new System.Drawing.Point(134, 343);
            this.txtDataAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataAuthor.Multiline = true;
            this.txtDataAuthor.Name = "txtDataAuthor";
            this.txtDataAuthor.Size = new System.Drawing.Size(344, 33);
            this.txtDataAuthor.TabIndex = 9;
            this.txtDataAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataAuthor.Visible = false;
            // 
            // txtDataTitle
            // 
            this.txtDataTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataTitle.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtDataTitle.Location = new System.Drawing.Point(134, 293);
            this.txtDataTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataTitle.Multiline = true;
            this.txtDataTitle.Name = "txtDataTitle";
            this.txtDataTitle.Size = new System.Drawing.Size(344, 32);
            this.txtDataTitle.TabIndex = 8;
            this.txtDataTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataTitle.Visible = false;
            // 
            // txtDataISBN
            // 
            this.txtDataISBN.Enabled = false;
            this.txtDataISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataISBN.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtDataISBN.Location = new System.Drawing.Point(208, 241);
            this.txtDataISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataISBN.Multiline = true;
            this.txtDataISBN.Name = "txtDataISBN";
            this.txtDataISBN.Size = new System.Drawing.Size(204, 32);
            this.txtDataISBN.TabIndex = 1000;
            this.txtDataISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataISBN.Visible = false;
            // 
            // lblDataTransactionDate
            // 
            this.lblDataTransactionDate.AutoSize = true;
            this.lblDataTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTransactionDate.ForeColor = System.Drawing.Color.Navy;
            this.lblDataTransactionDate.Location = new System.Drawing.Point(512, 339);
            this.lblDataTransactionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataTransactionDate.Name = "lblDataTransactionDate";
            this.lblDataTransactionDate.Size = new System.Drawing.Size(64, 26);
            this.lblDataTransactionDate.TabIndex = 40;
            this.lblDataTransactionDate.Text = "Date:";
            this.lblDataTransactionDate.Visible = false;
            // 
            // lblDataOnHand
            // 
            this.lblDataOnHand.AutoSize = true;
            this.lblDataOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOnHand.ForeColor = System.Drawing.Color.Navy;
            this.lblDataOnHand.Location = new System.Drawing.Point(510, 297);
            this.lblDataOnHand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataOnHand.Name = "lblDataOnHand";
            this.lblDataOnHand.Size = new System.Drawing.Size(105, 26);
            this.lblDataOnHand.TabIndex = 39;
            this.lblDataOnHand.Text = "On Hand:";
            this.lblDataOnHand.Visible = false;
            // 
            // lblDataPrice
            // 
            this.lblDataPrice.AutoSize = true;
            this.lblDataPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPrice.ForeColor = System.Drawing.Color.Navy;
            this.lblDataPrice.Location = new System.Drawing.Point(512, 244);
            this.lblDataPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPrice.Name = "lblDataPrice";
            this.lblDataPrice.Size = new System.Drawing.Size(68, 26);
            this.lblDataPrice.TabIndex = 38;
            this.lblDataPrice.Text = "Price:";
            this.lblDataPrice.Visible = false;
            // 
            // lblDataAuthor
            // 
            this.lblDataAuthor.AutoSize = true;
            this.lblDataAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAuthor.ForeColor = System.Drawing.Color.Navy;
            this.lblDataAuthor.Location = new System.Drawing.Point(47, 352);
            this.lblDataAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataAuthor.Name = "lblDataAuthor";
            this.lblDataAuthor.Size = new System.Drawing.Size(82, 26);
            this.lblDataAuthor.TabIndex = 37;
            this.lblDataAuthor.Text = "Author:";
            this.lblDataAuthor.Visible = false;
            // 
            // lblDataTitle
            // 
            this.lblDataTitle.AutoSize = true;
            this.lblDataTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblDataTitle.Location = new System.Drawing.Point(47, 297);
            this.lblDataTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataTitle.Name = "lblDataTitle";
            this.lblDataTitle.Size = new System.Drawing.Size(58, 26);
            this.lblDataTitle.TabIndex = 36;
            this.lblDataTitle.Text = "Title:";
            this.lblDataTitle.Visible = false;
            // 
            // lblDataISBN
            // 
            this.lblDataISBN.AutoSize = true;
            this.lblDataISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataISBN.ForeColor = System.Drawing.Color.Navy;
            this.lblDataISBN.Location = new System.Drawing.Point(47, 238);
            this.lblDataISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataISBN.Name = "lblDataISBN";
            this.lblDataISBN.Size = new System.Drawing.Size(70, 26);
            this.lblDataISBN.TabIndex = 35;
            this.lblDataISBN.Text = "ISBN:";
            this.lblDataISBN.Visible = false;
            // 
            // lblEnterBookData
            // 
            this.lblEnterBookData.AutoSize = true;
            this.lblEnterBookData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterBookData.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblEnterBookData.Location = new System.Drawing.Point(47, 193);
            this.lblEnterBookData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterBookData.Name = "lblEnterBookData";
            this.lblEnterBookData.Size = new System.Drawing.Size(194, 26);
            this.lblEnterBookData.TabIndex = 34;
            this.lblEnterBookData.Text = "Enter Book Data:";
            this.lblEnterBookData.Visible = false;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteBook.Location = new System.Drawing.Point(558, 109);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(136, 63);
            this.btnDeleteBook.TabIndex = 7;
            this.btnDeleteBook.Text = "DELETE";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Visible = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateBook.Location = new System.Drawing.Point(416, 109);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(136, 63);
            this.btnUpdateBook.TabIndex = 6;
            this.btnUpdateBook.Text = "UPDATE";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Visible = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddBook.Location = new System.Drawing.Point(276, 109);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(136, 63);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "ADD";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblSelectTransaction
            // 
            this.lblSelectTransaction.AutoSize = true;
            this.lblSelectTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTransaction.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblSelectTransaction.Location = new System.Drawing.Point(47, 125);
            this.lblSelectTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectTransaction.Name = "lblSelectTransaction";
            this.lblSelectTransaction.Size = new System.Drawing.Size(216, 26);
            this.lblSelectTransaction.TabIndex = 30;
            this.lblSelectTransaction.Text = "Select Transaction:";
            this.lblSelectTransaction.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnOK.Location = new System.Drawing.Point(539, 36);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 55);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtISBNRight
            // 
            this.txtISBNRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBNRight.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtISBNRight.Location = new System.Drawing.Point(420, 36);
            this.txtISBNRight.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBNRight.Multiline = true;
            this.txtISBNRight.Name = "txtISBNRight";
            this.txtISBNRight.Size = new System.Drawing.Size(92, 55);
            this.txtISBNRight.TabIndex = 2;
            this.txtISBNRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtISBNRight.TextChanged += new System.EventHandler(this.txtRight_TextChanged);
            // 
            // lblHyphen
            // 
            this.lblHyphen.AutoSize = true;
            this.lblHyphen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHyphen.Location = new System.Drawing.Point(392, 49);
            this.lblHyphen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHyphen.Name = "lblHyphen";
            this.lblHyphen.Size = new System.Drawing.Size(24, 31);
            this.lblHyphen.TabIndex = 27;
            this.lblHyphen.Text = "-";
            // 
            // txtISBNLeft
            // 
            this.txtISBNLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBNLeft.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtISBNLeft.Location = new System.Drawing.Point(298, 36);
            this.txtISBNLeft.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBNLeft.Multiline = true;
            this.txtISBNLeft.Name = "txtISBNLeft";
            this.txtISBNLeft.Size = new System.Drawing.Size(90, 55);
            this.txtISBNLeft.TabIndex = 1;
            this.txtISBNLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtISBNLeft.TextChanged += new System.EventHandler(this.txtLeft_TextChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblISBN.Location = new System.Drawing.Point(29, 49);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(248, 26);
            this.lblISBN.TabIndex = 25;
            this.lblISBN.Text = "Enter ISBN (nnn-nnn):";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(619, 36);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 55);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBook
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtDataDate);
            this.Controls.Add(this.txtDataOnHand);
            this.Controls.Add(this.txtDataPrice);
            this.Controls.Add(this.txtDataAuthor);
            this.Controls.Add(this.txtDataTitle);
            this.Controls.Add(this.txtDataISBN);
            this.Controls.Add(this.lblDataTransactionDate);
            this.Controls.Add(this.lblDataOnHand);
            this.Controls.Add(this.lblDataPrice);
            this.Controls.Add(this.lblDataAuthor);
            this.Controls.Add(this.lblDataTitle);
            this.Controls.Add(this.lblDataISBN);
            this.Controls.Add(this.lblEnterBookData);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblSelectTransaction);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtISBNRight);
            this.Controls.Add(this.lblHyphen);
            this.Controls.Add(this.txtISBNLeft);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.btnExit);
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtDataDate;
        private System.Windows.Forms.TextBox txtDataOnHand;
        private System.Windows.Forms.TextBox txtDataPrice;
        private System.Windows.Forms.TextBox txtDataAuthor;
        private System.Windows.Forms.TextBox txtDataTitle;
        private System.Windows.Forms.TextBox txtDataISBN;
        private System.Windows.Forms.Label lblDataTransactionDate;
        private System.Windows.Forms.Label lblDataOnHand;
        private System.Windows.Forms.Label lblDataPrice;
        private System.Windows.Forms.Label lblDataAuthor;
        private System.Windows.Forms.Label lblDataTitle;
        private System.Windows.Forms.Label lblDataISBN;
        private System.Windows.Forms.Label lblEnterBookData;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblSelectTransaction;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtISBNRight;
        private System.Windows.Forms.Label lblHyphen;
        private System.Windows.Forms.TextBox txtISBNLeft;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Button btnExit;
    }
}