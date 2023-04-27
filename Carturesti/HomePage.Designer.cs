namespace Carturesti
{
    partial class HomePage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Cauta = new System.Windows.Forms.Button();
            this.radioButton_Romana = new System.Windows.Forms.RadioButton();
            this.radioButton_Engleza = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_Crescator = new System.Windows.Forms.RadioButton();
            this.radioButton_Descrescator = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(397, 9);
            this.label2.MinimumSize = new System.Drawing.Size(150, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 100);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bine ai venit!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ce carte doresti sa cumperi?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 192);
            this.textBox1.MaximumSize = new System.Drawing.Size(500, 500);
            this.textBox1.MinimumSize = new System.Drawing.Size(50, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Cauta
            // 
            this.button_Cauta.BackColor = System.Drawing.Color.RosyBrown;
            this.button_Cauta.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Cauta.Location = new System.Drawing.Point(444, 190);
            this.button_Cauta.Name = "button_Cauta";
            this.button_Cauta.Size = new System.Drawing.Size(112, 29);
            this.button_Cauta.TabIndex = 5;
            this.button_Cauta.Text = "Cauta";
            this.button_Cauta.UseVisualStyleBackColor = false;
            this.button_Cauta.Click += new System.EventHandler(this.button_Cauta_Click_1);
            // 
            // radioButton_Romana
            // 
            this.radioButton_Romana.AutoSize = true;
            this.radioButton_Romana.Location = new System.Drawing.Point(646, 160);
            this.radioButton_Romana.Name = "radioButton_Romana";
            this.radioButton_Romana.Size = new System.Drawing.Size(85, 24);
            this.radioButton_Romana.TabIndex = 6;
            this.radioButton_Romana.TabStop = true;
            this.radioButton_Romana.Text = "Romana";
            this.radioButton_Romana.UseVisualStyleBackColor = true;
            this.radioButton_Romana.CheckedChanged += new System.EventHandler(this.radioButton_Romana_CheckedChanged);
            // 
            // radioButton_Engleza
            // 
            this.radioButton_Engleza.AutoSize = true;
            this.radioButton_Engleza.Location = new System.Drawing.Point(649, 190);
            this.radioButton_Engleza.Name = "radioButton_Engleza";
            this.radioButton_Engleza.Size = new System.Drawing.Size(82, 24);
            this.radioButton_Engleza.TabIndex = 7;
            this.radioButton_Engleza.TabStop = true;
            this.radioButton_Engleza.Text = "Engleza";
            this.radioButton_Engleza.UseVisualStyleBackColor = true;
            this.radioButton_Engleza.CheckedChanged += new System.EventHandler(this.radioButton_Engleza_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(649, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Poti cauta si dupa : ";
            // 
            // radioButton_Crescator
            // 
            this.radioButton_Crescator.AutoSize = true;
            this.radioButton_Crescator.Location = new System.Drawing.Point(765, 160);
            this.radioButton_Crescator.Name = "radioButton_Crescator";
            this.radioButton_Crescator.Size = new System.Drawing.Size(120, 24);
            this.radioButton_Crescator.TabIndex = 9;
            this.radioButton_Crescator.TabStop = true;
            this.radioButton_Crescator.Text = "Pret crescator";
            this.radioButton_Crescator.UseVisualStyleBackColor = true;
            this.radioButton_Crescator.CheckedChanged += new System.EventHandler(this.radioButton_Crescator_CheckedChanged);
            // 
            // radioButton_Descrescator
            // 
            this.radioButton_Descrescator.AutoSize = true;
            this.radioButton_Descrescator.Location = new System.Drawing.Point(765, 195);
            this.radioButton_Descrescator.Name = "radioButton_Descrescator";
            this.radioButton_Descrescator.Size = new System.Drawing.Size(143, 24);
            this.radioButton_Descrescator.TabIndex = 10;
            this.radioButton_Descrescator.TabStop = true;
            this.radioButton_Descrescator.Text = "Pret descrescator";
            this.radioButton_Descrescator.UseVisualStyleBackColor = true;
            this.radioButton_Descrescator.CheckedChanged += new System.EventHandler(this.radioButton_Descrescator_CheckedChanged);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1051, 618);
            this.Controls.Add(this.radioButton_Descrescator);
            this.Controls.Add(this.radioButton_Crescator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_Engleza);
            this.Controls.Add(this.radioButton_Romana);
            this.Controls.Add(this.button_Cauta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button_Cauta;
        private EventHandler button_Cauta_Click;
        private RadioButton radioButton_Romana;
        private RadioButton radioButton_Engleza;
        private Label label3;
        private RadioButton radioButton_Crescator;
        private RadioButton radioButton_Descrescator;
    }
}