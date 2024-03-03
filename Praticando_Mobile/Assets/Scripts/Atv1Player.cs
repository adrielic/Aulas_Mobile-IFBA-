using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atv1Player : MonoBehaviour
{
    private float deltaX, deltaY, jumpForce = 5f;
    private bool onGround, allowDoubleJump, isFlying;
    private Touch touch;
    private Rigidbody2D rb;
    private Animator anim;
    public GameObject projectile;
    private float acmlPressure;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
        Jump();
    }

    void Movement()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            touch = Input.GetTouch(i);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    deltaX = touchPos.x - transform.position.x;
                    deltaY = touchPos.y - transform.position.y;
                    acmlPressure = 0;
                    break;
                case TouchPhase.Moved:
                    isFlying = true;
                    anim.SetBool("isJumping", false);
                    anim.SetBool("isFlying", true);
                    rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
                    rb.gravityScale = 0;
                    break;
                case TouchPhase.Ended:
                    anim.SetBool("isFlying", false);
                    isFlying = false;
                    rb.gravityScale = 1;

                    if (acmlPressure >= 1)
                    {
                        Instantiate(projectile, transform.position, transform.rotation);
                        acmlPressure = 0;
                    }
                    break;
                case TouchPhase.Stationary:
                    if (onGround)
                    {
                        acmlPressure += touch.pressure * Time.deltaTime;
                    }

                    if (isFlying)
                        rb.velocity = Vector2.zero;
                    break;
            }

            Debug.Log("tapCount = " + touch.tapCount);
            Debug.Log("acmlPressure = " + (int)acmlPressure);
        }
    }

    void Jump()
    {
        if (Input.touchCount > 0)
        {
            if (touch.phase == TouchPhase.Began)
            {
                if (onGround)
                {
                    anim.SetBool("isJumping", true);
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                    allowDoubleJump = true;
                    Debug.Log("pulo");
                }

                if (allowDoubleJump && touch.tapCount == 2)
                {
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                    allowDoubleJump = false;
                    Debug.Log("pulo duplo");
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            onGround = true;
            allowDoubleJump = false;
            anim.SetBool("isJumping", false);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }
    }
}
