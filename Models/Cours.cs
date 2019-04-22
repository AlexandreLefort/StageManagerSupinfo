using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesStageManagerSupinfo.Models
{
    public class Cours
    {
        public int ID { get; set; }
        public string Titre { get; set; }
        public string Salle { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Language { get; set; }
        public string Commentaire { get; set; }
    }
}





