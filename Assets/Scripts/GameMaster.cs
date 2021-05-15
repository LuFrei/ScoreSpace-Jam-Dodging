using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//* This class is needed for buttons and other objects to access the Loadscene & Quit functions.
// can also serve as a location for global variables that will be needed throughout all game scenes
public class GameMaster : MonoBehaviour{

    public Score score = new Score();


    //Singleton (sorry, Carlos)
    private static GameMaster instance;
    public static GameMaster Instance { get { return instance; } }

    private void Awake() {
        if(instance != null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    //-----


    public void ChangeScene(int sceneId) {
        SceneManager.LoadScene(sceneId);
    }

    public void QuitApp() {
        Application.Quit();
    }
}