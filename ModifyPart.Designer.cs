namespace C968_PA
{
    partial class ModifyPart
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
            this.inhouseButton = new System.Windows.Forms.RadioButton();
            this.outsourcedButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.companyMachine = new System.Windows.Forms.Label();
            this.partIDText = new System.Windows.Forms.TextBox();
            this.companyMachineText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.inventoryText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.maxText = new System.Windows.Forms.TextBox();
            this.minText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.savePart = new System.Windows.Forms.Button();
            this.cancelPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Part";
            // 
            // inhouseButton
            // 
            this.inhouseButton.AutoSize = true;
            this.inhouseButton.Location = new System.Drawing.Point(425, 43);
            this.inhouseButton.Name = "inhouseButton";
            this.inhouseButton.Size = new System.Drawing.Size(129, 29);
            this.inhouseButton.TabIndex = 1;
            this.inhouseButton.TabStop = true;
            this.inhouseButton.Text = "In-House";
            this.inhouseButton.UseVisualStyleBackColor = true;
            this.inhouseButton.CheckedChanged += new System.EventHandler(this.Inhouse_CheckedChanged);
            // 
            // outsourcedButton
            // 
            this.outsourcedButton.AutoSize = true;
            this.outsourcedButton.Location = new System.Drawing.Point(663, 43);
            this.outsourcedButton.Name = "outsourcedButton";
            this.outsourcedButton.Size = new System.Drawing.Size(154, 29);
            this.outsourcedButton.TabIndex = 2;
            this.outsourcedButton.TabStop = true;
            this.outsourcedButton.Text = "Outsourced";
            this.outsourcedButton.UseVisualStyleBackColor = true;
            this.outsourcedButton.CheckedChanged += new System.EventHandler(this.Outsourced_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price/Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max";
            // 
            // companyMachine
            // 
            this.companyMachine.AutoSize = true;
            this.companyMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyMachine.Location = new System.Drawing.Point(186, 691);
            this.companyMachine.Name = "companyMachine";
            this.companyMachine.Size = new System.Drawing.Size(161, 31);
            this.companyMachine.TabIndex = 8;
            this.companyMachine.Text = "Machine ID";
            // 
            // partIDText
            // 
            this.partIDText.Location = new System.Drawing.Point(425, 217);
            this.partIDText.Name = "partIDText";
            this.partIDText.Size = new System.Drawing.Size(392, 31);
            this.partIDText.TabIndex = 9;
            // 
            // companyMachineText
            // 
            this.companyMachineText.Location = new System.Drawing.Point(425, 694);
            this.companyMachineText.Name = "companyMachineText";
            this.companyMachineText.Size = new System.Drawing.Size(392, 31);
            this.companyMachineText.TabIndex = 10;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(425, 494);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(392, 31);
            this.priceText.TabIndex = 11;
            // 
            // inventoryText
            // 
            this.inventoryText.Location = new System.Drawing.Point(425, 400);
            this.inventoryText.Name = "inventoryText";
            this.inventoryText.Size = new System.Drawing.Size(392, 31);
            this.inventoryText.TabIndex = 12;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(425, 306);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(392, 31);
            this.nameText.TabIndex = 13;
            // 
            // maxText
            // 
            this.maxText.Location = new System.Drawing.Point(425, 590);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(129, 31);
            this.maxText.TabIndex = 14;
            // 
            // minText
            // 
            this.minText.Location = new System.Drawing.Point(776, 590);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(129, 31);
            this.minText.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(630, 587);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Min";
            // 
            // savePart
            // 
            this.savePart.AutoSize = true;
            this.savePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePart.Location = new System.Drawing.Point(776, 940);
            this.savePart.Name = "savePart";
            this.savePart.Size = new System.Drawing.Size(133, 53);
            this.savePart.TabIndex = 17;
            this.savePart.Text = "Save";
            this.savePart.UseVisualStyleBackColor = true;
            this.savePart.Click += new System.EventHandler(this.savePart_Click);
            // 
            // cancelPart
            // 
            this.cancelPart.AutoSize = true;
            this.cancelPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPart.Location = new System.Drawing.Point(951, 940);
            this.cancelPart.Name = "cancelPart";
            this.cancelPart.Size = new System.Drawing.Size(133, 53);
            this.cancelPart.TabIndex = 18;
            this.cancelPart.Text = "Cancel";
            this.cancelPart.UseVisualStyleBackColor = true;
            this.cancelPart.Click += new System.EventHandler(this.cancelPart_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1329, 1123);
            this.Controls.Add(this.cancelPart);
            this.Controls.Add(this.savePart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.inventoryText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.companyMachineText);
            this.Controls.Add(this.partIDText);
            this.Controls.Add(this.companyMachine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outsourcedButton);
            this.Controls.Add(this.inhouseButton);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inhouseButton;
        private System.Windows.Forms.RadioButton outsourcedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label companyMachine;
        private System.Windows.Forms.TextBox partIDText;
        private System.Windows.Forms.TextBox companyMachineText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox inventoryText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button savePart;
        private System.Windows.Forms.Button cancelPart;
    }
}