using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    static public List<int> listaFases = new List<int>(){0, 0, 0, 0, 0};
    static public int faseAtual = 0;
    int fase, i = 0, j = 0;
    bool verificador = true;

    void Start()
    {
        while(i < 5)
        {
            while (listaFases[i] == 0)
            {
                fase = Random.Range(1, 6);
                verificador = true;
                for (j=0;j<5;j++)
                {
                    if (listaFases[j] == fase)
                    {
                        verificador = false;
                        j = 5;
                    }
                }
                if (verificador == true)
                {
                    listaFases[i] = fase;
                }
            }
            i++;
        }

        for (j = 0; j < 5; j++)
        {
            Debug.Log(listaFases[j]);
        }
    }
}
