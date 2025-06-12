using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds <= 0)
        {
            if (minutes > 0 )
            {
                seconds += 59;
                minutes--;
            }
            else
            {
                int sceneIndex = EditorSceneManager.GetActiveScene().buildIndex;
                EditorSceneManager.LoadScene(sceneIndex);
            }
        }

    }
}
