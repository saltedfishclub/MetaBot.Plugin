using MetaBot.Plugins.Event;
using QQ.Framework;
using QQ.Framework.Domains;
using QQ.Framework.Sockets;
using QQ.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaBot.Net
{
    public class Bots
    {
        public static Dictionary<long, Robot> bots { get; set; } = new Dictionary<long, Robot>();
    }
    public class Robot: CustomRobot
    {
        private QQUser _QQUser;
        public long QQ { get
            {
                return _QQUser.QQ;
            } }
        public bool isLogined { get; set; } = false;
        public MessageManage Manager { get; set; }
        public Robot(ISendMessageService service, IServerMessageSubject transponder, QQUser user) : base(service, transponder, user)
        {
            this._QQUser = user;
        }
        private List<IBotListener> listeners = new List<IBotListener>();
        public void Dispose()
        {
            Manager.Dispose();
            Bots.bots.Remove(this.QQ);
        }
        public void AddListener(IBotListener listener)
        {
            this.listeners.Add(listener);
        }
        public void RemoveListener(IBotListener listener)
        {
            this.listeners.Remove(listener);
        }
        public void CallEvent(IBotEvent Event)
        {
            foreach (IBotListener listener in listeners)
            {
                Event.Call(listener);
            }
        }
        public override void ReceiveFriendMessage(long friendNumber, Richtext content)
        {
            CallEvent(new FriendMessageEvent(QQ, friendNumber, content));
        }

        public override void ReceiveGroupMessage(long groupNumber, long fromNumber, Richtext content)
        {
            CallEvent(new GroupMessageEvent(QQ, groupNumber, fromNumber, content));
        }
    }
}
