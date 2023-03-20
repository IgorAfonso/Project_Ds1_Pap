namespace Avaliacao
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 308);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 308);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 1;
            label1.Text = "Quantidade a ser Movimentada";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Selecione o Tipo de Movimentação", "Entrada", "Saída" });
            comboBox1.Location = new Point(273, 123);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(493, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 3;
            label2.Text = "Tipo de Movimentação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 308);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 4;
            label3.Text = "Saldo de Estoque";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(751, 302);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 31);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 180);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(185, 25);
            label4.TabIndex = 6;
            label4.Text = "Descrição do Produto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(273, 414);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 31);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 414);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 9;
            label5.Text = "Preço de Custo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(273, 362);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 31);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 362);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 25);
            label6.TabIndex = 11;
            label6.Text = "% de Lucro Desejado";
            // 
            // button1
            // 
            button1.Location = new Point(460, 567);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(183, 38);
            button1.TabIndex = 12;
            button1.Text = "Validar Cálculos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 567);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(173, 38);
            button2.TabIndex = 13;
            button2.Text = "Fechar Programa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(441, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(385, 60);
            label7.TabIndex = 15;
            label7.Text = "PriThur Papelaria";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "NENHUM ITEM SELECIONADO", "CANETA BIC AZUL", "LÁPIS", "CADERNO 10 MATÉRIAS", "TESOURA", "COLA BASTÃO" });
            comboBox2.Location = new Point(273, 172);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(493, 33);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(524, 368);
            label8.Name = "label8";
            label8.Size = new Size(205, 25);
            label8.TabIndex = 17;
            label8.Text = "Preço Sujerido de Venda";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(751, 362);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 31);
            textBox3.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(751, 567);
            button3.Name = "button3";
            button3.Size = new Size(183, 38);
            button3.TabIndex = 19;
            button3.Text = "Finalizar Operação";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1164, 750);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle Papelaria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Label label7;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox textBox3;
        private Button button3;
    }
}