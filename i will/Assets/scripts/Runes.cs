using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runes : MonoBehaviour
{
    public plater player;
    public int req = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FirstPersonController").GetComponent<plater>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FirstPersonController")
        {
            if (player.a>=req)
            {
                player.ends();
            }
           
            
        }
    }
}

    // Update is called once per frame
 
