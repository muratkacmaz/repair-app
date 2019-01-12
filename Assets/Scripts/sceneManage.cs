using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManage : MonoBehaviour {

	//int i = 0;
	Scene scene;
	int i;
	public GameObject tornavida, vida, teker1,image1,image2,image3,image4,lift1,lift2,teker2,teker3,teker4;


	public void Start(){
		i = 0;

	}

	public void clickNext()
	{
		Scene scene = SceneManager.GetActiveScene();
		if (scene.name == "sahne2_1") {
			 
			SceneManager.LoadScene ("sahne2_2");
		}
		if (scene.name == "sahne2_2") {
 
			SceneManager.LoadScene ("sahne2_3");
		}
		if (scene.name == "sahne2_3") {
 
			SceneManager.LoadScene ("sahne2_4");
		}

	}


	public void clickPrev()
	{
		Scene scene = SceneManager.GetActiveScene();
		if (scene.name == "sahne2_2") {

			SceneManager.LoadScene ("sahne2_1");
		}
		if (scene.name == "sahne2_3") {

			SceneManager.LoadScene ("sahne2_2");
		}
		if (scene.name == "sahne2_4") {

			SceneManager.LoadScene ("sahne2_3");
		}
	}

	public void next()   /// without scene change
	{
		Debug.Log (i);
		 
		if (i == 0) {   //ikinci ekran
			i++;
			image1.SetActive (false);
			image2.SetActive (true);   
			tornavida.SetActive (false);
			vida.SetActive (false);
			lift1.SetActive (true);
			return;
		}
		if (i == 1) { // ücüncü ekran
			i++;
			image2.SetActive (false);
			image3.SetActive (true);   
			lift1.SetActive (false);
			lift2.SetActive (true);
			teker1.SetActive (false);
			teker2.SetActive (true);
			return;	
		}
		if (i == 2) {//son ekran
			i++;
			image3.SetActive (false);
			image4.SetActive (true);   
			teker2.SetActive (false);
			teker3.SetActive (true);
			teker4.SetActive (true);
			return;
		}


	
	}

	public void prev()   /// without scene change
	{
		if (i == 3) { //3. ekran
			i--;
			image3.SetActive (true);
			image4.SetActive (false);   
			teker2.SetActive (true);
			teker3.SetActive (false);
			teker4.SetActive (false);
			return;
		}
		if (i == 2) {  //2.ekran
			i--;
			image2.SetActive (true);
			image3.SetActive (false);   
			lift1.SetActive (true);
			lift2.SetActive (false);
			teker1.SetActive (true);
			teker2.SetActive (false);
			return;	
		}
		if (i == 1) { // 1.ekran
			i--;
			image1.SetActive (true);
			image2.SetActive (false);   
			tornavida.SetActive (true);
			vida.SetActive (true);
			lift1.SetActive (false);
			return;
		}




	}

}
