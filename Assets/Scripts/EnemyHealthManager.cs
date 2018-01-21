using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int MaxHP;
    public int CurrentHP;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHP <= 0)
        {
            Destroy (gameObject);
        }
    }

    public void DmgEnemy(int DmgTaken)
    {
        CurrentHP -= DmgTaken;
    }
}
