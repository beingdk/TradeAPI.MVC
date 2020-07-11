using Ninject.Modules;
using Ninject;
using Trade.Business;
using Trade.Data.Repository;

public class Bindings : NinjectModule
{
    public override void Load()
    {
        Bind<ICompanyEngine>().To<CompanyEngine>();
        Bind<ICompanyRepo>().To<CompanyRepo>();
    }
}