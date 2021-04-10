using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleFindRectangles
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Point> coordinates = new() { new(1, 1), new(2, 1), new(3, 1), new(1, 2), new(2, 2), new(3, 2) };
			ConsoleFindRectangles(coordinates);
		}
		/// <summary>
		/// Find rectangles in coordinates.
		/// </summary>
		/// <param name="coordinates"></param>
		private static void ConsoleFindRectangles(List<Point> coordinates)
		{
			foreach (var P0 in coordinates)
			{
				// get points with same X-coor.
				foreach (var P1 in coordinates) if (P1.X == P0.X && P1.Y > P0.Y)
					{
						foreach (var P2 in coordinates) if (P2.Y == P1.Y && P2.X > P1.X)
							{
								foreach (var P3 in coordinates) if (P3.X == P2.X && P3.Y == P0.Y)
									{
										Console.WriteLine($"Rectangle at: {P0} {P1} {P2} {P3}");
									}
							}
					}
			}
		}
	}
}
