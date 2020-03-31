using System.Collections.Generic;
using System.Data.Entity;
using AutoLotDal_NetStandart.EF;

namespace AutoLotDal_NetStandart.Repos
{
    public interface IRepo<T>
    {
        int Add(T entity);
        int AddRange(IList<T> entities);
        int Save(T entity);
        int Delete(int id, byte[] timeStanp);
        int Delete(T entity);
        T GetOne(int? id);
        List<T> GetAll();

        List<T> ExecuteQuery(string sql);
        List<T> ExecuteQuery(string sql, object[] sqlParametersObjects);

        AutoLotEntities Context { get; }
    }
}