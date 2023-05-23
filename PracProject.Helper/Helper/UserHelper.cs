using PracProject.Model.Context;
using PracProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProject.Helper.Helper
{
    public class UserHelper
    {
        public Users AddUser (SignUpModel Data)
        {
            Users AddData = new Users();
            AddData.ID = Data.ID;
            AddData.Username = Data.Username;
            AddData.Email = Data.Email;
            AddData.Password = Data.Password;

            return AddData;
        }
    }
}
