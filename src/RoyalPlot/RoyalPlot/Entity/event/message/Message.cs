/*
 * 消息类  一切情节 由消息驱动
 * 用户： Administrator
 * 日期: 2017/5/11
 * 时间: 15:46
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace royalplot.Entity
{
	/// <summary>
	/// Description of Message.
	/// </summary>
	public class Message
	{   
		//消息种类 如: 自动弹出消息 ,弹出后消失消息 弹出后还在消息列表消息 等 需要在TOOLS 做常量定义
		//此消息属于那个玩家 即在那个玩家消息列表展示
        	
        public string thename;
        //消息体 带有超链接的 消息文本 玩家点击超链接 出菜单 或跳转
        public string thebody;
        //事件ID
        public int eventid;
        //是否已读
        public int readed=0;
        
		public Message()
		{
		}
		//根据消息名字 读入创建消息
		public  Message(string msgname)
		{
			thename=msgname;
			thebody=".............";
		}
		public bool save(string msgname)
		{return true;
		}
		public bool load(string msgname)
		{return true;
		}
	}
}
