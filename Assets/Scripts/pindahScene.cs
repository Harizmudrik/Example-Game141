using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using JetBrains.Annotations;

public class pindahScene : MonoBehaviour
{
    //public int pindahScene = 1;

    //public void ChangeScene()
    //{
    //    UnityEngine.SceneManagement.SceneManager.LoadScene(pindahScene);
    //}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

}
