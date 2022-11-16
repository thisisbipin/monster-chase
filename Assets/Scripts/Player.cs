using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float moveForce=10;
    
    [SerializeField]
    public float jumpForce = 10;

    private float movementX;
    private Rigidbody2D mybody;
    private SpriteRenderer sr;
    private Animator anim;

    private bool isGrounded = true;
    public static bool isdead = false;

    private string WALK_ANIMATION = "walk";
    private string GROUND_TAG = "Ground";
    private string ENEMY = "Enemy";
    
    
    
    private void Awake()
    {
        mybody= GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
        sr= GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        isdead= false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        PlayerJump();
    }
    private void FixedUpdate()
    {
    }
    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0, 0)*Time.deltaTime*moveForce;
    }
    void AnimatePlayer()
    {
        if(movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;

        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }
    void PlayerJump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            mybody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;
        }
        if(collision.gameObject.CompareTag(ENEMY))
        {
            Destroy(gameObject);
            isdead = true;
        }
    }
}
