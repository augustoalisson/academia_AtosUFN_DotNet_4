using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Alternativa2_Arquivos_WF_Estacionamento
{
    internal class Veiculo
    {
        private string _placa;
        private string _data;
        private string _hora;
        private string _tempoPermanencia;
        private int _valorCobrado;

        public string Placa
        {
            get { return _placa; }
            set { _placa = value.ToUpper(); }
        }
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public string Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        public string TempoPermanencia
        {
            get { return _tempoPermanencia; }
            set { _tempoPermanencia = value; }
        }
        public int ValorCobrado
        {
            get { return _valorCobrado; }
            set { _valorCobrado = value; }
        }
        public Veiculo(string placa)
        {
            Placa = placa;

            DateTime dataHoraAtual = DateTime.Now;
            string data = dataHoraAtual.ToString("dd/MM/yyyy");
            string hora = dataHoraAtual.ToString("HH:mm");

            Data = data;
            Hora = hora;
        }
        public Veiculo(string placa, string data, string hora)
        {
            Placa = placa;
            Data = data;
            Hora = hora;
        }
        public Veiculo(string placa, string data, string hora, string tempoPermanencia, int valorCobrado)
        {
            Placa = placa;
            Data = data;
            Hora = hora;
            _tempoPermanencia = tempoPermanencia;
            _valorCobrado = valorCobrado;
        }
    }
}
