using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Camera gamCam;

    private Rigidbody2D rgbd;

    public KeyCode moveLeft;
    public KeyCode moveRight;

    public float speed;

    private bool canJump = true;
    private bool playerHittingSideWall = false;

	void Start () {

        rgbd = GetComponent<Rigidbody2D>();

	}

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer() {

        //speed = speed * Time.deltaTime;

        if (Input.GetKey(moveLeft)) {

            rgbd.velocity = new Vector2(-speed, rgbd.velocity.y);

        }
        else if (Input.GetKey(moveRight)) {

            rgbd.velocity = new Vector2(speed, rgbd.velocity.y);

        }
        else {

            rgbd.velocity = new Vector2(0, rgbd.velocity.y);

        }

        if (Input.GetKeyDown("space"))
        {

            if (canJump) {

                Jump();

            }

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("ground")) {

            canJump = true;

        }

        if (collision.gameObject.CompareTag("verticalBorder")) {

            playerHittingSideWall = true;
            //transform.position = new Vector3(gamCam.ScreenToWorldPoint(new Vector3(Screen.width - 0.5f, 0, 0)).x, transform.position.y, 0);

        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("verticalBorder"))
        {

            playerHittingSideWall = false;
            //Debug.Log("Do not walk");
            //rgbd.velocity = new Vector2(0, rgbd.velocity.y);

        }

    }

    private void Jump() {

        rgbd.AddForce(new Vector2(0, 20), ForceMode2D.Impulse);
        canJump = false;

    }

    

}
