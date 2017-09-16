using CouponAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Hosting;

namespace CouponAssistant.Controllers
{
    public class CouponController : ApiController
    {
        List<Coupon> _coupons;

        public CouponController()
        {
            string path = HostingEnvironment.MapPath(@"~/App_Data/coupons.json");
            var f = System.IO.File.ReadAllText(path);
            _coupons = JsonConvert.DeserializeObject<List<Coupon>>(f);
        }

        // GET: api/Coupon
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Coupon/5
        [HttpGet]
        [Route("/api/coupn/{site}")]
        public IEnumerable<Coupon> GetCouponWithSiteName(string site)
        {
            return _coupons.Where(item => item.SiteName == site);
        }
    }
}
