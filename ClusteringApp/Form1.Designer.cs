
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
            this.grpDataset = new System.Windows.Forms.GroupBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblAppVer = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.grpPreprocessing = new System.Windows.Forms.GroupBox();
            this.lblPreprocessingType = new System.Windows.Forms.Label();
            this.optSubstitute = new System.Windows.Forms.RadioButton();
            this.optDropNaRows = new System.Windows.Forms.RadioButton();
            this.optDropNaColumns = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDataset = new System.Windows.Forms.DataGridView();
            this.grpPlotting = new System.Windows.Forms.GroupBox();
            this.optScatter = new System.Windows.Forms.RadioButton();
            this.optHighlighetdScatter = new System.Windows.Forms.RadioButton();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.lblPlottingTypel = new System.Windows.Forms.Label();
            this.imgScatter = new System.Windows.Forms.PictureBox();
            this.imgHighlightedScatter = new System.Windows.Forms.PictureBox();
            this.grpDataset.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.grpPreprocessing.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataset)).BeginInit();
            this.grpPlotting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgScatter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHighlightedScatter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(73, 109);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(493, 29);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(287, 1031);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(253, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStartClustering
            // 
            this.btnStartClustering.Location = new System.Drawing.Point(26, 1031);
            this.btnStartClustering.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartClustering.Name = "btnStartClustering";
            this.btnStartClustering.Size = new System.Drawing.Size(253, 46);
            this.btnStartClustering.TabIndex = 3;
            this.btnStartClustering.Text = "Start";
            this.btnStartClustering.UseVisualStyleBackColor = true;
            this.btnStartClustering.Click += new System.EventHandler(this.btnStartClustering_Click);
            // 
            // lblClusteringAlg
            // 
            this.lblClusteringAlg.AutoSize = true;
            this.lblClusteringAlg.Location = new System.Drawing.Point(9, 52);
            this.lblClusteringAlg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClusteringAlg.Name = "lblClusteringAlg";
            this.lblClusteringAlg.Size = new System.Drawing.Size(227, 25);
            this.lblClusteringAlg.TabIndex = 6;
            this.lblClusteringAlg.Text = "Select the operation type";
            this.lblClusteringAlg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optKNN
            // 
            this.optKNN.AutoSize = true;
            this.optKNN.Location = new System.Drawing.Point(73, 96);
            this.optKNN.Margin = new System.Windows.Forms.Padding(4);
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
            this.optSVM.Location = new System.Drawing.Point(73, 144);
            this.optSVM.Margin = new System.Windows.Forms.Padding(4);
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
            this.optBayes.Location = new System.Drawing.Point(73, 193);
            this.optBayes.Margin = new System.Windows.Forms.Padding(4);
            this.optBayes.Name = "optBayes";
            this.optBayes.Size = new System.Drawing.Size(235, 29);
            this.optBayes.TabIndex = 9;
            this.optBayes.TabStop = true;
            this.optBayes.Text = "Gaussian Naive Bayes";
            this.optBayes.UseVisualStyleBackColor = true;
            // 
            // grpDataset
            // 
            this.grpDataset.Controls.Add(this.lblFilePath);
            this.grpDataset.Controls.Add(this.btnBrowse);
            this.grpDataset.Controls.Add(this.txtFilePath);
            this.grpDataset.Location = new System.Drawing.Point(24, 14);
            this.grpDataset.Margin = new System.Windows.Forms.Padding(4);
            this.grpDataset.Name = "grpDataset";
            this.grpDataset.Padding = new System.Windows.Forms.Padding(4);
            this.grpDataset.Size = new System.Drawing.Size(602, 180);
            this.grpDataset.TabIndex = 10;
            this.grpDataset.TabStop = false;
            this.grpDataset.Text = "Dataset";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(9, 113);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(58, 25);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(73, 42);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(253, 46);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Load dataset";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblAppVer
            // 
            this.lblAppVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAppVer.AutoSize = true;
            this.lblAppVer.Location = new System.Drawing.Point(8, 1087);
            this.lblAppVer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppVer.Name = "lblAppVer";
            this.lblAppVer.Size = new System.Drawing.Size(69, 25);
            this.lblAppVer.TabIndex = 11;
            this.lblAppVer.Text = "V1.0.0";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(73, 240);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(215, 29);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Compare Algorithms";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.lblClusteringAlg);
            this.grpOperations.Controls.Add(this.radioButton1);
            this.grpOperations.Controls.Add(this.optKNN);
            this.grpOperations.Controls.Add(this.optSVM);
            this.grpOperations.Controls.Add(this.optBayes);
            this.grpOperations.Location = new System.Drawing.Point(24, 452);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(602, 296);
            this.grpOperations.TabIndex = 12;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Operation";
            // 
            // grpPreprocessing
            // 
            this.grpPreprocessing.Controls.Add(this.optSubstitute);
            this.grpPreprocessing.Controls.Add(this.lblPreprocessingType);
            this.grpPreprocessing.Controls.Add(this.optDropNaRows);
            this.grpPreprocessing.Controls.Add(this.optDropNaColumns);
            this.grpPreprocessing.Location = new System.Drawing.Point(24, 201);
            this.grpPreprocessing.Name = "grpPreprocessing";
            this.grpPreprocessing.Size = new System.Drawing.Size(602, 245);
            this.grpPreprocessing.TabIndex = 13;
            this.grpPreprocessing.TabStop = false;
            this.grpPreprocessing.Text = "Pre-Processing";
            // 
            // lblPreprocessingType
            // 
            this.lblPreprocessingType.AutoSize = true;
            this.lblPreprocessingType.Location = new System.Drawing.Point(9, 52);
            this.lblPreprocessingType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreprocessingType.Name = "lblPreprocessingType";
            this.lblPreprocessingType.Size = new System.Drawing.Size(276, 25);
            this.lblPreprocessingType.TabIndex = 11;
            this.lblPreprocessingType.Text = "Select the pre-processing type";
            this.lblPreprocessingType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optSubstitute
            // 
            this.optSubstitute.AutoSize = true;
            this.optSubstitute.Location = new System.Drawing.Point(73, 192);
            this.optSubstitute.Margin = new System.Windows.Forms.Padding(4);
            this.optSubstitute.Name = "optSubstitute";
            this.optSubstitute.Size = new System.Drawing.Size(457, 29);
            this.optSubstitute.TabIndex = 14;
            this.optSubstitute.Text = "Substitute NaN values with average of neighbors";
            this.optSubstitute.UseVisualStyleBackColor = true;
            // 
            // optDropNaRows
            // 
            this.optDropNaRows.AutoSize = true;
            this.optDropNaRows.Location = new System.Drawing.Point(73, 93);
            this.optDropNaRows.Margin = new System.Windows.Forms.Padding(4);
            this.optDropNaRows.Name = "optDropNaRows";
            this.optDropNaRows.Size = new System.Drawing.Size(325, 29);
            this.optDropNaRows.TabIndex = 11;
            this.optDropNaRows.Text = "Drop NaN values containing rows";
            this.optDropNaRows.UseVisualStyleBackColor = true;
            // 
            // optDropNaColumns
            // 
            this.optDropNaColumns.AutoSize = true;
            this.optDropNaColumns.Location = new System.Drawing.Point(73, 141);
            this.optDropNaColumns.Margin = new System.Windows.Forms.Padding(4);
            this.optDropNaColumns.Name = "optDropNaColumns";
            this.optDropNaColumns.Size = new System.Drawing.Size(357, 29);
            this.optDropNaColumns.TabIndex = 13;
            this.optDropNaColumns.Text = "Drop NaN values containing columns";
            this.optDropNaColumns.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(651, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1963, 1086);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDataset);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1955, 1049);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.imgHighlightedScatter);
            this.tabPage2.Controls.Add(this.imgScatter);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2008, 1038);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDataset
            // 
            this.dgvDataset.AllowUserToAddRows = false;
            this.dgvDataset.AllowUserToDeleteRows = false;
            this.dgvDataset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataset.Location = new System.Drawing.Point(6, 6);
            this.dgvDataset.Name = "dgvDataset";
            this.dgvDataset.ReadOnly = true;
            this.dgvDataset.RowHeadersWidth = 72;
            this.dgvDataset.RowTemplate.Height = 31;
            this.dgvDataset.Size = new System.Drawing.Size(1943, 1037);
            this.dgvDataset.TabIndex = 0;
            // 
            // grpPlotting
            // 
            this.grpPlotting.Controls.Add(this.lblPlottingTypel);
            this.grpPlotting.Controls.Add(this.optScatter);
            this.grpPlotting.Controls.Add(this.optHighlighetdScatter);
            this.grpPlotting.Controls.Add(this.optAll);
            this.grpPlotting.Location = new System.Drawing.Point(24, 754);
            this.grpPlotting.Name = "grpPlotting";
            this.grpPlotting.Size = new System.Drawing.Size(602, 255);
            this.grpPlotting.TabIndex = 15;
            this.grpPlotting.TabStop = false;
            this.grpPlotting.Text = "Plotting";
            // 
            // optScatter
            // 
            this.optScatter.AutoSize = true;
            this.optScatter.Location = new System.Drawing.Point(66, 103);
            this.optScatter.Margin = new System.Windows.Forms.Padding(4);
            this.optScatter.Name = "optScatter";
            this.optScatter.Size = new System.Drawing.Size(137, 29);
            this.optScatter.TabIndex = 11;
            this.optScatter.Text = "Scatter Plot";
            this.optScatter.UseVisualStyleBackColor = true;
            // 
            // optHighlighetdScatter
            // 
            this.optHighlighetdScatter.AutoSize = true;
            this.optHighlighetdScatter.Location = new System.Drawing.Point(66, 151);
            this.optHighlighetdScatter.Margin = new System.Windows.Forms.Padding(4);
            this.optHighlighetdScatter.Name = "optHighlighetdScatter";
            this.optHighlighetdScatter.Size = new System.Drawing.Size(239, 29);
            this.optHighlighetdScatter.TabIndex = 12;
            this.optHighlighetdScatter.Text = "Highlighted Scatter Plot";
            this.optHighlighetdScatter.UseVisualStyleBackColor = true;
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.Location = new System.Drawing.Point(66, 200);
            this.optAll.Margin = new System.Windows.Forms.Padding(4);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(59, 29);
            this.optAll.TabIndex = 13;
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = true;
            // 
            // lblPlottingTypel
            // 
            this.lblPlottingTypel.AutoSize = true;
            this.lblPlottingTypel.Location = new System.Drawing.Point(12, 54);
            this.lblPlottingTypel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlottingTypel.Name = "lblPlottingTypel";
            this.lblPlottingTypel.Size = new System.Drawing.Size(227, 25);
            this.lblPlottingTypel.TabIndex = 11;
            this.lblPlottingTypel.Text = "Select the operation type";
            this.lblPlottingTypel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgScatter
            // 
            this.imgScatter.Location = new System.Drawing.Point(18, 21);
            this.imgScatter.Name = "imgScatter";
            this.imgScatter.Size = new System.Drawing.Size(977, 983);
            this.imgScatter.TabIndex = 0;
            this.imgScatter.TabStop = false;
            // 
            // imgHighlightedScatter
            // 
            this.imgHighlightedScatter.Location = new System.Drawing.Point(1024, 21);
            this.imgHighlightedScatter.Name = "imgHighlightedScatter";
            this.imgHighlightedScatter.Size = new System.Drawing.Size(955, 983);
            this.imgHighlightedScatter.TabIndex = 1;
            this.imgHighlightedScatter.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2626, 1121);
            this.Controls.Add(this.grpPlotting);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpPreprocessing);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.lblAppVer);
            this.Controls.Add(this.grpDataset);
            this.Controls.Add(this.btnStartClustering);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 1185);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clustering Algorithm Comparer";
            this.grpDataset.ResumeLayout(false);
            this.grpDataset.PerformLayout();
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.grpPreprocessing.ResumeLayout(false);
            this.grpPreprocessing.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataset)).EndInit();
            this.grpPlotting.ResumeLayout(false);
            this.grpPlotting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgScatter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHighlightedScatter)).EndInit();
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
        private System.Windows.Forms.GroupBox grpDataset;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblAppVer;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.GroupBox grpPreprocessing;
        private System.Windows.Forms.RadioButton optSubstitute;
        private System.Windows.Forms.Label lblPreprocessingType;
        private System.Windows.Forms.RadioButton optDropNaRows;
        private System.Windows.Forms.RadioButton optDropNaColumns;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDataset;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpPlotting;
        private System.Windows.Forms.RadioButton optScatter;
        private System.Windows.Forms.RadioButton optHighlighetdScatter;
        private System.Windows.Forms.RadioButton optAll;
        private System.Windows.Forms.Label lblPlottingTypel;
        private System.Windows.Forms.PictureBox imgHighlightedScatter;
        private System.Windows.Forms.PictureBox imgScatter;
    }
}

