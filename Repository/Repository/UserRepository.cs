using Repository.IRepository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            
        }
        public List<UserE> GetList(UserE user)
        {
            try
            {
                using (var connection= new SqlConnection(Connection.GetConnectionString()))
                {
                    string script = "dbo.PA_CON_MBR_TBL_USER";
                    connection.Open();
                    using (SqlCommand cmd=new SqlCommand(script,connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@P_OPCION", user.Opcion);
                        cmd.Parameters.AddWithValue("@P_ID",user.ID);
                        cmd.Parameters.AddWithValue("@P_User", user.User);

                        using (SqlDataReader reader=cmd.ExecuteReader())
                        {
                            List <UserE> List=new List<UserE>();
                            while (reader.Read()) {
                                List.Add(new UserE() {
                                    ID = Convert.ToInt32(reader["ID"].ToString()),
                                    User = reader["User"].ToString(),
                                    Password = reader["Password"].ToString()
                                });      
                            }
                            return List;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Maintenance(UserE user)
        {
            throw new NotImplementedException();
        }
    }
}
