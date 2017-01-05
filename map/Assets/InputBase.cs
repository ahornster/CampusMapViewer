using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Events;

public class InputBase : MonoBehaviour {
	
	List<string> dates = new List<string>(){ "Please Select Date" , "1874" , "1894" , "1930" , "1947" , "1973" , "1983" , "1996" , "2000" , "2006" , "2016" };

	public Dropdown dropdown;
	public Text selectedDate;
	public void OnValueChange(){

		Debug.Log ("ValueChanged");
	}

		void Start()
		{
			PopulateList();
			}

		void PopulateList(){
		
		dropdown.AddOptions(dates);
	}
	}	

