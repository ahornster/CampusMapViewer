using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Events;

public class Input : MonoBehaviour {

	List<string> dates = new List<string>(){ "Please Select Date" , "1874" , "1947" , "1983" , "2000" , "2006" , "2016" };

	public Dropdown dropdown;
	public Dropdown dropdown1;
	public Text selectedDate;
	public GameObject[] images;
	public Slider slider;
	public GameObject NeedMap;
	public Button Reset;


	public void OnValueChange(){
		Debug.Log ("ValueChanged"+slider.value);
		Debug.Log (dropdown.value);
		Debug.Log (dropdown1.value);

		if (dropdown.value > 0 || dropdown1.value > 0) {
			NeedMap.SetActive (false);

			images [dropdown.value - 1].SetActive (true);
			images [dropdown.value - 1].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, (slider.value/100f));
			images [dropdown1.value - 1].SetActive (true);
			images [dropdown1.value - 1].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, ((100 - slider.value)/100f));
		}

			else {
				images [0].SetActive (false);
				images [1].SetActive (false);
				images [2].SetActive (false);
				images [3].SetActive (false);
				images [4].SetActive (false);
				images [5].SetActive (false);
				NeedMap.SetActive (true);
			}
		}

	public void PlayReset(){
		Debug.Log ("Reset Button");
		images [0].SetActive (false);
		images [1].SetActive (false);
		images [2].SetActive (false);
		images [3].SetActive (false);
		images [4].SetActive (false);
		images [5].SetActive (false);
		dropdown.value = 0;
		dropdown1.value = 0;
		slider.value = 50;
		NeedMap.SetActive (false);
	}


	void Start(){
		PopulateList();
		HideImage();
		Button btn = Reset.GetComponent<Button> ();
		btn.onClick.AddListener (PlayReset);
	}

	void PopulateList(){
		dropdown.AddOptions(dates);
		dropdown1.AddOptions (dates);
	}

	void HideImage(){
		images [0].SetActive (false);
		images [1].SetActive (false);
		images [2].SetActive (false);
		images [3].SetActive (false);
		images [4].SetActive (false);
		images [5].SetActive (false);
		NeedMap.SetActive (false);
	}
}