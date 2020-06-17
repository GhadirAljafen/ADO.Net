namespace CompanyForm
{
    partial class deleteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(89, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 64);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_delete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(82, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Employee ID";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(296, 54);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(209, 44);
            this.textID.TabIndex = 15;
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.GridColor = System.Drawing.Color.Teal;
            this.dataGridEmployee.Location = new System.Drawing.Point(12, 234);
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.RowHeadersWidth = 82;
            this.dataGridEmployee.RowTemplate.Height = 33;
            this.dataGridEmployee.Size = new System.Drawing.Size(1040, 833);
            this.dataGridEmployee.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Location = new System.Drawing.Point(265, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 64);
            this.button3.TabIndex = 23;
            this.button3.Text = "Display ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_display);
            // 
            // deleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 1179);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridEmployee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Name = "deleteForm";
            this.Text = "Delete an Employee";
            this.Load += new System.EventHandler(this.deleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.DataGridView dataGridEmployee;
        private System.Windows.Forms.Button button3;
    }
}