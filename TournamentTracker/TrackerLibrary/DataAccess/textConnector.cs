﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
  public class TextConnector : IDataConnection
  {
    private const string PrizesFile = "PrizeModels.csv";
    public PrizeModel CreatePrize(PrizeModel model)
    {
      //Load the text file
      //Convert the text to List<PrizeModel>
      List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
      //Find the max ID
      int currentId = 1;
      if (prizes.Count > 0)
      {
        currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
      }
      model.Id = currentId;     
      //Add the new record with the new ID (max + 1)
      prizes.Add(model);
      //Convert the Prizes to list<string>
      //Save the lis<string> to the text file
      prizes.SaveToPrizeFile(PrizesFile);
      return model;
    }
  }
}
