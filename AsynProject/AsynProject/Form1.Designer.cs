namespace AsynProject
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
            this.btnExec = new System.Windows.Forms.Button();
            this.btnExecAsync = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(604, 32);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(184, 59);
            this.btnExec.TabIndex = 0;
            this.btnExec.Text = "Exec";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnExecAsync
            // 
            this.btnExecAsync.Location = new System.Drawing.Point(604, 122);
            this.btnExecAsync.Name = "btnExecAsync";
            this.btnExecAsync.Size = new System.Drawing.Size(184, 58);
            this.btnExecAsync.TabIndex = 1;
            this.btnExecAsync.Text = "Exec Async";
            this.btnExecAsync.UseVisualStyleBackColor = true;
            this.btnExecAsync.Click += new System.EventHandler(this.btnExecAsync_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(604, 214);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(184, 58);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(604, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(9, 8);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(587, 420);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnExecAsync);
            this.Controls.Add(this.btnExec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnExecAsync;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

