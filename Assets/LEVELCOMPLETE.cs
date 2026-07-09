using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVELCOMPLETE : MonoBehaviour
{
    public int scenename;
    public int nextscene;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(nextscene);
        if (collision.gameObject.CompareTag("HURDLE"))
            SceneManager.LoadScene(scenename);
    }
}
