using JobPortal.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Repository.Implementation
{
    public class PagedResult<TEntity>
    {
        IEnumerable<TEntity> _items;
        int _totalCount;

        public PagedResult(IEnumerable<TEntity> items, int totalCount)
        {
            _items = items;
            _totalCount = totalCount;
        }

        public IEnumerable<TEntity> Items { get { return _items; } }
        public int TotalCount { get { return _totalCount; } }
    }

    //public class UserRepository
    //{
    //    public PagedResult<User> Find(int pageNumber, int pageSize)
    //    {

    //    }
    //}
}
