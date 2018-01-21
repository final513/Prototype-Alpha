using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    public int dmgGiven;
    public GameObject dmgNumber;
    private int currentDmg;
    private PlayerStats thePlayerStats;
    
    // Use this for initialization
	void Start () {
        thePlayerStats = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            currentDmg = dmgGiven - thePlayerStats.currentDefense;
            if (currentDmg < 0)
            {
                currentDmg = 1;
            }

            other.gameObject.GetComponent<PlayerHealthManager>().DmgPlayer(dmgGiven);
        }
    }
}
