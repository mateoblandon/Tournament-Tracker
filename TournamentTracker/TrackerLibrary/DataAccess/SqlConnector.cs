﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
  public class SqlConnector : IDataConnection
  {
    /// <summary>
    /// Saves a new prize to the databe.
    /// </summary>
    /// <param name="model">The prize information.</param>
    /// <returns>The prize inforamtion, including the unique identifier.</returns>
    public PrizeModel CreatePrize(PrizeModel model)
    {
      model.Id = 1;
      return model;
    }
  }
}
