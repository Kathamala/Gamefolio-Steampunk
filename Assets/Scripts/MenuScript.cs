using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    //Para adicionar fases, mudar o stageAmount e colocar mais zeros na lista.
    public static int stageAmount = 5;
    static public List<int> listaFases = new List<int>(){0, 0, 0, 0, 0};
    static public int faseAtual = 0;
    int fase, i = 0, j = 0;
    bool verificador = true;

    void Start()
    {
        while(i < stageAmount)
        {
            while (listaFases[i] == 0)
            {
                fase = Random.Range(1, stageAmount+1);
                verificador = true;
                for (j=0;j<stageAmount;j++)
                {
                    if (listaFases[j] == fase)
                    {
                        verificador = false;
                        j = stageAmount;
                    }
                }
                if (verificador == true)
                {
                    listaFases[i] = fase;
                }
            }
            i++;
        }

        for (j = 0; j < stageAmount; j++)
        {
            Debug.Log(listaFases[j]);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(listaFases[faseAtual]);
            faseAtual++;
        }
    }
}
