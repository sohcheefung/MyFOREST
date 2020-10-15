using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
   public void play_sound(int s){
		audioManager.instance.s_playSound(s);
   }
}
