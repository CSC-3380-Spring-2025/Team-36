using UnityEngine;

public class MainCharacter : MonoBehaviour
{

    private class Stats //plug in hp, mp (used for skills), etc.
    {
        private int hp; //have it scale with player lvl and skill tree point allocation
        private int mp; //same as hp, different skill tree point allocation
        private Random random; //check with group to see what else to add for this
        private int baseAttack;

        public Stats(int health, int mana, int baseAttack)
        {
            this.hp = health; //add the lvl bump and skill tree bump (if any)
            this.mp = mana; //add the lvl bump and skill tree bump (if any)
            this.baseAttack = baseAttack;
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void Movement() (implement this when movement gets done)

    //void Inventory() (inventory system)

    public void Attack(MainCharacter basic_Attack) /*(implement default attack and possibly a void Skill() for skill attacks granted by skill trees) (And add type damage to skill)*/
    {
        double rng = random.NextDouble();
        rng = rng / 2 + 0.75f;
        int randDamage = (int)(baseAttack * rng)
    } 
}
