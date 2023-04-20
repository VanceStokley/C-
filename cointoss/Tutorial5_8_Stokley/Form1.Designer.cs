
namespace Tutorial5_8_Stokley
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
            this.pictureBoxHead = new System.Windows.Forms.PictureBox();
            this.pictureBoxTails = new System.Windows.Forms.PictureBox();
            this.buttonToss = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTails)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHead
            // 
            this.pictureBoxHead.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHead.Image")));
            this.pictureBoxHead.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxHead.Name = "pictureBoxHead";
            this.pictureBoxHead.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHead.TabIndex = 0;
            this.pictureBoxHead.TabStop = false;
            // 
            // pictureBoxTails
            // 
            this.pictureBoxTails.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTails.Image")));
            this.pictureBoxTails.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxTails.Name = "pictureBoxTails";
            this.pictureBoxTails.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTails.TabIndex = 1;
            this.pictureBoxTails.TabStop = false;
            // 
            // buttonToss
            // 
            this.buttonToss.Location = new System.Drawing.Point(12, 204);
            this.buttonToss.Name = "buttonToss";
            this.buttonToss.Size = new System.Drawing.Size(96, 28);
            this.buttonToss.TabIndex = 2;
            this.buttonToss.Text = "Toss";
            this.buttonToss.UseVisualStyleBackColor = true;
            this.buttonToss.Click += new System.EventHandler(this.buttonToss_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(128, 204);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(81, 28);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 253);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToss);
            this.Controls.Add(this.pictureBoxHead);
            this.Controls.Add(this.pictureBoxTails);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHead;
        private System.Windows.Forms.PictureBox pictureBoxTails;
        private System.Windows.Forms.Button buttonToss;
        private System.Windows.Forms.Button buttonExit;
    }
}

