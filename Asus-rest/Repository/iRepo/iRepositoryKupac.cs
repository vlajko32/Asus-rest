﻿using Asus_rest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Repository.iRepo
{
    public interface iRepositoryKupac: IRepository<Kupac>
    {
        Kupac FindById(string PiB);
    }
}
