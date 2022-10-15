<Query Kind="Statements">
  <Reference Relative="..\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\Linqpad-Esst-2856085\source\Assets\VisualStudio\CourseLib\bin\Release\netstandard2.0\CourseLib.dll</Reference>
</Query>

// include or exclude columns.

var q = from wc in CourseLib.ColorSource.GetColors()
				where wc.ColorFamily == CourseLib.ColorFamily.Orange
				select wc;
q.Dump("Big table of colors");

