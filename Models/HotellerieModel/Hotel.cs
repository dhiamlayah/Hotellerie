using System;

namespace Hotel.Models.HotellerieModel
{
    public class Hotel
    {
        private string nom;
        private int etoiles;
        private string ville;
        private string siteWeb;

        public int Id { get; set; } // Use properties instead of public fields

        public string Nom
        {
            get { return nom; }
            set
            {
                if (value == null || value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException("Nom should be between 3 and 20 characters.");
                }
                nom = value;
            }
        }

        public int Etoiles
        {
            get { return etoiles; }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Etoiles should be a number between 0 and 5.");
                }
                etoiles = value;
            }
        }

        public string Ville
        {
            get { return ville; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Ville should not be null.");
                }
                ville = value;
            }
        }

        public string SiteWeb
        {
            get { return siteWeb; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Site Web is required.");
                }
                siteWeb = value;
            }
        }
    }
}
