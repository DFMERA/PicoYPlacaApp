using System;
using System.ComponentModel.DataAnnotations;

namespace PicoYPlacaUtil.Models
{
    public class PicoYPlacaInput
    {
        public PicoYPlacaInput()
        {
        }

        public string LicensePlate { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [StringLength(maximumLength:10, MinimumLength =10)]
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
