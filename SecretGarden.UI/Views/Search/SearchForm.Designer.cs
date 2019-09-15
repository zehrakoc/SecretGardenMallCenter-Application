namespace SecretGarden.UI.Views.Search
{
    partial class SearchForm
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
            this.BtnManager = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.LbStores = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnManager
            // 
            this.BtnManager.Location = new System.Drawing.Point(445, 291);
            this.BtnManager.Name = "BtnManager";
            this.BtnManager.Size = new System.Drawing.Size(75, 37);
            this.BtnManager.TabIndex = 0;
            this.BtnManager.Text = "Yönetici Girişi";
            this.BtnManager.UseVisualStyleBackColor = true;
            this.BtnManager.Click += new System.EventHandler(this.BtnManager_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.TbSearch);
            this.groupBox1.Controls.Add(this.LbStores);
            this.groupBox1.Controls.Add(this.BtnManager);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aramak İstediğiniz Kategoriyi ya da Mağazayı Yazınız";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(310, 82);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "ARA";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(39, 49);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(251, 20);
            this.TbSearch.TabIndex = 2;
            this.TbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // LbStores
            // 
            this.LbStores.FormattingEnabled = true;
            this.LbStores.Location = new System.Drawing.Point(39, 82);
            this.LbStores.Name = "LbStores";
            this.LbStores.Size = new System.Drawing.Size(251, 121);
            this.LbStores.TabIndex = 1;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 356);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.ListBox LbStores;
    }
}