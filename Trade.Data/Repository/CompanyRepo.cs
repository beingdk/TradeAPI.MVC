using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Trade.Data.Database;

namespace Trade.Data.Repository
{
	public class CompanyRepo : ICompanyRepo
	{
		[Inject]
		public Payroll Context { get; set; }
		public CompanyRepo(Payroll context)
		{
			Context = context;
		}

		public IQueryable<Company> GetCompanies()
		{
			//return from com in Context.Companies
			//	   select com;
			var list = new List<Company>();
			list.Add(new Company { CompanyID = 1,CompanyName = "Jadu",Inactive = "Y",UserID = "heloo"});
			return list.AsQueryable();
		}
	}
}
