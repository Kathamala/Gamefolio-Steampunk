using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public float heatlh;
    public int attack;
    public int defense;
    public int activeBullet;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeBullet(int newBullet)
    {
        activeBullet = newBullet;
    }
}
