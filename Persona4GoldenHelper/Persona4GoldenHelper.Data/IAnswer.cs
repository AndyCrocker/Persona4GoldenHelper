﻿using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface IAnswer
    {
        List<Answer> GetByMonth(string monthName);
    }
}
