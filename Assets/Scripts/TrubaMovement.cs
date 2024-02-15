using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrubaMovement : MonoBehaviour
{
    [SerializeField] private Transform obiect;
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        /*Vector2 poz;
        poz = obiect.position;
        poz.x = poz.x - _speed;
        obiect.position = poz;

        obiect.Translate(new Vector2(-_speed, 0));*/

        obiect.position += new Vector3(-_speed, 0);
    }
}