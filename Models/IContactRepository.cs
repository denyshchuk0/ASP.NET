﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public interface IContactRepository
    {
        Contact GetContact(int id);
        void AddContact(Contact model);
        IEnumerable<Contact> GetAllContacts();
    }
}
