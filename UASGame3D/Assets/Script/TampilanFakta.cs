using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TampilanFakta : MonoBehaviour
{
    public GameObject tempatSampah;
    public Text skorakhir;

    // Start is called before the first frame update
    void Update()
    {
        skorakhir.text = ""+tempatSampah.gameObject.GetComponent<GameMekanik>().skor;
    }

    public void keMenu()
    {
        SceneManager.LoadScene(0);
    }
}
