using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderManager : MonoBehaviour {

    public BoxCollider2D leftBorder;
    public BoxCollider2D rightBorder;
    public BoxCollider2D bottomBorder;
    public BoxCollider2D topBorder;

    public Camera gameCam;

    private void Start()
    {

        SetBorders();

    }

    private void Update()
    {

        SetBorders();

    }

    public void SetBorders() {

        leftBorder.offset = new Vector2(gameCam.ScreenToWorldPoint(new Vector3(-0.5f, 0, 0)).x, 0);
        rightBorder.offset = new Vector2(gameCam.ScreenToWorldPoint(new Vector3(Screen.width + 0.5f, 0, 0)).x, 0);
        topBorder.offset = new Vector2(0, gameCam.ScreenToWorldPoint(new Vector3(0, Screen.height + 0.5f, 0)).y);
        bottomBorder.offset = new Vector2(0, gameCam.ScreenToWorldPoint(new Vector3(0, -0.5f, 0)).y);

    }

}
