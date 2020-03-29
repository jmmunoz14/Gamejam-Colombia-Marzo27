﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainThird : MonoBehaviour
{
    [SerializeField]
    private Animator animation;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "book")
        {
            animation = GetComponent<Animator>();
            animation.Play("book fall2");
        }
        else
        {
            Debug.Log("no hay collision");
        }
    }
}