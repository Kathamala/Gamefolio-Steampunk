using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    public GameObject mira;
    public GameObject player;
    private Vector3 target;

    void Start()
    {
        Cursor.visible = false;
        player = GameObject.Find("Player");
    }

    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        mira.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        //player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (Input.GetMouseButtonDown(0) && player.GetComponent<CharacterStats>().bulletCount > 0)
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            if (player.GetComponent<CharacterStats>().activeBullet == 1)
            {
                player.GetComponent<GunShots>().shotgunShot(direction, rotationZ);
            }
            if (player.GetComponent<CharacterStats>().activeBullet == 2)
            {
                player.GetComponent<GunShots>().machineGunShot(direction, rotationZ);
            }
            if (player.GetComponent<CharacterStats>().activeBullet == 3)
            {
                player.GetComponent<GunShots>().pistolShot(direction, rotationZ);
            }
            if (player.GetComponent<CharacterStats>().activeBullet == 4)
            {
                player.GetComponent<GunShots>().rocketLauncherShot(direction, rotationZ);
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && player.GetComponent<CharacterStats>().bulletCount == 0)
        {
            player.GetComponent<GunShots>().recharge(player.GetComponent<CharacterStats>().activeBullet);
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    