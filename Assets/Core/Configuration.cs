using System.Collections.Generic;
using Core.Entity;

namespace Core {
	
	public static class Configuration
	{
		public const string PlayerName = @"John";
		public static readonly List<Bible.BibleType> VisiblesBiblesType = new List<Bible.BibleType>(){ Bible.BibleType.FirstBible };
	}
	
}
