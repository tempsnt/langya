/*
 * 单个桥段类  表达一段剧情 但又不是一整个故事 通常在多结局跳转的故事里使用 桥段之间跳转 桥段之内不会跳转 包含CLIP
 * 用户： Administrator
 * 日期: 2017/5/3
 * 时间: 15:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic; //应用泛型

namespace royalplot.Entity
{
	/// <summary>
	/// 一般来说 一个桥段 是不换场景的
	/// </summary>
	public class Plot
	{   
		public string thename;
		//单句对话列表
		public  List<Clip>   cliplist;
		public Plot(string ptname="缺省桥段")
		{
			thename=ptname;
			cliplist=new List<Clip>();
			
			//先写在这里 为调试
			//testinit();
			
		}
		
		public int execute()
		{  //执行事件 
		//	Debug.WriteLine("事件plot执行: "+thename);
			//循环顺序执行clip 因为PLOT 内部是不许跳转的 所以不用担心跳转问题
			int selid= cliplist[0].execute(); //最后返回 PLOT 最后一个问题的 选项答案 决定跳转到个PLOT
			
			//发出消息 消息是在plot层级发出的  执行到某个PLOT 发出固定的消息 
			sentmessage();
			
			return selid;
				
		}
		public int sentmessage()
		{  //执行事件 
		//	Debug.WriteLine("plot sentmessage: "+thename);
			
			return 1;
				
		}
		//从文件文本 读入事件 目前测试阶段 可以先写死事件
		public bool loadEventFromStr()
		{   
			return true;
		}
		//保存事件到文本 应可动态 加入人物参数  
		public bool saveEventtoStr()
		{
			return true;
		}
		
		
		
		
	}
}
