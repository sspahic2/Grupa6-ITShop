﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Procesor //: Proizvod
    {
        public int Id { get; set; }
        public Proizvod Proizvod { get; set; }
        public int BrojJezgra { get; set; }
        public int BrzinaJezgra { get; set; }
    }
}