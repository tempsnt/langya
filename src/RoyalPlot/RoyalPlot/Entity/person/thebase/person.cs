/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/4/21
 * 时间: 14:42
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace royalplot.Entity
{
	/// <summary>
	/// Description of person.
	/// </summary>
	public class Person
	{   
		//姓名
		public string thename;
		//性格
		public Character cha;
		//职业
		public Job job;
		//兴趣
		public Interest itr;
		//历史
		public History his;
		//声望
		public Prestige psg;
		//人物关系
        public Relation rel;
        
        //图像属性
		//立像
		//头像
		public Person()
		{
			thename="noname";
		}
	}
}
