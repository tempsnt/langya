/*
 * 用户可以采取的各种行动的基类 未来各种各样行动 在此基础上扩展 行动产生 事件 事件产生消息 消息产生传播 传播产生影响
 * 用户： Administrator
 * 日期: 2017/5/2
 * 时间: 13:24
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace royalplot.Entity
{
	/// <summary>
	/// Description of Actions.
	/// </summary>
	public class Actions
	{   public string thename;
		public Actions()
		{
			thename="未命名行动";
		}
	}
}
