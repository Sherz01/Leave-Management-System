using Leave_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Contracts
{
    interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        ICollection<LeaveAllocation> GetEmployeeLeaveAllocation(int id);
    }
}
