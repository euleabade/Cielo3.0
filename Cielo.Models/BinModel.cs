using System;
using System.Collections.Generic;
using System.Text;

namespace Cielo.Models
{
    public class BinModel
    {
        public BinModel()
        {

        }

        public string Status { get; set; }
        public string Provider { get; set; }
        public string CardType { get; set; }
        public bool ForeignCard { get; set; }
        public bool CorporateCard { get; set; }
        public string Issuer { get; set; }
        public string IssuerCode { get; set; }
    }

}
