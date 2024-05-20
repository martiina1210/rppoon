using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz2
{
    public class GameManager
    {
        public void Create(CharacterFactory characterFactory) 
        { 
            characterFactory.CreateWizard();
            characterFactory.CreateGoblin();
        }
    }
}
