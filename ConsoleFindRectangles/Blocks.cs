﻿/// <summary>
/// This file is generated by Visual Studio 2019: Edit > Paste Special > Past JSON as Classes.
/// </summary>
namespace ConsoleFindRectangles
{
	public class Rootobject
	{
		public Block[] Blocks { get; set; }
		public override string ToString() => $" gym, school, store";

	}

	public class Block
	{
		public bool Gym { get; set; }
		public bool School { get; set; }
		public bool Store { get; set; }
		public override string ToString() => $"{Gym}, {School}, {Store}";
	}
}