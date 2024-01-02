namespace Curriculo_App_Back.Models
{
    public class Formacao
    {
        public int IdFormacao { get; set; }
        public string Instituicao { get; set; }
        public string Curso { get; set; }
        public  bool CursoFinalizado { get; set; }
        public DateTime DataInicio { get; set; }
        public  DateTime DataTermino { get; set; }
    }
}
