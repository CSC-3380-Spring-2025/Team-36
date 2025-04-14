using UnityEngine;

public class FinalBoss_ : MonoBehaviour
{

    public class Stats //plug in hp, mp (used for skills), etc.
    {
        public int hp; //have a base hp amount that changes depending on difficulty level
        public int mp; //have a base mp amount that changes depending on difficulty level (allowing for more skill attacks)
                       //most likely will add resistances and weaknesses to this

        public Stats(int health, int mana)
        {
            hp = health; //multiply by difficulty (1x normal, 1.5x hard, 2.5 or 3x for extreme mode)
            mp = mana; //multiply by difficulty (1x normal, 1.5x hard, 2.5 or 3x for extreme mode)
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

    // void Attack() (Default skilless attack)
    // void Skills() (Around 3-4 set skills that do a certain damage type)

    //implement a sort of second phase? Perhaps.
}
