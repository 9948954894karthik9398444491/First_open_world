using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orb : MonoBehaviour
{
    public AudioClip collect;
    public plater player;
    // Start is called before the first frame update
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FirstPersonController").GetComponent< plater > ();
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.name == "FirstPersonController")
        {
            player.a += 1;
            player.players.PlayOneShot(collect);
            Destroy(gameObject);
        }
    }
}
