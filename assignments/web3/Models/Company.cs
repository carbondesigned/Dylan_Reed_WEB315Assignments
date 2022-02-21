using System;
using System.ComponentModel.DataAnnotations;

namespace web3.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [DataType(DataType.Date)]
        public DateTime InterestDate { get; set; }
    }
}