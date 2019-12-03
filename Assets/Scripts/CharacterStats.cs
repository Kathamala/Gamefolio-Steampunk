using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int bulletCount = 0;
    public float heatlh;
    public int attack;
    public int defense;
    public int activeBullet;
    public float speed;

    public void changeBullet(int newBullet)
    {
        activeBullet = newBullet;

        if (activeBullet == 1 || activeBullet == 4)
        {
            bulletCount = 2;
        }
        if (activeBullet == 2)
        {
            bulletCount = 20;
        }
        if (activeBullet == 3)
        {
            bulletCount = 8;
        }
    }
}
