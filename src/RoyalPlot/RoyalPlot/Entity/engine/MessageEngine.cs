/*
 * 消息引擎类  负责根据玩家等级不同 自动生成 每日消息 收发 用户消息
 * 用户： Administrator
 * 日期: 2017/5/11
 * 时间: 15:51
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using  System.Diagnostics;  //调试用

namespace royalplot.Entity
{
	/// <summary>
	/// 消息引擎类  负责自动生成 每日消息 收发 用户消息   
	/// 每日消息 自动弹出 显示在屏幕上?? 还是手动点开??
	/// </summary>
	public class MessageEngine
	{
		public MessageEngine()
		{
		}
		public string everydayMessage()
		{
			//如果游戏天数是0 即才进来 发送新手说明 和 第一个任务消息 带起其他一系列消息 第一个任务得有趣点

			if (Global.game.gameday==0)
			{   
				Global.game.messages.MsgAdd();
				sentMsg();
				Global.game.gameday++; //日期加一
			}
				 Debug.WriteLine("GameDay="+Global.game.gameday);
            
			return "";
		}
		public int sentMsg()
		{
			return 1;
		}
	}
}
