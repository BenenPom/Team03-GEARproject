using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class BoundsScript : MonoBehaviour
{
    [SerializeField]
    GameObject manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("player fell");
            manager.GetComponent<SceneManager>().Respawn();
        }
    }
}
