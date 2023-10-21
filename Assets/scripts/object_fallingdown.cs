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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        bone_effects.Play();
        ob_ject.enabled = false;
       
    }
    private void OnMouseDown()
    {
        

        click_effects.Play();
        ob_ject.enabled = false;
        
    }
}
