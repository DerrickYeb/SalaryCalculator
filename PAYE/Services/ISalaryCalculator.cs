﻿using PAYE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYE.Api.Services
{
    public interface ISalaryCalculator
    {
        Task<UserOutputModel> GenerateSalary(UserInputModel userInput,UserOutputModel userOutput);
    }
}
