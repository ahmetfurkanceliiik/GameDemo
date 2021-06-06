using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Campaign:IEntity
    {
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }

    }
}
