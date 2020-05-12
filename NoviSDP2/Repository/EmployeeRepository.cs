﻿using Microsoft.EntityFrameworkCore;
using NoviSDP2.Interface;
using NoviSDP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoviSDP2.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly DbTestContext _context;

        public EmployeeRepository(DbTestContext context)
        {
            _context = context;
        }

        public void Create(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public Employee Get(int id)
        {
            return GetAll().FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees
                    .Include(e => e.Items);

        }

        public IEnumerable<Item> GetItems(int employeeId)
        {
            return Get(employeeId).Items;
        }
    }
}
