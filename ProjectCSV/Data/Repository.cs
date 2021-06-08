using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCSV.Data
{
    class Repository : IRepository
    {
        private List<States> _states = new List<States>();

        public IEnumerable<States> GetListStates()
        {
            return _states.ToArray();
        }
        public int GetMaxIdState()
        {
            int t = GetStates().Max(state => state.Id);
            return t;
        }
        public IEnumerable<States> GetStates()
        {

            if (!File.Exists("state.csv"))
            {
                MessageBox.Show("dfgf");
                return null;
            }
            using (var reader = new StreamReader("state.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            {
                _states = csv.GetRecords<States>().ToList();
                return _states;
            }
        }
        public void AddState(States state)
        {
            _states.Add(state);
        }
        public void UpdateState(States state, int stateId)
        {
            _states[_states.IndexOf(_states.FirstOrDefault(d => d.Id == stateId))] = state;
        }
        public void RemoveState(int id)
        {
            var state = _states.FirstOrDefault(d => d.Id == id);
            if (state != null)
            {
                _states.Remove(state);
            }
        }
    }
}
