using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour {


	public void ChangeScene(string scene)
	{
		SceneManager.LoadScene (scene);
	}
}
