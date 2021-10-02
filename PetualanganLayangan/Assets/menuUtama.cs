using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuUtama : MonoBehaviour
{
    public GameObject terimakasih;

    public void game()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Terimakasih()
    {
        terimakasih.SetActive(true);
    }

    public void menu()
    {
        terimakasih.SetActive(false);
    }
}
