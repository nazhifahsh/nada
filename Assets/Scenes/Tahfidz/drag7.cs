﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag7 : MonoBehaviour
{
    [SerializeField]
    private Transform bearPlace;

    private Vector2 initialPosition;

    private float deltaX, deltaY;

    public static bool yay = false;

    void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && yay == false)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;

                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    }
                    break;
                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - bearPlace.position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - bearPlace.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(bearPlace.position.x, bearPlace.position.y);

                        yay = true;
                    }
                    else
                    {
                        transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    }
                    break;
            }
        }
    }
}
