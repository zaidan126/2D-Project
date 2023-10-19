using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_fallingdown : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public ParticleSystem click_effects;
    public ParticleSystem bone_effects;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*Time.deltaTime*speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bone_effects.gameObject.SetActive(true);
        bone_effects .Play();
        Destroy(gameObject);
    }
    private void OnMouseDown()
    {
        click_effects.gameObject.SetActive(true);
        click_effects .Play();
        Destroy(gameObject);
    }
}
