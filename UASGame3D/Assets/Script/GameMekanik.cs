using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMekanik : MonoBehaviour
{
    public GameObject keranjang;
    public GameObject benar;
    public GameObject salah;
    public GameObject[] nyawa = new GameObject[5];
    public GameObject lantai;
    public GameObject gameover;
    public int hp;
    public Text teksskor;
    public int skor;
    public int randomFakta;

    private void Start()
    {
        hp = 4;
        skor = 0;
        teksskor.text = "" + skor;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("jaring") && lantai.gameObject.GetComponent<CekTrigger>().cek)
        {
            StartCoroutine(Salah());
            NyawaBerkurang();
            lantai.gameObject.GetComponent<CekTrigger>().cek = false;
            Debug.Log(lantai.gameObject.GetComponent<CekTrigger>().cek);
        }
        else if (collider.gameObject.CompareTag("jaring"))
        {
            StartCoroutine(Benar());
            skor++;
            teksskor.text = "" + skor;
            Debug.Log(skor);
            NyawaBertambah();
            Destroy(collider.gameObject);
        }
        
    }

    private void NyawaBerkurang()
    {
        if (hp >= 0)
        {
            nyawa[hp].SetActive(false);
            hp--;
        }
        else if (hp < 0)
        {
            randomFakta = UnityEngine.Random.Range(0, 10);
            gameover.SetActive(true);

        }
    }

    private void NyawaBertambah()
    {
        if (hp < 4)
        {
            hp++;
            nyawa[hp].SetActive(true);
        }
    }

    IEnumerator Benar()
    {
        benar.SetActive(true);
        yield return new WaitForSeconds(2);
        benar.SetActive(false);
    }

    IEnumerator Salah()
    {
        salah.SetActive(true);
        yield return new WaitForSeconds(2);
        salah.SetActive(false);
    }

    public void ResetGame()
    {
        for(int i=0; i<nyawa.Length; i++)
        {
            nyawa[i].SetActive(true);
        }
        hp = 4;
        skor = 0;
        teksskor.text = "" + skor;
        gameover.SetActive(false);
    }
}
