using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public Text teksSkor;
    public Text skorAkhir;
    public GameObject gameOver;
    public AudioSource musik;
    float kekuatanLompat = 8f;
    float skor;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Rb.gravityScale = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rb.velocity = Vector2.up * kekuatanLompat;
        }

        teksSkor.text = "Skor: " + skor;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "poin")
        {
            skor++;
        }

        if (collision.gameObject.tag == "tiang")
        {
            Berhenti();
            gameOver.SetActive(true);
            skorAkhir.text = "tapi kamu udah lolos dari " + skor + " tiang listrik";
        }
    }

    void Berhenti()
    {
        Time.timeScale = 0;
        musik.Stop();
    }

    public void Lanjut()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void MenuUtama()
    {
        SceneManager.LoadScene(0);
    }
}
