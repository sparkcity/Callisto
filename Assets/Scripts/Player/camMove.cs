using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour
{

    public Transform player;
    public float smooth;

    // Start is called before the first frame update
    void Start()
    {

    }

    void LateUpdate()
    {
        if(transform.position != player.position)
        {
            Vector3 playerPosition = new Vector3(
                player.position.x,
                player.position.y, 
                transform.position.z);
            transform.position = Vector3.Lerp(
                transform.position,
                playerPosition,
                smooth);
        }
    }
}
