using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// tutorial https://www.youtube.com/watch?v=zc8ac_qUXQY
// sketch https://medium.com/sketch-app-sources/prototyping-ui-in-unity-creating-the-ui-navigation-bar-d0cf92353029
public class mainMenu : MonoBehaviour {
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active scene is '" + scene.name + "'.");
    }

	public void playGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
	public void QuitGame(){
		Debug.Log("Salir");
		Application.Quit();
	}
}
