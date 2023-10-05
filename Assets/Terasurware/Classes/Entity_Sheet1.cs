using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Entity_Sheet1 : ScriptableObject
{	
	public List<Sheet> sheets = new List<Sheet> ();

	[System.SerializableAttribute]
	public class Sheet
	{
		public string name = string.Empty;
		public List<Param> list = new List<Param>();
	}

	[System.SerializableAttribute]
	public class Param
	{
		
		public int index;
		public string charaterName;
		public int hp;
		public int mp;
	}
}

