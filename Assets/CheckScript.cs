using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class CheckScript : MonoBehaviour
{
    [SerializeField]
    GameObject manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("hit checkpoint");
            manager.GetComponent<SceneManager>().checkpoint = this.gameObject;
        }
    }
}
