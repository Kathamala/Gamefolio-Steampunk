using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroy : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ExplosionArea")
        {
            Debug.Log("Explode");
            Destroy(collision.gameObject);
            GetComponent<CharacterStats>().heatlh -= 100;
            if (GetComponent<CharacterStats>().heatlh <= 0)
            {
                player.GetComponent<CharacterStats>().changeBullet(GetComponent<CharacterStats>().activeBullet);
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.tag == "Bullet")
        {
            if (collision.gameObject.GetComponent<bulletInfo>().bulletType == 4)
            {
                return;
            }

            Destroy(collision.gameObject);
            GetComponent<CharacterStats>().heatlh -= collision.GetComponent<bulletInfo>().damage;
            if (GetComponent<CharacterStats>().heatlh <= 0)
            {
                player.GetComponent<CharacterStats>().changeBullet(GetComponent<CharacterStats>().activeBullet);
                Destroy(gameObject);
            }
        }
    }
}
