using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
	public static audioManager instance;
	
	public AudioClip[] s_audiolist;
	
	List<AudioSource> s_source = new List<AudioSource>();
	
	void Awake(){
		instance = this;
	}
    // Start is called before the first frame update
    void Start()
    {
		for (int i = 0; i < s_audiolist.Length; i++)
		{
			s_source.Add(new AudioSource());
			s_source[i] = gameObject.AddComponent<AudioSource>();
			s_source[i].clip = s_audiolist[i];
        }
    }

    public void s_playSound(int s){
		s_source[s].Play();
	}
}
