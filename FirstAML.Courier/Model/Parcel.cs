using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirstAML.Courier.Service.Model
{
    public class Parcel
    {
        [Required]
        public string ParcelName { get; set; }

        public char Type { get; set; }

        [Required]
        public decimal ParcelSize { get; set; }
        
        public decimal ParcelWeight { get; set; }

        public decimal Cost { get; set; }

    }
}
