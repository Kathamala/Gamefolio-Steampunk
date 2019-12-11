using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private bool check = false;

    private Vector3 target;
    public Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        target = new Vector3(player.position.x, player.position.y, player.position.z);

        Vector3 difference = target - transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        float distance = difference.magnitude;
        Vector2 direction = difference / distance;
        direction.Normalize();

        if (check)
        {
            return;
        }

        check = true;
        if (GetComponent<CharacterStats>().activeBullet == 1)
        {
            GetComponent<GunShots>().shotgunShot(direction, rotationZ);
        }
        if (GetComponent<CharacterStats>().activeBullet == 2)
        {
            GetComponent<GunShots>().machineGunShot(direction, rotationZ);
        }
        if (GetComponent<CharacterStats>().activeBullet == 3)
        {
            GetComponent<GunShots>().pistolShot(direction, rotationZ);
        }
        if (GetComponent<CharacterStats>().activeBullet == 4)
        {
            GetComponent<GunShots>().rocketLauncherShot(direction, rotationZ);
        }

        StartCoroutine(checkCO());
    }

    private IEnumerator checkCO()
    {
        if (GetComponent<CharacterStats>().activeBullet == 1)
        {
            yield return new WaitForSeconds(1f);
        }
        if (GetComponent<CharacterStats>().activeBullet == 2)
        {
            yield return new WaitForSeconds(0.2f);
        }
        if (GetComponent<CharacterStats>().activeBullet == 3)
        {
            yield return new WaitForSeconds(0.6f);
        }
        if (GetComponent<CharacterStats>().activeBullet == 4)
        {
            yield return new WaitForSeconds(3f);
        }

        check = false;
    }
}
