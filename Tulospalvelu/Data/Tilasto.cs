namespace Tulospalvelu.Data
{
    public class Tilasto
    {
        public int Id { get; set; }
        public Joukkue? koti { get; set; }
        public Joukkue? vieras { get; set; }
        public int VierasPisteet { get; set; }
        public int KotiPistet { get; set; }
        public DateTime PVM { get; set; }
        public bool Paattynyt { get; set; }
    }
}
