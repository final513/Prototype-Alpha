using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHP;
    public int playerCurrentHP;
    
    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if(playerCurrentHP <= 0)
        {
            gameObject.SetActive(false);
        }
	}

    public void DmgPlayer(int playerDmgTaken)
    {
        playerCurrentHP -= playerDmgTaken;
    }

    
    
}
