using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornerstech.EntityLayer.Entities
{
    public class RiskManagement : BaseEntity
    {
        public string RiskCategory { get; set; }

        public string RiskDescription { get; set; }

        public decimal RiskValue { get; set; }
    }
}
