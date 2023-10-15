using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject[] character;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 3, Random.Range(1, 7));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void spawn()
    {
        Instantiate(character[Random.Range(0,character.Length)]);
    }
}
