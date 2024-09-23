using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcuraPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public CinemachineVirtualCamera virtualCamera;


    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player");
        virtualCamera.Follow = player.transform;
    }
}
