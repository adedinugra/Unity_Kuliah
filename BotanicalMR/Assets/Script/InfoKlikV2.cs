using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoKlikV2 : MonoBehaviour
{
    public GameObject infoklik;
    public Image gambar;
    public Text informasi;
    public Transform[] target = new Transform[6];
    public Sprite[] foto = new Sprite[6];
    public string[] info = new string[6];

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform == target[0])
                {
                    informasi.text = info[0];
                    gambar.sprite = foto[0];
                }
                else if (hit.transform == target[1])
                {
                    informasi.text = info[1];
                    gambar.sprite = foto[1];
                }
                else if (hit.transform == target[2])
                {
                    informasi.text = info[2];
                    gambar.sprite = foto[2];
                }
                else if (hit.transform == target[3])
                {
                    informasi.text = info[3];
                    gambar.sprite = foto[3];
                }
                else if (hit.transform == target[4])
                {
                    informasi.text = info[4];
                    gambar.sprite = foto[4];
                }
                else if (hit.transform == target[5])
                {
                    informasi.text = info[5];
                    gambar.sprite = foto[5];
                }
                infoklik.SetActive(true);
            }
        }
    }

    public void sembunyiInfoKlik()
    {
        infoklik.SetActive(false);
    }
}
