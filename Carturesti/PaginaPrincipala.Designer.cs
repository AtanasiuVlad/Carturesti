namespace Carturesti
{
    partial class PaginaPrincipala
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipala));
            label1 = new Label();
            textBox_Email = new TextBox();
            button_ContNou = new Button();
            button_Conectare = new Button();
            textBox_Parola = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 25.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(340, 143);
            label1.MinimumSize = new Size(150, 50);
            label1.Name = "label1";
            label1.Size = new Size(190, 50);
            label1.TabIndex = 0;
            label1.Text = "Carturesti";
            label1.Click += label1_Click;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(321, 267);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(209, 27);
            textBox_Email.TabIndex = 1;
            // 
            // button_ContNou
            // 
            button_ContNou.BackColor = Color.Gainsboro;
            button_ContNou.ForeColor = SystemColors.ActiveCaptionText;
            button_ContNou.Location = new Point(387, 447);
            button_ContNou.Name = "button_ContNou";
            button_ContNou.Size = new Size(113, 27);
            button_ContNou.TabIndex = 5;
            button_ContNou.Text = "Creaza cont";
            button_ContNou.UseVisualStyleBackColor = false;
            button_ContNou.Click += button_ContNou_Click;
            // 
            // button_Conectare
            // 
            button_Conectare.BackColor = Color.Gainsboro;
            button_Conectare.ForeColor = SystemColors.ActiveCaptionText;
            button_Conectare.Location = new Point(387, 410);
            button_Conectare.Name = "button_Conectare";
            button_Conectare.Size = new Size(113, 31);
            button_Conectare.TabIndex = 4;
            button_Conectare.Text = "Conecteaza-te";
            button_Conectare.UseVisualStyleBackColor = false;
            button_Conectare.Click += button_Conectare_Click;
            // 
            // textBox_Parola
            // 
            textBox_Parola.Location = new Point(321, 340);
            textBox_Parola.MaximumSize = new Size(500, 600);
            textBox_Parola.MinimumSize = new Size(2, 30);
            textBox_Parola.Name = "textBox_Parola";
            textBox_Parola.Size = new Size(200, 30);
            textBox_Parola.TabIndex = 3;
            textBox_Parola.TextChanged += textBox_Parola_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(400, 306);
            label3.MinimumSize = new Size(100, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 31);
            label3.TabIndex = 2;
            label3.Text = "Parola";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(400, 223);
            label2.MinimumSize = new Size(100, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 0;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(527, 340);
            button1.Name = "button1";
            button1.Size = new Size(35, 33);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // PaginaPrincipala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(863, 590);
            Controls.Add(button1);
            Controls.Add(button_ContNou);
            Controls.Add(label1);
            Controls.Add(button_Conectare);
            Controls.Add(label2);
            Controls.Add(textBox_Parola);
            Controls.Add(textBox_Email);
            Controls.Add(label3);
            Name = "PaginaPrincipala";
            Text = "Pagina Principala";
            Load += PaginaPrincipala_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Email;
        private Button button_ContNou;
        private Button button_Conectare;
        private TextBox textBox_Parola;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}