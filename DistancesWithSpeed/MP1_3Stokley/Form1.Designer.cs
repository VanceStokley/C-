
namespace MP1_3Stokley
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5Hour = new System.Windows.Forms.Label();
            this.label8Hour = new System.Windows.Forms.Label();
            this.label12Hour = new System.Windows.Forms.Label();
            this.MPGTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter speed (MPH)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance after 5 hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance after 8 hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distance After 12 hours";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(132, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5Hour
            // 
            this.label5Hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5Hour.Location = new System.Drawing.Point(173, 34);
            this.label5Hour.Name = "label5Hour";
            this.label5Hour.Size = new System.Drawing.Size(100, 23);
            this.label5Hour.TabIndex = 5;
            this.label5Hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8Hour
            // 
            this.label8Hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8Hour.Location = new System.Drawing.Point(173, 66);
            this.label8Hour.Name = "label8Hour";
            this.label8Hour.Size = new System.Drawing.Size(100, 23);
            this.label8Hour.TabIndex = 6;
            this.label8Hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12Hour
            // 
            this.label12Hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12Hour.Location = new System.Drawing.Point(173, 94);
            this.label12Hour.Name = "label12Hour";
            this.label12Hour.Size = new System.Drawing.Size(100, 23);
            this.label12Hour.TabIndex = 7;
            this.label12Hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MPGTextBox
            // 
            this.MPGTextBox.Location = new System.Drawing.Point(173, 9);
            this.MPGTextBox.Name = "MPGTextBox";
            this.MPGTextBox.Size = new System.Drawing.Size(100, 20);
            this.MPGTextBox.TabIndex = 8;
            this.MPGTextBox.TextChanged += new System.EventHandler(this.MPGTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 190);
            this.Controls.Add(this.MPGTextBox);
            this.Controls.Add(this.label12Hour);
            this.Controls.Add(this.label8Hour);
            this.Controls.Add(this.label5Hour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance Caluclator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5Hour;
        private System.Windows.Forms.Label label8Hour;
        private System.Windows.Forms.Label label12Hour;
        private System.Windows.Forms.TextBox MPGTextBox;
    }
}

