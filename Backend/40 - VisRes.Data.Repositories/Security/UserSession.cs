using System;
using System.Collections.Generic;
using System.Text;
using VisRes.Data.EFCore;
using VisRes.Models.EF;

namespace VisRes.Data.Repositories.Security
{
    public class UserSessionRepository:  IUserSession
    {
        private VrsContext _context;
        public UserSessionRepository(VrsContext context)
        {
            _context = context;
        }


    }
}
