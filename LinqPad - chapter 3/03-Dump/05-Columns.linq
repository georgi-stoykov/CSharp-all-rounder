<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">F:\0. Repos\CSharp-all-rounder\LinqPad - chapter 3\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// include or exclude columns.

var q = from wc in CourseLib.ColorSource.GetColors()
				where wc.ColorFamily == CourseLib.ColorFamily.Orange
				select wc;
//q.Dump("Big table of colors", exclude: "HSL, RedPercent");

q.Dump(include: "ColorName, HexValue");

