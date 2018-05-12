namespace TopTenListsFormsExample
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
            this.btnListChoice = new System.Windows.Forms.Button();
            this.txtListChoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListChoice
            // 
            this.btnListChoice.Location = new System.Drawing.Point(93, 108);
            this.btnListChoice.Name = "btnListChoice";
            this.btnListChoice.Size = new System.Drawing.Size(100, 55);
            this.btnListChoice.TabIndex = 0;
            this.btnListChoice.Text = "Click to Display List";
            this.btnListChoice.UseVisualStyleBackColor = true;
            this.btnListChoice.Click += new System.EventHandler(this.btnListChoice_Click);
            // 
            // txtListChoice
            // 
            this.txtListChoice.Location = new System.Drawing.Point(93, 58);
            this.txtListChoice.Name = "txtListChoice";
            this.txtListChoice.Size = new System.Drawing.Size(100, 26);
            this.txtListChoice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter 1 to show list of cars, 2 to show list of motorcycles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListChoice);
            this.Controls.Add(this.btnListChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListChoice;
        private System.Windows.Forms.TextBox txtListChoice;
        private System.Windows.Forms.Label label1;
    }
}

