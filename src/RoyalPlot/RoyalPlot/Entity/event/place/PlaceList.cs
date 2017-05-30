/*
 * 地点列表类 
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
	public class PlaceList:List<Place>  //继承自 地点类型的列表类
	{
		public PlaceList()
		{   
			//testinit();
			//loadAllPlace();
		}
		   //初始化地点 
        public int testinit()
		{//先手动创建 3个place 用作调试
        	Place place0=new Place();
        	place0.thename="大街";
        	place0.eventArr[0]="事件1";
        	place0.eventArr[1]="事件2";
        	place0.eventArr[2]="事件3";
        	place0.eventArr[3]="事件4";
        	place0.eventArr[4]="事件5";
        	place0.eventArr[5]="事件6";
        	place0.eventArr[6]="事件7";
        	place0.eventArr[7]="事件8";
        	place0.eventArr[8]="事件9";
        	place0.eventArr[9]="事件10";
        	
        	
        	Place place1=new Place();
        	place1.thename="城门";
        	Place place2=new Place();
        	place2.thename="皇宫";
        	Place place3=new Place();
        	place3.thename="国子监";
        	place3.eventArr[0]="事件1";
        	place3.eventArr[1]="事件2";
        	place3.eventArr[2]="事件3";
        	place3.eventArr[3]="事件4";
        	place3.eventArr[4]="事件5";
        	place3.eventArr[5]="事件6";
        	place3.eventArr[6]="事件7";
        	place3.eventArr[7]="事件8";
        	place3.eventArr[8]="事件9";
        	place3.eventArr[9]="事件10";
        	
        	
        	this.Add(place0);
        	this.Add(place1);
        	this.Add(place2);
        	this.Add(place3);
        	
        	Tools.savetoJson(this,"places","Places");
        	
        	return 1;
        }
        
        public int loadAllPlace()
        {
        	return 1;
        }
       
	}
}
