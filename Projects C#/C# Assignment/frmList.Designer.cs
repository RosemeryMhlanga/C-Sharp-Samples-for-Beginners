
namespace _34282963_Mhlanga_Act4
{
    partial class frmList
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
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblfind = new System.Windows.Forms.Label();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.textBoxfind = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCompany
            // 
            this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompany.Location = new System.Drawing.Point(134, 27);
            this.dataGridViewCompany.Name = "dataGridViewCompany";
            this.dataGridViewCompany.Size = new System.Drawing.Size(468, 238);
            this.dataGridViewCompany.TabIndex = 0;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(30, 305);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(155, 13);
            this.lblsearch.TabIndex = 1;
            this.lblsearch.Text = "Search for phrase within slogan";
            // 
            // lblfind
            // 
            this.lblfind.AutoSize = true;
            this.lblfind.Location = new System.Drawing.Point(30, 344);
            this.lblfind.Name = "lblfind";
            this.lblfind.Size = new System.Drawing.Size(118, 13);
            this.lblfind.TabIndex = 2;
            this.lblfind.Text = "Find according to rating";
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(191, 302);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxsearch.TabIndex = 3;
            // 
            // textBoxfind
            // 
            this.textBoxfind.Location = new System.Drawing.Point(168, 344);
            this.textBoxfind.Name = "textBoxfind";
            this.textBoxfind.Size = new System.Drawing.Size(100, 20);
            this.textBoxfind.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(323, 295);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(301, 344);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 6;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(461, 323);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display all";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.textBoxfind);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.lblfind);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.dataGridViewCompany);
            this.Name = "frmList";
            this.Text = "List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompany;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblfind;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.TextBox textBoxfind;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnDisplay;
    }
}