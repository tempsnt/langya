/*
 * 地点 随着情节的发展 玩家能去的地方越来越多 去地点要消耗体力的 去一个地方 有概率触发事件 如比武 赛文 抢亲等
 * 用户： Administrator
 * 日期: 2017/5/5
 * 时间: 13:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using  System.Diagnostics;  //调试用


namespace royalplot.Entity
{
	/// <summary>
	/// Description of Place.
	/// </summary>
	public class Place
	{   //地点ID
		public int id;
		//地点名称
		public string thename;
		public string thetypes;
		//地点文字描述
		public string note;
		//通往列表 此处可直接通往的地点 一般不超过5个 通常2个用于展示 通往菜单 
		
		//可触发事件列表及//事件触发概率
		public string[] eventArr; //事件 改由中文文件名 命名了
		
		public Place()
		{
			thename="未定义地点";
			eventArr = new string[10];
			//eventArr[0]="遇到美女";
		}
		//为地点添加关联事件 //参数为事件和发生概率
		public int AddEvent(Events evt,int rnd)
		{
			//这里先手动关联几个事件 如 赛事会 得到物品 遇到美女 等 遇到特定美女 只能是一次???
			return 1;
		}
		public int actByRND()  //随机执行 关联事件
		{
        	//按不同的概率 来触发事件 有的概率大 有的概率小 得到随机数 0..100
        	int rnd=Tools.rnd();
        	
        	//先暂时执行 第一个事件 作为调试
     
        	string str=eventArr[ RND2NO(rnd)];
        	Events ev= Tools.loadfromJson<Events>(Tools.cut(str)[0]);
        	
        	//执行该事件
        	if (ev!=null) ev.execute();
        	        	
			return 1;
		}
		//根据RND数值 返回要调用的 事件ID 这个方法还要调整
		public int RND2NO(int rnd)  //随机执行 关联事件
		{   
			int z=0;
			for(int i=0;i<10;i++)
			{
				try
				{
				string s=Tools.cut(eventArr[i])[1];
				int a =int.Parse(s);
				//Debug.WriteLine(s);
				z=z+a;
				if (z>=rnd) {
				  return i;
				}
				}catch{
					return 0; //如果失败返回第一个事件
				};
			}
			return 1;
		}
		
	}
}
