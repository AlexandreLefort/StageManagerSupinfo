using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesStageManagerSupinfo.Models
{
    public class Stage
    {
        public int ID { get; set; }
        public string Titre { get; set; }
        public string Societe { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public decimal Nombredejour { get; set; }
        public string Commentaire { get; set; }
    }
}





