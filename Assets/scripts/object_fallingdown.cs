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
    private spawnmanager spawnmanager;
    private BoxCollider2D boxCollider;

    void Start()
    {
        ob_ject = GetComponent<Renderer>();
        player = GetComponent<AudioSource>();
        spawnmanager = GameObject.Find("spawn manager").GetComponent<spawnmanager>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
    private bool clicked = false;
    private bool touch_bone = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bone"))
        {

            if (!clicked)
            {
                touch_bone = true;
                spawnmanager.update_score(-2);
                gameObject.GetComponent<Renderer>().enabled = false;
                player.PlayOneShot(bone_sound, 1);
                bone_effects.Play();
                boxCollider.enabled = false;
                if (!bone_effects.IsAlive())
                {
                    Destroy(gameObject);
                }
            }

        }
    }
    private void OnMouseDown()
    {
        if (!touch_bone)
        {
            spawnmanager.update_score(2);
            clicked = true;
            gameObject.GetComponent<Renderer>().enabled = false;
            player.PlayOneShot(click_sound, 1);
            click_effects.Play();
            boxCollider.enabled = false;
            if (!click_effects.IsAlive())
            {
                Destroy(gameObject);
            }


        }
    }
}
