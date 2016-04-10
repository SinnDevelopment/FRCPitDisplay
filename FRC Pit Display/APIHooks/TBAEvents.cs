using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRC_Pit_Display.APIHooks
{
    public class TBAEvents
    {
    
      
    }
    public class Match
    {
        class Alliances
        {
            Alliance blue { get; set; }
            Alliance red { get; set; }
        }
        class Alliance
        {
            int score { get; set; }
            IList<string> teams { get; set; }
        }
        string comp_level { get; set; }
        int match_number { get; set; }
        // Videos, JSON ARRAY
        int set_number { get; set; }
        string key { get; set; }
        long time { get; set; }

        string event_key { get; set; }
    }
    public class Rankings
    {
        IList<string> rankings { get; set; }
        // Index is the titles of each. 
    }
}
