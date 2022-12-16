using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plater : MonoBehaviour
{
    public int a=0;
    public AudioSource players;
    public AudioClip final;
    public Image end;
    // Start is called before the first frame update
    void Start()
    {
        end.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ends()
    {
        players.PlayOneShot(final);
        end.gameObject.SetActive(true);
    }
}
