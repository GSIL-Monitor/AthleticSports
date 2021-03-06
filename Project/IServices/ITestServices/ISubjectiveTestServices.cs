﻿using IServices.Infrastructure;
using Models.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices.ITestServices
{
    public interface ISubjectiveTestService : IRepository<SubjectiveTest>
    {
    }
    public interface IPainPointService : IRepository<PainPoint>
    {
    }

}
