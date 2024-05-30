using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requests
{
    public static class Auth
    {
        private static readonly DB db = new DB();
        public static Users currentUser;
        public static Users AuthenticateUser(string login, string password)
        { 
            try
            {           
                var result = db.Users.Single(user => user.password == password && user.login == login);
                currentUser = result;
                if(result == null) throw new Exception("Неправильный логин или пароль!");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при подключении к базе данных: " + ex.Message);
            }
        }
    }
}
