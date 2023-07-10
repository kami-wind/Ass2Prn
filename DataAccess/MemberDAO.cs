using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess;

public class MemberDAO : BaseDAL
{

    //-----------------------------
    //Using Singlton Patern


    private static MemberDAO? instance = null;
    private static readonly object instanceLock = new object();
    private MemberDAO() { }

    public static MemberDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new MemberDAO();
                }
                return instance;
            }
        }
    }

    public IEnumerable<MemberObject> GetMemberList()
    {
        IDataReader? dataReader = null;
        string SQLSelect = "Select MemberID, Email, CompanyName, City, Country, Password from Member";
        var members = new List<MemberObject>();

        try
        {
            dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
            while (dataReader.Read())
            {
                members.Add(new MemberObject
                {
                    MemberID = dataReader.GetInt32(0),
                    Email = dataReader.GetString(1),
                    CompanyName = dataReader.GetString(2),
                    City = dataReader.GetString(3),
                    Country = dataReader.GetString(4),
                    Password = dataReader.GetString(5)
                });
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally {
            dataReader.Close();
            connection.Close();
        }
        return members;
    }


    public MemberObject GetMemberByID(int memberID)
    {
        MemberObject? member = null;
        IDataReader dataReader = null;
        string SQLSelect = "Select MemberID, Email, CompanyName, City, Country, Password from Member where MemberID=@MemberID";
        try
        {
            var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
            dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
            if (dataReader.Read())
            {
                member = new MemberObject
                {
                    MemberID = dataReader.GetInt32(0),
                    Email = dataReader.GetString(1),
                    CompanyName = dataReader.GetString(2),
                    City = dataReader.GetString(3),
                    Country = dataReader.GetString(4),
                    Password = dataReader.GetString(5)
                };
            }
        }
        catch (Exception ex)
        {
           throw new Exception(ex.Message);
        }
        finally
        {
            dataReader?.Close();
            CloseConnection();
        }
        return member;
    }

    //----------------------------

    public void Add(MemberObject member)
    {
        try
        {
            MemberObject pro = GetMemberByID(member.MemberID);
            if (pro == null)
            {
                string SQLInsert = "Insert Member values(@MemberID,@Email,@CompanyName,@City,@Country,@Password)";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@CompanyName", 50, member.CompanyName, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
            }
            else
            {
                throw new Exception("Member is already exist.");
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }


    public void Update(MemberObject member)
    {
        try
        {
            MemberObject c = GetMemberByID(member.MemberID);
            if (c != null)
            {
                string SQLUpdate = "Update Member set Email=@Email,CompanyName=@CompanyName, " +
                    "City=@City,Country=@Country,Password=@Password where MemberID=@MemberID";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@CompanyName", 50, member.CompanyName, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());

            }
            else { throw new Exception("Member does not already exist"); }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }





    //-----------------

    public void Remove(int memberID)
    {
        try
        {
            MemberObject member = GetMemberByID(memberID);
            if (member != null)
            {
                string SQLDelete = "Delete from Member where MemberID=@MemberID";
                var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                dataProvider.Delete(SQLDelete, CommandType.Text, param);
            }
            else
            {
                throw new Exception("Member does not already exist.");
            }

        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally { CloseConnection(); }
    }


}