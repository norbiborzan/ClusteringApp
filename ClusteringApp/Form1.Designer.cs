
namespace ClusteringApp
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStartClustering = new System.Windows.Forms.Button();
            this.lblClusteringAlg = new System.Windows.Forms.Label();
            this.optKNN = new System.Windows.Forms.RadioButton();
            this.optSVM = new System.Windows.Forms.RadioButton();
            this.optBayes = new System.Windows.Forms.RadioButton();
            this.grpAlgorithms = new System.Windows.Forms.GroupBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblAppVer = new System.Windows.Forms.Label();
            this.grpAlgorithms.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(343, 79);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(637, 29);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(761, 183);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(253, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStartClustering
            // 
            this.btnStartClustering.Location = new System.Drawing.Point(501, 183);
            this.btnStartClustering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartClustering.Name = "btnStartClustering";
            this.btnStartClustering.Size = new System.Drawing.Size(253, 46);
            this.btnStartClustering.TabIndex = 3;
            this.btnStartClustering.Text = "Start clustering";
            this.btnStartClustering.UseVisualStyleBackColor = true;
            // 
            // lblClusteringAlg
            // 
            this.lblClusteringAlg.AutoSize = true;
            this.lblClusteringAlg.Location = new System.Drawing.Point(15, 30);
            this.lblClusteringAlg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClusteringAlg.Name = "lblClusteringAlg";
            this.lblClusteringAlg.Size = new System.Drawing.Size(267, 25);
            this.lblClusteringAlg.TabIndex = 6;
            this.lblClusteringAlg.Text = "Select the custering algorithm";
            this.lblClusteringAlg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optKNN
            // 
            this.optKNN.AutoSize = true;
            this.optKNN.Location = new System.Drawing.Point(389, 30);
            this.optKNN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optKNN.Name = "optKNN";
            this.optKNN.Size = new System.Drawing.Size(79, 29);
            this.optKNN.TabIndex = 7;
            this.optKNN.TabStop = true;
            this.optKNN.Text = "KNN";
            this.optKNN.UseVisualStyleBackColor = true;
            // 
            // optSVM
            // 
            this.optSVM.AutoSize = true;
            this.optSVM.Location = new System.Drawing.Point(541, 30);
            this.optSVM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optSVM.Name = "optSVM";
            this.optSVM.Size = new System.Drawing.Size(82, 29);
            this.optSVM.TabIndex = 8;
            this.optSVM.TabStop = true;
            this.optSVM.Text = "SVM";
            this.optSVM.UseVisualStyleBackColor = true;
            // 
            // optBayes
            // 
            this.optBayes.AutoSize = true;
            this.optBayes.Location = new System.Drawing.Point(710, 28);
            this.optBayes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optBayes.Name = "optBayes";
            this.optBayes.Size = new System.Drawing.Size(235, 29);
            this.optBayes.TabIndex = 9;
            this.optBayes.TabStop = true;
            this.optBayes.Text = "Gaussian Naive Bayes";
            this.optBayes.UseVisualStyleBackColor = true;
            // 
            // grpAlgorithms
            // 
            this.grpAlgorithms.Controls.Add(this.lblFilePath);
            this.grpAlgorithms.Controls.Add(this.optBayes);
            this.grpAlgorithms.Controls.Add(this.btnBrowse);
            this.grpAlgorithms.Controls.Add(this.lblClusteringAlg);
            this.grpAlgorithms.Controls.Add(this.optSVM);
            this.grpAlgorithms.Controls.Add(this.optKNN);
            this.grpAlgorithms.Controls.Add(this.txtFilePath);
            this.grpAlgorithms.Location = new System.Drawing.Point(13, 4);
            this.grpAlgorithms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAlgorithms.Name = "grpAlgorithms";
            this.grpAlgorithms.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAlgorithms.Size = new System.Drawing.Size(1001, 156);
            this.grpAlgorithms.TabIndex = 10;
            this.grpAlgorithms.TabStop = false;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(279, 83);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(58, 25);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(20, 72);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(253, 46);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Select the .CSV file";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblAppVer
            // 
            this.lblAppVer.AutoSize = true;
            this.lblAppVer.Location = new System.Drawing.Point(13, 203);
            this.lblAppVer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppVer.Name = "lblAppVer";
            this.lblAppVer.Size = new System.Drawing.Size(203, 25);
            this.lblAppVer.TabIndex = 11;
            this.lblAppVer.Text = "Clustering App V1.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 246);
            this.Controls.Add(this.lblAppVer);
            this.Controls.Add(this.grpAlgorithms);
            this.Controls.Add(this.btnStartClustering);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clustering";
            this.grpAlgorithms.ResumeLayout(false);
            this.grpAlgorithms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStartClustering;
        private System.Windows.Forms.Label lblClusteringAlg;
        private System.Windows.Forms.RadioButton optKNN;
        private System.Windows.Forms.RadioButton optSVM;
        private System.Windows.Forms.RadioButton optBayes;
        private System.Windows.Forms.GroupBox grpAlgorithms;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblAppVer;
    }
}

