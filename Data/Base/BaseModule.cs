using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Base
{
    public abstract class BaseModule</*TRepository, */TLoggingClass> /*where TRepository : IRepository*/
    {
        #region Private Fields
        //private readonly TRepository repository;
        private readonly ILogger<TLoggingClass> logger;
        #endregion
        #region Constructor
        protected BaseModule(/*TRepository repository,*/ ILogger<TLoggingClass> logger)
        {
            //this.repository = repository;
            this.logger = logger;
        }
        #endregion
        #region Protected Properties
        // ReSharper disable once ConvertToAutoProperty
        //protected TRepository Repository => this.repository;
        protected ILogger<TLoggingClass> Logger => this.logger;
        #endregion
    }
}
