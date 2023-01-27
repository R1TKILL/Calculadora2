namespace Calculadora2
{
    public partial class Form1 : Form
    {

        decimal calculo;
        bool resultado = false;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Visor.Text += "1";
            Visor2.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Visor.Text += "2";
            Visor2.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Visor.Text += "3";
            Visor2.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Visor.Text += "4";
            Visor2.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Visor.Text += "5";
            Visor2.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Visor.Text += "6";
            Visor2.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Visor.Text += "7";
            Visor2.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Visor.Text += "8";
            Visor2.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Visor.Text += "9";
            Visor2.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Visor.Text += "0";
            Visor2.Text += "0";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(Visor.Text);

                Visor2.Text += "+";
                Visor.Text = " ";

                adicao = true;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            resultado = true;
            Visor2.Text += "=";

            if (adicao == true)
            {
                Visor.Text = Convert.ToString(Convert.ToDecimal(Visor.Text) + calculo);
                Visor2.Text += Visor.Text;
            }

            if (subtracao == true)
            {
                Visor.Text = Convert.ToString(calculo - Convert.ToDecimal(Visor.Text));
                Visor2.Text += Visor.Text;
            }

            if (multiplicacao == true)
            {
                Visor.Text = Convert.ToString(Convert.ToDecimal(Visor.Text) * calculo);
                Visor2.Text += Visor.Text;
            }

            try
            {
                if (divisao == true)
                {
                    Visor.Text = Convert.ToString(calculo / Convert.ToDecimal(Visor.Text));
                    Visor2.Text += Visor.Text;
                }
            }
            catch (DivideByZeroException)
            {
                Visor2.Text = " ";
                Visor.Text = "Erro";
            }
        }

        private void btnSubtacao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(Visor.Text);

                Visor2.Text += "-";
                Visor.Text = " ";

                adicao = false;
                subtracao = true;
                multiplicacao = false;
                divisao = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(Visor.Text);

                Visor2.Text += "X";
                Visor.Text = " ";

                adicao = false;
                subtracao = false;
                multiplicacao = true;
                divisao = false;
            }
            catch(Exception)
            {

            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(Visor.Text);

                Visor2.Text += "/";
                Visor.Text = " ";

                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = true;
            }
            catch(Exception)
            {

            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            try
            {
                Visor.Text += ",";
                Visor2.Text += ",";
            }
            catch(Exception)
            {

            }
        }

        private void btnAllClean_Click(object sender, EventArgs e)
        {
            Visor.Text = " ";
            Visor2.Text = " ";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            try
            {
                String remove = Visor.Text;
                remove = remove.Remove(remove.Length - 1);
                Visor.Text = remove;
                Visor2.Text = remove;
            }
            catch(Exception)
            {

            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (subtracao == true)
            {
                double value = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(Visor.Text) / 100;

                Visor.Text = Convert.ToString(value - (percentual * value));

                Visor2.Text += "% =";
                Visor2.Text += Visor.Text;
            }
            else if(adicao == true)
            {
                double value = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(Visor.Text) / 100;

                Visor.Text = Convert.ToString(value + (percentual * value));

                Visor2.Text += "% =";
                Visor2.Text += Visor.Text;
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                double raiz = Convert.ToDouble(Visor.Text);

                if(raiz < 0)
                {
                    Visor2.Text = " ";
                    Visor.Text = "Erro";
                }
                else
                {
                    raiz = Math.Sqrt(raiz);
                    Visor.Text = Convert.ToString(raiz);
                    Visor2.Text += "√ =" + Convert.ToString(raiz);
                }
            }
            catch(Exception)
            {

            }
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            try
            {
                double conversor = Convert.ToDouble(Visor.Text);

                if (conversor > 0)
                {
                    conversor = (conversor * -1);
                    Visor.Text = Convert.ToString(conversor);
                    Visor2.Text = Visor.Text;
                }
                else
                {
                    conversor = (conversor * -1);
                    Visor.Text = Convert.ToString(conversor);
                    Visor2.Text = Visor.Text;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

