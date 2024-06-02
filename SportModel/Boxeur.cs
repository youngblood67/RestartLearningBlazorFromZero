namespace SportModel
{
    public class Boxeur
    {
        public int BoxeurId { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public List<string> Surnoms { get; set; } = new List<string>();
        public Genre Genre { get; set; } = Genre.NonRenseigne;
        public string DateDeNaissance { get; set; } = string.Empty;
        public string PhotoPath { get; set; } = string.Empty;

        public string ListeSurnomsEnChaineDeCaracteres => string.Join(", ", Surnoms);
    }
}

