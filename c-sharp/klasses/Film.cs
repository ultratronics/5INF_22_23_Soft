using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Patient
{
    class Film
    {
        public string naam { get; set; }
        public List<string> Acteurs = new List<string>();

        public void addActor(string acteurnaam) { 
        
        Acteurs.Add(acteurnaam);
        
        
        }

    }
}
