using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer prologue;
    public int sceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        PlayPrologue();
        prologue.loopPointReached += PrologueLoop;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayPrologue()
    {
        prologue.Play();
    }
    private void PrologueLoop(VideoPlayer souce)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
