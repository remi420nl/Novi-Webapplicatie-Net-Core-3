﻿using NoviSDP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoviSDP2.Interface
{
    public interface IEmployeeRepository
    {
        Employee Get(int id);
        IEnumerable<Employee> GetAll();
        IEnumerable<Item> GetItems(int employeeId);
        void CreateAsync(Employee employee);
    

    }
}
