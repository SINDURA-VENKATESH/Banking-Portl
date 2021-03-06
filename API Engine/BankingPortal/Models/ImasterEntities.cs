﻿using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace BankingPortal.Models
{
    public interface ImasterEntities:IDisposable
    {
        DbSet<customers_table> customers_table { get; set; }
        DbSet<login_table> login_table { get; set; }

        int sp_addcustomer(string name, string address, string status, ObjectParameter id);
    }
}