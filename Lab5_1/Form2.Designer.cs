namespace Lab5_1
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
            this.graphWind = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).BeginInit();
            this.SuspendLayout();
            // 
            // graphWind
            // 
            this.graphWind.BackColor = System.Drawing.Color.White;
            this.graphWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphWind.Location = new System.Drawing.Point(14, 14);
            this.graphWind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.graphWind.Name = "graphWind";
            this.graphWind.Size = new System.Drawing.Size(369, 547);
            this.graphWind.TabIndex = 1;
            this.graphWind.TabStop = false;
            this.graphWind.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "нарисовать график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.graphWind);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "1й способ";
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graphWind;
        private System.Windows.Forms.Button button1;
    }
}