using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMekanik : MonoBehaviour
{
    public GameObject[] tong = new GameObject[3];
    public GameObject[] benar = new GameObject[3];
    public GameObject[] salah = new GameObject[3];
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
        if (tong[0].gameObject.GetComponent<CekTrigger>().cek)
        {
            if (collider.gameObject.CompareTag("organik"))
            {
                StartCoroutine(Benar(0));
                skor++;
                teksskor.text = "" + skor;
                Debug.Log(skor);
                NyawaBertambah();
                Destroy(collider.gameObject);
                tong[0].gameObject.GetComponent<CekTrigger>().cek = false;
            }
            else if (collider.gameObject.CompareTag("anorganik") || collider.gameObject.CompareTag("b3")) 
            {
                StartCoroutine(Salah(0));
                NyawaBerkurang();
                Destroy(collider.gameObject);
                tong[0].gameObject.GetComponent<CekTrigger>().cek = false;
            }
        }
        else if (tong[1].gameObject.GetComponent<CekTrigger>().cek)
        {
            if (collider.gameObject.CompareTag("anorganik"))
            {
                StartCoroutine(Benar(1));
                skor++;
                teksskor.text = "" + skor;
                Debug.Log(skor);
                NyawaBertambah();
                Destroy(collider.gameObject);
                tong[1].gameObject.GetComponent<CekTrigger>().cek = false;
            }
            else if (collider.gameObject.CompareTag("organik") || collider.gameObject.CompareTag("b3"))
            {
                StartCoroutine(Salah(1));
                NyawaBerkurang();
                Destroy(collider.gameObject);
                tong[1].gameObject.GetComponent<CekTrigger>().cek = false;
            }
        }
        else if (tong[2].gameObject.GetComponent<CekTrigger>().cek)
        {
            if (collider.gameObject.CompareTag("b3"))
            {
                StartCoroutine(Benar(2));
                skor++;
                teksskor.text = "" + skor;
                Debug.Log(skor);
                NyawaBertambah();
                Destroy(collider.gameObject);
                tong[2].gameObject.GetComponent<CekTrigger>().cek = false;
            }
            else if (collider.gameObject.CompareTag("organik") || collider.gameObject.CompareTag("anorganik"))
            {
                StartCoroutine(Salah(2));
                NyawaBerkurang();
                Destroy(collider.gameObject);
                tong[2].gameObject.GetComponent<CekTrigger>().cek = false;
            }
        }
        else if (lantai.gameObject.GetComponent<CekTrigger>().cek)
        {
            Debug.Log(lantai.gameObject.GetComponent<CekTrigger>().cek);
            if (collider.gameObject.CompareTag("organik") || collider.gameObject.CompareTag("anorganik") || collider.gameObject.CompareTag("b3"))
            {
                NyawaBerkurang();
                lantai.gameObject.GetComponent<CekTrigger>().cek = false;
                Debug.Log(lantai.gameObject.GetComponent<CekTrigger>().cek);
            }
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

    IEnumerator Benar(int i)
    {
        benar[i].SetActive(true);
        yield return new WaitForSeconds(2);
        benar[i].SetActive(false);
    }

    IEnumerator Salah(int i)
    {
        salah[i].SetActive(true);
        yield return new WaitForSeconds(2);
        salah[i].SetActive(false);
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
