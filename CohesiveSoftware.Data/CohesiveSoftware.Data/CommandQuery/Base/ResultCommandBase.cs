using CohesiveSoftware.Data.CommandQuery.Interfaces;

namespace CohesiveSoftware.Data.CommandQuery.Base
{
    public abstract class ResultCommandBase<TDbContext, TResult> : CommandBase<TDbContext>, ICommand<TResult>
        where TDbContext : IDbContext<TDbContext>
        where TResult : class
    {
        // command result
        protected TResult _result;

        protected ResultCommandBase(TDbContext context, string user)
            : base(context, user)
        { }

        public TResult ExecuteAndReturnResults()
        {
            return _result = InternalExecute();
        }

        public TResult Results
        {
            get { return _result; }
        }

        public void Execute()
        {
            _result = InternalExecute();
        }
        
        protected abstract TResult InternalExecute();
    }
}
