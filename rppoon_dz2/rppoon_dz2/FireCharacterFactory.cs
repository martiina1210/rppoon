using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz2
{
    public class FireCharacterFactory : CharacterFactory
    {
        public override Goblin CreateGoblin()
        {
            return new FireGoblin();
        }

        public override Wizard CreateWizard()
        {
            return new FireWizard();
        }
    }
}
