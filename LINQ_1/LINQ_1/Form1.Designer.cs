namespace LINQ_1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnElement = new System.Windows.Forms.Button();
            this.btnLinqLamda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 38;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(618, 536);
            this.listBox.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(624, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(425, 34);
            this.txtSearch.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(745, 55);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(144, 55);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Search";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(745, 116);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(144, 56);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(745, 178);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(144, 56);
            this.btnOrderBy.TabIndex = 4;
            this.btnOrderBy.Text = "Order By...";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(745, 240);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(144, 56);
            this.btnGroupBy.TabIndex = 5;
            this.btnGroupBy.Text = "Group By...";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(745, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 56);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Agregator Operator";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnElement
            // 
            this.btnElement.Location = new System.Drawing.Point(745, 364);
            this.btnElement.Name = "btnElement";
            this.btnElement.Size = new System.Drawing.Size(144, 56);
            this.btnElement.TabIndex = 7;
            this.btnElement.Text = "Element Operator";
            this.btnElement.UseVisualStyleBackColor = true;
            this.btnElement.Click += new System.EventHandler(this.btnElement_Click);
            // 
            // btnLinqLamda
            // 
            this.btnLinqLamda.Location = new System.Drawing.Point(745, 426);
            this.btnLinqLamda.Name = "btnLinqLamda";
            this.btnLinqLamda.Size = new System.Drawing.Size(144, 56);
            this.btnLinqLamda.TabIndex = 8;
            this.btnLinqLamda.Text = "Linq Lambda";
            this.btnLinqLamda.UseVisualStyleBackColor = true;
            this.btnLinqLamda.Click += new System.EventHandler(this.btnLinqLamda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 551);
            this.Controls.Add(this.btnLinqLamda);
            this.Controls.Add(this.btnElement);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnElement;
        private System.Windows.Forms.Button btnLinqLamda;
    }
}

