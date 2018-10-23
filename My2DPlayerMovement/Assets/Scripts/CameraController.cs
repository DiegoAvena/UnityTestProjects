using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //private Camera gameCam;

    public Transform playerTransform;
    public Rigidbody2D playerRigidBody;

    public float camSpeed = 0.5f;
    private Vector3 newPosition;

	void Start () {

        newPosition = this.transform.position;

	}

    private void LateUpdate()
    {

        CalculateNewCamPosition();

    }

    private void FixedUpdate()
    {

        //this.transform.position = newPosition;
        moveCam();

    }

    private void moveCam() {

        newPosition = playerTransform.position;
        newPosition.z = -10;
        newPosition.y = 0;
        transform.position = Vector3.Slerp(transform.position, newPosition, camSpeed);

    }

    public float GameCamXPosition() {

        return this.transform.position.x;

    }

    private void CalculateNewCamPosition() {

        /*if (playerTransform.position.x > this.transform.position.x + 2) {

            newPosition.x = this.transform.position.x + 0.058f;
           
        }
        else if (playerTransform.position.x < this.transform.position.x - 2) {

            newPosition.x = this.transform.position.x - 0.058f;

        }
        else {

            newPosition.x = this.transform.position.x;

        }*/

    }


}
