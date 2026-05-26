namespace ProjetoWeb01.Classes.Entidades
{
    public class Cursos
    {
        private Dictionary<int, string> cursos = new Dictionary<int, string>()
        {
            {1 , "Desenvolvedor Back-end" },
            {2 , "Tecnico em eletroeletrônica" },
            {3 , "Mecânico de manutenção" }
        };

        //PROPFULL
       
        public Dictionary<int,string> Curso
        {
            get { return cursos; }
            set { cursos = value; }
        }

    }
}
