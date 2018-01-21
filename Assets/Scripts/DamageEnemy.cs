using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour {

    public int dmgGiven;
    private int currentDmg;
    public GameObject damgeBurst;
    public Transform hp;
    public GameObject damageNumber;

    private PlayerStats thePlayerSats;
    
    // Use this for initialization
	void Start () {
        thePlayerSats = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            currentDmg = dmgGiven + thePlayerSats.currentAttack;

            other.gameObject.GetComponent<EnemyHealthManager>().DmgEnemy(currentDmg);

        }
    }


}
