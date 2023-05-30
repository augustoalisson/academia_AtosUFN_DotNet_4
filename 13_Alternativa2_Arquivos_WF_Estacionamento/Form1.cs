using Microsoft.VisualBasic;
using System.Linq;
using System.Windows.Forms;

namespace _13_Alternativa2_Arquivos_WF_Estacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarListas();
        }

        public void AtualizarListas()
        {
            List<Veiculo> EstacionamentoEntrada = new List<Veiculo>();
            List<Veiculo> EstacionamentoSaida = new List<Veiculo>();
            string nomeArquivoEntrada = "EstacionamentoEntrada.dat";
            string nomeArquivoSaida = "EstacionamentoSaida.dat";

            textBoxEntrada.Clear();
            textBoxSaida.Clear();

            Persistencia.lerArquivoVeiculosEntrada(nomeArquivoEntrada, EstacionamentoEntrada);

            foreach (var item in EstacionamentoEntrada)
            {
                textBoxEntrada.AppendText(item.Placa + ";" + item.Data + ";" + item.Hora + Environment.NewLine);
            }

            Persistencia.lerArquivoVeiculosSaida(nomeArquivoSaida, EstacionamentoSaida);

            foreach (var item in EstacionamentoSaida)
            {
                textBoxSaida.AppendText(item.Placa + ";" + item.Data + ";" + item.Hora + ";" + item.TempoPermanencia + ";" + item.ValorCobrado + Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string placa = textBoxPlaca.Text.ToUpper();
            Veiculo v = new Veiculo(placa);

            List<Veiculo> EstacionamentoEntrada = new List<Veiculo>();

            string nomeArquivoEntrada = "EstacionamentoEntrada.dat";

            Persistencia.lerArquivoVeiculosEntrada(nomeArquivoEntrada, EstacionamentoEntrada);

            if (String.IsNullOrEmpty(placa) || placa.Length != 7)
            {
                MessageBox.Show("Placa inválida");
            }
            else if (EstacionamentoEntrada.Any(v => v.Placa == placa))
            {
                MessageBox.Show("Veículo estacionado");
            }
            else
            {
                EstacionamentoEntrada.Add(v);

                Persistencia.gravarArquivoVeiculosEntrada(nomeArquivoEntrada, EstacionamentoEntrada);

                textBoxEntrada.Clear();

                foreach (var item in EstacionamentoEntrada)
                {
                    textBoxEntrada.AppendText(item.Placa + ";" + item.Data + ";" + item.Hora + Environment.NewLine);
                }
                textBoxPlaca.Clear();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string placa = textBoxPlaca.Text.ToUpper();
            Veiculo v = new Veiculo(placa);

            List<Veiculo> EstacionamentoEntrada = new List<Veiculo>();
            List<Veiculo> EstacionamentoSaida = new List<Veiculo>();

            string nomeArquivoEntrada = "EstacionamentoEntrada.dat";
            string nomeArquivoSaida = "EstacionamentoSaida.dat";

            Persistencia.lerArquivoVeiculosEntrada(nomeArquivoEntrada, EstacionamentoEntrada);
            Persistencia.lerArquivoVeiculosSaida(nomeArquivoSaida, EstacionamentoSaida);

            if (String.IsNullOrEmpty(placa) || placa.Length != 7)
            {
                MessageBox.Show("Placa inválida");
            }
            else if (EstacionamentoEntrada.Any(v => v.Placa == placa))
            {
                Veiculo veiculoEncontrado = EstacionamentoEntrada.First(v => v.Placa == placa);
                string placaEncontrada = veiculoEncontrado.Placa;
                string dataEntradaEncontrada = veiculoEncontrado.Data;
                string horaEntradaEncontrada = veiculoEncontrado.Hora;
                string horaEntrada = horaEntradaEncontrada;

                string inputHora = Interaction.InputBox("Digite a hora de saída do veículo (HH:mm)", "Hora saída");
                TimeSpan horaInformada = TimeSpan.Parse(inputHora);

                Veiculo vs = new Veiculo(placaEncontrada, dataEntradaEncontrada, horaEntradaEncontrada, Persistencia.CalcularDiferencaHoraEntrada(horaEntrada, horaInformada), Persistencia.CalcularValorCobrado(horaEntrada, horaInformada));

                MessageBox.Show($"Baixado veículo de placa: {vs.Placa}\nTempo de permanência: {TimeSpan.Parse(vs.TempoPermanencia).Hours} horas e {TimeSpan.Parse(vs.TempoPermanencia).Minutes} minutos \nValor cobrado R$ {vs.ValorCobrado},00");

                EstacionamentoEntrada.RemoveAll(veiculo => veiculo.Placa == placa);

                Persistencia.gravarArquivoVeiculosEntrada(nomeArquivoEntrada, EstacionamentoEntrada);

                textBoxEntrada.Clear();

                foreach (var item in EstacionamentoEntrada)
                {
                    textBoxEntrada.AppendText(item.Placa + ";" + item.Data + ";" + item.Hora + Environment.NewLine);
                }

                EstacionamentoSaida.Add(vs);

                Persistencia.gravarArquivoVeiculosSaida(nomeArquivoSaida, EstacionamentoSaida);

                textBoxSaida.Clear();

                foreach (var item in EstacionamentoSaida)
                {
                    textBoxSaida.AppendText(item.Placa + ";" + item.Data + ";" + item.Hora + ";" + item.TempoPermanencia.ToString() + ";" + item.ValorCobrado.ToString() + Environment.NewLine);
                }

                textBoxPlaca.Clear();
            }
            else
            {
                MessageBox.Show("Veículo não encontrado");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelDataAtual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelHoraAtual_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPlaca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}