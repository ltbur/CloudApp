using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos=player.transform.position;
        transform.position=new Vector3(
            transform.position.x,
            player.transform.position.y,
            transform.position.z
        );
    }
}