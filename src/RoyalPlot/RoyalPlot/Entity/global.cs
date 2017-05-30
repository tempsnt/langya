/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/4/25
 * 时间: 14:00
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace royalplot.Entity
{
	/// <summary>
	/// Description of global.
	/// </summary>
	public class Global
	{
        public static Boolean Pass=false;
        public static int ID=0; 
        public static Game game;        
		public Global()
		{
          game=new Game();
		}
	}
}
