using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenes : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Clicou");
            SceneManager.LoadScene(MenuScript.listaFases[MenuScript.faseAtual]);
            MenuScript.faseAtual++;
        }
    }
}
