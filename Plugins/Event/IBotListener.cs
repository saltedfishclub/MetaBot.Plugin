using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaBot.Plugins.Event
{
    public interface IBotListener
    {
        void FirendMessageReceived(FriendMessageEvent e);
        void GroupMessageReceived(GroupMessageEvent e);
    }
}
