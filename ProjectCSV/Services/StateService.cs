using ProjectCSV.Data;
using System.Collections.Generic;
using ProjectCSV.Entities;

namespace ProjectCSV.Services
{
    class StateService : IStateService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IRepository _repository;
        public StateService()
        {
            _repository = _unitOfWork.Repository;
        }
        public IEnumerable<States> GetState()
        {
            return _repository.GetStates();
        }
        public IEnumerable<States> GetOldState()
        {
            return _repository.GetOldStates();
        }
        public IEnumerable<States> CopyOldState()
        {
            return _repository.CopyOldStates();
        }
        public void AddState(States state)
        {
            _repository.AddState(state);
            _unitOfWork.SaveStates();
        }
        public void RemoveState(int stateId)
        {
            _repository.RemoveState(stateId);
            _unitOfWork.SaveStates();
        }
        public int GetMaxId()
        {
            return _repository.GetMaxIdState();
        }
        public void UpdateState(States state, int stateId)
        {
            _repository.UpdateState(state, stateId);
            _unitOfWork.SaveStates();
        }
    }
}