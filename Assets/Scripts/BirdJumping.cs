using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BirdJumping : MonoBehaviour
{
   [SerializeField] private Rigidbody2D _bird;
   [SerializeField] private float _speed;

   public Rigidbody2D Bird()
   {
      return _bird;
   }

   private void Update()
   {
      //Vector2 velocity;
      if (Input.GetKeyDown(KeyCode.Space))
      {
         //velocity = _bird.velocity;
         //velocity.y = _speed;
         //_bird.velocity = velocity;

         _bird.velocity = new Vector2(0, _speed);
      }
   }
}
