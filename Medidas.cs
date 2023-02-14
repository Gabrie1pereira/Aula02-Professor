namespace Aula02
{
    public partial class Medidas : Form
    {
        public Medidas()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if ( this.cboTipoConversao.SelectedIndex== 0 )
            {
                float Celsius = 0;
                 if (float.TryParse(txtValorOriginal.Text, out Celsius ) )
                {

                    float Fahrenheit = (float)(Celsius* 9/ 5 +32);
                    txtValorConvertido.Text = $"{Fahrenheit:N1}";
                }
                else
                {
                    MessageBox.Show( "Valor inválido" );
                    txtValorConvertido.Text = "";
                }
            }
           else if (this.cboTipoConversao.SelectedIndex == 1)
            {

                {
                float Fahrenheit = 0;
                if (float.TryParse(txtValorOriginal.Text, out Fahrenheit ))
                    {
                    float Celsius = (float)((Fahrenheit-32)*5/9);
                    txtValorConvertido.Text = $"{Celsius:N1}";
                }
                else
                    {
                    MessageBox.Show("Valor inválido");
                        txtValorConvertido.Text = "";
                    }
            }

            }
           else
            {
                MessageBox.Show("Selecione o tipo de conversão!");
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoConversao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}