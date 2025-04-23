using UnityEngine;

public class MainCharacter : MonoBehaviour
{

    public class Stats //plug in hp, mp (used for skills), etc.
    {
        public int hp; //have it scale with player lvl and skill tree point allocation
        public int mp; //same as hp, different skill tree point allocation
                       //check with group to see what else to add for this

        public Stats(int health, int mana)
        {
            hp = health; //add the lvl bump and skill tree bump (if any)
            mp = mana; //add the lvl bump and skill tree bump (if any)
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

    //void Attack() (implement default attack and possibly a void Skill() for skill attacks granted by skill trees) (And add type damage to skill)
}
