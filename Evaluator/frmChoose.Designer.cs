namespace Evaluator
{
    partial class frmChoose
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
            this.btnInfix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnPrefix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfix
            // 
            this.btnInfix.Location = new System.Drawing.Point(107, 68);
            this.btnInfix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInfix.Name = "btnInfix";
            this.btnInfix.Size = new System.Drawing.Size(78, 19);
            this.btnInfix.TabIndex = 2;
            this.btnInfix.Text = "Infix";
            this.btnInfix.UseVisualStyleBackColor = true;
            this.btnInfix.Click += new System.EventHandler(this.btnInfix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the notiation for your expression";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(107, 90);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(78, 19);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Postfix";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnPrefix
            // 
            this.btnPrefix.Location = new System.Drawing.Point(107, 46);
            this.btnPrefix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrefix.Name = "btnPrefix";
            this.btnPrefix.Size = new System.Drawing.Size(78, 19);
            this.btnPrefix.TabIndex = 1;
            this.btnPrefix.Text = "Prefix";
            this.btnPrefix.UseVisualStyleBackColor = true;
            this.btnPrefix.Click += new System.EventHandler(this.btnPrefix_Click);
            // 
            // frmChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnPrefix);
            this.Controls.Add(this.btnInfix);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnPrefix;
    }
}