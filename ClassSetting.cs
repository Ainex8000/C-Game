using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    /// <summary>
    /// This will allows the user to explore different area depending on their choices
    /// </summary>
    internal class ClassSetting
    {
        // This will set the name of the area or situation the player is in
        public string ScenarioName { get; set; }
        // This will set the situation and tell what choices are given to the player
        public string Situation { get; set; }
    }
}
