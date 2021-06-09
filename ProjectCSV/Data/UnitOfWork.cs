using CsvHelper;
using System.Globalization;
using System.IO;

namespace ProjectCSV.Data
{
    class UnitOfWork : IUnitOfWork
    {
        public IRepository Repository { get; } = new Repository();
        public void SaveStates()
        {
            var states = Repository.GetListStates();
            using (var writer = new StreamWriter("state.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.CurrentCulture))
            {
                csv.WriteRecords(states);
            }
        }
    }
}
