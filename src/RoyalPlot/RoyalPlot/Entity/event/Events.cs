/*
 * 事件类 每个事件都会产生后果 主要作用于 皇帝的态度 人物之间的关系 用户自身的能力成长
 * 用户： Administrator
 * 日期: 2017/5/3
 * 时间: 14:44
 * 
 * 
 */
using System;
using System.Collections.Generic; //应用泛型
using  System.Diagnostics;  //调试用

namespace royalplot.Entity
{
	/// <summary>
	/// Description of Events.
	/// </summary>
	public class Events
	{   
		//事件ID
		public int id;
		//事件名称
		public string thename;
		//事件描述
		public string note;
		//事件种类
		
		//触发条件
		
		//事件秘密程度 表示消息传播的速度
		
		//事件处理菜单 //并包含 消息的发送
		
		//事后要通知的人 (用户手动选择吗??)
		
		//事件关联人列表
		 public  List<Person>  npclist;
		 
		//事件描述模版 文本 用{A},{B}表示变量参数 变量可以是人 可以是物品
		 
		//事件参数列表
		
		//情节推进桥段list  目前情节推进以对话为主  桥段包含clip列表 clip每一条存一句单独的对话 或者展示 或者选择菜单
		  public  List<Plot>   plotlist;
		
		//当前plot 运行到
		public  int    currentPlot;
    	//当前 clip  运行到
    	public  int    currentClip;
		
		 
		
		public Events()
		{
			
			thename="未定义事件";
			//初始化桥段链
			plotlist=new List<Plot>();
			//先暂时放这里 为了调试跑通
			
		}
		
		public bool execute()
		{  
			//如果Global.game.currentEvent不是自己 是初次执行 先把game里的 各种当前值设置好
			if (Global.game.currentEvent!=this){
			Global.game.currentEvent=this;
			//Global.game.currentPlot=0;
			//Global.game.currentClip=0;
			}
			//否则
			
			
			//执行事件
			//Debug.WriteLine("先创建一段测试事件 否则出错");
			//testinit(); //这里先创建一段测试事件
			Debug.WriteLine("地点事件执行: "+thename);
			//首先执行 初始plot(即ID是0的) 如PLOT 返回 值 不是0 则停止循环 跳转到返回的ID 的PLOT去
			
			int goid= plotlist[0].execute();
			
			return true;
			//每个事件被执行 都会产生后果 主要作用于 皇帝的态度 人物之间的关系 用户自身的能力成长	
		}
		//从文件文本 读入事件 目前测试阶段 可以先写死事件
		//废弃 因为保存可以在类内 读取要在类外 NEW 一个类
		public bool loadEvent(string filename)
		{  //主要是填充plotlist 
			
			 //Events o= Tools.loadfromJson<Events>(filename);
			 
			 //Debug.WriteLine(o.thename);
			 //Debug.WriteLine(o.plotlist[0].cliplist[0].sad);
			
			
			return true;
				
		}
		//保存事件 可以只保存事件模版 用的时候随机 动态 加入参数 那么参数表达的方式就要有讲究了 
		//比如那个位置只能是那个等级的人 填入
		public bool saveEvent(string filename)
		{
			//this.thename=filename;
			Tools.savetoJson(this,filename);
			return true;
				
		}
		//随机产生事件参数 填入人员和物品
		public bool fillEventByRnd()
		{
			return true;
				
		}
		//---------------------------
		//用于测试的初始化一段情节  真正的情节 应该是由一个编辑器生成 并保存为文件
		public int testinit()
		{   
			Plot pt=new Plot();
			plotlist.Add(pt);
			
			//首先 建立一个场景描述 遇见美女情节 为例
			//进入国子监大门
			pt.cliplist.Add(new Clip(0,"走进去,正红朱漆大门顶端悬着黑色金丝楠木匾额，上面龙飞凤舞地题着三个大字‘国子监’"));
			pt.cliplist.Add(new Clip(0,"水塘边树下,站着一个女子"));
			pt.cliplist.Add(new Clip(0,"粉红玫瑰香紧身袍袍袖上衣，下罩翠绿烟纱散花裙，腰间用金丝软烟罗系成一个大大的蝴蝶结，鬓发低垂斜插碧玉瓒凤钗，显的体态修长妖妖艳艳勾人魂魄。"));
			
			//做个选项菜单 菜单项的结构??? 尤其是跳转部分
            pt.cliplist.Add(new Clip(2,"过去招呼/XXXX|走开/VVVVV"));
            
			pt.cliplist.Add(new Clip(1,"大家好 我是宫羽"));
			pt.cliplist.Add(new Clip(1,"宫羽来了 !!"));
			pt.cliplist.Add(new Clip(1,"宫羽说说今天的情况"));
			
			
			  
		
			  
			return 1;
				
		}
		//得到当前clip
		public Clip getCurrentClip()
		{   
			
			Clip cl=this.plotlist[currentPlot].cliplist[currentClip];
			if (currentClip<plotlist[currentPlot].cliplist.Count-1) currentClip++;
			return cl;
			
		}
		//得到当前 左右
		public int leftorright()
		{  
			if ((currentClip+1)%2==0) return 0; else return 1;
		}
		
	}
}
