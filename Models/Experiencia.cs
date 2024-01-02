namespace Curriculo_App_Back.Models
{
    public class Experiencia
    {
        public int Id { get; set; }

        public bool ContratoAtual { get; set; }
        public string Empresa { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicioContrato { get; set; }
        public DateTime DataTerminoContrato { get; set; }
    }
}
