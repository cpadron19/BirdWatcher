using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdWatcher.Models
{
	public class Spotted
	{
		public int id { get; set; }
		public User Spotter { get; set; }
		public Bird SpottedBird { get; set; }
		public int QuantitySpotted { get; set; }

		public DateTime DateSpotted { get;}

	}
}
