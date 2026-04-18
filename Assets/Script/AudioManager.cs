using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   public static AudioManager Instance;
   
   [SerializeField] private AudioSource BG;
   [SerializeField] private AudioSource dialogues;

   [SerializeField] private AudioClip mainMenuClip;
   [SerializeField] private AudioClip l1Q1;
   [SerializeField]  private AudioClip l2Q1;
   [SerializeField]  private AudioClip l3Q1;

   private void Awake()
   {
      Instance = this;
   }

   public void PlayMainMenuDialogues()
   {
      if (dialogues != null && !dialogues.isPlaying)
      {
         dialogues.PlayOneShot(mainMenuClip);
      }
   }

   public void PlayL1Q1()
   {
      if (dialogues != null && !dialogues.isPlaying)
      {
         dialogues.Stop();
         dialogues.PlayOneShot(l1Q1);
      }
   }
   
   public void PlayL2Q1()
   {
      if (dialogues != null && !dialogues.isPlaying)
      {
         dialogues.Stop();
         dialogues.PlayOneShot(l2Q1);
      }
   }
   public void PlayL3Q1()
   {
      if (dialogues != null && !dialogues.isPlaying)
      {
         dialogues.Stop();
         dialogues.PlayOneShot(l3Q1);
      }
   }
}
