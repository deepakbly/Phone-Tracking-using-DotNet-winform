namespace Tracking
{
    partial class Form2
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
            this.txtip = new System.Windows.Forms.TextBox();
            this.btnfecthip = new System.Windows.Forms.Button();
            this.btnlocation = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(154, 62);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(318, 20);
            this.txtip.TabIndex = 0;
            // 
            // btnfecthip
            // 
            this.btnfecthip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfecthip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfecthip.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecthip.ForeColor = System.Drawing.Color.White;
            this.btnfecthip.Location = new System.Drawing.Point(111, 120);
            this.btnfecthip.Name = "btnfecthip";
            this.btnfecthip.Size = new System.Drawing.Size(171, 34);
            this.btnfecthip.TabIndex = 1;
            this.btnfecthip.Text = "IP";
            this.btnfecthip.UseVisualStyleBackColor = false;
            this.btnfecthip.Click += new System.EventHandler(this.btnfecthip_Click);
            // 
            // btnlocation
            // 
            this.btnlocation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlocation.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlocation.ForeColor = System.Drawing.Color.White;
            this.btnlocation.Location = new System.Drawing.Point(301, 120);
            this.btnlocation.Name = "btnlocation";
            this.btnlocation.Size = new System.Drawing.Size(171, 34);
            this.btnlocation.TabIndex = 2;
            this.btnlocation.Text = "Location";
            this.btnlocation.UseVisualStyleBackColor = false;
            this.btnlocation.Click += new System.EventHandler(this.btnlocation_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(154, 194);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(318, 188);
            this.txtresult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Location";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnlocation);
            this.Controls.Add(this.btnfecthip);
            this.Controls.Add(this.txtip);
            this.Name = "Form2";
            this.Text = "Find Location By Ip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Button btnfecthip;
        private System.Windows.Forms.Button btnlocation;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}