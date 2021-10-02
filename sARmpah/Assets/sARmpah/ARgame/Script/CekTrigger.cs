using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CekTrigger : MonoBehaviour
{
    public bool cek;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.transform.position.y - this.gameObject.transform.position.y) < 0)
        {
            this.gameObject.GetComponent<CekTrigger>().cek = true;
            //Debug.Log(cek);
        }
    }
}
