using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API;
using Exiled.API.Features;
namespace FastHandidk
{
    public class Main : Plugin<Config>
    {
        public override string Author => "Discord=>pelemenb";
        public override string Name => "FastHand";
        public override Version Version => new Version(1, 2, 3);
        public override void OnEnabled()
        {
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
        }
        
    }
}
