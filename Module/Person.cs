using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System.Module
{
    public abstract class Person
    {
        protected int id;
        public string LastName {  get; set; }
        public string FirstName { get; set; }
        public string MiddleNAme { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Contact_number { get; set; }

        public void setID(int id)
        {
            this.id = id;
        }
        public int ID
        {
            get { return id;}
        }
        public string GetFullname() { 
            return $"{this.LastName}, {this.FirstName}";
        }

    }
}
