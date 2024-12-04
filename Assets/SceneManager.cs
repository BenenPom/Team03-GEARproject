using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject player;
    public GameObject checkpoint;

    [SerializeField]
    GameObject playerPref;

    public void Respawn()
    {
        Debug.Log("teleporting player to " + checkpoint.transform.position);
        Destroy(player);
        Instantiate(playerPref, checkpoint.transform);
    }
}
