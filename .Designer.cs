namespace EmployeeApplication1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Pos = new System.Windows.Forms.Label();
            this.label_LN = new System.Windows.Forms.Label();
            this.label_FN = new System.Windows.Forms.Label();
            this.textBox_Pos = new System.Windows.Forms.TextBox();
            this.textBox_LN = new System.Windows.Forms.TextBox();
            this.textBox_FN = new System.Windows.Forms.TextBox();
            this.textBox_EID = new System.Windows.Forms.TextBox();
            this.label_EmpID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnFName,
            this.ColumnLName,
            this.ColumnPos});
            this.dataGridView1.Location = new System.Drawing.Point(296, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 311);
            this.dataGridView1.TabIndex = 12;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnFName
            // 
            this.ColumnFName.HeaderText = "First Name";
            this.ColumnFName.Name = "ColumnFName";
            // 
            // ColumnLName
            // 
            this.ColumnLName.HeaderText = "Last Name";
            this.ColumnLName.Name = "ColumnLName";
            // 
            // ColumnPos
            // 
            this.ColumnPos.HeaderText = "Position";
            this.ColumnPos.Name = "ColumnPos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(80, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 23;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Pos
            // 
            this.label_Pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pos.Location = new System.Drawing.Point(22, 268);
            this.label_Pos.Name = "label_Pos";
            this.label_Pos.Size = new System.Drawing.Size(106, 23);
            this.label_Pos.TabIndex = 22;
            this.label_Pos.Text = "Position *";
            // 
            // label_LN
            // 
            this.label_LN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LN.Location = new System.Drawing.Point(22, 201);
            this.label_LN.Name = "label_LN";
            this.label_LN.Size = new System.Drawing.Size(106, 23);
            this.label_LN.TabIndex = 21;
            this.label_LN.Text = "Last Name*";
            // 
            // label_FN
            // 
            this.label_FN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FN.Location = new System.Drawing.Point(22, 134);
            this.label_FN.Name = "label_FN";
            this.label_FN.Size = new System.Drawing.Size(106, 23);
            this.label_FN.TabIndex = 20;
            this.label_FN.Text = "First Name *";
            // 
            // textBox_Pos
            // 
            this.textBox_Pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pos.Location = new System.Drawing.Point(24, 294);
            this.textBox_Pos.Multiline = true;
            this.textBox_Pos.Name = "textBox_Pos";
            this.textBox_Pos.Size = new System.Drawing.Size(242, 25);
            this.textBox_Pos.TabIndex = 19;
            // 
            // textBox_LN
            // 
            this.textBox_LN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LN.Location = new System.Drawing.Point(26, 227);
            this.textBox_LN.Multiline = true;
            this.textBox_LN.Name = "textBox_LN";
            this.textBox_LN.Size = new System.Drawing.Size(242, 25);
            this.textBox_LN.TabIndex = 18;
            // 
            // textBox_FN
            // 
            this.textBox_FN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FN.Location = new System.Drawing.Point(26, 160);
            this.textBox_FN.Multiline = true;
            this.textBox_FN.Name = "textBox_FN";
            this.textBox_FN.Size = new System.Drawing.Size(242, 25);
            this.textBox_FN.TabIndex = 17;
            // 
            // textBox_EID
            // 
            this.textBox_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EID.Location = new System.Drawing.Point(26, 95);
            this.textBox_EID.Multiline = true;
            this.textBox_EID.Name = "textBox_EID";
            this.textBox_EID.Size = new System.Drawing.Size(242, 25);
            this.textBox_EID.TabIndex = 16;
            // 
            // label_EmpID
            // 
            this.label_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmpID.Location = new System.Drawing.Point(20, 69);
            this.label_EmpID.Name = "label_EmpID";
            this.label_EmpID.Size = new System.Drawing.Size(116, 23);
            this.label_EmpID.TabIndex = 15;
            this.label_EmpID.Text = "Employee ID *";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add Employee:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee List:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 388);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Pos);
            this.Controls.Add(this.label_LN);
            this.Controls.Add(this.label_FN);
            this.Controls.Add(this.textBox_Pos);
            this.Controls.Add(this.textBox_LN);
            this.Controls.Add(this.textBox_FN);
            this.Controls.Add(this.textBox_EID);
            this.Controls.Add(this.label_EmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Pos;
        private System.Windows.Forms.Label label_LN;
        private System.Windows.Forms.Label label_FN;
        private System.Windows.Forms.TextBox textBox_Pos;
        private System.Windows.Forms.TextBox textBox_LN;
        private System.Windows.Forms.TextBox textBox_FN;
        private System.Windows.Forms.TextBox textBox_EID;
        private System.Windows.Forms.Label label_EmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

