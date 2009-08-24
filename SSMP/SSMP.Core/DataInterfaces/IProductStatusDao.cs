using System;
using System.Collections.Generic;
using SSMP.Core.Domain;
using SSMP.Core.Utils;

namespace SSMP.Core.DataInterfaces
{
    /// <summary>
    /// Since this extends the <see cref="IDao{TypeOfListItem, IdT}" /> behavior, it's a good idea to 
    /// place it in its own file for manageability.  In this way, it can grow further without
    /// cluttering up <see cref="IDaoFactory" />.
    /// </summary>
    public interface IProductStatusDao : IDao<ProductStatus, System.Int32>
    {
        SearchResult<ProductStatus> GetProductStatusListByParam(ProductStatus entity, SearchParam searchParam);
    }
}
