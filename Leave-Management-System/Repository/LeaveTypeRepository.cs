using Leave_Management_System.Contracts;
using Leave_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository



    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;

        }


        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var LeaveTypes = _db.LeaveTypes.ToList();
            return LeaveTypes;
        }

        public LeaveType FindById(int id)
        {
            var LeaveType = _db.LeaveTypes.Find(id);
            return LeaveType;
        }

        public ICollection<LeaveType> GetEmployeeLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
