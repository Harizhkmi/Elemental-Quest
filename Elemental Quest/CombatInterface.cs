using System;
using System.Collections.Generic;
using System.Text;

public interface ICombat
{
	void Attack(Character target);
	void UseSpecialSkill(Character target);
}
