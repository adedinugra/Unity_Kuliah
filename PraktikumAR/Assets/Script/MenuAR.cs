using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAR : MonoBehaviour
{
    //Membuat variable untuk resize layar
    public GUISkin guiSkin;
    private float guiRatio;
    private float sWidth;
    private Vector3 GUIsF;

    public GameObject bumi;
    public float kecepatanRotasi = 50f;
    bool statusRotasi = false;

    void Awake()
    {
        sWidth = Screen.width;
        guiRatio = sWidth / 1920;
        GUIsF = new Vector3(guiRatio, guiRatio, 1);
    }

    private void OnGUI()
    {
        GUI.skin = guiSkin;
        //letakkan function disini
        Rotasi();

        void Rotasi()
        {
            //meletakkan button di pojok kanan atas
            GUI.matrix = Matrix4x4.TRS(new Vector3(GUIsF.x, GUIsF.y, 0), Quaternion.identity, GUIsF);

            if (statusRotasi == false)
            {
                if (GUI.Button(new Rect(50, 50, 700, 300), "Rotasi"))
                {
                    statusRotasi = true;
                }
            }
            else
            {
                if (GUI.Button(new Rect(50, 50, 700, 300), "Stop Rotasi"))
                {
                    statusRotasi = false;
                }
            }

            if (GUI.Button(new Rect(800, 50, 700, 300), "Keluar"))
            {
                Application.Quit(); //Keluar dari aplikasi
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (statusRotasi == true)
        {
            bumi.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
        }
    }
}