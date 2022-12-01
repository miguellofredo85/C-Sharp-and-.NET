namespace LoginApp
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
            this.Name = new System.Windows.Forms.Label();
            this.Birthdate = new System.Windows.Forms.Label();
            this.Civil = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.comboCS = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.checkHouse = new System.Windows.Forms.CheckBox();
            this.checkCar = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.list = new System.Windows.Forms.ListBox();
            this.btnRC = new System.Windows.Forms.Button();
            this.btnExclude = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(15, 16);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(86, 31);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // Birthdate
            // 
            this.Birthdate.AutoSize = true;
            this.Birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthdate.Location = new System.Drawing.Point(15, 93);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(123, 31);
            this.Birthdate.TabIndex = 1;
            this.Birthdate.Text = "Birthdate";
            // 
            // Civil
            // 
            this.Civil.AutoSize = true;
            this.Civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Civil.Location = new System.Drawing.Point(15, 170);
            this.Civil.Name = "Civil";
            this.Civil.Size = new System.Drawing.Size(145, 31);
            this.Civil.TabIndex = 2;
            this.Civil.Text = "Civilt State";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(15, 247);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(195, 31);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Phone Number";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(227, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(514, 38);
            this.txtName.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(227, 86);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(514, 38);
            this.txtDate.TabIndex = 5;
            // 
            // comboCS
            // 
            this.comboCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCS.FormattingEnabled = true;
            this.comboCS.Location = new System.Drawing.Point(227, 161);
            this.comboCS.Name = "comboCS";
            this.comboCS.Size = new System.Drawing.Size(514, 39);
            this.comboCS.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(227, 240);
            this.txtPhone.Mask = "(00)00000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(514, 38);
            this.txtPhone.TabIndex = 7;
            // 
            // checkHouse
            // 
            this.checkHouse.AutoSize = true;
            this.checkHouse.Location = new System.Drawing.Point(227, 307);
            this.checkHouse.Name = "checkHouse";
            this.checkHouse.Size = new System.Drawing.Size(114, 20);
            this.checkHouse.TabIndex = 8;
            this.checkHouse.Text = " Got a House?";
            this.checkHouse.UseVisualStyleBackColor = true;
            // 
            // checkCar
            // 
            this.checkCar.AutoSize = true;
            this.checkCar.Location = new System.Drawing.Point(227, 350);
            this.checkCar.Name = "checkCar";
            this.checkCar.Size = new System.Drawing.Size(92, 20);
            this.checkCar.TabIndex = 9;
            this.checkCar.Text = "Got a Car?";
            this.checkCar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioO);
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Location = new System.Drawing.Point(226, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.BackColor = System.Drawing.SystemColors.Control;
            this.radioO.Location = new System.Drawing.Point(18, 125);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(60, 20);
            this.radioO.TabIndex = 2;
            this.radioO.TabStop = true;
            this.radioO.Text = "Other";
            this.radioO.UseVisualStyleBackColor = false;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.BackColor = System.Drawing.SystemColors.Control;
            this.radioF.Location = new System.Drawing.Point(18, 74);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(74, 20);
            this.radioF.TabIndex = 1;
            this.radioF.TabStop = true;
            this.radioF.Text = "Female";
            this.radioF.UseVisualStyleBackColor = false;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.BackColor = System.Drawing.SystemColors.Control;
            this.radioM.Location = new System.Drawing.Point(18, 25);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(58, 20);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Male";
            this.radioM.UseVisualStyleBackColor = false;
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 22;
            this.list.Location = new System.Drawing.Point(12, 633);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(860, 180);
            this.list.TabIndex = 11;
            this.list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            // 
            // btnRC
            // 
            this.btnRC.FlatAppearance.BorderSize = 2;
            this.btnRC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRC.Location = new System.Drawing.Point(345, 560);
            this.btnRC.Name = "btnRC";
            this.btnRC.Size = new System.Drawing.Size(130, 49);
            this.btnRC.TabIndex = 12;
            this.btnRC.Text = "Register / Change";
            this.btnRC.UseVisualStyleBackColor = true;
            this.btnRC.Click += new System.EventHandler(this.btnRC_Click);
            // 
            // btnExclude
            // 
            this.btnExclude.FlatAppearance.BorderSize = 2;
            this.btnExclude.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExclude.Location = new System.Drawing.Point(520, 563);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(130, 49);
            this.btnExclude.TabIndex = 13;
            this.btnExclude.Text = "Exclude";
            this.btnExclude.UseVisualStyleBackColor = true;
            this.btnExclude.Click += new System.EventHandler(this.btnExclude_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Location = new System.Drawing.Point(188, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 49);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 859);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExclude);
            this.Controls.Add(this.btnRC);
            this.Controls.Add(this.list);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkCar);
            this.Controls.Add(this.checkHouse);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.comboCS);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Civil);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.Name);
            //this.Name = "Form1";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Birthdate;
        private System.Windows.Forms.Label Civil;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox comboCS;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.CheckBox checkHouse;
        private System.Windows.Forms.CheckBox checkCar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button btnRC;
        private System.Windows.Forms.Button btnExclude;
        private System.Windows.Forms.Button btnClear;
    }
}

