using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmenu : MonoBehaviour
{
   public void OpenLevel(int levelid)
    {
        string LevelName = "level" + levelid;
        SceneManager.LoadScene(LevelName);
    }
}
