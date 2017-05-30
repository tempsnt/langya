/*
 * 这个是事件列表类 或许将来可以做为一个单独的 故事类使用 即一系列事件 组合成故事
 * 用户： Administrator
 * 日期: 2017/5/8
 * 时间: 14:11
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic; //应用泛型

namespace royalplot.Entity
{
	/// <summary>
	/// Description of EventList.
	/// </summary>
	public class EventList:List<Events>  //继承自 事件类型的列表类
	{
		public EventList()
		{
			addEventsToday();
		}
		
		 //添加事件 
        public int addEventsToday()
		{//先手动创建 1个事件 用作调试
        	Events event0=new Events();
		    event0.thename="街头斗殴";
		    event0.id=1;
           
		    Events event1=new Events();
		    event1.thename="赛诗会";
		    event1.id=2;
           
            Events event2=new Events();
		    event2.thename="捡到宝物";
		    event2.id=3;
           
		    Events event3=new Events();
		    event3.thename="遇到美人";
		    event3.id=4;
           
		    
		    this.Add(event0);
		    this.Add(event1);
		    this.Add(event2);
		    this.Add(event3);
		   
		   	return 1;
        }
	}
}
