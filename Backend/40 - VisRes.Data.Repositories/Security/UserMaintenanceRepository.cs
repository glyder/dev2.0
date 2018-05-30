using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VisRes.Data.EFCore;
using VisRes.Models.EF;
using VisRes.Models.Model.UserMaintenance;

namespace VisRes.Data.Repositories.Security
{
    public class UserMaintenanceRepository
    {
        private VrsContext _context;

        public UserMaintenanceRepository(VrsContext context)
        {
            _context = context;
        }

        public List<tblUsers> GetUsers(UserMaintenanceFilter filter)
        {
            

            return _context.tblUsers.Skip(filter.PageSize * filter.PageNumber).Take(filter.PageSize).ToList();

           
        }
    }
}
