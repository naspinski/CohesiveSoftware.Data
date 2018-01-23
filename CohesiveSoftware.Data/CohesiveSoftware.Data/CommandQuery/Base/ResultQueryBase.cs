using CohesiveSoftware.Data.CommandQuery.Interfaces;
using System;

namespace CohesiveSoftware.Data.CommandQuery.Base
{
    public abstract class ResultQueryBase<TDbContext, TResult> : QueryBase<TDbContext>, IQuery<TResult>
        where TDbContext : IDisposable, IDbContext<TDbContext>
        where TResult : class
    {
        protected TResult _result;
        
        protected ResultQueryBase(TDbContext context) : base(context) { }

        public void Execute()
        {
            InternalExecute();
        }

        public TResult ExecuteAndReturnResults()
        {
            return InternalExecute();
        }

        protected abstract TResult InternalExecute();

        public TResult Results => _result;
    }
}
