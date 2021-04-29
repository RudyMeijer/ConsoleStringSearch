using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleFindRectangles
{
	class Program
	{
		// comment 1
		static void Main(string[] args)
		{
			//List<Point> coordinates = new() { new(1, 1), new(2, 1), new(3, 1), new(1, 2), new(2, 2), new(3, 2) };
			//ConsoleFindRectangles(coordinates);
			LoadJSONObject();
		}
		public SerialPort OpenPort1(string portName)
		{
			SerialPort port = new(portName);
			port.Open();  //CA2000 fires because this might throw
			SomeMethod(); //Other method operations can fail
			return port;
		}

		private void SomeMethod()
		{
			throw new NotImplementedException();
		}

		private static void LoadJSONObject()
		{
			var options = new JsonSerializerOptions
			{
				WriteIndented = true,
				PropertyNameCaseInsensitive = true
			};
			var blocks = JsonSerializer.Deserialize<Rootobject>(File.ReadAllText("blocks.json"),options).Blocks;
			for (int i = 0; i < blocks.Length; i++)
			{
				Console.WriteLine($"block {i}: {minDistance(i, blocks)}");
			}
		}
		/// <summary>
		/// This method computes the minimal distance from a block to gym + school + store.
		/// </summary>
		/// <param name="i"></param>
		/// <param name="blocks"></param>
		/// <returns></returns>
		private static int minDistance(int i, Block[] blocks)
		{
			var mingymdistance = 9;
			var minschooldistance = 9;
			var minstoredistance = 9;
			for (int j = 0; j < blocks.Length; j++)
			{
				if (blocks[j].Gym) mingymdistance = Math.Min(Math.Abs(i - j), mingymdistance);
				if (blocks[j].School) minschooldistance = Math.Min(Math.Abs(i - j), minschooldistance);
				if (blocks[j].Store) minstoredistance = Math.Min(Math.Abs(i - j), minstoredistance);
			}
			return mingymdistance + minschooldistance + minstoredistance;
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
