/*
 * 是用户玩家类  区别于NPC
 * 用户： Administrator
 * 日期: 2017/4/21
 * 时间: 15:30
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic; //应用泛型

namespace royalplot.Entity   //注意 这里所有实体 可以放在一个命名空间下 和实际目录不同 参见User
{
	/// <summary>
	/// Description of User.
	/// </summary>
	public class User :Person //继承自person
	{   
		//选择的皇子
		public Person prince;
		
		
		//行动点数
		public int actpower;
		//金币数
		public int icon;
		//个人等级 决定手下数量 和 行动菜单数量
		public int level;
		//行动菜单
		public Actions[] activemenu;
		
		
		//道具列表
		public int equipment_num;
		//道具列表
		public  List<Object>  equipment;//参加本游戏的用户列表 单机就一个equipment
		//各个技能值列表 应考虑用数组 而不是LIST
		public  List<int>  skill;
		
		//手下列表 随着玩家等级提升 手下列表 会扩展 先默认3个
		public  Person[] follower;
		
			
		public User()
		{
			thename="user";
			level=1;
			actpower=10;
			activemenu=new Actions[20];
			follower = new Person[20];
			
		}
		//设置选中的王子
		public bool setSelPrince(Person prince)
		{
			this.prince=prince;
			return true;
		}
		//设置最初的属下
		public bool setFirstFowllower()
		{
			this.follower[0]=new Person();
			this.follower[0].thename="飞流";
			this.follower[1]=new Person();
			this.follower[1].thename="宫羽";
			this.follower[2]=new Person();
			this.follower[2].thename="黎纲";
				
			return true;
		}
		//根据等级 或其他的什么 设置可以采取的行动菜单  //然后可以设置1个每日自动行动? 花钱可以变成2个
		public bool setActionMenu(List<Actions> actions)
		{  //Global. global=new Global();
			
		   activemenu[0]=actions[0];
		   activemenu[1]=actions[1];
		   activemenu[2]=actions[2];
			
		   return true;
		}
		
	}
}
