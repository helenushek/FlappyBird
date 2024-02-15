using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthDeath : MonoBehaviour
{
    [SerializeField] GameObject Loseorwin;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Prepyatstvie")
        {
            // активируем обьект
            Loseorwin.SetActive(true);
            

            // FindObjectOfType<BirdJumping>() - поиск обьекта с компонентом BirdJumping
            // .enabled - поле, отвечающее за включенность обьекта
            // = false - деактивируем компонент
            FindObjectOfType<BirdJumping>().enabled = false;
            FindObjectOfType<TrubaMovement>().enabled = false;
            FindObjectOfType<Genirating>().enabled = false;
            FindObjectOfType<BirdJumping>().Bird().constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}