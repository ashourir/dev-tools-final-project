namespace EggsInteractiveGUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEggs1 = new System.Windows.Forms.TextBox();
            this.txtEggs2 = new System.Windows.Forms.TextBox();
            this.txtEggs3 = new System.Windows.Forms.TextBox();
            this.txtEggs4 = new System.Windows.Forms.TextBox();
            this.txtEggs5 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter eggs produced by each of 5 chickens";
            // 
            // txtEggs1
            // 
            this.txtEggs1.Location = new System.Drawing.Point(80, 44);
            this.txtEggs1.Name = "txtEggs1";
            this.txtEggs1.Size = new System.Drawing.Size(41, 20);
            this.txtEggs1.TabIndex = 1;
            // 
            // txtEggs2
            // 
            this.txtEggs2.Location = new System.Drawing.Point(80, 70);
            this.txtEggs2.Name = "txtEggs2";
            this.txtEggs2.Size = new System.Drawing.Size(41, 20);
            this.txtEggs2.TabIndex = 2;
            // 
            // txtEggs3
            // 
            this.txtEggs3.Location = new System.Drawing.Point(80, 96);
            this.txtEggs3.Name = "txtEggs3";
            this.txtEggs3.Size = new System.Drawing.Size(41, 20);
            this.txtEggs3.TabIndex = 3;
            // 
            // txtEggs4
            // 
            this.txtEggs4.Location = new System.Drawing.Point(80, 122);
            this.txtEggs4.Name = "txtEggs4";
            this.txtEggs4.Size = new System.Drawing.Size(41, 20);
            this.txtEggs4.TabIndex = 4;
            // 
            // txtEggs5
            // 
            this.txtEggs5.Location = new System.Drawing.Point(80, 148);
            this.txtEggs5.Name = "txtEggs5";
            this.txtEggs5.Size = new System.Drawing.Size(41, 20);
            this.txtEggs5.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 231);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 186);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 29);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Click to calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(146, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chicken 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chicken 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chicken 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chicken 4";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chicken 5";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 313);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtEggs5);
            this.Controls.Add(this.txtEggs4);
            this.Controls.Add(this.txtEggs3);
            this.Controls.Add(this.txtEggs2);
            this.Controls.Add(this.txtEggs1);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Egg Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEggs1;
        private System.Windows.Forms.TextBox txtEggs2;
        private System.Windows.Forms.TextBox txtEggs3;
        private System.Windows.Forms.TextBox txtEggs4;
        private System.Windows.Forms.TextBox txtEggs5;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

