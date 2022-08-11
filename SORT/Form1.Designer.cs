namespace SORT
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rXX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOnZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(222, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 303);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(492, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(264, 303);
            this.listBox2.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(762, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(264, 303);
            this.listBox3.Sorted = true;
            this.listBox3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KOM,
            this.DATA,
            this.rP1,
            this.rP2,
            this.rXX,
            this.rX1,
            this.rX2,
            this.rOZ,
            this.rOnZ});
            this.dataGridView1.Location = new System.Drawing.Point(12, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1477, 284);
            this.dataGridView1.TabIndex = 9;
            // 
            // KOM
            // 
            this.KOM.HeaderText = "KOM";
            this.KOM.Name = "KOM";
            // 
            // DATA
            // 
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            // 
            // rP1
            // 
            this.rP1.HeaderText = "rP1";
            this.rP1.Name = "rP1";
            // 
            // rP2
            // 
            this.rP2.HeaderText = "rP2";
            this.rP2.Name = "rP2";
            // 
            // rXX
            // 
            this.rXX.HeaderText = "X";
            this.rXX.Name = "rXX";
            // 
            // rX1
            // 
            this.rX1.HeaderText = "rX1";
            this.rX1.Name = "rX1";
            // 
            // rX2
            // 
            this.rX2.HeaderText = "rX2";
            this.rX2.Name = "rX2";
            // 
            // rOZ
            // 
            this.rOZ.HeaderText = "rOZ";
            this.rOZ.Name = "rOZ";
            // 
            // rOnZ
            // 
            this.rOnZ.HeaderText = "rOnZ";
            this.rOnZ.Name = "rOnZ";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 277);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(193, 61);
            this.button7.TabIndex = 10;
            this.button7.Text = "Заполнить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1337, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 69);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 640);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn rP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rXX;
        private System.Windows.Forms.DataGridViewTextBoxColumn rX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOnZ;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
    }
}

