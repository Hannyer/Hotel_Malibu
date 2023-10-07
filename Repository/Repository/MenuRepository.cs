using EntityLayer;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class MenuRepository : IMenuRepository
    {
        public List<MenuE> GetList(MenuE menu)
        {
            try
            {
                using (var connection = new SqlConnection(Connection.GetConnectionString()))
                {
                    string script = "dbo.[PA_CON_MBR_MENU]";
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(script, connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@P_OPCION", menu.Opcion);
                        cmd.Parameters.AddWithValue("@P_PK_MENU", menu.ID);
                        cmd.Parameters.AddWithValue("@P_FK_ROLE", menu.IDP_ROLE);
                        cmd.Parameters.AddWithValue("@P_MENU_STATUS", menu.STATUS_Menu ? "1" : "");
                        cmd.Parameters.AddWithValue("@P_PERMISSON_STATUS", menu.Permisson_Status ? "1" : "");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<MenuE> List = new List<MenuE>();
                            while (reader.Read())
                            {
                                List.Add(new MenuE()
                                {
                                    ID = Convert.ToInt32(reader["ID_MENU"].ToString()),
                                    PARENT_CODE = reader["PARENT_CODE"].ToString(),
                                    DESCRIPTION = reader["DESCRIPTION"].ToString(),
                                    ICON = reader["ICON"].ToString(),
                                    CONTROLLER = reader["CONTROLLER"].ToString(),
                                    ACTION = reader["ACTION"].ToString(),
                                    STATUS_Menu = Convert.ToBoolean(reader["STATUS"].ToString()),
                                    Creeate_Menu = Convert.ToBoolean(reader["CREATE"].ToString()),
                                    Edit_Menu = Convert.ToBoolean(reader["EDIT"].ToString()),
                                    View_Menu = Convert.ToBoolean(reader["VIEW"].ToString()),
                                    Send_Menu = Convert.ToBoolean(reader["SEND"].ToString()),
                                    Permisson_Status = Convert.ToBoolean(reader["PERMISSON_STATUS"].ToString()),
                                    Permisson_Create = Convert.ToBoolean(reader["PERMISSON_CREATE"].ToString()),
                                    Permisson_Edit = Convert.ToBoolean(reader["PERMISSON_EDIT"].ToString()),
                                    Permisson_View = Convert.ToBoolean(reader["PERMISSON_VIEW"].ToString()),
                                    Permisson_Send = Convert.ToBoolean(reader["PERMISSON_SEND"].ToString())

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

        public void Maintenance(MenuE menu)
        {
            throw new NotImplementedException();
        }
    }
    
}
