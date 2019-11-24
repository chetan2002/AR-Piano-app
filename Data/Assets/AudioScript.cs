using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public AudioClip[] notes;
    public AudioSource source;
    string button;


    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit))
            {
                button = Hit.transform.name;
                switch (button)
                {
                    case "Tile1":
                        source.clip = notes[0];
                        source.Play();
                        break;
                    case "Tile2":
                        source.clip = notes[1];
                        source.Play();
                        break;
                    case "Tile3":
                        source.clip = notes[2];
                        source.Play();
                        break;
                    case "Tile4":
                        source.clip = notes[3];
                        source.Play();
                        break;
                    case "Tile5":
                        source.clip = notes[4];
                        source.Play();
                        break;
                    case "Tile6":
                        source.clip = notes[5];
                        source.Play();
                        break;
                    case "Tile7":
                        source.clip = notes[6];
                        source.Play();
                        break;
                    case "Tile8":
                        source.clip = notes[7];
                        source.Play();
                        break;
                    case "Tile9":
                        source.clip = notes[8];
                        source.Play();
                        break;
                    case "Tile10":
                        source.clip = notes[9];
                        source.Play();
                        break;
                    case "Tile11":
                        source.clip = notes[10];
                        source.Play();
                        break;

                }
            }
        }
        
    }
}
