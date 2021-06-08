using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSV.Entities
{
    public class States : IEntities
    {
        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public string Region { get; set; }
        [Index(2)]
        public string State { get; set; }
        [Index(3)]
        public double Area { get; set; }
        [Index(4)]
        public double Population { get; set; }
    }
}
