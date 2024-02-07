

namespace ConcorreConta.Domain.Model
{
    public class Transacao
    {
        public Guid Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public long Valor { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
    }
}
