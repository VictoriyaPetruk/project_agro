using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Agro
{
   public class ClassDatabase
    {
        #region ExecuteNonQuery
       public  int ExecuteNonQuery(string connectionToDBString, string sSql, int where)
        {
            int n = 0;
            try
            {
                MySqlConnection con = new MySqlConnection(string.Format("server=localhost;port=3306;user=root;database=agriculture;password=1234;", connectionToDBString));
                {

                    con.Open();
                    using (MySqlCommand sqlCommand = con.CreateCommand())
                    {
                        sqlCommand.CommandText = sSql;
                        n = sqlCommand.ExecuteNonQuery();

                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                n = 0;

            }
            return n;
        }
        #endregion

        #region Execute

        protected T GetObject<T>(params object[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }

        public void Execute<T>(string connectionToDBString, string sSql, ref List<T> listResult)
        {
            string result = "";
            try
            {

                MySqlConnection con = new MySqlConnection(string.Format("server=localhost;port=3306;user=root;database=agriculture;password=1234;", connectionToDBString));
                con.Open();
                MySqlCommand command = new MySqlCommand(sSql, con);
                MySqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        result = "";
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            try
                            {
                                result += dataReader.GetString(i) + "!";
                            }
                            catch { result += " !"; }
                        }
                        if (result.Count() > 2) result = result.Remove(result.Count() - 1);
                        if (result != "") listResult.Add(GetObject<T>(result));
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        

        #endregion
    }
}
