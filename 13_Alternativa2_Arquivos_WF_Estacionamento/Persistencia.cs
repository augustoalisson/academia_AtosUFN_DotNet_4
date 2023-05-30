using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Alternativa2_Arquivos_WF_Estacionamento
{
    internal class Persistencia
    {
        public static void lerArquivoVeiculosEntrada(string nomeArquivo, List<Veiculo> listaEntrada)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string linha;
                while ((linha = leitor.ReadLine()) != null)
                {
                    string[] vetorLinha = linha.Split(';');
                    if (vetorLinha.Length >= 2)
                    {
                        listaEntrada.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2]));
                    }
                }
                leitor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo ou arquivo não localizado! (ArquivoEntrada.dat)");
            }
        }

        public static void lerArquivoVeiculosSaida(string nomeArquivo, List<Veiculo> listaSaida)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string linha;
                while ((linha = leitor.ReadLine()) != null)
                {
                    string[] vetorLinha = linha.Split(';');
                    if (vetorLinha.Length >= 2)
                    {
                        listaSaida.Add(new Veiculo(vetorLinha[0], vetorLinha[1], vetorLinha[2], vetorLinha[3], int.Parse(vetorLinha[4])));
                    }
                }
                leitor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo ou arquivo não localizado! (ArquivoSaida.dat)");
            }
        }

        public static void gravarArquivoVeiculosEntrada(string nomeArquivo, List<Veiculo> listaEntrada)
        {
            using (StreamWriter escritor = new StreamWriter(nomeArquivo))
            {
                foreach (var item in listaEntrada)
                {
                    escritor.WriteLine(item.Placa + ";" + item.Data + ";" + item.Hora);
                }
                escritor.Close();
            }
        }

        public static void gravarArquivoVeiculosSaida(string nomeArquivo, List<Veiculo> listaSaida)
        {
            using (StreamWriter escritor = new StreamWriter(nomeArquivo, true))
            {
                foreach (var item in listaSaida)
                {
                    escritor.WriteLine(item.Placa + ";" + item.Data + ";" + item.Hora + ";" + item.TempoPermanencia + ";" + item.ValorCobrado);
                }
                escritor.Close();
            }
        }

        public static void LimparListaEntrada(string nomeArquivo, TextBox textBox)
        {
            File.WriteAllText(nomeArquivo, string.Empty);
            textBox.Clear();
        }

        public static void LimparListaSaida(string nomeArquivo, TextBox textBox)
        {
            File.WriteAllText(nomeArquivo, string.Empty);
            textBox.Clear();
        }
        public static string CalcularDiferencaHoraEntrada(string horaEntrada, TimeSpan horaInformada)
        {

            TimeSpan diferenca = horaInformada.Subtract(TimeSpan.Parse(horaEntrada));
            string horaFormatada = diferenca.ToString(@"hh\:mm");

            return horaFormatada;
        }
        public static int CalcularValorCobrado(string horaEntrada, TimeSpan horaInformada)
        {

            string diferenca = CalcularDiferencaHoraEntrada(horaEntrada, horaInformada);
            TimeSpan horaFomatada = TimeSpan.Parse(diferenca);

            int horasCompletas = (int)Math.Ceiling(horaFomatada.TotalHours);

            if (horasCompletas == 0 && horaFomatada.Minutes >= 1)
            {
                return 5;
            }
            else if (horasCompletas > 0 && horaFomatada.Minutes == 0)
            {
                return horasCompletas * 5;
            }
            else if (horasCompletas == 0 && horaFomatada.Minutes > 0)
            {
                horasCompletas++;
            }
            return horasCompletas * 5;
        }
    }
}
