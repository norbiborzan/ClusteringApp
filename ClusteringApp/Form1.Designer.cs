
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
            this.optCompare = new System.Windows.Forms.RadioButton();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.grpPreprocessing = new System.Windows.Forms.GroupBox();
            this.optReplaceNan = new System.Windows.Forms.RadioButton();
            this.lblPreprocessingType = new System.Windows.Forms.Label();
            this.optDropNaRows = new System.Windows.Forms.RadioButton();
            this.optDropNaColumns = new System.Windows.Forms.RadioButton();
            this.grpConfMtx = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.optShowKNNCM = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.optShowSVMCM = new System.Windows.Forms.RadioButton();
            this.txtTN = new System.Windows.Forms.TextBox();
            this.optShowGNBCM = new System.Windows.Forms.RadioButton();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtFP = new System.Windows.Forms.TextBox();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMetrics = new System.Windows.Forms.GroupBox();
            this.txtIncorrectPredCount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCorrectPredCount = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.optShowKNNM = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.optShowSVMM = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.optShowGNBM = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.grpSelectColumn = new System.Windows.Forms.GroupBox();
            this.cbxColumns = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvDataset = new System.Windows.Forms.DataGridView();
            this.grpAppControls = new System.Windows.Forms.GroupBox();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.grpDataset.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.grpPreprocessing.SuspendLayout();
            this.grpConfMtx.SuspendLayout();
            this.grpMetrics.SuspendLayout();
            this.grpSelectColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataset)).BeginInit();
            this.grpAppControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(92, 110);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(519, 29);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 29);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(275, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close Application";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStartClustering
            // 
            this.btnStartClustering.Location = new System.Drawing.Point(23, 29);
            this.btnStartClustering.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartClustering.Name = "btnStartClustering";
            this.btnStartClustering.Size = new System.Drawing.Size(275, 46);
            this.btnStartClustering.TabIndex = 3;
            this.btnStartClustering.Text = "Start Clustering";
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
            this.optKNN.Location = new System.Drawing.Point(73, 81);
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
            this.optSVM.Location = new System.Drawing.Point(73, 117);
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
            this.optBayes.Location = new System.Drawing.Point(73, 154);
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
            this.lblFilePath.Location = new System.Drawing.Point(28, 114);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(58, 25);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(92, 42);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(253, 46);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Load dataset";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // optCompare
            // 
            this.optCompare.AutoSize = true;
            this.optCompare.Location = new System.Drawing.Point(73, 191);
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
            this.grpOperations.Location = new System.Drawing.Point(24, 406);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(643, 230);
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
            this.grpPreprocessing.Location = new System.Drawing.Point(24, 189);
            this.grpPreprocessing.Name = "grpPreprocessing";
            this.grpPreprocessing.Size = new System.Drawing.Size(643, 204);
            this.grpPreprocessing.TabIndex = 13;
            this.grpPreprocessing.TabStop = false;
            this.grpPreprocessing.Text = "Pre-Processing";
            // 
            // optReplaceNan
            // 
            this.optReplaceNan.AutoSize = true;
            this.optReplaceNan.Location = new System.Drawing.Point(73, 156);
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
            this.optDropNaRows.Location = new System.Drawing.Point(73, 78);
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
            this.optDropNaColumns.Location = new System.Drawing.Point(73, 117);
            this.optDropNaColumns.Margin = new System.Windows.Forms.Padding(4);
            this.optDropNaColumns.Name = "optDropNaColumns";
            this.optDropNaColumns.Size = new System.Drawing.Size(357, 29);
            this.optDropNaColumns.TabIndex = 13;
            this.optDropNaColumns.Text = "Drop NaN values containing columns";
            this.optDropNaColumns.UseVisualStyleBackColor = true;
            // 
            // grpConfMtx
            // 
            this.grpConfMtx.Controls.Add(this.label18);
            this.grpConfMtx.Controls.Add(this.optShowKNNCM);
            this.grpConfMtx.Controls.Add(this.label6);
            this.grpConfMtx.Controls.Add(this.optShowSVMCM);
            this.grpConfMtx.Controls.Add(this.txtTN);
            this.grpConfMtx.Controls.Add(this.optShowGNBCM);
            this.grpConfMtx.Controls.Add(this.txtFN);
            this.grpConfMtx.Controls.Add(this.txtFP);
            this.grpConfMtx.Controls.Add(this.txtTP);
            this.grpConfMtx.Controls.Add(this.label5);
            this.grpConfMtx.Controls.Add(this.label4);
            this.grpConfMtx.Controls.Add(this.label3);
            this.grpConfMtx.Controls.Add(this.label2);
            this.grpConfMtx.Controls.Add(this.label1);
            this.grpConfMtx.Location = new System.Drawing.Point(24, 649);
            this.grpConfMtx.Name = "grpConfMtx";
            this.grpConfMtx.Size = new System.Drawing.Size(643, 232);
            this.grpConfMtx.TabIndex = 13;
            this.grpConfMtx.TabStop = false;
            this.grpConfMtx.Text = "Confusion Matrix";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 36);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(235, 25);
            this.label18.TabIndex = 11;
            this.label18.Text = "Show confusion matrix for";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optShowKNNCM
            // 
            this.optShowKNNCM.AutoSize = true;
            this.optShowKNNCM.Location = new System.Drawing.Point(250, 34);
            this.optShowKNNCM.Margin = new System.Windows.Forms.Padding(4);
            this.optShowKNNCM.Name = "optShowKNNCM";
            this.optShowKNNCM.Size = new System.Drawing.Size(79, 29);
            this.optShowKNNCM.TabIndex = 12;
            this.optShowKNNCM.TabStop = true;
            this.optShowKNNCM.Text = "KNN";
            this.optShowKNNCM.UseVisualStyleBackColor = true;
            this.optShowKNNCM.CheckedChanged += new System.EventHandler(this.optShowKNNCM_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Predicted Class";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optShowSVMCM
            // 
            this.optShowSVMCM.AutoSize = true;
            this.optShowSVMCM.Location = new System.Drawing.Point(365, 34);
            this.optShowSVMCM.Margin = new System.Windows.Forms.Padding(4);
            this.optShowSVMCM.Name = "optShowSVMCM";
            this.optShowSVMCM.Size = new System.Drawing.Size(82, 29);
            this.optShowSVMCM.TabIndex = 13;
            this.optShowSVMCM.TabStop = true;
            this.optShowSVMCM.Text = "SVM";
            this.optShowSVMCM.UseVisualStyleBackColor = true;
            this.optShowSVMCM.CheckedChanged += new System.EventHandler(this.optShowSVMCM_CheckedChanged);
            // 
            // txtTN
            // 
            this.txtTN.Location = new System.Drawing.Point(464, 178);
            this.txtTN.Name = "txtTN";
            this.txtTN.ReadOnly = true;
            this.txtTN.Size = new System.Drawing.Size(124, 29);
            this.txtTN.TabIndex = 9;
            this.txtTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // optShowGNBCM
            // 
            this.optShowGNBCM.AutoSize = true;
            this.optShowGNBCM.Location = new System.Drawing.Point(491, 34);
            this.optShowGNBCM.Margin = new System.Windows.Forms.Padding(4);
            this.optShowGNBCM.Name = "optShowGNBCM";
            this.optShowGNBCM.Size = new System.Drawing.Size(79, 29);
            this.optShowGNBCM.TabIndex = 14;
            this.optShowGNBCM.TabStop = true;
            this.optShowGNBCM.Text = "GNB";
            this.optShowGNBCM.UseVisualStyleBackColor = true;
            this.optShowGNBCM.CheckedChanged += new System.EventHandler(this.optShowGNBCM_CheckedChanged);
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(302, 178);
            this.txtFN.Name = "txtFN";
            this.txtFN.ReadOnly = true;
            this.txtFN.Size = new System.Drawing.Size(124, 29);
            this.txtFN.TabIndex = 8;
            this.txtFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFP
            // 
            this.txtFP.Location = new System.Drawing.Point(464, 137);
            this.txtFP.Name = "txtFP";
            this.txtFP.ReadOnly = true;
            this.txtFP.Size = new System.Drawing.Size(124, 29);
            this.txtFP.TabIndex = 7;
            this.txtFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTP
            // 
            this.txtTP.BackColor = System.Drawing.SystemColors.Control;
            this.txtTP.Location = new System.Drawing.Point(302, 137);
            this.txtTP.Name = "txtTP";
            this.txtTP.ReadOnly = true;
            this.txtTP.Size = new System.Drawing.Size(124, 29);
            this.txtTP.TabIndex = 6;
            this.txtTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Negative";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Positive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Negative";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Positive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "True Class";
            // 
            // grpMetrics
            // 
            this.grpMetrics.Controls.Add(this.txtIncorrectPredCount);
            this.grpMetrics.Controls.Add(this.label23);
            this.grpMetrics.Controls.Add(this.txtCorrectPredCount);
            this.grpMetrics.Controls.Add(this.label24);
            this.grpMetrics.Controls.Add(this.label19);
            this.grpMetrics.Controls.Add(this.optShowKNNM);
            this.grpMetrics.Controls.Add(this.label15);
            this.grpMetrics.Controls.Add(this.optShowSVMM);
            this.grpMetrics.Controls.Add(this.label16);
            this.grpMetrics.Controls.Add(this.optShowGNBM);
            this.grpMetrics.Controls.Add(this.label17);
            this.grpMetrics.Controls.Add(this.label14);
            this.grpMetrics.Controls.Add(this.label13);
            this.grpMetrics.Controls.Add(this.label12);
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
            this.grpMetrics.Location = new System.Drawing.Point(24, 899);
            this.grpMetrics.Name = "grpMetrics";
            this.grpMetrics.Size = new System.Drawing.Size(643, 301);
            this.grpMetrics.TabIndex = 14;
            this.grpMetrics.TabStop = false;
            this.grpMetrics.Text = "Metrics";
            // 
            // txtIncorrectPredCount
            // 
            this.txtIncorrectPredCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtIncorrectPredCount.Location = new System.Drawing.Point(464, 243);
            this.txtIncorrectPredCount.Name = "txtIncorrectPredCount";
            this.txtIncorrectPredCount.ReadOnly = true;
            this.txtIncorrectPredCount.Size = new System.Drawing.Size(124, 29);
            this.txtIncorrectPredCount.TabIndex = 32;
            this.txtIncorrectPredCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(404, 209);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(229, 25);
            this.label23.TabIndex = 31;
            this.label23.Text = "Incorrect prediction count";
            // 
            // txtCorrectPredCount
            // 
            this.txtCorrectPredCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorrectPredCount.Location = new System.Drawing.Point(158, 243);
            this.txtCorrectPredCount.Name = "txtCorrectPredCount";
            this.txtCorrectPredCount.ReadOnly = true;
            this.txtCorrectPredCount.Size = new System.Drawing.Size(124, 29);
            this.txtCorrectPredCount.TabIndex = 30;
            this.txtCorrectPredCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(104, 209);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(218, 25);
            this.label24.TabIndex = 29;
            this.label24.Text = "Correct prediction count";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 35);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(156, 25);
            this.label19.TabIndex = 16;
            this.label19.Text = "Show metrics for";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optShowKNNM
            // 
            this.optShowKNNM.AutoSize = true;
            this.optShowKNNM.Location = new System.Drawing.Point(252, 33);
            this.optShowKNNM.Margin = new System.Windows.Forms.Padding(4);
            this.optShowKNNM.Name = "optShowKNNM";
            this.optShowKNNM.Size = new System.Drawing.Size(79, 29);
            this.optShowKNNM.TabIndex = 17;
            this.optShowKNNM.TabStop = true;
            this.optShowKNNM.Text = "KNN";
            this.optShowKNNM.UseVisualStyleBackColor = true;
            this.optShowKNNM.CheckedChanged += new System.EventHandler(this.optShowKNNM_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(594, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "%";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optShowSVMM
            // 
            this.optShowSVMM.AutoSize = true;
            this.optShowSVMM.Location = new System.Drawing.Point(367, 33);
            this.optShowSVMM.Margin = new System.Windows.Forms.Padding(4);
            this.optShowSVMM.Name = "optShowSVMM";
            this.optShowSVMM.Size = new System.Drawing.Size(82, 29);
            this.optShowSVMM.TabIndex = 18;
            this.optShowSVMM.TabStop = true;
            this.optShowSVMM.Text = "SVM";
            this.optShowSVMM.UseVisualStyleBackColor = true;
            this.optShowSVMM.CheckedChanged += new System.EventHandler(this.optShowSVMM_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(594, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "%";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optShowGNBM
            // 
            this.optShowGNBM.AutoSize = true;
            this.optShowGNBM.Location = new System.Drawing.Point(493, 33);
            this.optShowGNBM.Margin = new System.Windows.Forms.Padding(4);
            this.optShowGNBM.Name = "optShowGNBM";
            this.optShowGNBM.Size = new System.Drawing.Size(79, 29);
            this.optShowGNBM.TabIndex = 19;
            this.optShowGNBM.TabStop = true;
            this.optShowGNBM.Text = "GNB";
            this.optShowGNBM.UseVisualStyleBackColor = true;
            this.optShowGNBM.CheckedChanged += new System.EventHandler(this.optShowGNBM_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(594, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 25);
            this.label17.TabIndex = 26;
            this.label17.Text = "%";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "%";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "%";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTNRate
            // 
            this.txtTNRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtTNRate.Location = new System.Drawing.Point(464, 124);
            this.txtTNRate.Name = "txtTNRate";
            this.txtTNRate.ReadOnly = true;
            this.txtTNRate.Size = new System.Drawing.Size(124, 29);
            this.txtTNRate.TabIndex = 22;
            this.txtTNRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "TN Rate";
            // 
            // txtPrelevance
            // 
            this.txtPrelevance.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrelevance.Location = new System.Drawing.Point(158, 124);
            this.txtPrelevance.Name = "txtPrelevance";
            this.txtPrelevance.ReadOnly = true;
            this.txtPrelevance.Size = new System.Drawing.Size(124, 29);
            this.txtPrelevance.TabIndex = 20;
            this.txtPrelevance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Prelevance";
            // 
            // txtFPRate
            // 
            this.txtFPRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtFPRate.Location = new System.Drawing.Point(464, 165);
            this.txtFPRate.Name = "txtFPRate";
            this.txtFPRate.ReadOnly = true;
            this.txtFPRate.Size = new System.Drawing.Size(124, 29);
            this.txtFPRate.TabIndex = 18;
            this.txtFPRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "FP Rate";
            // 
            // txtTPRate
            // 
            this.txtTPRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtTPRate.Location = new System.Drawing.Point(158, 165);
            this.txtTPRate.Name = "txtTPRate";
            this.txtTPRate.ReadOnly = true;
            this.txtTPRate.Size = new System.Drawing.Size(124, 29);
            this.txtTPRate.TabIndex = 16;
            this.txtTPRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "TP Rate";
            // 
            // txtPrecision
            // 
            this.txtPrecision.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecision.Location = new System.Drawing.Point(464, 83);
            this.txtPrecision.Name = "txtPrecision";
            this.txtPrecision.ReadOnly = true;
            this.txtPrecision.Size = new System.Drawing.Size(124, 29);
            this.txtPrecision.TabIndex = 14;
            this.txtPrecision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precision";
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.BackColor = System.Drawing.SystemColors.Control;
            this.txtAccuracy.Location = new System.Drawing.Point(158, 83);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.ReadOnly = true;
            this.txtAccuracy.Size = new System.Drawing.Size(124, 29);
            this.txtAccuracy.TabIndex = 12;
            this.txtAccuracy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(58, 83);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(94, 25);
            this.lbl7.TabIndex = 11;
            this.lbl7.Text = "Accuracy";
            // 
            // grpSelectColumn
            // 
            this.grpSelectColumn.Controls.Add(this.cbxColumns);
            this.grpSelectColumn.Controls.Add(this.label20);
            this.grpSelectColumn.Location = new System.Drawing.Point(24, 1217);
            this.grpSelectColumn.Name = "grpSelectColumn";
            this.grpSelectColumn.Size = new System.Drawing.Size(643, 110);
            this.grpSelectColumn.TabIndex = 15;
            this.grpSelectColumn.TabStop = false;
            this.grpSelectColumn.Text = "Remove column";
            // 
            // cbxColumns
            // 
            this.cbxColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColumns.FormattingEnabled = true;
            this.cbxColumns.Location = new System.Drawing.Point(276, 43);
            this.cbxColumns.Name = "cbxColumns";
            this.cbxColumns.Size = new System.Drawing.Size(335, 32);
            this.cbxColumns.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 50);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(253, 25);
            this.label20.TabIndex = 11;
            this.label20.Text = "Ignore the following column:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDataset
            // 
            this.dgvDataset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataset.Location = new System.Drawing.Point(688, 25);
            this.dgvDataset.Name = "dgvDataset";
            this.dgvDataset.RowHeadersWidth = 72;
            this.dgvDataset.RowTemplate.Height = 31;
            this.dgvDataset.Size = new System.Drawing.Size(1884, 1444);
            this.dgvDataset.TabIndex = 16;
            // 
            // grpAppControls
            // 
            this.grpAppControls.Controls.Add(this.btnStartClustering);
            this.grpAppControls.Controls.Add(this.btnClose);
            this.grpAppControls.Location = new System.Drawing.Point(24, 1330);
            this.grpAppControls.Name = "grpAppControls";
            this.grpAppControls.Size = new System.Drawing.Size(643, 104);
            this.grpAppControls.TabIndex = 17;
            this.grpAppControls.TabStop = false;
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Location = new System.Drawing.Point(13, 1454);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(341, 25);
            this.lblAppVersion.TabIndex = 18;
            this.lblAppVersion.Text = "Clustering Algorithm Comparer V1.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2598, 1486);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.grpAppControls);
            this.Controls.Add(this.dgvDataset);
            this.Controls.Add(this.grpSelectColumn);
            this.Controls.Add(this.grpMetrics);
            this.Controls.Add(this.grpConfMtx);
            this.Controls.Add(this.grpPreprocessing);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.grpDataset);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(2622, 1550);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Clustering Algorithm Comparer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.grpSelectColumn.ResumeLayout(false);
            this.grpSelectColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataset)).EndInit();
            this.grpAppControls.ResumeLayout(false);
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton optShowKNNCM;
        private System.Windows.Forms.RadioButton optShowSVMCM;
        private System.Windows.Forms.RadioButton optShowGNBCM;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton optShowKNNM;
        private System.Windows.Forms.RadioButton optShowSVMM;
        private System.Windows.Forms.RadioButton optShowGNBM;
        private System.Windows.Forms.GroupBox grpSelectColumn;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbxColumns;
        private System.Windows.Forms.DataGridView dgvDataset;
        private System.Windows.Forms.TextBox txtIncorrectPredCount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtCorrectPredCount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox grpAppControls;
        private System.Windows.Forms.Label lblAppVersion;
    }
}

