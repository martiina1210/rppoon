using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz2
{
    public abstract class CharacterFactory
    {
        public abstract Wizard CreateWizard();
        public abstract Goblin CreateGoblin();
    }
}
