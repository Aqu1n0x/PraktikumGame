using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Menu(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   
   public void back(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }
   
   public void QuitGame(){
       Application.Quit();
       }
}
