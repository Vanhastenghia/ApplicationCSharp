using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProjcet
{
    public class History
    {
        public int ID { get; set; }
        public Image Logo { get; set; }
        public string Job { get; set; }
        public string Company { get; set; }
        public string Salary { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public string Level { get; set; }
        public string NumberRecruit { get; set; }
        public string Gender { get; set; }
        public string Experience { get; set; }

        public History(int _id, Image _logo, string _job, string _company, string _salary, string _location, string _jobtype,
            string _level, string _numberrecruit, string _gender, string _experience)
        {
            ID = _id; Salary = _salary; 
            Logo = _logo; Location = _location;
            Job = _job; JobType = _jobtype;
            Company = _company; Level = _level;
            NumberRecruit = _numberrecruit; Gender = _gender; Experience = _experience;
        }
    }
}
