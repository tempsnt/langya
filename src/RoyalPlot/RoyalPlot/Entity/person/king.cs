/*
 * 皇帝类 本类 重要属性为 性格
 * 用户： Administrator
 * 日期: 2017/4/21
 * 时间: 16:09
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace royalplot.Entity
{
	/// <summary>
	/// Description of king.
	/// </summary>
	public class King:Person //继承自person
	{
		
		//强悍-软弱  容易被丞相架空 对强势易屈服 如禅位等
		public int hard;
		//精明--昏聩 精明可保证身边人的忠诚度 
		public int smart;
		public King()
		{
			thename="king";
		}
	}
}
