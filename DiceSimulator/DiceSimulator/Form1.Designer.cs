
namespace DiceSimulator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.Dice4 = new System.Windows.Forms.PictureBox();
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.dice6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dice1
            // 
            this.dice1.Image = ((System.Drawing.Image)(resources.GetObject("dice1.Image")));
            this.dice1.Location = new System.Drawing.Point(67, 23);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(104, 104);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice1.TabIndex = 2;
            this.dice1.TabStop = false;
            this.dice1.Visible = false;
            // 
            // dice2
            // 
            this.dice2.Image = ((System.Drawing.Image)(resources.GetObject("dice2.Image")));
            this.dice2.Location = new System.Drawing.Point(67, 23);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(104, 104);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice2.TabIndex = 3;
            this.dice2.TabStop = false;
            this.dice2.Visible = false;
            // 
            // dice3
            // 
            this.dice3.Image = ((System.Drawing.Image)(resources.GetObject("dice3.Image")));
            this.dice3.Location = new System.Drawing.Point(67, 23);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(104, 104);
            this.dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice3.TabIndex = 4;
            this.dice3.TabStop = false;
            this.dice3.Visible = false;
            // 
            // Dice4
            // 
            this.Dice4.Image = ((System.Drawing.Image)(resources.GetObject("Dice4.Image")));
            this.Dice4.Location = new System.Drawing.Point(67, 23);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(104, 104);
            this.Dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dice4.TabIndex = 5;
            this.Dice4.TabStop = false;
            this.Dice4.Visible = false;
            // 
            // dice5
            // 
            this.dice5.Image = ((System.Drawing.Image)(resources.GetObject("dice5.Image")));
            this.dice5.Location = new System.Drawing.Point(67, 23);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(104, 104);
            this.dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice5.TabIndex = 6;
            this.dice5.TabStop = false;
            this.dice5.Visible = false;
            // 
            // dice6
            // 
            this.dice6.Image = ((System.Drawing.Image)(resources.GetObject("dice6.Image")));
            this.dice6.Location = new System.Drawing.Point(67, 23);
            this.dice6.Name = "dice6";
            this.dice6.Size = new System.Drawing.Size(104, 104);
            this.dice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice6.TabIndex = 7;
            this.dice6.TabStop = false;
            this.dice6.Visible = false;
            this.dice6.Click += new System.EventHandler(this.dice6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.dice6);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.dice3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox Dice4;
        private System.Windows.Forms.PictureBox dice5;
        private System.Windows.Forms.PictureBox dice6;
    }
}

