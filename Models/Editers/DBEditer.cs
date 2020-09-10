using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorlWithAPI.Models.Editers
{
    internal class DBEditer
    {
        public virtual void EditDB(string commandString)
        {
            using(var connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(commandString, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
