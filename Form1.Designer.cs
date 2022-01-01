
namespace ExcelMacro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.run = new System.Windows.Forms.Button();
            this.cancelbutt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbbutt = new System.Windows.Forms.RadioButton();
            this.cancel = new System.Windows.Forms.Button();
            this.pathbutt = new System.Windows.Forms.Button();
            this.churnbutt = new System.Windows.Forms.RadioButton();
            this.deallocate = new System.Windows.Forms.RadioButton();
            this.rdAnalysisbutt = new System.Windows.Forms.RadioButton();
            this.savebutt = new System.Windows.Forms.RadioButton();
            this.coveragebutt = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(355, 171);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 0;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // cancelbutt
            // 
            this.cancelbutt.AutoSize = true;
            this.cancelbutt.Location = new System.Drawing.Point(6, 33);
            this.cancelbutt.Name = "cancelbutt";
            this.cancelbutt.Size = new System.Drawing.Size(83, 17);
            this.cancelbutt.TabIndex = 1;
            this.cancelbutt.TabStop = true;
            this.cancelbutt.Text = "Cancellation";
            this.cancelbutt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coveragebutt);
            this.groupBox1.Controls.Add(this.savebutt);
            this.groupBox1.Controls.Add(this.rdAnalysisbutt);
            this.groupBox1.Controls.Add(this.deallocate);
            this.groupBox1.Controls.Add(this.churnbutt);
            this.groupBox1.Controls.Add(this.mtbbutt);
            this.groupBox1.Controls.Add(this.cancelbutt);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MIS Macro Family";
            // 
            // mtbbutt
            // 
            this.mtbbutt.AutoSize = true;
            this.mtbbutt.Location = new System.Drawing.Point(6, 56);
            this.mtbbutt.Name = "mtbbutt";
            this.mtbbutt.Size = new System.Drawing.Size(112, 17);
            this.mtbbutt.TabIndex = 2;
            this.mtbbutt.TabStop = true;
            this.mtbbutt.Text = "Mean Time Bench";
            this.mtbbutt.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(274, 171);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // pathbutt
            // 
            this.pathbutt.Location = new System.Drawing.Point(164, 171);
            this.pathbutt.Name = "pathbutt";
            this.pathbutt.Size = new System.Drawing.Size(104, 23);
            this.pathbutt.TabIndex = 0;
            this.pathbutt.Text = "Select Macro Path";
            this.pathbutt.UseVisualStyleBackColor = true;
            this.pathbutt.Click += new System.EventHandler(this.pathbutt_Click);
            // 
            // churnbutt
            // 
            this.churnbutt.AutoSize = true;
            this.churnbutt.Location = new System.Drawing.Point(6, 79);
            this.churnbutt.Name = "churnbutt";
            this.churnbutt.Size = new System.Drawing.Size(53, 17);
            this.churnbutt.TabIndex = 3;
            this.churnbutt.TabStop = true;
            this.churnbutt.Text = "Churn";
            this.churnbutt.UseVisualStyleBackColor = true;
            // 
            // deallocate
            // 
            this.deallocate.AutoSize = true;
            this.deallocate.Location = new System.Drawing.Point(6, 102);
            this.deallocate.Name = "deallocate";
            this.deallocate.Size = new System.Drawing.Size(87, 17);
            this.deallocate.TabIndex = 4;
            this.deallocate.TabStop = true;
            this.deallocate.Text = "De-allocation";
            this.deallocate.UseVisualStyleBackColor = true;
            // 
            // rdAnalysisbutt
            // 
            this.rdAnalysisbutt.AutoSize = true;
            this.rdAnalysisbutt.Location = new System.Drawing.Point(224, 33);
            this.rdAnalysisbutt.Name = "rdAnalysisbutt";
            this.rdAnalysisbutt.Size = new System.Drawing.Size(82, 17);
            this.rdAnalysisbutt.TabIndex = 5;
            this.rdAnalysisbutt.TabStop = true;
            this.rdAnalysisbutt.Text = "RD Analysis";
            this.rdAnalysisbutt.UseVisualStyleBackColor = true;
            // 
            // savebutt
            // 
            this.savebutt.AutoSize = true;
            this.savebutt.Location = new System.Drawing.Point(224, 56);
            this.savebutt.Name = "savebutt";
            this.savebutt.Size = new System.Drawing.Size(86, 17);
            this.savebutt.TabIndex = 6;
            this.savebutt.TabStop = true;
            this.savebutt.Text = "Copy n Save";
            this.savebutt.UseVisualStyleBackColor = true;
            // 
            // coveragebutt
            // 
            this.coveragebutt.AutoSize = true;
            this.coveragebutt.Location = new System.Drawing.Point(224, 79);
            this.coveragebutt.Name = "coveragebutt";
            this.coveragebutt.Size = new System.Drawing.Size(71, 17);
            this.coveragebutt.TabIndex = 7;
            this.coveragebutt.TabStop = true;
            this.coveragebutt.Text = "Coverage";
            this.coveragebutt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 211);
            this.Controls.Add(this.pathbutt);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.run);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Excel Macro Run Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button run;
        private System.Windows.Forms.RadioButton cancelbutt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mtbbutt;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button pathbutt;
        private System.Windows.Forms.RadioButton coveragebutt;
        private System.Windows.Forms.RadioButton savebutt;
        private System.Windows.Forms.RadioButton rdAnalysisbutt;
        private System.Windows.Forms.RadioButton deallocate;
        private System.Windows.Forms.RadioButton churnbutt;
    }
}

