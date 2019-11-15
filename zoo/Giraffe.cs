using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Giraffe : Prey
    {
        public Giraffe(string sex) : base("Giraffe", sex)
        { }


        public override void MakeBaby(Prey giraffe1, Prey giraffe2)
        {
            // Boucler sur toutes les girafes puis if pour que les sexes soient différents
            // return new Giraffe;
            throw new NotImplementedException();
        }
    }
}
