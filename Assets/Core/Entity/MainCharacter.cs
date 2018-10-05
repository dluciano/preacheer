using UnityEngine;
using System;

namespace Core.Entity {

	public class MainCharacter : Entity
	{
		public string Name 
		{
			get;
			set;
		}
		
		private int spiritualPoints;
		
		public int SpitualPoints 
		{
			get
			{
				return spiritualPoints;
			}
			
			set
			{
				spiritualPoints = value <= MaximunSpiritualPoints ? value: spiritualPoints;
			}
		}
		
		public int MaximunSpiritualPoints
		{
			get;
			set;
		}
	}
		
}
