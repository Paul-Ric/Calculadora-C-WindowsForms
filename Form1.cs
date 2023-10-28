namespace Calculadora
{
    public partial class Form1 : Form
    {
        private Operacao OperacaoSelecionada { get; set; }
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; 
            this.KeyPress += Form1_KeyPress; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                txtResult.Text += e.KeyChar;
            }
            
            else if (e.KeyChar == ',' && !txtResult.Text.Contains(","))
            {
                txtResult.Text += e.KeyChar;
            }
            
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                if (e.KeyChar == '+')
                    OperacaoSelecionada = Operacao.Adicao;
                else if (e.KeyChar == '-')
                    OperacaoSelecionada = Operacao.Subtracao;
                else if (e.KeyChar == '*')
                    OperacaoSelecionada = Operacao.Multiplicacao;
                else if (e.KeyChar == '/')
                    OperacaoSelecionada = Operacao.Divisao;
                Valor = Convert.ToDecimal(txtResult.Text);
                txtResult.Text = "";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResult.Text);
                    break;
            }
            txtResult.Text = Convert.ToString(Resultado);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
                txtResult.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}