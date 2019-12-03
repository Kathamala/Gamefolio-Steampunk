using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShots : MonoBehaviour
{
    private bool canShoot = true;

    public GameObject bulletPrefab;
    public GameObject bulletStart;

    public float bulletSpeed = 600.0f;

    void Start()
    {
        bulletStart = GameObject.Find("bulletStart");
    }

    //Shotgun - 1
    public void shotgunShot(Vector2 direction, float rotationZ)
    {
        int bullets = Random.Range(5, 9);
        while (bullets > 0)
        {
            var offset = Random.Range(-2f, 2f);

            GameObject b = Instantiate(bulletPrefab) as GameObject;
            b.transform.position = bulletStart.transform.position;
            b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ + offset);
            b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed * Time.deltaTime;
            b.GetComponent<Rigidbody2D>().velocity += new Vector2(offset, offset);

            b.GetComponent<bulletInfo>().bulletType = 1;

            bullets--;
        }

        canShoot = false;
        StartCoroutine(wait(0.5f));
        GetComponent<CharacterStats>().bulletCount--;
    }

    //MachineGun - 2
    public void machineGunShot(Vector2 direction, float rotationZ)
    {
        if (!canShoot)
        {
            return;
        }

        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = bulletStart.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed * Time.deltaTime;

        b.GetComponent<bulletInfo>().bulletType = 2;
        canShoot = false;
        StartCoroutine(wait(0.1f));

        GetComponent<CharacterStats>().bulletCount--;
    }

    //Pistol - 3
    public void pistolShot(Vector2 direction, float rotationZ)
    {
        if (!canShoot)
        {
            return;
        }

        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = bulletStart.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed * Time.deltaTime;

        b.GetComponent<bulletInfo>().bulletType = 3;
        canShoot = false;
        StartCoroutine(wait(0.3f));

        GetComponent<CharacterStats>().bulletCount--;
    }

    public void recharge(int activeBullet)
    {
        if (activeBullet == 1 || activeBullet == 4)
        {
            GetComponent<CharacterStats>().bulletCount = 2;
        }
        if (activeBullet == 2)
        {
            GetComponent<CharacterStats>().bulletCount = 20;
        }
        if (activeBullet == 3)
        {
            GetComponent<CharacterStats>().bulletCount = 8;
        }
    }

    private IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        canShoot = true;
    }
}
