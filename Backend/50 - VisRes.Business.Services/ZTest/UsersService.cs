using Microsoft.Extensions.Caching.Memory;
// using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using VisRes.Data.AncientSqlClient;
using VisRes.Models.Test;

// TODO: GP - this was one of phugongs files using NPOCO. 
// I might port this later but this can be delete as well but you'll notice it has the SQL that we need to get stuff.
namespace VisRes.Business.Services.Test
{
    public interface IUsersService
    {
        UserModel GetUserById(int id);
        UserModel GetUserByUsername(string username);
        IEnumerable<UserModel> GetUsersList();
        // Page<UserModel> GetUsers(int offset, int number);
        void Update(UserModel um);
        void UpdateIndividual(UserUpdateRequestModel um);
        void UpdateUser(UserUpdateRequestModel um);
    }

    public class UsersService : IUsersService
    {
        //IDataAccess Da;
        IMemoryCache Cache;
        // IPaginationService Pagination;

        public UsersService(//IDataAccess da, 
                            IMemoryCache cache)
        {
            // Da = da;
            Cache = cache;
            // Pagination = pagination;
        }

        public IEnumerable<UserModel> GetUsersList()
        {
            return null;
            //var userSql =
            //    " select u.userid, u.IndividualID, u.username, l.userlevel, l.userlevelid, u.isActive, i.firstname, i.lastname, i.personalPhoto, i.emailAddress, i.phoneNumber, i.mobileNumber  from tblusers u " +
            //    " inner join tblIndividualDetails i on i.IndividualID=u.IndividualID " +
            //    " inner join tblUserLevels l on l.UserLevelID = u.UserLevelID " +
            //    " where u.IsActive = 1 " +
            //    " order by i.firstname, i.lastname ";

            //var projectSql = " select pd.projectname from tblIndividualProjectDetails ipd inner join tblProjectDetails pd on pd.ProjectID = ipd.ProjectID where ipd.individualid = @0 ";

            //var items = Da.Query<UserModel>(userSql);
            //items.ToList().ForEach(x => {
            //    var names = Da.Query<string>(projectSql, x.IndividualId);
            //    x.ProjectName = string.Join(", ", names.ToArray());
            //});
            //return items;
        }

        public UserModel GetUserById(int id)
        {
            return null;

            //var userSql =
            //    " select u.userid, u.IndividualID, u.username, l.userlevel, l.userlevelid, u.isActive, i.firstname, i.lastname, i.personalPhoto, i.emailAddress, i.phoneNumber, i.mobileNumber from tblusers u " +
            //    " inner join tblIndividualDetails i on i.IndividualID=u.IndividualID " +
            //    " inner join tblUserLevels l on l.UserLevelID = u.UserLevelID " +
            //    " where u.IsActive = 1 and u.userid = @0";

            //var projectSql = " select pd.projectname from tblIndividualProjectDetails ipd inner join tblProjectDetails pd on pd.ProjectID = ipd.ProjectID where ipd.individualid = @0 ";

            //var items = Da.Query<UserModel>(userSql, id);
            //items.ToList().ForEach(x =>
            //{
            //    var names = Da.Query<string>(projectSql, x.IndividualId);
            //    x.ProjectName = string.Join(", ", names.ToArray());
            //});
            //return items.SingleOrDefault();
        }

        public UserModel GetUserByUsername(string username)
        {
            return null;
            //var sql =
            //    " select u.userid, u.IndividualID, u.UserName, ul.UserLevel, ul.UserLevelID, u.IsActive, i.FirstName, i.LastName, i.PersonalPhoto, i.EmailAddress, i.PhoneNumber, i.MobileNumber " +
            //    " from tblUsers u " +
            //    " join tblIndividualDetails i on i.IndividualID=u.IndividualID " +
            //    " join tblUserLevels ul on ul.UserLevelID=u.UserLevelID " +
            //    " where u.username=@0 ";

            //var items = Da.Query<UserModel>(sql, username);
            //return items.SingleOrDefault();
        }

        public void Update(UserModel um)
        {
            //Da.Update<UserModel>("update tblusers set UserLevelId = @0 where userid = @1", um.UserLevelId, um.UserId);
        }

        public void UpdateUser(UserUpdateRequestModel um)
        {
            //List<string> q = new List<string>();
            //int i = 0;
            //um.Columns.ForEach(x =>
            //{
            //    q.Add(x + " = " + "@" + i);
            //    i++;
            //});
            //var sql = "update tblusers set " + string.Join(", ", q.ToArray()) + "  where userid = @" + i;

            //um.Values.Add(Convert.ToString(um.UserId));

            //Da.Update<UserModel>(sql, um.Values.ToArray());
        }

        public void UpdateIndividual(UserUpdateRequestModel um)
        {
            //List<string> q = new List<string>();

            //int i = 0;

            //um.Columns.ForEach(x =>
            //{
            //    q.Add(x + " = " + "@" + i);
            //    i++;
            //});

            //um.Values.Add(Convert.ToString(um.IndividualId));
            //var sql = "update tblindividualdetails set " + string.Join(", ", q.ToArray()) + "  where individualid = @" + i;
            //Da.Update<UserModel>(sql, um.Values.ToArray());
        }

        //public Page<UserModel> GetUsers(int offset, int number)
        //{
        //    return null;
        //    //var userCountSql =
        //    //    " select count(*) from tblusers u " +
        //    //    " inner join tblIndividualDetails i on i.IndividualID=u.IndividualID " +
        //    //    " inner join tblUserLevels l on l.UserLevelID = u.UserLevelID " +
        //    //    " where u.IsActive = 1 ";

        //    //var userSql =
        //    //    " select u.userid, u.IndividualID, u.username, l.userlevel, l.userlevelid, u.isActive, i.firstname, i.lastname, i.personalPhoto, i.emailAddress, i.phoneNumber, i.mobileNumber  from tblusers u " +
        //    //    " inner join tblIndividualDetails i on i.IndividualID=u.IndividualID " +
        //    //    " inner join tblUserLevels l on l.UserLevelID = u.UserLevelID " +
        //    //    " where u.IsActive = 1 " +
        //    //    " order by i.firstname, i.lastname " +
        //    //    " OFFSET @0 ROWS FETCH NEXT @1 ROWS ONLY";

        //    //var projectSql = " select pd.projectname from tblIndividualProjectDetails ipd inner join tblProjectDetails pd on pd.ProjectID = ipd.ProjectID where ipd.individualid = @0 ";

        //    //var count = Da.ExecuteScalar(userCountSql);
        //    //if (count == 0)
        //    //{
        //    //    return new Page<UserModel>()
        //    //    {
        //    //        TotalItems = 0,
        //    //        TotalPages = 0,
        //    //        Items = null,
        //    //        CurrentPage = 0,
        //    //        ItemsPerPage = 0
        //    //    };
        //    //}

        //    //var items = Da.Query<UserModel>(userSql, offset, number);
        //    //items.ToList().ForEach(x =>
        //    //{
        //    //    var names = Da.Query<string>(projectSql, x.IndividualId);
        //    //    x.ProjectName = string.Join(", ", names.ToArray());
        //    //});

        //    //var pg = new Page<UserModel>()
        //    //{
        //    //    TotalItems = count,
        //    //    TotalPages = (long)Math.Ceiling((double)count / number),
        //    //    Items = items.ToList(),
        //    //    CurrentPage = offset,
        //    //    ItemsPerPage = count > number ? number : count
        //    //};

        //    //return pg;
        //}
    }
}
