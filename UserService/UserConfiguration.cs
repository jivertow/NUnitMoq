using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MdP.Interfaces;

namespace MdP
{
    public class UserConfiguration : IUserConfiguration
    {
        public string GetUserInformation(int userId)
        {
            if (userId == 123) return "Hans Wurst";
            else return "";            
        }
    }
}
