using UnityEngine;

public class CombatSystem : MonoBehaviour
{

    private Random random = new Random()
	public CombatSystem()
	{
	}

    public void BasicAttack(MainCharacter attacker, MainCharacter defender) /*(implement default attack and possibly a void Skill() for skill attacks granted by skill trees) (And add type damage to skill)*/
    {
        double rng = random.NextDouble() / 2 + 0.75f;
        int randDmg = (int)(attacker.attack * rng)

        int finalDmg = Mathf.Max(1, randDmg - defender.defense);

        //defender.TakeDamage(finalDmg); Implement the TakeDamage method into maincharacter/companion/bosses classes
    }

    /*public void Block(MainCharacter defender)
    {
        defender.Block();
    } For this we need to implement a Defending method into the base class and have this here in the combat system so that they can use the block option.*/


}
