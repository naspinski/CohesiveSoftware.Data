using System;
using System.Collections.Generic;
using System.Text;
namespace CohesiveSoftware.Data.CommandQuery.Interfaces
{
    public interface ICommand
    {
        void Execute();
    }

    public interface ICommand<T> : ICommand
    {
        T ExecuteAndReturnResults();
        T Results { get; }
    }
}
