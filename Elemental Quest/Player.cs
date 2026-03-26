using System;
using System.Collections.Generic;
using System.Text;

class Player : Character
{
	private int Gold;
	public Inventory Inventory { get; private set; }
	public Player(string name) : base(name) // calls Character constructor
	{
		Gold = 100;
		Inventory = new Inventory();
	}

	public int gold
	{
		get { return Gold; }
		set { Gold = value; }
	}

}

