﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : BaseEntity
    {
        protected string firstname;
        protected string lastname;
        protected DateTime bday;
        protected bool gender;
        protected City city;
        protected bool isManger;
        protected string email;
        protected string password;
        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public DateTime Bday { get { return bday; } set { bday = value; } }
        public bool Gender { get { return gender; } set { gender = value; } }
        public City City { get { return city; } set { city = value; } }
        public bool IsManger { get { return IsManger; } set { IsManger = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }

       
    }
    public class UserList : List<User>
    {
        //בנאי ברירת מחדל - אוסף ריק
        public UserList() { }
        //המרה אוסף גנרי לרשימת משתמשים
        public UserList(IEnumerable<User> list)
            : base(list) { }
        //המרה מטה מטיפוס בסיס לרשימת משתמשים
        public UserList(IEnumerable<BaseEntity> list)
            : base(list.Cast<User>().ToList()) { }
    }
}
