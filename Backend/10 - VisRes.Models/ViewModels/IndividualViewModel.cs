using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisRes.Models.EF;

namespace VisRes.Models.ViewModels
{
    public class IndividualViewModel
    {
        public bool IsFake { get; set; }


        public int UserId { get; set; }         //tblUsers USERID
        public string Username { get; set; }    //tblUsers 
 
        public string FirstName { get; set; }   //tblUsers first --> tblIndividual look up
        public string LastName { get; set; }    //tblUsers last--> tblIndividual look up

        public string Token { get; set; }
        public string Roles { get; set; }

        // Return List of Projects you have access to.
        public List<tblProjects> ProjectList { get; set; }
    }

}
