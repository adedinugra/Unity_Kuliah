using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TampilanFakta : MonoBehaviour
{
    public Image randomImage;
    public Sprite[] images = new Sprite[10];
    public GameObject tempatSampah;

    // Start is called before the first frame update
    void Update()
    {
        randomImage.sprite = images[tempatSampah.gameObject.GetComponent<GameMekanik>().randomFakta];
    }
}
