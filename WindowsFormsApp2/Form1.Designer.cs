namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstname_txt = new System.Windows.Forms.TextBox();
            this.lastname_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.email_txt_delete = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstname_txt
            // 
            this.firstname_txt.Location = new System.Drawing.Point(154, 46);
            this.firstname_txt.Name = "firstname_txt";
            this.firstname_txt.Size = new System.Drawing.Size(210, 20);
            this.firstname_txt.TabIndex = 5;
            // 
            // lastname_txt
            // 
            this.lastname_txt.Location = new System.Drawing.Point(154, 94);
            this.lastname_txt.Name = "lastname_txt";
            this.lastname_txt.Size = new System.Drawing.Size(210, 20);
            this.lastname_txt.TabIndex = 6;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(154, 141);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(210, 20);
            this.email_txt.TabIndex = 7;
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(154, 190);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(210, 20);
            this.age_txt.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "update based on previous mail ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter The Email to delete the record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 274);
            this.dataGridView1.TabIndex = 11;
            // 
            // email_txt_delete
            // 
            this.email_txt_delete.Location = new System.Drawing.Point(26, 344);
            this.email_txt_delete.Name = "email_txt_delete";
            this.email_txt_delete.Size = new System.Drawing.Size(254, 20);
            this.email_txt_delete.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(546, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "Load Table (Refresh)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.email_txt_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.lastname_txt);
            this.Controls.Add(this.firstname_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstname_txt;
        private System.Windows.Forms.TextBox lastname_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox email_txt_delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

