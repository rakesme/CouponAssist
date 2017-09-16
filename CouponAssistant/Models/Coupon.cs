using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouponAssistant.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public string Description { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
    }
}