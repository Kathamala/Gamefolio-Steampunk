using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroy : MonoBehaviour
{
    float distanceTravelled = 0;
    Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    private void Update()
    {
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        Debug.Log(distanceTravelled);

        //Destruir pelo alcance
        if (GetComponent<bulletInfo>().bulletType == 1 && distanceTravelled >= 3)
        {
            Destroy(gameObject);
        }
        if (GetComponent<bulletInfo>().bulletType == 2 && distanceTravelled >= 7)
        {
            Destroy(gameObject);
        }
        if (GetComponent<bulletInfo>().bulletType == 3 && distanceTravelled >= 8)
        {
            Destroy(gameObject);
        }
        if (GetComponent<bulletInfo>().bulletType == 4 && distanceTravelled >= 6)
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
