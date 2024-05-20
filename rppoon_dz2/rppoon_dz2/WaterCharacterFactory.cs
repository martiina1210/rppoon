using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz2
{
    internal class WaterCharacterFactory : CharacterFactory
    {
        public override Goblin CreateGoblin()
        {
            return new WaterGoblin();
        }

        public override Wizard CreateWizard()
        {
            return new WaterWizard();
        }
    }
}
