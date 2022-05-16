using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core
{
    internal class MapperFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapperFactory" /> class.
        /// </summary>
        public MapperFactory(ILifetimeScope lifetimeScope)
        {
            this.LifetimeScope = lifetimeScope;
        }
        /// <summary>
        /// The IoC container.
        /// </summary>
        private ILifetimeScope LifetimeScope { get; set; }
        /// <summary>
        /// Returns instances of mappers from IoC container.
        /// </summary>
        public TMapper CreateMapper<TMapper>()
            where TMapper : IMapper
        {
            return this.LifetimeScope.Resolve<TMapper>();
        }
    }
}
