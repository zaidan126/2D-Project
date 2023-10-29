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
    private AudioSource player;
    public AudioClip click_sound;
    public AudioClip bone_sound;

    void Start()
    {
        ob_ject = GetComponent<Renderer>();
        player = GetComponent<AudioSource>();
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
                player.PlayOneShot(bone_sound, 1);
                bone_effects.Play();
                if (!bone_effects.IsAlive())
                {
                    Destroy(gameObject);
                }
            }

        }
    }
    private void OnMouseDown()
    {
        clicked = true;
        gameObject.GetComponent<Renderer>().enabled = false;
        player.PlayOneShot(click_sound, 1);
        click_effects.Play(); 
        if (!click_effects.IsAlive())
        {
            Destroy(gameObject);
        }

    }
}
