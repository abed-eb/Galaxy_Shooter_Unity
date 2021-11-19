using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Access to the player
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                //Enable TripleShot
                player.TripleShotPowerupOn();
            }
            //Destroy TripleShot Powerup
            Destroy(this.gameObject);
        }
    }
}
