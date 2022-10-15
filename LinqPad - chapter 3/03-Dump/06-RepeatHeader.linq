<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">F:\0. Repos\CSharp-all-rounder\LinqPad - chapter 3\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

var q2 = from p in System.Diagnostics.Process.GetProcesses()
				 let ThreadCount = p.Threads.Count
				 orderby ThreadCount descending
				 select new {p.ProcessName, ThreadCount};

	q2.Dump (description:"Processor threads", repeatHeadersAt: 15);
	
