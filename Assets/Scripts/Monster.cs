using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    private Rigidbody2D mybody;
    private void Awake()
    {
        mybody= GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void FixedUpdate()
    {
        mybody.velocity = new Vector2(speed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
