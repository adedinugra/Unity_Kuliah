using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoKlik : MonoBehaviour
{

    public Transform target1;
    public Texture gambar1, gambar2, gambar3;
    public string info1, info2, info3;
    public Vector2 scrollPosition1 = Vector2.zero;
    public bool show = false;
    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform == target1)
                {
                    show = true;
                }
            }
        }
    }

    public void tampil()
    {
        show = false;
    }

    void OnGUI()
    {
        if (show == true)
        {
            GUI.BeginGroup(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 250, 800, 500));
            GUI.Box(new Rect(0, 50, 405, 360), "Informasi");

            scrollPosition1 = GUI.BeginScrollView(new Rect(30, 0, 350, 390), scrollPosition1, new Rect(0, 0, 1150, 200));

            GUI.DrawTexture(new Rect(0, 90, 350, 210), gambar1);
            info1 = GUI.TextArea(new Rect(0, 300, 350, 50), info1, 200);

            GUI.DrawTexture(new Rect(400, 90, 350, 210), gambar2);
            info2 = GUI.TextArea(new Rect(400, 300, 350, 50), info2, 200);

            GUI.DrawTexture(new Rect(800, 90, 350, 210), gambar3);
            info3 = GUI.TextArea(new Rect(800, 300, 350, 50), info3, 200);

            GUI.EndScrollView();
            GUI.EndGroup();
        }
    }

}
