/*
 * 消息列表类 
 * 用户： Administrator
 * 日期: 2017/5/8
 * 时间: 14:20
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic; //应用泛型

namespace royalplot.Entity
{
	/// <summary>
	/// Description of PlaceList.
	/// </summary>
	public class MessageList:List<Message>  //继承自 地点类型的列表类
	{
		public MessageList()
		{
			
		}
		//添加消息
		public bool MsgAdd(string msgnam="")  //参数有缺省值 
		{
			
			Message msg=new Message("欢迎新人赠送礼品");
			msg.thebody="欢迎来到琅琊榜,第一次登录赠送金币10个";
			this.Add(msg);
			return true;
		}
		
       
	}
}
