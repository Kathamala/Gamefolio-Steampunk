using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Door : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Passou");
            if (MenuScript.faseAtual == MenuScript.stageAmount)
            {
                SceneManager.LoadScene("Conclusion");
            }
            else
            {
                SceneManager.LoadScene(MenuScript.listaFases[MenuScript.faseAtual]);
                MenuScript.faseAtual++;
            }
        }
    }
}
