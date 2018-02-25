using System;
using System.Collections.Generic;
using System.Text;

namespace CohesiveSoftware.Data.Interfaces
{
    public interface ICrudHandler<out T, in DbContext, in M>
    {
        T Get(int id);
        IEnumerable<T> GetAll(bool isDeleted = false);
        T Upsert(M model);
        void Delete(int id);
        void Restore(int id);
    }
}
