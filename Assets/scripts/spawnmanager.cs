using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class spawnmanager : MonoBehaviour
{
    public GameObject[] character;
    private int score;
    public TextMeshProUGUI score_text;
    public Image Game_over;
    private bool Game_over1;
    public Button exit;
    // Start is called before the first frame update
    void Start()
    {
        update_score(0);
        Game_over1 = false;
        InvokeRepeating("spawn", 3, Random.Range(1, 7));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void spawn()
    {
        if (!Game_over1)
        {
            Instantiate(character[Random.Range(0, character.Length)], new Vector3(Random.Range(-7.4f, 7.4f), 8), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
        }
    }
        
    public void update_score(int number)
    {
        score += number;
        score_text.text = "score: " + score;
        if(score<= -4)
        {
            Game_over.GetComponent<Image>().enabled = true;
            exit.gameObject.SetActive(true);
            Game_over1 = true;

        }
    }
}
