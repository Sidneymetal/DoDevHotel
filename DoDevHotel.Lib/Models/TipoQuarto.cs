using DoDevHotel.Lib.Exceptions;

namespace DoDevHotel.Lib.Models
{
    public class TipoQuarto : ModelBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int OcupacaoMaxima { get; set; }
        public int CamaCasal { get; set; }
        public int CamaSolteiro { get; set; }
        public double Valor { get; set; }
        
        public TipoQuarto(string nome, string descricao, int ocupacaoMaxima, int camaCasal, int camaSolteiro, double valor, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
        {
            Nome = nome;
            Descricao = descricao;
            OcupacaoMaxima = ocupacaoMaxima;
            CamaCasal = camaCasal;
            CamaSolteiro = camaSolteiro;
            Valor = valor;            
        }
        public TipoQuarto()
        {

        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetDescricao()
        {
            return Descricao;
        } 
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public int GetOcupacaoMaxima()
        {
            return OcupacaoMaxima;
        }
        public void SetOcupacaoMaxima(int ocupacaoMaxima)
        {
            ValidarQuantidadeMaxima(ocupacaoMaxima);
            OcupacaoMaxima = ocupacaoMaxima;
        }
        public int GetCamaCasal()
        {
            return CamaCasal;
        }
        public void SetCamaCasal(int camaCasal)
        {
            CamaCasal = camaCasal;
        }
        public int GetCamaSolteiro()
        {
            return CamaSolteiro;
        }
        public void SetCamaSolteiro(int camaSolteiro)
        {
            CamaSolteiro= camaSolteiro;
        }
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public bool ValidarQuantidadeMaxima(int quarto)
        {
            if (quarto < 3)
            {
                return true;
            }
            throw new DoDevHotelException("Excedeu a quantidade de camas por quarto.");
        }        
    }
}
