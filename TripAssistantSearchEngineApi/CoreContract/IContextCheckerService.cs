﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IContextCheckerService
    {
        string GetFilteredQueryResponse(string input);
    }
}
