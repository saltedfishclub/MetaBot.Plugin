using QQ.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaBot.Plugins.Event
{
    public class FriendMessageEvent:IBotEvent
    {
        public long BotQQ { get; private set; }
        public long FromQQ { get; private set; }
        public Richtext Content { get; private set; }
        public FriendMessageEvent(long botQQ, long fromQQ, Richtext content)
        {
            this.BotQQ = botQQ;
            this.FromQQ = fromQQ;
            this.Content = content;
        }
        public void Call(IBotListener listener)
        {
            listener.FirendMessageReceived(this);
        }
    }
}
