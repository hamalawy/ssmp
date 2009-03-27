using System;
using System.Collections.Generic;
using System.Text;
using SSMP.Core.Utils;

namespace SSMP.Data.Manager
{
    public interface IManager<T, IdT>
    {
        T GetById(IdT id, bool shouldLock);
        List<T> GetAll();
        List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude);
        T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude);
        T Save(T entity);
        T SaveOrUpdate(T entity);
        void Delete(T entity);
        SearchResult<T> GetByExampleAndPaging(T exampleInstance, SearchParam searchParam);
    }
}
