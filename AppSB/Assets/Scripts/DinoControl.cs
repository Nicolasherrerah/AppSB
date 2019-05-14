using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class DinoControl : MonoBehaviour {

	Animator anim;
	Rigidbody2D rb;
	[SerializeField]
	float jumpForce = 0.5f;
	float upOrDown;
    public bool isGrounded;
    public LayerMask ground;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x, transform.position.y - 0.90f), new Vector2(0.8f, 0.1f), ground);
        Debug.Log(transform.position.x);

        if (GameControl.gameStopped != true) {

            //jump(rb, jumpForce);
			upOrDown = CrossPlatformInputManager.GetAxisRaw ("Vertical");
            if (upOrDown > 0 && rb.velocity.y == 0)
            {
                rb.AddForce(Vector2.up * jumpForce);
                SoundManagerScript.PlaySound("jump");
            }
			if (upOrDown < 0 && rb.velocity.y == 0)
				anim.SetBool ("isDown", true);
			else
				anim.SetBool ("isDown", false);
		}
	}

    public void jump(){
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
            SoundManagerScript.PlaySound("jump");
        }
        
    }
    public void duck()
    {
        rb.AddForce(Vector2.down * jumpForce);
        //SoundManagerScript.PlaySound("jump");
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(new Vector2(transform.position.x, transform.position.y - 0.90f), new Vector2(0.8f, 0.1f));
    }


}
