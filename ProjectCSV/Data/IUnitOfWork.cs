namespace ProjectCSV.Data
{
    interface IUnitOfWork
    {
        IRepository Repository { get; }

        void SaveStates();
    }
}