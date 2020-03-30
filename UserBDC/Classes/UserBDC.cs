using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using UserBDC.Interfaces;

namespace UserBDC.Classes
{
    public class UserBDC : IUserBDC
    {
        public UserDTO userDetails;

        public UserBDC()
        {
            userDetails = new UserDTO
            {
                Name = "John",
                Age = 23,
                Email = "john.doe@google.com"
            };
        }
        public UserDTO GetUserByID(int userId)
        {
            return userDetails;
        }
    }
}
