using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Importe essa biblioteca
using UnityStandardAssets.CrossPlatformInput;

public class Flash : MonoBehaviour {

    Rigidbody2D rb;
    public float velX, velY;
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {
        //pega o movimento na horizontal
        velX = CrossPlatformInputManager.GetAxis("Horizontal");
        //pega o movimento na vertival
        velY = CrossPlatformInputManager.GetAxis("Vertical");

        if (velX < 0)
        {
            transform.localScale = new Vector2(-0.210174f, 0.3999445f);
        }
        else
        {
            transform.localScale = new Vector2(0.210174f, 0.3999445f);
        }

        //movimenta o player de acordo com os toques nos botões
        rb.velocity = new Vector2(velX * 50f, velY * 50f);
	}
}
