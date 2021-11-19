using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    [SerializeField] private int powerupID; //0: TripleShot 1: Speed boost
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
                if (powerupID == 0 )
                {
                    //Enable TripleShot
                    player.TripleShotPowerupOn();
                }

                if (powerupID == 1)
                {
                    //Enable speed boost
                    player.SpeedBoostPowerupOn();
                }
                
            }
            //Destroy TripleShot Powerup
            Destroy(this.gameObject);
        }
    }
}
