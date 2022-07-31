using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDontDestroy : MonoBehaviour
{
    public string tagNoDestroy;

    public AudioSource sound;

    void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag(tagNoDestroy);

        if(obj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

    }

    public void SetVolume()
    {
        if (sound.volume == 0) sound.volume = 0.3f;
        else sound.volume = 0;
    }


    
}
