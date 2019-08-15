using MetaBot.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaBot.Plugins
{
    public abstract class Plugin
    {
        private bool enable=false;
        public abstract string Name { get; }
        public abstract string Version { get; }
        public virtual void OnLoad() { }
        public virtual void OnEnable() { enable = true; }
        public virtual void OnDisable() { enable = false; }
        IDictionary<long, Robot> Bots { get; set; }
        public bool Enabled { get { return enable; } }
        public override string ToString()
        {
            return Name + " [" + Version + "]";
        }
    }
}
