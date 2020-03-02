using System;
/// Required designer variable.
namespace C968_PA
{
    partial class MainScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PartTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartsSearch = new System.Windows.Forms.TextBox();
            this.btnPartsDel = new System.Windows.Forms.Button();
            this.btnPartsMod = new System.Windows.Forms.Button();
            this.btnPartsAdd = new System.Windows.Forms.Button();
            this.PartSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProdSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.btnProdMod = new System.Windows.Forms.Button();
            this.btnProdDel = new System.Windows.Forms.Button();
            this.ProductSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PartTable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPartsSearch);
            this.groupBox1.Controls.Add(this.btnPartsDel);
            this.groupBox1.Controls.Add(this.btnPartsMod);
            this.groupBox1.Controls.Add(this.btnPartsAdd);
            this.groupBox1.Controls.Add(this.PartSearch);
            this.groupBox1.Location = new System.Drawing.Point(78, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(702, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // PartTable
            // 
            this.PartTable.AllowUserToAddRows = false;
            this.PartTable.AllowUserToDeleteRows = false;
            this.PartTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartTable.Location = new System.Drawing.Point(33, 78);
            this.PartTable.Name = "PartTable";
            this.PartTable.ReadOnly = true;
            this.PartTable.RowHeadersWidth = 82;
            this.PartTable.RowTemplate.Height = 33;
            this.PartTable.Size = new System.Drawing.Size(636, 236);
            this.PartTable.TabIndex = 8;
            this.PartTable.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parts";
            this.label2.UseWaitCursor = true;
            // 
            // txtPartsSearch
            // 
            this.txtPartsSearch.Location = new System.Drawing.Point(464, 33);
            this.txtPartsSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPartsSearch.Name = "txtPartsSearch";
            this.txtPartsSearch.Size = new System.Drawing.Size(205, 31);
            this.txtPartsSearch.TabIndex = 5;
            this.txtPartsSearch.UseWaitCursor = true;
            // 
            // btnPartsDel
            // 
            this.btnPartsDel.Location = new System.Drawing.Point(558, 323);
            this.btnPartsDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsDel.Name = "btnPartsDel";
            this.btnPartsDel.Size = new System.Drawing.Size(112, 58);
            this.btnPartsDel.TabIndex = 4;
            this.btnPartsDel.Text = "Delete";
            this.btnPartsDel.UseVisualStyleBackColor = true;
            this.btnPartsDel.UseWaitCursor = true;
            this.btnPartsDel.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // btnPartsMod
            // 
            this.btnPartsMod.Location = new System.Drawing.Point(435, 323);
            this.btnPartsMod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsMod.Name = "btnPartsMod";
            this.btnPartsMod.Size = new System.Drawing.Size(112, 58);
            this.btnPartsMod.TabIndex = 3;
            this.btnPartsMod.Text = "Modify";
            this.btnPartsMod.UseVisualStyleBackColor = true;
            this.btnPartsMod.UseWaitCursor = true;
            this.btnPartsMod.Click += new System.EventHandler(this.modPart_Click);
            // 
            // btnPartsAdd
            // 
            this.btnPartsAdd.Location = new System.Drawing.Point(314, 323);
            this.btnPartsAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsAdd.Name = "btnPartsAdd";
            this.btnPartsAdd.Size = new System.Drawing.Size(112, 58);
            this.btnPartsAdd.TabIndex = 2;
            this.btnPartsAdd.Text = "Add";
            this.btnPartsAdd.UseVisualStyleBackColor = true;
            this.btnPartsAdd.UseWaitCursor = true;
            this.btnPartsAdd.Click += new System.EventHandler(this.addPart_Click);
            // 
            // PartSearch
            // 
            this.PartSearch.Location = new System.Drawing.Point(342, 33);
            this.PartSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PartSearch.Name = "PartSearch";
            this.PartSearch.Size = new System.Drawing.Size(112, 36);
            this.PartSearch.TabIndex = 1;
            this.PartSearch.Text = "Search";
            this.PartSearch.UseVisualStyleBackColor = true;
            this.PartSearch.UseWaitCursor = true;
            this.PartSearch.Click += new System.EventHandler(this.searchPart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProductTable);
            this.groupBox2.Controls.Add(this.txtProdSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnProdAdd);
            this.groupBox2.Controls.Add(this.btnProdMod);
            this.groupBox2.Controls.Add(this.btnProdDel);
            this.groupBox2.Controls.Add(this.ProductSearch);
            this.groupBox2.Location = new System.Drawing.Point(920, 165);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(702, 391);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.UseWaitCursor = true;
            // 
            // txtProdSearch
            // 
            this.txtProdSearch.Location = new System.Drawing.Point(447, 33);
            this.txtProdSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProdSearch.Name = "txtProdSearch";
            this.txtProdSearch.Size = new System.Drawing.Size(211, 31);
            this.txtProdSearch.TabIndex = 6;
            this.txtProdSearch.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Products";
            this.label1.UseWaitCursor = true;
            // 
            // btnProdAdd
            // 
            this.btnProdAdd.Location = new System.Drawing.Point(304, 323);
            this.btnProdAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(112, 58);
            this.btnProdAdd.TabIndex = 6;
            this.btnProdAdd.Text = "Add";
            this.btnProdAdd.UseVisualStyleBackColor = true;
            this.btnProdAdd.UseWaitCursor = true;
            this.btnProdAdd.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // btnProdMod
            // 
            this.btnProdMod.Location = new System.Drawing.Point(426, 323);
            this.btnProdMod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProdMod.Name = "btnProdMod";
            this.btnProdMod.Size = new System.Drawing.Size(112, 58);
            this.btnProdMod.TabIndex = 7;
            this.btnProdMod.Text = "Modify";
            this.btnProdMod.UseVisualStyleBackColor = true;
            this.btnProdMod.UseWaitCursor = true;
            this.btnProdMod.Click += new System.EventHandler(this.modProduct_Click);
            // 
            // btnProdDel
            // 
            this.btnProdDel.Location = new System.Drawing.Point(548, 323);
            this.btnProdDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProdDel.Name = "btnProdDel";
            this.btnProdDel.Size = new System.Drawing.Size(112, 58);
            this.btnProdDel.TabIndex = 8;
            this.btnProdDel.Text = "Delete";
            this.btnProdDel.UseVisualStyleBackColor = true;
            this.btnProdDel.UseWaitCursor = true;
            this.btnProdDel.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // ProductSearch
            // 
            this.ProductSearch.Location = new System.Drawing.Point(326, 33);
            this.ProductSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductSearch.Name = "ProductSearch";
            this.ProductSearch.Size = new System.Drawing.Size(112, 36);
            this.ProductSearch.TabIndex = 5;
            this.ProductSearch.Text = "Search";
            this.ProductSearch.UseVisualStyleBackColor = true;
            this.ProductSearch.UseWaitCursor = true;
            this.ProductSearch.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(1468, 586);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(560, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inventory Management System";
            this.label3.UseWaitCursor = true;
            // 
            // candidateTable
            // 
            this.ProductTable.AllowUserToAddRows = false;
            this.ProductTable.AllowUserToDeleteRows = false;
            this.ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductTable.Location = new System.Drawing.Point(34, 78);
            this.ProductTable.Name = "candidateTable";
            this.ProductTable.ReadOnly = true;
            this.ProductTable.RowHeadersWidth = 82;
            this.ProductTable.RowTemplate.Height = 33;
            this.ProductTable.Size = new System.Drawing.Size(624, 237);
            this.ProductTable.TabIndex = 9;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1673, 900);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainScreen";
            this.Text = "Inventory Management System";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartsSearch;
        private System.Windows.Forms.Button btnPartsDel;
        private System.Windows.Forms.Button btnPartsMod;
        private System.Windows.Forms.Button btnPartsAdd;
        private System.Windows.Forms.Button PartSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProdSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProdAdd;
        private System.Windows.Forms.Button btnProdMod;
        private System.Windows.Forms.Button btnProdDel;
        private System.Windows.Forms.Button ProductSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PartTable;
        private System.Windows.Forms.DataGridView ProductTable;
    }
}