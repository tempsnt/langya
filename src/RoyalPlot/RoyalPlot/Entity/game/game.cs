/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/4/21
 * 时间: 14:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic; //应用泛型
//using System.Collections;
using  System.Diagnostics;  //调试用



namespace royalplot.Entity
{
	/// <summary>
	/// Description of game.
	/// </summary>

	public class Game
	{
	    //public  ArrayList  userlist;
	    public  int  mutli; //单人多人 
	    public  List<User>  userlist;//参加本游戏的用户列表 单机就一个
	    
	    //游戏数据
	    //皇帝
	    public  King  king;
	    //王子 一般是8个
	    public  List<Person>  princelist;
	    //NPC 列表 树形架构
	    public  List<Person>  npclist;
	    
	    
	    //所有地点的列表 未来持续扩展
	    //public List<Place> places;
	    public PlaceList places;
	    //所有行动的列表 未来持续扩展
	    //public List<Actions> actions;
	    public ActionList actions;
	    //事件列表 每个玩家有自己的事件列 互相不同 都存在这 通过标识来区分
	    //public List<Events> events;
	    public EventList events;
	    
	    public MessageList messages;
	    
	    public  score  score;  //得分情况
	    public  Npcmap<Person> npcmap;  //NPC人物树  暂时取消 先用LIST的方式组织 NPC
	    
	    //游戏进行天数 游戏中的天数 并不一定是真实的天数 
	    public  int  gameday=0;
	    
	    //以下为当前状态 
		//当前event
		public  Events currentEvent;
		//当前plot 取消
		//public  int    currentPlot;
    	//当前 clip 取消
    	//public  int    currentClip;
	    
        
		public Game()
		{
			//如果是已进行 就不需要初始化了 只要读存档即可 
			gameInit();
			//游戏进行
			//gameRun();
			
			
			//测试代码 
            //gameTest();			
			 
		
		}
		//游戏初始化
		public int gameInit()
		{
			userlist=new List<User>(); //创建玩家列表
			 User user=new User();
			 userlist.Add(user);
			 Debug.WriteLine("创建玩家: "+userlist[0].thename);
			 //创建皇帝
			 king=new King();
			 Debug.WriteLine("创建皇帝: "+king.thename);
			 //创建王子列表
			 princelist=new List<Person>();
			 //添加王子
			 addPrince();
			 
			 
			 //初始化所有地点
			// places=new PlaceList();
			 places= Tools.loadfromJson<PlaceList>("places","Places");
			 //初始化所有可执行行动菜单 先全部读入 再根据用户等级分配给用户  或者应该用几个从库里读出加几个????
			 actions=new ActionList();
			 //创建所有事件列表
			 events=new EventList();
             //初始化消息列表
			 messages=new MessageList();
			 
			 
			 //为用户添加 权限内可采取行动 
			 userlist[0].setActionMenu(actions);
			 Debug.WriteLine("可执行行动: "+userlist[0].activemenu[0].thename+userlist[0].activemenu[1].thename+userlist[0].activemenu[2].thename);
			 
			 //创建NPC列表
			 npclist=new List<Person>();
			 //添加NPC
			 var npcnum=addNpc();
			 Debug.WriteLine("创建NPC数量="+npcnum);
			 
			 //先让默认玩家默认选择第一个王子为扶持对象
			 userlist[0].setSelPrince(princelist[0]);
			 Debug.WriteLine("已选定王子: "+userlist[0].prince.thename);
			 
			 //先为默认玩家 指定3个手下 保镖,情报,财政+行动  玩家要为这3个手下 不断升级 才能获胜
			 //未来 应该是玩家自己挑选不同相性的 手下 
			
             			 
			 userlist[0].setFirstFowllower();
			 Debug.WriteLine("已选定属下: "+userlist[0].follower[0].thename+"/"+userlist[0].follower[1].thename+"/"+userlist[0].follower[2].thename);
			 
			 //创建NPC人物树  暂时取消 先用LIST的方式组织 NPC
			 npcmap = new Npcmap<Person>();
			 //随机填充NPC 人物树
			 
			 
			 
			 return 1;
		}
		//游戏进行
		public int gameRun()
		{
		  //启动每日事件引擎 见微知著 拜访? 街上的事件? 听说的朝局??

			MessageEngine msgENG=new MessageEngine();
			msgENG.everydayMessage();
           return 1;		  
		}
		//一些测试用代码
		public int gameTest()
		{
		  	 //以下为测试代码 ============================================
			 //测试保存
			// Tools tools=new Tools(); 现在做成静态方法了 不用再NEW类了
			 
             //保存对象到文件
            //  Tools.savetoJson(king,"test");
			 //tools.savetoJson(king,"test");
			 //tools.savetoJson(princelist);
			 
			 //从文件恢复对象测试
			 //King o= Tools.loadfromJson<King>("test");
			 //Debug.WriteLine(o.thename);
			 //还要测试文件保存后 类属性做了改变会怎么样 如增加了属性 SMART  很好 似乎没有影响
			 //Debug.WriteLine(o.smart);
			 
			 //测试EVENT 读写 先修改掉 一部分内容保存
			 //events[0].plotlist[0].cliplist[0].sad="哈哈哈 被改掉了";
			 //events[0].saveEvent("遇到美女");
			 //events[0].loadEvent("遇到美女"); 
			 //可以读取成功 但是会被inittest覆盖掉 先取消inittest
			 //Events o= Tools.loadfromJson<Events>(filename);
			 //这个测试成功 就得做一个事件编辑器了
			 
			 //尝试 把常量 保存为文件???? 这样 编辑器做各种下拉使用
			 
			//树结构测试
             //tools.testtree();
             //tools.testtree0();
             
             //字符串拆分测试
             //string[] s=Tools.cut("哈哈哈/0");
             //Debug.WriteLine(s[0]);
             //Debug.WriteLine(s[1]);
             
			 return 1; 
		}
		//循环创建王子
		public int addPrince()
		{
			for(int i=0;i<8;i++)
			{
				Person theprince=new Person();
				theprince.thename="prince"+i.ToString();
				princelist.Add(theprince);
				Debug.WriteLine("创建王子: "+princelist[i].thename);
				
			}
			return princelist.Count;
		}
        //循环创建NPC
        public int addNpc()
		{
			for(int i=0;i<100;i++)
			{
				Person theprince=new Person();
				theprince.thename="npc"+i.ToString();
				npclist.Add(theprince);
			}
			return npclist.Count;
		}		
     
     
       
	}
}
