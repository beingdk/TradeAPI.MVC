using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Data.Database;

namespace Trade.Data.Repository
{
	public interface ICompanyRepo
	{
		IQueryable<Company> GetCompanies();
	}
}
