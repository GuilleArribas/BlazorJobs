namespace PFG_BlazorWS.Models
{
    public class Idioma
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Level Nivel { get; set; }
    }

    public enum Level
    {
        BAJO = 0,
        MEDIO_BAJO = 1,
        MEDIO = 2,
        MEDIO_ALTO = 3,
        ALTO = 4,
        NATIVO = 5
    }
}