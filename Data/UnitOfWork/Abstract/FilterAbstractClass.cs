using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.UnitOfWork.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data.UnitOfWork.Abstract
{
    public abstract class FilterAbstract<T> where T : class
    {
        private ApplicationContext _context;
        private IServiceProvider _serviceProvider;
        public FilterAbstract(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<ApplicationContext>();
        }
        public async Task<List<T>> Filter(T obj, string page, string filters)
        {
            var type = typeof(T);
            var name = type.Name;

            string sqlRequest = $" Select * from [dbo].[{name}] ";
                /*$"where MainId = {page} and CompanyTenantId = {filters}" +*/
            foreach (var item in filters.Split(":"))
            {
                var str = item.Substring(0, 1).ToUpper() + (item.Length > 1 ? item.Substring(1) : "");
                sqlRequest += $"order by {str}" + Environment.NewLine;
            }

            return await _context.Set<T>().FromSqlRaw(sqlRequest).ToListAsync();
            
        }
    }
}
