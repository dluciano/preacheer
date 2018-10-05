using System;
using UnityEngine;

namespace Core.Entity {

	public class Bible : Entity
	{
		public int SpiritualPoints 
		{
			get
			{
				switch(Type)
				{
					case BibleType.FirstBible:
						return 20;
					case BibleType.Simple:
						return 5;
					case BibleType.ReferencedBible:
						return 10;
					default:
						//TODO: Add this error message to a setting file
						throw new UnityException(@"The type of the bible is not defined");
				}
			}
		}
		
		public BibleType Type 
		{
			get;
			set;
		}
		
		public string Verse
		{
			get;
			set;
		}
		
		public enum BibleType
		{
			FirstBible,
			Simple,
			ReferencedBible,
		}
		
		public bool Visible
		{
			get
			{
				return Configuration.VisiblesBiblesType.Contains(Type);
			}
		}
	}

}