using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
   public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
        public double UnitPrice { get; set; }
        public double getUnitPriceAfterDiscount()
        {
            return this.UnitPrice - (this.UnitPrice * this.DiscountRate / 100);
        }
    }
}
