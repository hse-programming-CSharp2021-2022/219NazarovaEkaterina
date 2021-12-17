
namespace Ефыл_02
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
            this.buttonReal = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonChanged = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReal
            // 
            this.buttonReal.Location = new System.Drawing.Point(13, 24);
            this.buttonReal.Name = "buttonReal";
            this.buttonReal.Size = new System.Drawing.Size(275, 29);
            this.buttonReal.TabIndex = 0;
            this.buttonReal.Text = "Показать исходный список";
            this.buttonReal.UseVisualStyleBackColor = true;
            this.buttonReal.Click += new System.EventHandler(this.buttonReal_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(13, 71);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(275, 175);
            this.textBoxResult.TabIndex = 1;
            // 
            // buttonChanged
            // 
            this.buttonChanged.Location = new System.Drawing.Point(13, 262);
            this.buttonChanged.Name = "buttonChanged";
            this.buttonChanged.Size = new System.Drawing.Size(275, 29);
            this.buttonChanged.TabIndex = 2;
            this.buttonChanged.Text = "Показать изменения";
            this.buttonChanged.UseVisualStyleBackColor = true;
            this.buttonChanged.Click += new System.EventHandler(this.buttonChanged_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChanged);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonReal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReal;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonChanged;
    }
}

