namespace תרגיל_ראשון_הכרות_והעלאת_הורדת_קובץ_טקסט
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
            this.add = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gType = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.deleteall = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.gType.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightCoral;
            this.add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add.Location = new System.Drawing.Point(267, 259);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 47);
            this.add.TabIndex = 0;
            this.add.Text = "Add Recipe";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.DarkOrange;
            this.show.Location = new System.Drawing.Point(464, 344);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(150, 46);
            this.show.TabIndex = 1;
            this.show.Text = "Show Recipes";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.name.Location = new System.Drawing.Point(50, 109);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(174, 35);
            this.name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(46, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Recipe Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.SpringGreen;
            this.update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update.Location = new System.Drawing.Point(267, 344);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(159, 47);
            this.update.TabIndex = 5;
            this.update.Text = "Update Recipe";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Tomato;
            this.delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete.Location = new System.Drawing.Point(50, 344);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(159, 47);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete Recipe";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID.Location = new System.Drawing.Point(50, 48);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(174, 35);
            this.ID.TabIndex = 7;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(46, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recipe ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(46, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "category";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "breakfest",
            "lunch",
            "dinner"});
            this.category.Location = new System.Drawing.Point(50, 170);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(174, 28);
            this.category.TabIndex = 11;
            // 
            // gType
            // 
            this.gType.BackColor = System.Drawing.Color.Transparent;
            this.gType.Controls.Add(this.radioButton3);
            this.gType.Controls.Add(this.radioButton2);
            this.gType.Controls.Add(this.radioButton1);
            this.gType.ForeColor = System.Drawing.Color.DarkBlue;
            this.gType.Location = new System.Drawing.Point(302, 48);
            this.gType.Name = "gType";
            this.gType.Size = new System.Drawing.Size(187, 127);
            this.gType.TabIndex = 12;
            this.gType.TabStop = false;
            this.gType.Text = "Recipe Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 98);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "meat";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "regular";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "vegan";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // deleteall
            // 
            this.deleteall.BackColor = System.Drawing.Color.Crimson;
            this.deleteall.Location = new System.Drawing.Point(603, 46);
            this.deleteall.Name = "deleteall";
            this.deleteall.Size = new System.Drawing.Size(145, 44);
            this.deleteall.TabIndex = 13;
            this.deleteall.Text = "Delete Text File";
            this.deleteall.UseVisualStyleBackColor = false;
            this.deleteall.Click += new System.EventHandler(this.deleteall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.deleteall);
            this.Controls.Add(this.gType);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.show);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gType.ResumeLayout(false);
            this.gType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox category;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gType;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button deleteall;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

