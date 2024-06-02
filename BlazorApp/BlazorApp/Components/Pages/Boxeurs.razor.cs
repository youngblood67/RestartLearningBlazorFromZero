using SportModel;

namespace BlazorApp.Components.Pages
{
    public partial class Boxeurs
    {
        private List<Boxeur> _boxeurs = new List<Boxeur>();

        protected override void OnInitialized()
        {
            base.OnInitialized();

            _boxeurs = RetournerListeDesBoxeurs();
        }

        private List<Boxeur> RetournerListeDesBoxeurs()
        {
            Boxeur mikeTyson = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Tyson",
                Prenom = "Mike",
                Surnoms = new List<string> { "Iron Mike", "Kid Dynamite", "The Baddest Man on the Planet" }
            };

            Boxeur floydMayweather = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Mayweather",
                Prenom = "Floyd",
                Surnoms = new List<string> { "Money", "Pretty Boy" }
            };

            Boxeur caneloAlvarez = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Alvarez",
                Prenom = "Canelo",
                Surnoms = new List<string> { "Cinnamon" }
            };

            Boxeur anthonyJoshua = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Joshua",
                Prenom = "Anthony",
                Surnoms = new List<string> { "AJ" }
            };

            Boxeur tysonFury = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Fury",
                Prenom = "Tyson",
                Surnoms = new List<string> { "The Gypsy King" }
            };

            Boxeur mannyPacquiao = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Pacquiao",
                Prenom = "Manny",
                Surnoms = new List<string> { "Pac-Man" }
            };

            Boxeur gennadyGolovkin = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Golovkin",
                Prenom = "Gennady",
                Surnoms = new List<string> { "GGG", "Triple G" }
            };

            Boxeur deontayWilder = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Wilder",
                Prenom = "Deontay",
                Surnoms = new List<string> { "The Bronze Bomber" }
            };

            Boxeur vasiliyLomachenko = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Lomachenko",
                Prenom = "Vasiliy",
                Surnoms = new List<string> { "Hi-Tech", "Loma" }
            };

            Boxeur errolSpence = new Boxeur()
            {
                Genre = Genre.Monsieur,
                Nom = "Spence",
                Prenom = "Errol",
                Surnoms = new List<string> { "The Truth" }
            };


            return new List<Boxeur> { mikeTyson, floydMayweather, anthonyJoshua, tysonFury, mannyPacquiao, gennadyGolovkin, deontayWilder, vasiliyLomachenko, errolSpence };

        }
    }
}
