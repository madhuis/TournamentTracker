﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public interface IDataConnection
    {

        PrizeModel CreatePrize(PrizeModel model); // We want just one method here which can create a Prizemodel.
    }
}
