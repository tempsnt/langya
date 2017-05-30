/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/5/8
 * 时间: 14:24
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic; //应用泛型

namespace royalplot.Entity
{
	/// <summary>
	/// Description of ActionList.
	/// </summary>
	public class ActionList:List<Actions>  //继承自 行动类型的列表类
	{
		public ActionList()
		{loadAllAction();
		}
		
		   //初始化所有可执行行动菜单 
        public int loadAllAction()
		{//先手动创建 3个action 用作调试
        	Actions action0=new Actions();
		    action0.thename="学习技能/参加聚会";
            Actions action1=new Actions();
		    action1.thename="散布谣言";
            Actions action2=new Actions();
		    action2.thename="调查某人";

		    this.Add(action0);
		    this.Add(action1);
		    this.Add(action2);
		    //正式使用应该是一个循环从数据库读出actions
        	return 1;
        }
	}
}
