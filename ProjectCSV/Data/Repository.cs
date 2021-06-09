using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using ProjectCSV.Entities;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectCSV.Data
{
    class Repository : IRepository
    {
        private List<States> _states = new List<States>();

        public List<States> oldState = new List<States>();
        public IEnumerable<States> GetListStates()
        {
            return _states.ToArray();
        }
        public int GetMaxIdState()
        {
            int t = GetStates().Max(state => state.Id);
            return t;
        }
        public List<States> GetOldStates()
        {
            return oldState;
        }
        public IEnumerable<States> CopyOldStates()
        {
            if (!File.Exists("state.csv"))
            {
                return null;
            }
            using (var reader = new StreamReader("state.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            {
                oldState = csv.GetRecords<States>().ToList();
                return _states;
            }
        }
        public IEnumerable<States> GetStates()
        {

            if (!File.Exists("state.csv"))
            {
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