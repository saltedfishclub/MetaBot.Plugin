using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaBot.Plugins
{
    public interface IMessageListener
    {
        void ReceiveFriendMessage(long botQQ, long friendNumber, QQ.Framework.Utils.Richtext content);
        void ReceiveGroupMessage(long botQQ, long groupNumber, long fromNumber, QQ.Framework.Utils.Richtext content);
    }
}
