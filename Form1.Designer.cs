namespace HerringtonResidents
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.residentGrid = new System.Windows.Forms.DataGridView();
            this.Resident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoResident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Misc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.RichTextBox();
            this.searchDrop = new System.Windows.Forms.ComboBox();
            this.searchButt = new System.Windows.Forms.Button();
            this.addButt = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.residentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // residentGrid
            // 
            this.residentGrid.AllowUserToOrderColumns = true;
            this.residentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.residentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(102)))));
            this.residentGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.residentGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.residentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.residentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resident,
            this.CoResident,
            this.LotNum,
            this.Date,
            this.Current,
            this.Misc});
            this.residentGrid.Location = new System.Drawing.Point(5, 138);
            this.residentGrid.Name = "residentGrid";
            this.residentGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.residentGrid.RowHeadersVisible = false;
            this.residentGrid.RowHeadersWidth = 51;
            this.residentGrid.RowTemplate.Height = 24;
            this.residentGrid.Size = new System.Drawing.Size(1260, 499);
            this.residentGrid.StandardTab = true;
            this.residentGrid.TabIndex = 0;
            this.residentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.residentGrid_CellClick);
            // 
            // Resident
            // 
            this.Resident.HeaderText = "Resident";
            this.Resident.MinimumWidth = 6;
            this.Resident.Name = "Resident";
            this.Resident.Width = 93;
            // 
            // CoResident
            // 
            this.CoResident.HeaderText = "CoResident";
            this.CoResident.MinimumWidth = 6;
            this.CoResident.Name = "CoResident";
            this.CoResident.Width = 110;
            // 
            // LotNum
            // 
            this.LotNum.HeaderText = "Lot #";
            this.LotNum.MinimumWidth = 6;
            this.LotNum.Name = "LotNum";
            this.LotNum.Width = 57;
            // 
            // Date
            // 
            this.Date.HeaderText = "Purchase Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 120;
            // 
            // Current
            // 
            this.Current.HeaderText = "Current?";
            this.Current.MinimumWidth = 6;
            this.Current.Name = "Current";
            this.Current.Width = 92;
            // 
            // Misc
            // 
            this.Misc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Misc.HeaderText = "Misc";
            this.Misc.MinimumWidth = 6;
            this.Misc.Name = "Misc";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(253, 100);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(82, 17);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search for: ";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.Location = new System.Drawing.Point(341, 97);
            this.searchText.MaxLength = 100;
            this.searchText.Multiline = false;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(343, 25);
            this.searchText.TabIndex = 2;
            this.searchText.Text = "";
            this.searchText.TextChanged += new System.EventHandler(this.searchDrop_SelectedIndexChanged);
            // 
            // searchDrop
            // 
            this.searchDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDrop.FormattingEnabled = true;
            this.searchDrop.Items.AddRange(new object[] {
            "All",
            "Resident",
            "Coresident",
            "Lot Number",
            "Purchase Date",
            "The Current Resident",
            "Misc Notes"});
            this.searchDrop.Location = new System.Drawing.Point(727, 97);
            this.searchDrop.Name = "searchDrop";
            this.searchDrop.Size = new System.Drawing.Size(299, 24);
            this.searchDrop.TabIndex = 3;
            this.searchDrop.SelectedIndexChanged += new System.EventHandler(this.searchDrop_SelectedIndexChanged);
            // 
            // searchButt
            // 
            this.searchButt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(102)))));
            this.searchButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButt.Location = new System.Drawing.Point(1044, 91);
            this.searchButt.Name = "searchButt";
            this.searchButt.Size = new System.Drawing.Size(84, 35);
            this.searchButt.TabIndex = 4;
            this.searchButt.Text = "Search";
            this.searchButt.UseVisualStyleBackColor = false;
            // 
            // addButt
            // 
            this.addButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(135)))), ((int)(((byte)(102)))));
            this.addButt.CausesValidation = false;
            this.addButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButt.Location = new System.Drawing.Point(603, 55);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(118, 36);
            this.addButt.TabIndex = 5;
            this.addButt.Text = "Add Row";
            this.addButt.UseVisualStyleBackColor = false;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Logo.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Villa Farms Resident List";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1269, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.searchButt);
            this.Controls.Add(this.searchDrop);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.residentGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Resident Lit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.residentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView residentGrid;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.RichTextBox searchText;
        private System.Windows.Forms.ComboBox searchDrop;
        private System.Windows.Forms.Button searchButt;
        private System.Windows.Forms.Button addButt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resident;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoResident;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current;
        private System.Windows.Forms.DataGridViewTextBoxColumn Misc;
        private System.Windows.Forms.Label label1;
    }
}

