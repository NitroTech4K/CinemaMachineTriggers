using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillFloor : MonoBehaviour
{
    public GameObject player;
    public GameObject respawn_point;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("SampleScene");
    }
}