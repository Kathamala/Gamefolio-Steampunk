using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAreaDestroy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(destroyExplosion());
    }

    private IEnumerator destroyExplosion()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
