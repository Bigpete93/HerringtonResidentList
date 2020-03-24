namespace HerringtonResidents
{
    partial class RowData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RowData));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.residentText = new System.Windows.Forms.TextBox();
            this.coresidentText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lotNumText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseDateText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currentResidentText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.miscText = new System.Windows.Forms.RichTextBox();
            this.cancelButt = new System.Windows.Forms.Button();
            this.addButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Resident";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resident";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 15;
            // 
            // residentText
            // 
            this.residentText.Location = new System.Drawing.Point(147, 96);
            this.residentText.Name = "residentText";
            this.residentText.Size = new System.Drawing.Size(183, 22);
            this.residentText.TabIndex = 16;
            this.residentText.TextChanged += new System.EventHandler(this.residentText_TextChanged);
            // 
            // coresidentText
            // 
            this.coresidentText.Location = new System.Drawing.Point(147, 124);
            this.coresidentText.Name = "coresidentText";
            this.coresidentText.Size = new System.Drawing.Size(183, 22);
            this.coresidentText.TabIndex = 18;
            this.coresidentText.TextChanged += new System.EventHandler(this.coresidentText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Coresident";
            // 
            // lotNumText
            // 
            this.lotNumText.Location = new System.Drawing.Point(147, 152);
            this.lotNumText.Name = "lotNumText";
            this.lotNumText.Size = new System.Drawing.Size(183, 22);
            this.lotNumText.TabIndex = 20;
            this.lotNumText.TextChanged += new System.EventHandler(this.lotNumText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lot Number";
            // 
            // purchaseDateText
            // 
            this.purchaseDateText.Location = new System.Drawing.Point(147, 180);
            this.purchaseDateText.Name = "purchaseDateText";
            this.purchaseDateText.Size = new System.Drawing.Size(183, 22);
            this.purchaseDateText.TabIndex = 22;
            this.purchaseDateText.TextChanged += new System.EventHandler(this.purchaseDateText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Purchase Date";
            // 
            // currentResidentText
            // 
            this.currentResidentText.Location = new System.Drawing.Point(147, 208);
            this.currentResidentText.Name = "currentResidentText";
            this.currentResidentText.Size = new System.Drawing.Size(183, 22);
            this.currentResidentText.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Current Resident?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Miscellaneous Notes:";
            // 
            // miscText
            // 
            this.miscText.Location = new System.Drawing.Point(147, 252);
            this.miscText.Name = "miscText";
            this.miscText.Size = new System.Drawing.Size(183, 131);
            this.miscText.TabIndex = 27;
            this.miscText.Text = "";
            this.miscText.TextChanged += new System.EventHandler(this.miscText_TextChanged);
            // 
            // cancelButt
            // 
            this.cancelButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(102)))));
            this.cancelButt.CausesValidation = false;
            this.cancelButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButt.Location = new System.Drawing.Point(215, 396);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(105, 36);
            this.cancelButt.TabIndex = 29;
            this.cancelButt.Text = "Cancel";
            this.cancelButt.UseVisualStyleBackColor = false;
            // 
            // addButt
            // 
            this.addButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(102)))));
            this.addButt.CausesValidation = false;
            this.addButt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButt.Location = new System.Drawing.Point(80, 396);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(105, 36);
            this.addButt.TabIndex = 28;
            this.addButt.Text = "Add";
            this.addButt.UseVisualStyleBackColor = false;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // RowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(354, 447);
            this.Controls.Add(this.cancelButt);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.miscText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.currentResidentText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.purchaseDateText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lotNumText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coresidentText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.residentText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RowData";
            this.Text = "Adding a Resident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox residentText;
        private System.Windows.Forms.TextBox coresidentText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lotNumText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox purchaseDateText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentResidentText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox miscText;
        private System.Windows.Forms.Button cancelButt;
        private System.Windows.Forms.Button addButt;
    }
}