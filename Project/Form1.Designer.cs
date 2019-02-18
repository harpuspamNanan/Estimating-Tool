namespace Project
{
    partial class Form1
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
            this.EqpCodesBox = new System.Windows.Forms.ComboBox();
            this.EqpCodeLabel = new System.Windows.Forms.Label();
            this.eqpLbl = new System.Windows.Forms.Label();
            this.BulkImportListLabel = new System.Windows.Forms.Label();
            this.subCodeLbl = new System.Windows.Forms.Label();
            this.EquipmentLabel = new System.Windows.Forms.Label();
            this.BulkCodeComboBox = new System.Windows.Forms.ComboBox();
            this.EqpImportListTextBox = new System.Windows.Forms.TextBox();
            this.graphBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EqpCodesBox
            // 
            this.EqpCodesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqpCodesBox.FormattingEnabled = true;
            this.EqpCodesBox.Items.AddRange(new object[] {
            "PUMP",
            "AGTR",
            "HOPP",
            "BINS",
            "CHUT",
            "TANK",
            "SMIL",
            "CRUS",
            "CONV",
            "BMIL",
            "RMIL"});
            this.EqpCodesBox.Location = new System.Drawing.Point(332, 104);
            this.EqpCodesBox.Name = "EqpCodesBox";
            this.EqpCodesBox.Size = new System.Drawing.Size(183, 24);
            this.EqpCodesBox.TabIndex = 0;
            // 
            // EqpCodeLabel
            // 
            this.EqpCodeLabel.AutoSize = true;
            this.EqpCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.EqpCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqpCodeLabel.Location = new System.Drawing.Point(58, 108);
            this.EqpCodeLabel.Name = "EqpCodeLabel";
            this.EqpCodeLabel.Size = new System.Drawing.Size(105, 20);
            this.EqpCodeLabel.TabIndex = 1;
            this.EqpCodeLabel.Text = "A) Main Code";
            this.EqpCodeLabel.Click += new System.EventHandler(this.EqpCodeLabel_Click);
            // 
            // eqpLbl
            // 
            this.eqpLbl.AutoSize = true;
            this.eqpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqpLbl.Location = new System.Drawing.Point(58, 161);
            this.eqpLbl.Name = "eqpLbl";
            this.eqpLbl.Size = new System.Drawing.Size(100, 20);
            this.eqpLbl.TabIndex = 2;
            this.eqpLbl.Text = "B) Sub Code";
            // 
            // BulkImportListLabel
            // 
            this.BulkImportListLabel.AutoSize = true;
            this.BulkImportListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulkImportListLabel.Location = new System.Drawing.Point(58, 320);
            this.BulkImportListLabel.Name = "BulkImportListLabel";
            this.BulkImportListLabel.Size = new System.Drawing.Size(0, 20);
            this.BulkImportListLabel.TabIndex = 4;
            // 
            // subCodeLbl
            // 
            this.subCodeLbl.AutoSize = true;
            this.subCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subCodeLbl.Location = new System.Drawing.Point(58, 231);
            this.subCodeLbl.Name = "subCodeLbl";
            this.subCodeLbl.Size = new System.Drawing.Size(161, 20);
            this.subCodeLbl.TabIndex = 5;
            this.subCodeLbl.Text = "Sub Code Equipment";
            // 
            // EquipmentLabel
            // 
            this.EquipmentLabel.AutoSize = true;
            this.EquipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentLabel.Location = new System.Drawing.Point(46, 60);
            this.EquipmentLabel.Name = "EquipmentLabel";
            this.EquipmentLabel.Size = new System.Drawing.Size(86, 20);
            this.EquipmentLabel.TabIndex = 7;
            this.EquipmentLabel.Text = "Equipment";
            // 
            // BulkCodeComboBox
            // 
            this.BulkCodeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulkCodeComboBox.FormattingEnabled = true;
            this.BulkCodeComboBox.Items.AddRange(new object[] {
            "PUMP",
            "AGTR",
            "HOPP",
            "BINS",
            "CHUT",
            "TANK",
            "SMIL",
            "CRUS",
            "CONV",
            "BMIL",
            "RMIL"});
            this.BulkCodeComboBox.Location = new System.Drawing.Point(332, 227);
            this.BulkCodeComboBox.Name = "BulkCodeComboBox";
            this.BulkCodeComboBox.Size = new System.Drawing.Size(183, 24);
            this.BulkCodeComboBox.TabIndex = 9;
            // 
            // EqpImportListTextBox
            // 
            this.EqpImportListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqpImportListTextBox.Location = new System.Drawing.Point(332, 161);
            this.EqpImportListTextBox.Name = "EqpImportListTextBox";
            this.EqpImportListTextBox.Size = new System.Drawing.Size(183, 26);
            this.EqpImportListTextBox.TabIndex = 10;
            // 
            // graphBtn
            // 
            this.graphBtn.Location = new System.Drawing.Point(293, 286);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(75, 23);
            this.graphBtn.TabIndex = 15;
            this.graphBtn.Text = "Graph";
            this.graphBtn.UseVisualStyleBackColor = true;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(212, 286);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 16;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.EqpImportListTextBox);
            this.Controls.Add(this.BulkCodeComboBox);
            this.Controls.Add(this.EquipmentLabel);
            this.Controls.Add(this.subCodeLbl);
            this.Controls.Add(this.BulkImportListLabel);
            this.Controls.Add(this.eqpLbl);
            this.Controls.Add(this.EqpCodeLabel);
            this.Controls.Add(this.EqpCodesBox);
            this.Name = "Form1";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EqpCodesBox;
        private System.Windows.Forms.Label EqpCodeLabel;
        private System.Windows.Forms.Label eqpLbl;
        private System.Windows.Forms.Label BulkImportListLabel;
        private System.Windows.Forms.Label subCodeLbl;
        private System.Windows.Forms.Label EquipmentLabel;
        private System.Windows.Forms.ComboBox BulkCodeComboBox;
        private System.Windows.Forms.TextBox EqpImportListTextBox;
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.Button findBtn;
    }
}

