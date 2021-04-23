
namespace SGBD_Lab01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.parentTab = new System.Windows.Forms.DataGridView();
            this.childTab = new System.Windows.Forms.DataGridView();
            this.parentLabel = new System.Windows.Forms.Label();
            this.childLabel = new System.Windows.Forms.Label();
            this.ActualizeazaButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.parentTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parentTable
            // 
            this.parentTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentTab.Location = new System.Drawing.Point(12, 74);
            this.parentTab.Name = "filmeTable";
            this.parentTab.RowHeadersWidth = 82;
            this.parentTab.RowTemplate.Height = 41;
            this.parentTab.Size = new System.Drawing.Size(1301, 437);
            this.parentTab.TabIndex = 0;
            // 
            // childTable
            // 
            this.childTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childTab.Location = new System.Drawing.Point(12, 587);
            this.childTab.Name = "proiectiiTable";
            this.childTab.RowHeadersWidth = 82;
            this.childTab.RowTemplate.Height = 41;
            this.childTab.Size = new System.Drawing.Size(1479, 389);
            this.childTab.TabIndex = 1;
            // 
            // parentLabel
            // 
            this.parentLabel.AutoSize = true;
            this.parentLabel.Location = new System.Drawing.Point(55, 23);
            this.parentLabel.Name = "FilmeLabel";
            this.parentLabel.Size = new System.Drawing.Size(72, 32);
            this.parentLabel.TabIndex = 8;
            this.parentLabel.Text = parentTable;
            // 
            // childLabel
            // 
            this.childLabel.AutoSize = true;
            this.childLabel.Location = new System.Drawing.Point(55, 536);
            this.childLabel.Name = "ProiectiiLabel";
            this.childLabel.Size = new System.Drawing.Size(99, 32);
            this.childLabel.TabIndex = 9;
            this.childLabel.Text = childTable;
            // 
            // ActualizeazaButton
            // 
            this.ActualizeazaButton.Location = new System.Drawing.Point(1653, 695);
            this.ActualizeazaButton.Name = "ActualizeazaButton";
            this.ActualizeazaButton.Size = new System.Drawing.Size(249, 100);
            this.ActualizeazaButton.TabIndex = 10;
            this.ActualizeazaButton.Text = "Actualizează";
            this.ActualizeazaButton.UseVisualStyleBackColor = true;
            this.ActualizeazaButton.Click += new System.EventHandler(this.ActualizeazaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1399, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 414);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2069, 999);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ActualizeazaButton);
            this.Controls.Add(this.childLabel);
            this.Controls.Add(this.parentLabel);
            this.Controls.Add(this.childTab);
            this.Controls.Add(this.parentTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView parentTab;
        private System.Windows.Forms.Label parentLabel;
        private System.Windows.Forms.Label childLabel;
        private System.Windows.Forms.Button ActualizeazaButton;
        private System.Windows.Forms.DataGridView childTab;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

