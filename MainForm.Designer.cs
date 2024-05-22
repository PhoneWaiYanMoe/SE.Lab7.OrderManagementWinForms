namespace OrderManagementWinForms
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnAddAgent = new System.Windows.Forms.Button();
            this.btnFilterData = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generate Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filter Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add Agent";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(37, 85);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(111, 42);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "Click";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click_2);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(37, 215);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(111, 42);
            this.btnAddOrder.TabIndex = 11;
            this.btnAddOrder.Text = "Click";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click_1);
            // 
            // btnAddAgent
            // 
            this.btnAddAgent.Location = new System.Drawing.Point(648, 62);
            this.btnAddAgent.Name = "btnAddAgent";
            this.btnAddAgent.Size = new System.Drawing.Size(111, 42);
            this.btnAddAgent.TabIndex = 12;
            this.btnAddAgent.Text = "Click";
            this.btnAddAgent.UseVisualStyleBackColor = true;
            this.btnAddAgent.Click += new System.EventHandler(this.btnAddAgent_Click_1);
            // 
            // btnFilterData
            // 
            this.btnFilterData.Location = new System.Drawing.Point(648, 215);
            this.btnFilterData.Name = "btnFilterData";
            this.btnFilterData.Size = new System.Drawing.Size(111, 42);
            this.btnFilterData.TabIndex = 13;
            this.btnFilterData.Text = "Click";
            this.btnFilterData.UseVisualStyleBackColor = true;
            this.btnFilterData.Click += new System.EventHandler(this.btnFilterData_Click_1);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(345, 334);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(111, 42);
            this.btnGenerateReport.TabIndex = 14;
            this.btnGenerateReport.Text = "Click";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnFilterData);
            this.Controls.Add(this.btnAddAgent);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnAddAgent;
        private System.Windows.Forms.Button btnFilterData;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}