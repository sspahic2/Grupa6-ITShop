﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Memorija : /*Proizvod,*/ ITip
    {
        [Required]
        [RegularExpression("^^[A-Za-z0-9 _]*[A-Za-z0-9][A-Za-z0-9 _]*$", ErrorMessage = "Naziv proizvoda može da sadrži slova i brojeve.")]
        public string Naziv { get; set; }
        [Required]
        [Display(Name = "Proizvođač")]
        public string Proizvodjac { get; set; }
        [Required]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Cijena nije validna.")]
        public double Cijena { get; set; }
        [RegularExpression("\\{\\d+:\\d+\\}", ErrorMessage = "Vrijednost nije validna.")]
        [Required]
        [Display(Name = "Količina")]
        public int Kolicina { get; set; }
        [Required]
        private string Tip;
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        //Ovaj atribut je ustvari id, ali kada pravis bazu, moras staviti da je tipa sa kojim zelis fk imati
        public Proizvod Proizvod { get; set; }

        public void setTip(string Tip)
        {
            this.Tip = Tip;
        } 

        public string getTip()
        {
            return Tip;
        }
    }
}