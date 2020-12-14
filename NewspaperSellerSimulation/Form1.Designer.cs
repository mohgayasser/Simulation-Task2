namespace NewspaperSellerSimulation
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
            this.DemandDistribution = new System.Windows.Forms.DataGridView();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Fair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_Poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L0 = new System.Windows.Forms.Label();
            this.NumOfRecords = new System.Windows.Forms.TextBox();
            this.PurchasePrice = new System.Windows.Forms.TextBox();
            this.L1 = new System.Windows.Forms.Label();
            this.ScrapPrice = new System.Windows.Forms.TextBox();
            this.L2 = new System.Windows.Forms.Label();
            this.SellingPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.bigtable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateBigTable = new System.Windows.Forms.Button();
            this.NumOfNewsPaPer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showPreformance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DemandDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigtable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // DemandDistribution
            // 
            this.DemandDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DemandDistribution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.D_Good,
            this.D_Fair,
            this.D_Poor});
            this.DemandDistribution.Location = new System.Drawing.Point(293, 41);
            this.DemandDistribution.Name = "DemandDistribution";
            this.DemandDistribution.RowHeadersWidth = 51;
            this.DemandDistribution.Size = new System.Drawing.Size(412, 96);
            this.DemandDistribution.TabIndex = 1;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.MinimumWidth = 6;
            this.Demand.Name = "Demand";
            this.Demand.Width = 125;
            // 
            // D_Good
            // 
            this.D_Good.HeaderText = "D_Good";
            this.D_Good.MinimumWidth = 6;
            this.D_Good.Name = "D_Good";
            this.D_Good.Width = 125;
            // 
            // D_Fair
            // 
            this.D_Fair.HeaderText = "D_Fair";
            this.D_Fair.MinimumWidth = 6;
            this.D_Fair.Name = "D_Fair";
            this.D_Fair.Width = 125;
            // 
            // D_Poor
            // 
            this.D_Poor.HeaderText = "D_Poor";
            this.D_Poor.MinimumWidth = 6;
            this.D_Poor.Name = "D_Poor";
            this.D_Poor.Width = 125;
            // 
            // L0
            // 
            this.L0.AutoSize = true;
            this.L0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L0.Location = new System.Drawing.Point(14, 29);
            this.L0.Name = "L0";
            this.L0.Size = new System.Drawing.Size(113, 16);
            this.L0.TabIndex = 2;
            this.L0.Text = "NumOfRecords";
            // 
            // NumOfRecords
            // 
            this.NumOfRecords.Location = new System.Drawing.Point(178, 29);
            this.NumOfRecords.Name = "NumOfRecords";
            this.NumOfRecords.Size = new System.Drawing.Size(100, 20);
            this.NumOfRecords.TabIndex = 3;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.Location = new System.Drawing.Point(178, 63);
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.PurchasePrice.TabIndex = 5;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(12, 65);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(109, 16);
            this.L1.TabIndex = 4;
            this.L1.Text = "PurchasePrice";
            // 
            // ScrapPrice
            // 
            this.ScrapPrice.Location = new System.Drawing.Point(178, 97);
            this.ScrapPrice.Name = "ScrapPrice";
            this.ScrapPrice.Size = new System.Drawing.Size(100, 20);
            this.ScrapPrice.TabIndex = 7;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(27, 97);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(85, 16);
            this.L2.TabIndex = 6;
            this.L2.Text = "ScrapPrice";
            // 
            // SellingPrice
            // 
            this.SellingPrice.Location = new System.Drawing.Point(178, 127);
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(100, 20);
            this.SellingPrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "SellingPrice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(22, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(318, 153);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Good";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fair";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Poor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Demand Distributions";
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(429, 143);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(241, 37);
            this.Done.TabIndex = 12;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // bigtable
            // 
            this.bigtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bigtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.bigtable.Location = new System.Drawing.Point(9, 202);
            this.bigtable.Margin = new System.Windows.Forms.Padding(2);
            this.bigtable.Name = "bigtable";
            this.bigtable.RowHeadersWidth = 51;
            this.bigtable.RowTemplate.Height = 24;
            this.bigtable.Size = new System.Drawing.Size(903, 135);
            this.bigtable.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Days";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Random of Newsdays";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type of newsday";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Random for Demond";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Demand";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Revenue of Sales";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Lost profit";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Scrap";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Daily profit";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // calculateBigTable
            // 
            this.calculateBigTable.Location = new System.Drawing.Point(938, 240);
            this.calculateBigTable.Margin = new System.Windows.Forms.Padding(2);
            this.calculateBigTable.Name = "calculateBigTable";
            this.calculateBigTable.Size = new System.Drawing.Size(114, 68);
            this.calculateBigTable.TabIndex = 14;
            this.calculateBigTable.Text = "show";
            this.calculateBigTable.UseVisualStyleBackColor = true;
            this.calculateBigTable.Click += new System.EventHandler(this.calculateBigTable_Click);
            // 
            // NumOfNewsPaPer
            // 
            this.NumOfNewsPaPer.AutoSize = true;
            this.NumOfNewsPaPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfNewsPaPer.Location = new System.Drawing.Point(14, 6);
            this.NumOfNewsPaPer.Name = "NumOfNewsPaPer";
            this.NumOfNewsPaPer.Size = new System.Drawing.Size(135, 16);
            this.NumOfNewsPaPer.TabIndex = 15;
            this.NumOfNewsPaPer.Text = "NumOfNewsPaPer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(711, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 197);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Day Type Distributions";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dataGridView2.Location = new System.Drawing.Point(24, 384);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(893, 99);
            this.dataGridView2.TabIndex = 18;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 200F;
            this.Column10.HeaderText = "TotalSalesRevenue";
            this.Column10.MaxInputLength = 60000;
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 200;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "TotalCostofNewspapers";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.FillWeight = 200F;
            this.Column12.HeaderText = "TotalLostProfitfromExcessDemand";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 200;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "TotalSalvagefromsaleofScrappapers";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "NetProfit";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Numberofdayshavingexcessdemand";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "NumberOfDaysHavingUnsoldPapers";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.Width = 125;
            // 
            // showPreformance
            // 
            this.showPreformance.Location = new System.Drawing.Point(970, 396);
            this.showPreformance.Margin = new System.Windows.Forms.Padding(2);
            this.showPreformance.Name = "showPreformance";
            this.showPreformance.Size = new System.Drawing.Size(82, 87);
            this.showPreformance.TabIndex = 19;
            this.showPreformance.Text = "SHOWW";
            this.showPreformance.UseVisualStyleBackColor = true;
            this.showPreformance.Click += new System.EventHandler(this.showPreformance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 535);
            this.Controls.Add(this.showPreformance);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NumOfNewsPaPer);
            this.Controls.Add(this.calculateBigTable);
            this.Controls.Add(this.bigtable);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScrapPrice);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.PurchasePrice);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.NumOfRecords);
            this.Controls.Add(this.L0);
            this.Controls.Add(this.DemandDistribution);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DemandDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigtable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DemandDistribution;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Fair;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_Poor;
        private System.Windows.Forms.Label L0;
        private System.Windows.Forms.TextBox NumOfRecords;
        private System.Windows.Forms.TextBox PurchasePrice;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox ScrapPrice;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.TextBox SellingPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView bigtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button calculateBigTable;
        private System.Windows.Forms.Label NumOfNewsPaPer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.Button showPreformance;
    }
}