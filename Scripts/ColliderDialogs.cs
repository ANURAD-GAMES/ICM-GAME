using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDialogs : MonoBehaviour
{
    public GameObject TreeText;
    public GameObject Collider;
    public GameObject Player;


    private void OnTriggerStay2D(Collider2D other)
    {
        TreeText.SetActive(true);
        Player.SetActive(false);
    }

    public void TfeeOff()
    {
        Collider.SetActive(false);
        Player.SetActive(true);
        
    }
}
