
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
            this.run = new System.Windows.Forms.Button();
            this.cancelbutt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbbutt = new System.Windows.Forms.RadioButton();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(355, 250);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 0;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.mtbbutt);
            this.groupBox1.Controls.Add(this.cancelbutt);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 214);
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
            this.cancel.Location = new System.Drawing.Point(274, 250);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 285);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.run);
            this.Controls.Add(this.groupBox1);
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
    }
}

