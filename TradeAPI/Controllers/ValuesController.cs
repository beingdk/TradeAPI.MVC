using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Trade.Business;
using Trade.Data.Database;

namespace TradeAPI.Controllers
{
	public class ValuesController : ApiController
	{
		[Inject]
		public ICompanyEngine CompanyEngine { get; set; }

		Payroll en = new Payroll();
		// GET api/values
		[HttpGet]
		[Route("Values")]
		public IQueryable<Company> Get()
		{
			var results = from con in en.Companies select con;
			return results;
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
