﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DataContext
{
	public class AppDbContext: DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options)
			:base(options)
		{

		}
		public DbSet<Employee> Employee { get; set; }
	}
}