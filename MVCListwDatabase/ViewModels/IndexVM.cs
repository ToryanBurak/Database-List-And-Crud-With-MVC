using MVCListwDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCListwDatabase.ViewModels
{
    public class IndexVM
    {
        public List<Employee> Employees { get; set; }
        public Employee Employee { get; set; }
    }
}