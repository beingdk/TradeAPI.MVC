using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Data.Database;

namespace Trade.Business
{
	public interface ICompanyEngine
	{
		IQueryable<Company> RetrieveAll();
	}
}
