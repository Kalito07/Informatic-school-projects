namespace DataGridView
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
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnForeign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInformatic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHighestAvr = new System.Windows.Forms.Label();
            this.labelLowestAvr = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnMath,
            this.ColumnBEL,
            this.ColumnForeign,
            this.ColumnInformatic,
            this.ColumnIT});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Име";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnMath
            // 
            this.ColumnMath.HeaderText = "Математика";
            this.ColumnMath.Name = "ColumnMath";
            // 
            // ColumnBEL
            // 
            this.ColumnBEL.HeaderText = "БЕЛ";
            this.ColumnBEL.Name = "ColumnBEL";
            // 
            // ColumnForeign
            // 
            this.ColumnForeign.HeaderText = "Чужд език";
            this.ColumnForeign.Name = "ColumnForeign";
            // 
            // ColumnInformatic
            // 
            this.ColumnInformatic.HeaderText = "Информатика";
            this.ColumnInformatic.Name = "ColumnInformatic";
            // 
            // ColumnIT
            // 
            this.ColumnIT.HeaderText = "ИТ";
            this.ColumnIT.Name = "ColumnIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ученикът с най-висок успех";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Предметът с най-нисък среден успех";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelHighestAvr
            // 
            this.labelHighestAvr.AutoSize = true;
            this.labelHighestAvr.Location = new System.Drawing.Point(216, 181);
            this.labelHighestAvr.Name = "labelHighestAvr";
            this.labelHighestAvr.Size = new System.Drawing.Size(35, 13);
            this.labelHighestAvr.TabIndex = 3;
            this.labelHighestAvr.Text = "label3";
            // 
            // labelLowestAvr
            // 
            this.labelLowestAvr.AutoSize = true;
            this.labelLowestAvr.Location = new System.Drawing.Point(214, 205);
            this.labelLowestAvr.Name = "labelLowestAvr";
            this.labelLowestAvr.Size = new System.Drawing.Size(35, 13);
            this.labelLowestAvr.TabIndex = 4;
            this.labelLowestAvr.Text = "label3";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 236);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Изчисли";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelLowestAvr);
            this.Controls.Add(this.labelHighestAvr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnForeign;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInformatic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHighestAvr;
        private System.Windows.Forms.Label labelLowestAvr;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

