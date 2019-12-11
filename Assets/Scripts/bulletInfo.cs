using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletInfo : MonoBehaviour
{
    public float damage = 10f;
    public int bulletType = 0; //1- Shotgun, 2- MachineGun, 3- Pistol, 4- RocketLauncher;

    private void Update()
    {
        if (bulletType == 1)
        {
            damage = 15;
        }
        if (bulletType == 2)
        {
            damage = 5;
        }
        if (bulletType == 3)
        {
            damage = 10;
        }
        if (bulletType == 4)
        {
            damage = 0;
        }
    }
}
