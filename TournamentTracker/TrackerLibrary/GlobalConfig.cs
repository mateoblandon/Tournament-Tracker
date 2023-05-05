using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
  public static class GlobalConfig
  {
    public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
    public static void InitializeConnections(bool database, bool textFiles)
    {
      if (database)
      {
        SqlConnector sql = new SqlConnector();
        Connections.Add(sql);
      }
      if (textFiles)
      {
        textConnector text = new textConnector();
        Connections.Add(text);
      }
    }
  }
}
