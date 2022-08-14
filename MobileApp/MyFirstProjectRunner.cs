using TestProject.Common.DTO.ExecutionResult;
using TestProject.Common.Enums;
using System;
using System.Reflection;
using TestProject.SDK;

namespace TestProject.Generated.Tests.MyFirstProject
{
	
	public class MyFirstProjectRunner
	{
		public static string DevToken = "DEVkoGc55Ec1htS70hbMbFFu97ps_iB7WvhouQQ3SZE";
		public static string DeviceUDID = "DRGID19082203341";
		public static string AndroidPackage = "Your AndroidPackage";
		public static string AndroidActivity = "Your AndroidActivity";
		public static StepExecutionResult RunTechtask2()
		{
			using (var runner = new RunnerBuilder(DevToken).AsAndroid(DeviceUDID, AndroidPackage, AndroidActivity).Build())
				return runner.Run(new Techtask2(), true);
		}

		public static void Main(string[] args)
		{
			try
			{
				RunTechtask2();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
}