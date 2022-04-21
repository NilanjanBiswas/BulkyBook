using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ISAP_Call : IDisposable
    {
        T Single<T>(string prcedureName, DynamicParameters param = null);
        void Execute(string prcedureName, DynamicParameters param = null);
        T OneRecord<T>(string prcedureName, DynamicParameters param = null);
        IEnumerable<T> List<T>(string prcedureName, DynamicParameters param = null);
        Tuple<IEnumerable<T1>,IEnumerable<T2>> List<T1,T2>(string prcedureName, DynamicParameters param = null);

    }
}
