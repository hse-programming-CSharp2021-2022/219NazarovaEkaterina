
namespace Task_03
{
    partial class Form1
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
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.buttonReduce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.Location = new System.Drawing.Point(13, 13);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(268, 29);
            this.buttonIncrease.TabIndex = 0;
            this.buttonIncrease.Text = "Увеличить форму!";
            this.buttonIncrease.UseVisualStyleBackColor = true;
            this.buttonIncrease.Click += new System.EventHandler(this.buttonIncrease_Click);
            // 
            // buttonReduce
            // 
            this.buttonReduce.Location = new System.Drawing.Point(13, 49);
            this.buttonReduce.Name = "buttonReduce";
            this.buttonReduce.Size = new System.Drawing.Size(268, 29);
            this.buttonReduce.TabIndex = 1;
            this.buttonReduce.Text = "Уменьшить форму!";
            this.buttonReduce.UseVisualStyleBackColor = true;
            this.buttonReduce.Click += new System.EventHandler(this.buttonReduce_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReduce);
            this.Controls.Add(this.buttonIncrease);
            this.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIncrease;
        private System.Windows.Forms.Button buttonReduce;
    }
}

