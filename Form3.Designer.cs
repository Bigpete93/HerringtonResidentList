namespace HerringtonResidents
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.cellText = new System.Windows.Forms.TextBox();
            this.EditButt = new System.Windows.Forms.Button();
            this.CancelButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Edit Cell:";
            // 
            // cellText
            // 
            this.cellText.Location = new System.Drawing.Point(15, 30);
            this.cellText.Name = "cellText";
            this.cellText.Size = new System.Drawing.Size(369, 22);
            this.cellText.TabIndex = 32;
            this.cellText.TextChanged += new System.EventHandler(this.cellText_TextChanged);
            this.cellText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cellText_KeyDown);
            // 
            // EditButt
            // 
            this.EditButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(102)))));
            this.EditButt.CausesValidation = false;
            this.EditButt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EditButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButt.Location = new System.Drawing.Point(15, 58);
            this.EditButt.Name = "EditButt";
            this.EditButt.Size = new System.Drawing.Size(105, 36);
            this.EditButt.TabIndex = 36;
            this.EditButt.Text = "Edit";
            this.EditButt.UseVisualStyleBackColor = false;
            // 
            // CancelButt
            // 
            this.CancelButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(102)))));
            this.CancelButt.CausesValidation = false;
            this.CancelButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButt.Location = new System.Drawing.Point(126, 58);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(105, 36);
            this.CancelButt.TabIndex = 35;
            this.CancelButt.Text = "Cancel";
            this.CancelButt.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(396, 151);
            this.Controls.Add(this.EditButt);
            this.Controls.Add(this.CancelButt);
            this.Controls.Add(this.cellText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Cell Edit";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cellText;
        private System.Windows.Forms.Button EditButt;
        private System.Windows.Forms.Button CancelButt;
    }
}