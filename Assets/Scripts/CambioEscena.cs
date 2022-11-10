using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public static CambioEscena instance;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy1"))
        {
            SceneManager.LoadScene("Nivel1");
        }

        if (other.gameObject.CompareTag("Enemy2"))
        {
            SceneManager.LoadScene("Nivel2");
        }

        if (other.gameObject.CompareTag("Enemy3"))
        {
            SceneManager.LoadScene("Nivel3");
        }

        if (other.gameObject.CompareTag("Win1"))
        {
            SceneManager.LoadScene("Nivel2");
        }

        if (other.gameObject.CompareTag("Win2"))
        {
            SceneManager.LoadScene("Nivel3");
        }

        if (other.gameObject.CompareTag("Win3"))
        {
            SceneManager.LoadScene("Creditos");
        }
    }
}