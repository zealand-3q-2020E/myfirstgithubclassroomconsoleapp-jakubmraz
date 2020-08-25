using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Panzerkampfwagen
    {
        public Panzerkampfwagen(string name)
        {
            this.Name = name;
            this.Sound = "vroom vroom";
        }

        public string Sound { get; set; }
        public string Name { get; set; }
    }
}
