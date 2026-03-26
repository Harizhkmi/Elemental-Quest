using System;
using System.Collections.Generic;
using System.Text;

class Enemy : Character
{
	public Enemy(string name, int healthpoint, int _damage) : base(name)
	{
		healthPoint = healthpoint;
		damage = _damage;
	}
}

