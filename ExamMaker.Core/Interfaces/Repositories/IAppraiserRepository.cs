﻿using ExamMaker.Core.Models;
using System;
using System.Collections.Generic;

namespace ExamMaker.Core.Interfaces.Repositories {
    public interface IAppraiserRepository : IDisposable{
        void Create(Appraiser appraiser);
        Appraiser Get(Guid Id);
        Appraiser Get(string cpf);
        IEnumerable<Appraiser> GetAll(int limit, int offset);
        void Delete(Appraiser appraiser);
        void Update(Appraiser appraiser);
    }
}
