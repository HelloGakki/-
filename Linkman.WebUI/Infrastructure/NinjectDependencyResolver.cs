using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Moq;
using Linkman.Domain.Abstract;
using Linkman.Domain.Entities;
using Linkman.Domain.Concrete;

namespace Linkman.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        #region " 依赖注入内核 "

        private IKernel _kernel;

        #endregion

        #region " 构造函数 "
        // 绑定所有接口
        public NinjectDependencyResolver(IKernel kernelparam)
        {
            _kernel = kernelparam;
            AllBinding();
        }

        #endregion

        #region " 绑定入口 "
        // 需要注入的接口
        private void AllBinding()
        {

            _kernel.Bind<IPeopleRepository>().To<EFPersonRepository>();
        }

        #endregion

        #region " 接口实现 "

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        #endregion
    }
}