using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject bg;
    public GameObject about;
   
    // Start is called before the first frame update
    void Start()
    {
        bg.SetActive(true);
        about.SetActive(false);
    }

    public void playClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void aboutClicked()
    {
        bg.SetActive(false);
        about.SetActive(true);
    }

    public void exitClicked()
    {
        Application.Quit();
    }

    public void backClicked()
    {
        bg.SetActive(true);
        about.SetActive(false);
        
    }

   
}
