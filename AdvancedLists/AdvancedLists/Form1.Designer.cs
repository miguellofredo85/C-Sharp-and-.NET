namespace AdvancedLists
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnSorted = new System.Windows.Forms.Button();
            this.btnDict = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(-5, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(629, 531);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.Location = new System.Drawing.Point(647, 75);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(141, 57);
            this.btnHashSet.TabIndex = 2;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(647, 138);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(141, 57);
            this.btnDictionary.TabIndex = 3;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnSorted
            // 
            this.btnSorted.Location = new System.Drawing.Point(647, 201);
            this.btnSorted.Name = "btnSorted";
            this.btnSorted.Size = new System.Drawing.Size(141, 57);
            this.btnSorted.TabIndex = 4;
            this.btnSorted.Text = "Sorted list";
            this.btnSorted.UseVisualStyleBackColor = true;
            this.btnSorted.Click += new System.EventHandler(this.btnSorted_Click);
            // 
            // btnDict
            // 
            this.btnDict.Location = new System.Drawing.Point(647, 264);
            this.btnDict.Name = "btnDict";
            this.btnDict.Size = new System.Drawing.Size(141, 57);
            this.btnDict.TabIndex = 5;
            this.btnDict.Text = "Sorted Dict";
            this.btnDict.UseVisualStyleBackColor = true;
            this.btnDict.Click += new System.EventHandler(this.btnDict_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(647, 330);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(141, 57);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Sorted Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(647, 393);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(141, 57);
            this.btnQueue.TabIndex = 7;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(649, 456);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(141, 57);
            this.btnStack.TabIndex = 8;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 553);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnDict);
            this.Controls.Add(this.btnSorted);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lists Advanced";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnSorted;
        private System.Windows.Forms.Button btnDict;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
    }
}

