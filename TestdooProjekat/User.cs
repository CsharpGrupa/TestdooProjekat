//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestdooProjekat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public enum Role { SalesEmployee, SalesManager, LogisticEmployee, LogisticManager, ProductsEmployee, HREmployee, ProductsManager, Admin }

    public partial class User
    {
        public string username { get; set; }
        protected string password { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string role { get; set; }
        public int empid { get; set; }
        public string status { get; set; }
    
        public virtual Employee Employee { get; set; }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public bool ValidateUser(string username, string password)
        {
            TEST_DOOEntities db = new TEST_DOOEntities();

            if (db.Users.Where(u => u.username == username && u.password == password).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
   

        public int GetEmployeeID(string username)
        {
            TEST_DOOEntities db = new TEST_DOOEntities();
            var usr = db.Users.Where(u => u.username == username).FirstOrDefault<User>();
            return usr.empid;
        }
        public Role GetUserRole(string username)
        {
            TEST_DOOEntities db = new TEST_DOOEntities();
            var usr = db.Users.Where(u => u.username == username).FirstOrDefault<User>();
            return ConvertStringToRole(usr.role);
        }
        public Role ConvertStringToRole(string role)
        {
            if (role == "Sales Manager" || role == "SalesManager")
            {
                return Role.SalesManager;
            }
            else if (role == "Admin")
            {
                return Role.Admin;
            }
            else if (role == "Sales Representative" || role == "SalesEmployee")
            {
                return Role.SalesEmployee;
            }
            else if (role == "LogisticEmployee")
            {
                return Role.LogisticEmployee;

            }
            else if (role == "LogisticManager")
            {
                return Role.LogisticManager;

            }
            else if (role == "ProductsEmployee")
            {
                return Role.ProductsEmployee;

            }
            else if (role == "ProductsManager")
            {
                return Role.ProductsManager;

            }
            else
            {
                return Role.HREmployee;
            }

        }
        
    }
}
