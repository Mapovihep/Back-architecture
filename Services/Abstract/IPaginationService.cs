using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IPaginationService<T>
    {
        Task<List<T>> GetElementsByPage(T last, int offSet, int currentPage);
        Task<List<IGrouping<string, T>>> GetGroupingAllPages();
    }
}
