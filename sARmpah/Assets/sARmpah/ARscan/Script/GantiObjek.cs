using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GantiObjek : MonoBehaviour
{
    public GameObject[] sampah =  new GameObject[3];

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == this.transform)
                {
                    if (sampah[0].activeSelf)
                    {
                        sampah[0].SetActive(false);
                        sampah[1].SetActive(true);
                    }
                    else if (sampah[1].activeSelf)
                    {
                        sampah[1].SetActive(false);
                        sampah[2].SetActive(true);
                    }
                    else if (sampah[2].activeSelf)
                    {
                        sampah[2].SetActive(false);
                        sampah[0].SetActive(true);
                    }
                }
            }
        }
    }
}
