using System;
using System.Collections.Generic;
using SSMP.Core.Utils;

namespace SSMP.Core.DataInterfaces
{
    public interface IDao<T, IdT>
    {
        T GetById(IdT id, bool shouldLock);
        List<T> GetAll();
        List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude);
        T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude);
        T Save(T entity);
        T SaveOrUpdate(T entity);
        void Delete(T entity);
        void CommitChanges();
        SearchResult<T> GetByExampleAndPaging(T exampleInstance, SearchParam searchParam);
        void OpenTransaction();
        void RollbackTransaction();
    }
}
