using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerWall : MonoBehaviour {
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            int sceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;

            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);

        }
        
    }
}
