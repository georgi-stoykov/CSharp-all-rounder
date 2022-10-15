<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">F:\0. Repos\CSharp-all-rounder\LinqPad - chapter 1 and 2\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// add a reference to the CourseLib.dll

// use the WebColor and ColorSource classes..

var q = from wc in CourseLib.ColorSource.GetColors()
		select wc;
		
Console.WriteLine(q);