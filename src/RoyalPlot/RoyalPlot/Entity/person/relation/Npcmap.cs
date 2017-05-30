/*
 * NPC人物关系树 
 * 用户： Administrator
 * 日期: 2017/4/28
 * 时间: 13:09
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace royalplot.Entity
{
	/// <summary>
	/// Description of Npcmap.
	/// </summary>
	public class Npcmap<Person>:MLTree<Person>  //继承自tree
	{
		public Npcmap()
		{
		}
	}
}
