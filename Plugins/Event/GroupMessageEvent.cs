using QQ.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaBot.Plugins.Event
{
    public class GroupMessageEvent:IBotEvent
    {
        public long BotQQ { get; private set; }
        public long FromGroup { get; private set; }
        public long FromQQ { get; private set; }
        public Richtext Content { get; private set; }
        public GroupMessageEvent(long botQQ, long fromGroup, long fromQQ, Richtext content)
        {
            this.BotQQ = botQQ;
            this.FromGroup = fromGroup;
            this.FromQQ = fromQQ;
            this.Content = content;
        }
        public void Call(IBotListener listener)
        {
            listener.GroupMessageReceived(this);
        }
    }
}
