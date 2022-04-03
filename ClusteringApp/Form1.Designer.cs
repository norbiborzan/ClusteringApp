
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
            this.optCompare = new System.Windows.Forms.RadioButton();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.grpPreprocessing = new System.Windows.Forms.GroupBox();
            this.optReplaceNan = new System.Windows.Forms.RadioButton();
            this.lblPreprocessingType = new System.Windows.Forms.Label();
            this.optDropNaRows = new System.Windows.Forms.RadioButton();
            this.optDropNaColumns = new System.Windows.Forms.RadioButton();
            this.grpConfMtx = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtFP = new System.Windows.Forms.TextBox();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMetrics = new System.Windows.Forms.GroupBox();
            this.txtTNRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrelevance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFPRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTPRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecision = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccuracy = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDataset = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.grpDataset.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.grpPreprocessing.SuspendLayout();
            this.grpConfMtx.SuspendLayout();
            this.grpMetrics.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataset)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(127, 110);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(493, 29);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(331, 1070);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStartClustering
            // 
            this.btnStartClustering.Location = new System.Drawing.Point(24, 1070);
            this.btnStartClustering.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartClustering.Name = "btnStartClustering";
            this.btnStartClustering.Size = new System.Drawing.Size(295, 46);
            this.btnStartClustering.TabIndex = 3;
            this.btnStartClustering.Text = "Start";
            this.btnStartClustering.UseVisualStyleBackColor = true;
            this.btnStartClustering.Click += new System.EventHandler(this.btnStartClustering_Click);
            // 
            // lblClusteringAlg
            // 
            this.lblClusteringAlg.AutoSize = true;
            this.lblClusteringAlg.Location = new System.Drawing.Point(9, 39);
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
            this.optKNN.Location = new System.Drawing.Point(73, 83);
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
            this.optSVM.Location = new System.Drawing.Point(73, 120);
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
            this.optBayes.Location = new System.Drawing.Point(73, 157);
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
            this.grpDataset.Size = new System.Drawing.Size(643, 162);
            this.grpDataset.TabIndex = 10;
            this.grpDataset.TabStop = false;
            this.grpDataset.Text = "Dataset";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(63, 114);
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
            this.lblAppVer.Location = new System.Drawing.Point(15, 1136);
            this.lblAppVer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppVer.Name = "lblAppVer";
            this.lblAppVer.Size = new System.Drawing.Size(69, 25);
            this.lblAppVer.TabIndex = 11;
            this.lblAppVer.Text = "V1.0.0";
            // 
            // optCompare
            // 
            this.optCompare.AutoSize = true;
            this.optCompare.Location = new System.Drawing.Point(73, 194);
            this.optCompare.Margin = new System.Windows.Forms.Padding(4);
            this.optCompare.Name = "optCompare";
            this.optCompare.Size = new System.Drawing.Size(215, 29);
            this.optCompare.TabIndex = 10;
            this.optCompare.TabStop = true;
            this.optCompare.Text = "Compare Algorithms";
            this.optCompare.UseVisualStyleBackColor = true;
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.lblClusteringAlg);
            this.grpOperations.Controls.Add(this.optCompare);
            this.grpOperations.Controls.Add(this.optKNN);
            this.grpOperations.Controls.Add(this.optSVM);
            this.grpOperations.Controls.Add(this.optBayes);
            this.grpOperations.Location = new System.Drawing.Point(24, 407);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(643, 251);
            this.grpOperations.TabIndex = 12;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Operation";
            // 
            // grpPreprocessing
            // 
            this.grpPreprocessing.Controls.Add(this.optReplaceNan);
            this.grpPreprocessing.Controls.Add(this.lblPreprocessingType);
            this.grpPreprocessing.Controls.Add(this.optDropNaRows);
            this.grpPreprocessing.Controls.Add(this.optDropNaColumns);
            this.grpPreprocessing.Location = new System.Drawing.Point(24, 192);
            this.grpPreprocessing.Name = "grpPreprocessing";
            this.grpPreprocessing.Size = new System.Drawing.Size(643, 209);
            this.grpPreprocessing.TabIndex = 13;
            this.grpPreprocessing.TabStop = false;
            this.grpPreprocessing.Text = "Pre-Processing";
            // 
            // optReplaceNan
            // 
            this.optReplaceNan.AutoSize = true;
            this.optReplaceNan.Location = new System.Drawing.Point(73, 159);
            this.optReplaceNan.Margin = new System.Windows.Forms.Padding(4);
            this.optReplaceNan.Name = "optReplaceNan";
            this.optReplaceNan.Size = new System.Drawing.Size(441, 29);
            this.optReplaceNan.TabIndex = 14;
            this.optReplaceNan.Text = "Replace NaN values with average of neighbors";
            this.optReplaceNan.UseVisualStyleBackColor = true;
            // 
            // lblPreprocessingType
            // 
            this.lblPreprocessingType.AutoSize = true;
            this.lblPreprocessingType.Location = new System.Drawing.Point(9, 39);
            this.lblPreprocessingType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreprocessingType.Name = "lblPreprocessingType";
            this.lblPreprocessingType.Size = new System.Drawing.Size(276, 25);
            this.lblPreprocessingType.TabIndex = 11;
            this.lblPreprocessingType.Text = "Select the pre-processing type";
            this.lblPreprocessingType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optDropNaRows
            // 
            this.optDropNaRows.AutoSize = true;
            this.optDropNaRows.Location = new System.Drawing.Point(73, 80);
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
            this.optDropNaColumns.Location = new System.Drawing.Point(73, 120);
            this.optDropNaColumns.Margin = new System.Windows.Forms.Padding(4);
            this.optDropNaColumns.Name = "optDropNaColumns";
            this.optDropNaColumns.Size = new System.Drawing.Size(357, 29);
            this.optDropNaColumns.TabIndex = 13;
            this.optDropNaColumns.Text = "Drop NaN values containing columns";
            this.optDropNaColumns.UseVisualStyleBackColor = true;
            // 
            // grpConfMtx
            // 
            this.grpConfMtx.Controls.Add(this.label6);
            this.grpConfMtx.Controls.Add(this.txtTN);
            this.grpConfMtx.Controls.Add(this.txtFN);
            this.grpConfMtx.Controls.Add(this.txtFP);
            this.grpConfMtx.Controls.Add(this.txtTP);
            this.grpConfMtx.Controls.Add(this.label5);
            this.grpConfMtx.Controls.Add(this.label4);
            this.grpConfMtx.Controls.Add(this.label3);
            this.grpConfMtx.Controls.Add(this.label2);
            this.grpConfMtx.Controls.Add(this.label1);
            this.grpConfMtx.Location = new System.Drawing.Point(24, 664);
            this.grpConfMtx.Name = "grpConfMtx";
            this.grpConfMtx.Size = new System.Drawing.Size(643, 197);
            this.grpConfMtx.TabIndex = 13;
            this.grpConfMtx.TabStop = false;
            this.grpConfMtx.Text = "Confusion Matrix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 50);
            this.label6.TabIndex = 10;
            this.label6.Text = "Predicted \r\nClass";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTN
            // 
            this.txtTN.Location = new System.Drawing.Point(420, 134);
            this.txtTN.Name = "txtTN";
            this.txtTN.ReadOnly = true;
            this.txtTN.Size = new System.Drawing.Size(187, 29);
            this.txtTN.TabIndex = 9;
            this.txtTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(227, 134);
            this.txtFN.Name = "txtFN";
            this.txtFN.ReadOnly = true;
            this.txtFN.Size = new System.Drawing.Size(187, 29);
            this.txtFN.TabIndex = 8;
            this.txtFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFP
            // 
            this.txtFP.Location = new System.Drawing.Point(420, 96);
            this.txtFP.Name = "txtFP";
            this.txtFP.ReadOnly = true;
            this.txtFP.Size = new System.Drawing.Size(187, 29);
            this.txtFP.TabIndex = 7;
            this.txtFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTP
            // 
            this.txtTP.BackColor = System.Drawing.SystemColors.Control;
            this.txtTP.Location = new System.Drawing.Point(227, 96);
            this.txtTP.Name = "txtTP";
            this.txtTP.ReadOnly = true;
            this.txtTP.Size = new System.Drawing.Size(187, 29);
            this.txtTP.TabIndex = 6;
            this.txtTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Negative";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Positive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Negative";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Positive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "True Class";
            // 
            // grpMetrics
            // 
            this.grpMetrics.Controls.Add(this.txtTNRate);
            this.grpMetrics.Controls.Add(this.label10);
            this.grpMetrics.Controls.Add(this.txtPrelevance);
            this.grpMetrics.Controls.Add(this.label11);
            this.grpMetrics.Controls.Add(this.txtFPRate);
            this.grpMetrics.Controls.Add(this.label7);
            this.grpMetrics.Controls.Add(this.txtTPRate);
            this.grpMetrics.Controls.Add(this.label9);
            this.grpMetrics.Controls.Add(this.txtPrecision);
            this.grpMetrics.Controls.Add(this.label8);
            this.grpMetrics.Controls.Add(this.txtAccuracy);
            this.grpMetrics.Controls.Add(this.lbl7);
            this.grpMetrics.Location = new System.Drawing.Point(24, 867);
            this.grpMetrics.Name = "grpMetrics";
            this.grpMetrics.Size = new System.Drawing.Size(643, 185);
            this.grpMetrics.TabIndex = 14;
            this.grpMetrics.TabStop = false;
            this.grpMetrics.Text = "Metrics";
            // 
            // txtTNRate
            // 
            this.txtTNRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtTNRate.Location = new System.Drawing.Point(420, 83);
            this.txtTNRate.Name = "txtTNRate";
            this.txtTNRate.ReadOnly = true;
            this.txtTNRate.Size = new System.Drawing.Size(187, 29);
            this.txtTNRate.TabIndex = 22;
            this.txtTNRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "TN Rate";
            // 
            // txtPrelevance
            // 
            this.txtPrelevance.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrelevance.Location = new System.Drawing.Point(121, 87);
            this.txtPrelevance.Name = "txtPrelevance";
            this.txtPrelevance.ReadOnly = true;
            this.txtPrelevance.Size = new System.Drawing.Size(187, 29);
            this.txtPrelevance.TabIndex = 20;
            this.txtPrelevance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Prelevance";
            // 
            // txtFPRate
            // 
            this.txtFPRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtFPRate.Location = new System.Drawing.Point(420, 127);
            this.txtFPRate.Name = "txtFPRate";
            this.txtFPRate.ReadOnly = true;
            this.txtFPRate.Size = new System.Drawing.Size(187, 29);
            this.txtFPRate.TabIndex = 18;
            this.txtFPRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "FP Rate";
            // 
            // txtTPRate
            // 
            this.txtTPRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtTPRate.Location = new System.Drawing.Point(121, 127);
            this.txtTPRate.Name = "txtTPRate";
            this.txtTPRate.ReadOnly = true;
            this.txtTPRate.Size = new System.Drawing.Size(187, 29);
            this.txtTPRate.TabIndex = 16;
            this.txtTPRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "TP Rate";
            // 
            // txtPrecision
            // 
            this.txtPrecision.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecision.Location = new System.Drawing.Point(420, 41);
            this.txtPrecision.Name = "txtPrecision";
            this.txtPrecision.ReadOnly = true;
            this.txtPrecision.Size = new System.Drawing.Size(187, 29);
            this.txtPrecision.TabIndex = 14;
            this.txtPrecision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precision";
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.BackColor = System.Drawing.SystemColors.Control;
            this.txtAccuracy.Location = new System.Drawing.Point(121, 44);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.ReadOnly = true;
            this.txtAccuracy.Size = new System.Drawing.Size(187, 29);
            this.txtAccuracy.TabIndex = 12;
            this.txtAccuracy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(23, 47);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(94, 25);
            this.lbl7.TabIndex = 11;
            this.lbl7.Text = "Accuracy";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDataset);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1900, 1101);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dgvDataset.Size = new System.Drawing.Size(1888, 1089);
            this.dgvDataset.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(682, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1908, 1138);
            this.tabControl1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2602, 1170);
            this.Controls.Add(this.grpMetrics);
            this.Controls.Add(this.grpConfMtx);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpPreprocessing);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAppVer);
            this.Controls.Add(this.grpDataset);
            this.Controls.Add(this.btnStartClustering);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 1185);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clustering Algorithm Comparer";
            this.grpDataset.ResumeLayout(false);
            this.grpDataset.PerformLayout();
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.grpPreprocessing.ResumeLayout(false);
            this.grpPreprocessing.PerformLayout();
            this.grpConfMtx.ResumeLayout(false);
            this.grpConfMtx.PerformLayout();
            this.grpMetrics.ResumeLayout(false);
            this.grpMetrics.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataset)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton optCompare;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.GroupBox grpPreprocessing;
        private System.Windows.Forms.RadioButton optReplaceNan;
        private System.Windows.Forms.Label lblPreprocessingType;
        private System.Windows.Forms.RadioButton optDropNaRows;
        private System.Windows.Forms.RadioButton optDropNaColumns;
        private System.Windows.Forms.GroupBox grpConfMtx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtFP;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.GroupBox grpMetrics;
        private System.Windows.Forms.TextBox txtFPRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTPRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccuracy;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox txtTNRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrelevance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDataset;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

