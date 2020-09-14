using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargaNivel(string sceneToLoad){
        print("test");
        SceneManager.LoadScene (sceneToLoad);
        
    }
}
