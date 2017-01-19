using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexRemote
{
    public class FanHighCommand : FanStufe
    {
        public FanHighCommand(CeilingFan Fan) : base(Fan)
        {
            prevStufe = Fan.Stufe;
        }

        protected override void SetSpeed()
        {
            Fan.Stufe = FanSpeed.high;
        }
    }
}
