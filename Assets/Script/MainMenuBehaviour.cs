using System;
using System.Xml.Schema;
using UnityEngine;
using DG.Tweening;
public class MainMenuBehaviour : MonoBehaviour
{
   public bool isTesting = false;
   [SerializeField] private Transform tittle;
   [SerializeField] private Transform play_Btn;
   [SerializeField] private Transform level1, l1question;
   [SerializeField] private Transform[] answers;
   [SerializeField] private Transform BG2;
   [SerializeField]  private Transform  questions2;
   [SerializeField] private Transform[] answers2;

   [SerializeField] private Transform BG3;
   [SerializeField]  private Transform  questions3;
   [SerializeField] private Transform[] answers3;

   private void Start()
   {
      if(isTesting) return;

      InitializeGame();
   }

   void InitializeGame()
   {
      BG3.localScale = Vector3.zero;
      questions3.localScale = Vector3.zero;
      
      foreach (var VARIABLE in answers3)
      {
         VARIABLE.localScale = Vector3.zero;
      }
      BG2.localScale = Vector3.zero;
      questions2.localScale = Vector3.zero;
      
      foreach (var VARIABLE in answers2)
      {
         VARIABLE.localScale = Vector3.zero;
      }
      level1.localScale = Vector3.zero;
      l1question.localScale = Vector3.zero;
      foreach (Transform child in answers)
      {
         child.localScale = Vector3.zero;
      }  
    
      tittle.localScale = Vector3.zero;
      play_Btn.localScale = Vector3.zero;

      tittle.DOScale(Vector3.one, .5f).OnComplete((() =>
      {
         play_Btn.DOScale(Vector3.one, .5f).OnComplete((() =>
         {
            AudioManager.Instance.PlayMainMenuDialogues();
            play_Btn.GetComponent<UIHoverClickEffect>().enableIdlePulse = true;
         }));

      }));
         
   }

   public void PlayButtonClick()
   {
      
      level1.DOScale(Vector3.one, .5f).SetEase(Ease.OutBack)
         .OnComplete((() =>
         {
            l1question.DOScale(Vector3.one, .5f).SetEase(Ease.OutBack).OnComplete(
               (() =>
               {
                  AudioManager.Instance.PlayL1Q1();
                  foreach (Transform child in answers)
                  {
                     child.DOScale(Vector3.one, .5f).SetEase(Ease.OutBack).OnComplete((() =>
                     {
                        child.GetComponent<UIHoverClickEffect>().enableIdlePulse = true;
                     }));

                  }


               }));
         }));
   
   }

   void InitializeLevel2()
   {
      BG2.DOScale(Vector3.one, .5f).SetEase(Ease.OutBack).OnComplete((() =>
      {
         questions2.DOScale(Vector3.one, .5f).SetEase(Ease.OutBack)
            .OnComplete((() =>
            {
               AudioManager.Instance.PlayL2Q1();
               foreach (Transform child in answers2)
               {
                  child.DOScale(Vector3.one, .5f).SetEase(Ease.OutBack).OnComplete((() =>
                  {
                     child.GetComponent<UIHoverClickEffect>().enableIdlePulse = true;
                  }));
               
               }

           
            }));
      }));
      
      
   }
   void InitializeLevel3()
   {
      BG3.DOScale(Vector3.one, .5f).SetEase(Ease.OutBack).OnComplete((() =>
      {
         questions3.DOScale(Vector3.one, .5f).SetEase(Ease.OutBack)
            .OnComplete((() =>
            {
               AudioManager.Instance.PlayL3Q1();
               foreach (Transform child in answers3)
               {
                  child.DOScale(Vector3.one, .5f).SetEase(Ease.OutBack).OnComplete((() =>
                  {
                     child.GetComponent<UIHoverClickEffect>().enableIdlePulse = true;
                  }));
               
               }

           
            }));
      }));
      
      
   }

   public void Level3()
   {
      Invoke("InitializeLevel3", 2f);
   }

   public void Level2()
   {
      Invoke("InitializeLevel2", 2f);
   }
}
