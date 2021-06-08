using ProjectCSV.Data;
using System.Collections.Generic;

namespace ProjectCSV.Services
{
    interface IStateService
    {
        void AddState(States state);
        int GetMaxId();
        IEnumerable<States> GetState();
        void RemoveState(int stateId);
        void UpdateState(States state, int stateId);
    }
}