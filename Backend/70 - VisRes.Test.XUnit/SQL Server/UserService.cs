using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vrs.Business.Services.Test;
using Vrs.Core.Infrastructure.Helpers;
using Vrs.Data.AncientSqlClient;
using Vrs.Models.Test;
using Xunit;

namespace Vrs.Test.XUnit.SQLServer
{
    // Uncomment to enable tests
    //public class FactSwitch : FactAttribute { }

    // Uncomment to disable tests
    internal class FactSwitch : Attribute { }

    public class UserService : IDisposable
    {
        private ITestOutputHelper _output;

        public static string cs = "Data Source=VS28MVAPPSQL1-T;Initial Catalog=VisResTest;User ID=VisResWeb;Password=Sayvn1Derz03:23";
        public IDataAccess da;
        public IMemoryCache cache;

        public UserService(ITestOutputHelper output)
        {
            _output = output;
            //_output.WriteLine("Setting Up Test");

            da = new DataAccess(cs);
            cache = null;
        }

        //... tests

        public void Dispose()
        {
            da = null;
            cache = null;
        }

        [FactSwitch]
        public void GetUserByUsername_George()
        {
            //_output.WriteLine("I'm inside the test!");

            //Arrange
            IUsersService Users = new UsersService(da, cache);
            string username = "george";

            //Act
            UserModel model = Users.GetUserByUsername(username);

            //Assert
            Assert.Equal("george", model.FirstName.ToLower());
        }

        [FactSwitch]
        public void GetUserByUsername_gpagote()
        {
            //_output.WriteLine("I'm inside the test!");

            //Arrange
            IUsersService Users = new UsersService(da, cache);
            string username = "gpagote";

            //Act
            UserModel model = Users.GetUserByUsername(username);

            //Assert
            Assert.Equal("gpagote", model.FirstName.ToLower());
        }

        [FactSwitch]
        public void GetUserByUsername_Paul1()
        {
            //_output.WriteLine("I'm inside the test!");

            //Arrange
            IUsersService Users = new UsersService(da, cache);
            string username = "rigonip";

            //Act
            UserModel model = Users.GetUserByUsername(username);

            //Assert
            Assert.Equal("paul", model.FirstName.ToLower());
        }

        [FactSwitch]
        public void GetUserByUsername_Paul2()
        {
            // _output.WriteLine("I'm inside the test!");

            //Arrange
            IUsersService Users = new UsersService(da, cache);
            string username = "rigonip";

            //Act
            UserModel model = Users.GetUserByUsername(username);

            //Assert
            Assert.Equal("paul", model.FirstName.ToLower());
        }


    }
}
