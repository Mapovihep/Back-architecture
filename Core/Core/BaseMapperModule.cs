using Autofac;
using Data.Base;
using Microsoft.Extensions.Logging;
using Services.Core;

namespace Levi_Inventarization_Backend.Core
{
    public abstract class BaseMapperModule</*TRepository,*/ TLoggingClass> : BaseModule</*TRepository,*/ TLoggingClass> /*where TRepository : IRepository*/
    {
        #region Private Fields
        private readonly MapperFactory mapperFactory;
        #endregion
        #region Constructor
        protected BaseMapperModule(ILifetimeScope lifetimeScope, /*TRepository repository,*/ ILogger<TLoggingClass> logger)
            : base(/*repository,*/ logger)
        {
            this.mapperFactory = new MapperFactory(lifetimeScope);
        }
        #endregion
        #region Protected Properties
        protected MapperFactory MapperFactory => this.mapperFactory;
        #endregion
    }
}
