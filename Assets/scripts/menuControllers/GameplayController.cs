using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour {

	public void MainMenu () {
		SceneManager.LoadScene("menu", LoadSceneMode.Single);
	}

}
