using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public Camera cameraToFollow;

    private void StayWithCamera() {

        this.transform.position = new Vector3(cameraToFollow.transform.position.x, this.transform.position.y, 0);

    }

    private void LateUpdate()
    {

        StayWithCamera();

    }
}
