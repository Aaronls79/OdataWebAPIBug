using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData;
using OdataWebAPI.Models;

namespace OdataWebAPI.Controllers
{
    public class KISSController : ApiController
    {
        readonly List<KISS> kissList = new List<KISS>();
        public KISSController()
        {
            for (int i = 0; i < 1000; i++)
            {
                this.kissList.Add(new KISS
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = $"KISS_{i}",
                    Properties = new List<KeyValue> { new KeyValue("index", i.ToString())}
                });
            }
        }


        /// <summary>
        /// This will throw an exception for the following filter:
        /// KISS?$filter=properties/any(prop: prop/value eq '139')
        /// </summary>
        /// <returns></returns>
        [EnableQuery]
        [Route("KISS")] // <-- this causes an exception
        public IQueryable<KISS> GetAll()
        {
            return this.kissList.AsQueryable();
        }
    }
}
