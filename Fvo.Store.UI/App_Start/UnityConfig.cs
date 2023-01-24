using Fvo.Store.Data.ADO;
using Fvo.Store.Data.EF;
using Fvo.Store.Data.EF.Repositories;
using Fvo.Store.Domain.Contracts.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Fvo.Store.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<FvoStoreDataContext>();
            container.RegisterType<IProdutoRepository, ProdutoRepositoryEF>();
            container.RegisterType<ITipoDeProdutoRepository, TipoDeProdutoRepositoryEF>();
            //container.RegisterType<IUsuarioRepository, UsuarioRepositoryEF>();
            container.RegisterType<IUsuarioRepository, UsuarioRepositoryADO>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}