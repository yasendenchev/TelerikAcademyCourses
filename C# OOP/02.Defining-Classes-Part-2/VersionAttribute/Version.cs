using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class Version : Attribute
    {
        private double vers;

        public Version(double version)
        {
            this.vers = version;
        }

        public double Vers
        {
            get
            {
                return this.vers;
            }
            set
            {
                this.vers = value;
            }
        }

        
    }
}
