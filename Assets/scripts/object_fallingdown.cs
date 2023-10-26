using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_fallingdown : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    public ParticleSystem click_effects;
    public ParticleSystem bone_effects;
    private Renderer ob_ject;

    void Start()
    {
        ob_ject = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*Time.deltaTime*speed);
    }
    private bool clicked = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bone"))
        {
            
            if (!clicked)
            {
                gameObject.GetComponent<Renderer>().enabled = false;

                bone_effects.Play();
                if (!bone_effects.IsAlive())
                {
                    gameObject.GetComponent<BoxCollider2D>().enabled = false;
                }
            }

        }
    }
    private void OnMouseDown()
    {
        clicked = true;
        gameObject.GetComponent<Renderer>().enabled = false;

        click_effects.Play();
        
    }
}
