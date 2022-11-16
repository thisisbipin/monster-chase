using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    [SerializeField]
    private float minX, maxX;


    // Start is called before the first frame update
    void Start()
    {
        player= GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!player) return;
        Vector3 currpos = transform.position;
        currpos.x = player.position.x;

        if (currpos.x < minX)
            currpos.x = minX;
        else if (currpos.x > maxX)
            currpos.x = maxX; 
        transform.position = currpos;
     }
}
