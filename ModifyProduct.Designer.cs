namespace C968_PA
{
    partial class ModifyProduct
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
            this.candidateTable = new System.Windows.Forms.DataGridView();
            this.associatedTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.inventoryText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.maxText = new System.Windows.Forms.TextBox();
            this.minText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.candidateTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Product";
            // 
            // candidateTable
            // 
            this.candidateTable.AllowUserToAddRows = false;
            this.candidateTable.AllowUserToDeleteRows = false;
            this.candidateTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateTable.Location = new System.Drawing.Point(6, 66);
            this.candidateTable.Name = "candidateTable";
            this.candidateTable.ReadOnly = true;
            this.candidateTable.RowHeadersWidth = 82;
            this.candidateTable.RowTemplate.Height = 33;
            this.candidateTable.Size = new System.Drawing.Size(1124, 422);
            this.candidateTable.TabIndex = 1;
            // 
            // associatedTable
            // 
            this.associatedTable.AllowUserToAddRows = false;
            this.associatedTable.AllowUserToDeleteRows = false;
            this.associatedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedTable.Location = new System.Drawing.Point(6, 82);
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
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(252, 352);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(397, 31);
            this.idText.TabIndex = 8;
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
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(693, 14);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(397, 31);
            this.searchText.TabIndex = 15;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(531, 6);
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
            this.label8.Location = new System.Drawing.Point(-6, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "All Candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(454, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "Parts Associated with the Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.candidateTable);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.searchText);
            this.groupBox1.Location = new System.Drawing.Point(1069, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 494);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.associatedTable);
            this.groupBox2.Location = new System.Drawing.Point(1063, 600);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1142, 510);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // ModifyProduct
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
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidateTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView candidateTable;
        private System.Windows.Forms.DataGridView associatedTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox inventoryText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}