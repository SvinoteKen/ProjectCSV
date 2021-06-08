using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSV.Data
{
    class UnitOfWork : IUnitOfWork
    {
        public IRepository Repository { get; } = new Repository();
        public void SaveStates()
        {
            var states = Repository.GetListStates();
            using (var writer = new StreamWriter("states2.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(states);
            }
        }
    }
}
