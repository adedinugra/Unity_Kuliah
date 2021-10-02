using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject tiang;
    List<GameObject> listTiang;
    int jumlahTiang;
    float waktu;
    float durasi;

    // Start is called before the first frame update
    void Start()
    {
        listTiang = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        waktu -= Time.deltaTime;
        if (waktu <= 0)
        {
            jumlahTiang++;
            TingkatKesulitan();
            PanggilTiang();
            waktu = durasi;
        }
        HapusTiang();
    }

    void PanggilTiang()
    {
        GameObject a = Instantiate(tiang, transform.position, Quaternion.identity);
        listTiang.Add(a);
    }

    void TingkatKesulitan()
    {
        if (jumlahTiang >= 30) //Mustahil
        {
            durasi = 0.5f;
        }
        else if (jumlahTiang >= 20) //Sulit
        {
            durasi = 1.0f;
        }
        else if (jumlahTiang >= 10) //Sedang
        {
            durasi = 1.5f;
        }
        else //Mudah
        {
            durasi = 2.0f;
        }
    }

    void HapusTiang()
    {
        for (int i = 0; i < listTiang.Count; i++)
        {
            GameObject a = listTiang[i];
            if (a.transform.position.x < -10f)
            {
                Destroy(a.gameObject);
                listTiang.Remove(a);
                i--;
            }
        }
    }
}
