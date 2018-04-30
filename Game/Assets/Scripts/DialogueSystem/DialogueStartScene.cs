using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DialogueStartScene : MonoBehaviour {

	
	
	// Use this for initialization
	void Start () {
		Button buttonDialogue =  GameObject.Find("ConversationTrigger").GetComponent<UnityEngine.UI.Button>();
		 buttonDialogue.onClick.Invoke();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
