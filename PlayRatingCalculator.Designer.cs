
namespace PlayRatingCalcSecondEdition
{
    partial class PlayRatingCalculator
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
            this.chartConstant = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartConstantCHUNI = new System.Windows.Forms.NumericUpDown();
            this.labelGradeCHUNI = new System.Windows.Forms.Label();
            this.scoreCHUNI = new System.Windows.Forms.NumericUpDown();
            this.labelOutputCHUNI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartConstantCHUNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreCHUNI)).BeginInit();
            this.SuspendLayout();
            // 
            // chartConstant
            // 
            this.chartConstant.DecimalPlaces = 1;
            this.chartConstant.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chartConstant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.chartConstant.Location = new System.Drawing.Point(3, 3);
            this.chartConstant.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.chartConstant.Name = "chartConstant";
            this.chartConstant.Size = new System.Drawing.Size(179, 29);
            this.chartConstant.TabIndex = 0;
            this.chartConstant.Value = new decimal(new int[] {
            105,
            0,
            0,
            65536});
            this.chartConstant.ValueChanged += new System.EventHandler(this.chartConstant_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chart Constant";
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.score.Location = new System.Drawing.Point(3, 38);
            this.score.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(179, 29);
            this.score.TabIndex = 0;
            this.score.ThousandsSeparator = true;
            this.score.Value = new decimal(new int[] {
            9500000,
            0,
            0,
            0});
            this.score.ValueChanged += new System.EventHandler(this.score_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLabel.AutoSize = true;
            this.resultLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultLabel.Font = new System.Drawing.Font("Exo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(3, 70);
            this.resultLabel.MaximumSize = new System.Drawing.Size(205, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(65, 36);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "10.5";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Exo", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGrade.Location = new System.Drawing.Point(353, 13);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(72, 49);
            this.labelGrade.TabIndex = 4;
            this.labelGrade.Text = "AA";
            this.labelGrade.Click += new System.EventHandler(this.labelGrade_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(469, 134);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartConstant);
            this.tabPage1.Controls.Add(this.labelGrade);
            this.tabPage1.Controls.Add(this.score);
            this.tabPage1.Controls.Add(this.resultLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(461, 106);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arcaea";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartConstantCHUNI);
            this.tabPage2.Controls.Add(this.labelGradeCHUNI);
            this.tabPage2.Controls.Add(this.scoreCHUNI);
            this.tabPage2.Controls.Add(this.labelOutputCHUNI);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(461, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CHUNITHM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartConstantCHUNI
            // 
            this.chartConstantCHUNI.DecimalPlaces = 1;
            this.chartConstantCHUNI.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chartConstantCHUNI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.chartConstantCHUNI.Location = new System.Drawing.Point(3, 2);
            this.chartConstantCHUNI.Maximum = new decimal(new int[] {
            141,
            0,
            0,
            65536});
            this.chartConstantCHUNI.Name = "chartConstantCHUNI";
            this.chartConstantCHUNI.Size = new System.Drawing.Size(179, 29);
            this.chartConstantCHUNI.TabIndex = 5;
            this.chartConstantCHUNI.Value = new decimal(new int[] {
            105,
            0,
            0,
            65536});
            this.chartConstantCHUNI.ValueChanged += new System.EventHandler(this.chartConstantCHUNI_ValueChanged);
            // 
            // labelGradeCHUNI
            // 
            this.labelGradeCHUNI.AutoSize = true;
            this.labelGradeCHUNI.Font = new System.Drawing.Font("Exo", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGradeCHUNI.Location = new System.Drawing.Point(357, 12);
            this.labelGradeCHUNI.Name = "labelGradeCHUNI";
            this.labelGradeCHUNI.Size = new System.Drawing.Size(44, 49);
            this.labelGradeCHUNI.TabIndex = 10;
            this.labelGradeCHUNI.Text = "S";
            this.labelGradeCHUNI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreCHUNI
            // 
            this.scoreCHUNI.Font = new System.Drawing.Font("Exo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreCHUNI.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.scoreCHUNI.Location = new System.Drawing.Point(3, 37);
            this.scoreCHUNI.Maximum = new decimal(new int[] {
            1010000,
            0,
            0,
            0});
            this.scoreCHUNI.Name = "scoreCHUNI";
            this.scoreCHUNI.Size = new System.Drawing.Size(179, 29);
            this.scoreCHUNI.TabIndex = 6;
            this.scoreCHUNI.ThousandsSeparator = true;
            this.scoreCHUNI.Value = new decimal(new int[] {
            975000,
            0,
            0,
            0});
            this.scoreCHUNI.ValueChanged += new System.EventHandler(this.scoreCHUNI_ValueChanged);
            // 
            // labelOutputCHUNI
            // 
            this.labelOutputCHUNI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOutputCHUNI.AutoSize = true;
            this.labelOutputCHUNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOutputCHUNI.Font = new System.Drawing.Font("Exo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputCHUNI.Location = new System.Drawing.Point(3, 69);
            this.labelOutputCHUNI.MaximumSize = new System.Drawing.Size(205, 0);
            this.labelOutputCHUNI.Name = "labelOutputCHUNI";
            this.labelOutputCHUNI.Size = new System.Drawing.Size(65, 36);
            this.labelOutputCHUNI.TabIndex = 9;
            this.labelOutputCHUNI.Text = "10.5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(188, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chart Constant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(188, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Score";
            // 
            // PlayRatingCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 159);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlayRatingCalculator";
            this.Text = "VRG Play Rating Calculator";
            this.Load += new System.EventHandler(this.PlayRatingCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartConstantCHUNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreCHUNI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown chartConstant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown chartConstantCHUNI;
        private System.Windows.Forms.Label labelGradeCHUNI;
        private System.Windows.Forms.NumericUpDown scoreCHUNI;
        private System.Windows.Forms.Label labelOutputCHUNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

