using System.Collections.Generic;

namespace ProjectCSV.Data
{
    interface IRepository
    {
        void AddState(States state);
        IEnumerable<States> GetListStates();
        int GetMaxIdState();
        IEnumerable<States> GetStates();
        void RemoveState(int id);
        void UpdateState(States state, int stateId);
    }
}