using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //Reload Scene when pressing R
        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }


    }
}
