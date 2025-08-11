namespace DatabaseConnectivityDemo
{
    partial class FrmCategories
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
            dataGridView1 = new DataGridView();
            txtcatname = new TextBox();
            txtcatdesc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(737, 188);
            dataGridView1.TabIndex = 0;
            // 
            // txtcatname
            // 
            txtcatname.Location = new Point(312, 57);
            txtcatname.Name = "txtcatname";
            txtcatname.Size = new Size(125, 27);
            txtcatname.TabIndex = 1;
            // 
            // txtcatdesc
            // 
            txtcatdesc.Location = new Point(312, 130);
            txtcatdesc.Name = "txtcatdesc";
            txtcatdesc.Size = new Size(125, 27);
            txtcatdesc.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 57);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter CategoryName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 133);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter Category Description:";
            // 
            // button1
            // 
            button1.Location = new Point(127, 190);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Insert Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcatdesc);
            Controls.Add(txtcatname);
            Controls.Add(dataGridView1);
            Name = "FrmCategories";
            Text = "FrmCategories";
            Load += FrmCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtcatname;
        private TextBox txtcatdesc;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}