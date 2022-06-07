using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public AudioManager audioManager;

    
    public void LoadStartScene()
    {
        StartCoroutine(LoadSceneWithSound("StartScene"));
    }

    public void LoadGameScene()
    {
        StartCoroutine(LoadSceneWithSound("GameScene"));
    }

    public void LoadInstructionsScene()
    {
        StartCoroutine(LoadSceneWithSound("InstructionScene"));
    }

    public void LoadOptionsScene()
    {
        StartCoroutine(LoadSceneWithSound("InstructionScene"));
    }    

    public IEnumerator LoadSceneWithSound(string sceneName)
    {
        audioManager.Play("Select");
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(sceneName);
    }

}
