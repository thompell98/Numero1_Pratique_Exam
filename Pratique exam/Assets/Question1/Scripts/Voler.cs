using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voler : MonoBehaviour {

    public float speed;

    public Rigidbody avion;
    public ParticleSystem fumee;

	void Start () {
        avion = GetComponent<Rigidbody>();
    }
	
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        avion.AddForce(movement * speed);
        PivoterHelice();

        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Vertical") > 0)
        {
            if (!fumee.isEmitting)
            {
                fumee.Play();
            }
        }
        else
        {
            print("test");
            fumee.Stop();
        }
    }

    void PivoterHelice()
    {

    }
}
