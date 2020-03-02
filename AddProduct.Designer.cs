using System;

namespace C968_PA
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productIDText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.inventoryText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.maxText = new System.Windows.Forms.TextBox();
            this.minText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.candidateSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.candidateTable = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.associatedTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Part ID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Inventory";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 175;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 175;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Min";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 175;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Max";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            this.Column6.Width = 175;
            // 
            // associatedTable
            // 
            this.associatedTable.AllowUserToAddRows = false;
            this.associatedTable.AllowUserToDeleteRows = false;
            this.associatedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedTable.Location = new System.Drawing.Point(12, 66);
            this.associatedTable.Name = "associatedTable";
            this.associatedTable.ReadOnly = true;
            this.associatedTable.RowHeadersWidth = 82;
            this.associatedTable.RowTemplate.Height = 33;
            this.associatedTable.Size = new System.Drawing.Size(1136, 422);
            this.associatedTable.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 724);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max";
            // 
            // productIDText
            // 
            this.productIDText.Location = new System.Drawing.Point(252, 352);
            this.productIDText.Name = "productIDText";
            this.productIDText.Size = new System.Drawing.Size(397, 31);
            this.productIDText.TabIndex = 8;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(252, 628);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(397, 31);
            this.priceText.TabIndex = 9;
            // 
            // inventoryText
            // 
            this.inventoryText.Location = new System.Drawing.Point(252, 533);
            this.inventoryText.Name = "inventoryText";
            this.inventoryText.Size = new System.Drawing.Size(397, 31);
            this.inventoryText.TabIndex = 10;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(252, 446);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(397, 31);
            this.nameText.TabIndex = 11;
            // 
            // maxText
            // 
            this.maxText.Location = new System.Drawing.Point(252, 727);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(199, 31);
            this.maxText.TabIndex = 12;
            // 
            // minText
            // 
            this.minText.Location = new System.Drawing.Point(719, 727);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(199, 31);
            this.minText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 724);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Min";
            // 
            // candidateSearch
            // 
            this.candidateSearch.Location = new System.Drawing.Point(712, 38);
            this.candidateSearch.Name = "candidateSearch";
            this.candidateSearch.Size = new System.Drawing.Size(397, 31);
            this.candidateSearch.TabIndex = 15;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(550, 30);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(131, 41);
            this.search.TabIndex = 16;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(2074, 1220);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(131, 41);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(1929, 1220);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(131, 41);
            this.save.TabIndex = 18;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(2074, 1128);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(131, 41);
            this.delete.TabIndex = 19;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(2074, 572);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(131, 41);
            this.add.TabIndex = 20;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "All Candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(454, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "Parts Associated with the Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.candidateTable);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.candidateSearch);
            this.groupBox1.Location = new System.Drawing.Point(1069, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 487);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "candidateTable";
            // 
            // candidateTable
            // 
            this.candidateTable.AllowUserToAddRows = false;
            this.candidateTable.AllowUserToDeleteRows = false;
            this.candidateTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateTable.Location = new System.Drawing.Point(27, 101);
            this.candidateTable.Name = "candidateTable";
            this.candidateTable.ReadOnly = true;
            this.candidateTable.RowHeadersWidth = 82;
            this.candidateTable.RowTemplate.Height = 33;
            this.candidateTable.Size = new System.Drawing.Size(1082, 358);
            this.candidateTable.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.associatedTable);
            this.groupBox2.Location = new System.Drawing.Point(1069, 600);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1154, 509);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2375, 1326);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.inventoryText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.productIDText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.associatedTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
      //  private System.Windows.Forms.DataGridView candidateTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView associatedTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productIDText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox inventoryText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox candidateSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView candidateTable;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}