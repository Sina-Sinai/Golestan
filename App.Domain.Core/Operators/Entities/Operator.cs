using App.Domain.Core.Entities.Users;
using App.Domain.Core.Operators.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Operators.Entities
{
    internal class Operator : User
    {
        public Operator (int userId, int operatorId, string username, string password, string firstname, string lastname, int mobile)
            :base(userId, username, password)
        {
            OperatorID = operatorId;

        }
        public string Username { get; set; }
        public string Email { get; set; }
        public int OperatorID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Mobile { get; set; }
        public OperatorLevelEnum OperatiorLevel { get; set; }
        public int MyProperty { get; set; }
    }
}
