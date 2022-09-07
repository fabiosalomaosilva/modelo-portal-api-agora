namespace ModeloPortalAgora.Api.Entities
{
    public class ContaBancaria
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public int Digito { get; set; }
        public int Banco { get; set; }
    }

    public class Controlador
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public int Participacao { get; set; }
        public string PontroladorPai { get; set; }
    }
}
