using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Data.Model;
using Trade.Data.Repository;
using Trade.Data.Database;

namespace Trade.Business
{
    public class CompanyEngine : ICompanyEngine
    {
        public CompanyEngine()
        {
        }
        [Inject]
        public virtual ICompanyRepo CompanyRepo { get; set; }
        public IQueryable<Company> RetrieveAll()
        {
           //return cr.GetCompanies();
            var list = new List<Company>();
            list.Add(new Company { CompanyID = 1, CompanyName = "Jadu", Inactive = "Y", UserID = "heloo" });
            return list.AsQueryable();
        }
    }
}
