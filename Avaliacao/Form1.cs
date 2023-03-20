using System.Runtime.InteropServices;

namespace Avaliacao
{
    public partial class Frm_Main : Form
    {

        float SaldoItem1 = 1;
        float SaldoItem2 = 2;
        float SaldoItem3 = 3;
        float SaldoItem4 = 4;
        float SaldoItem5 = 5;
        public Frm_Main()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float qtdMov = float.Parse(textBox1.Text);
                float porcent = 1 + (float.Parse(textBox5.Text) / 100);
                float precoCusto = float.Parse(textBox4.Text);

                float custo = (qtdMov * precoCusto);
                float percentDesejado = custo * porcent;

                textBox3.Text = percentDesejado.ToString("F2");
            } 
            catch(Exception) 
            {
                MessageBox.Show("Valide os Dados da Operação!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Encerrar o Programa", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex == 1)
                {
                    textBox2.Text = SaldoItem1.ToString();
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    textBox2.Text = SaldoItem2.ToString();
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    textBox2.Text = SaldoItem3.ToString();
                }
                else if (comboBox2.SelectedIndex == 4)
                {
                    textBox2.Text = SaldoItem4.ToString();
                }
                else if (comboBox2.SelectedIndex == 5)
                {
                    textBox2.Text = SaldoItem5.ToString();
                }
            } catch (Exception)
            {
                MessageBox.Show("Valide os dados para seguir!", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                textBox1.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja adicionar ao Saldo do Produto", "Adicionar Item",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Atenção, Operação Irreversível!. Deseja Continuar ? (Dupla Verificação)", "Alerta",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        switch (comboBox1.SelectedIndex)
                        {
                            case 1:
                                switch (comboBox2.SelectedIndex)
                                {
                                    case 1:
                                        SaldoItem1 += float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem1.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                    case 2:
                                        SaldoItem2 += float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem2.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                    case 3:
                                        SaldoItem3 += float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem3.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                    case 4:
                                        SaldoItem4 += float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem4.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                    case 5:
                                        SaldoItem5 += float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem5.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                }
                                break;
                            case 2:
                                switch (comboBox2.SelectedIndex)
                                {
                                    case 1:
                                        SaldoItem1 -= float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem1.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                    case 2:
                                        SaldoItem2 -= float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem2.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                    case 3:
                                        SaldoItem3 -= float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem3.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                    case 4:
                                        SaldoItem4 -= float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem4.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                    case 5:
                                        SaldoItem5 -= float.Parse(textBox1.Text);
                                        textBox3.Text = SaldoItem5.ToString();
                                        comboBox1.SelectedIndex = 0;
                                        comboBox2.SelectedIndex = 0;
                                        textBox1.Text = "";
                                        textBox5.Text = "";
                                        textBox4.Text = "";
                                        textBox3.Text = "";
                                        break;
                                }
                                break;
                        }

                    }
                }
            } catch (Exception)
            {
                MessageBox.Show("Valide os Dados da Operação!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                textBox1.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
            }
        }
    }
}