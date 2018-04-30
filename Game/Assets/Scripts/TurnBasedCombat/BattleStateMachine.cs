using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BattleStateMachine : MonoBehaviour {

	//List of different Battle States
	// START = starts battle.
	// Flow starting with player: 
	// Player choice -> execute player choice 
	// Enemy choice (random roll between possible choices) - > execute enemy choice 
	// Shift to active defense: player controls and moves, spawn gameobjects and move
	// end phase

public enum BattleStates {
		START,
		PLAYERCHOICE, // <- Propt list
		P_C_EX, // <- Execute attack, rythem Attack?
		ENEMYCHOICE, // Random Attack from enemy
		E_C_EX, // Excitute Attack, active defence?
		LOSE, // player HP = 0, lose
		WIN // Enemy(s) HP = 0, win! add rewards?
	}

public BattleStates currentState; //variable to check battle states
	
public BasePlayer BasePlayer; 

public BaseEnemy BaseEnemy;




	void Start () {
		
		//set start state
		currentState = BattleStates.START;

		//disable sub-menus
		
		GameObject.Find("AttackBox").SetActive(false);
		GameObject.Find("DefenseBox").SetActive(false);
		GameObject.Find("BagBox").SetActive(false);
		GameObject.Find("FlagBox").SetActive(false);
		GameObject.Find("AttackAction").SetActive(false);

	}
	

	void Update () {
		
		Debug.Log (currentState);
		
		//get player and enemy	
		BasePlayer = GameObject.Find("player").GetComponent<BasePlayer>();
		BaseEnemy = GameObject.Find("WizardEnemy").GetComponent<BaseEnemy>();


		//get attack and defense buttons

		Button DefenseButton = GameObject.Find("DefenseButton").GetComponent<Button>();
		Button AttackButton = GameObject.Find("AttackButton").GetComponent<Button>();
		
		
switch(currentState){

//CASE 1 = START
case(BattleStates.START):
	
	//Player initial stats
	BasePlayer.HP = 30f * BasePlayer.level;

	BasePlayer.MP = 20f * BasePlayer.level;

	//Enemy initial stats

	BaseEnemy.HP = 100f * BaseEnemy.level;

	//Change case
	//{BattleStateMachine State = GameObject.Find("Assets").GetComponent<BattleStateMachine>();

	//	State.endAnimator = 1;
	currentState = BattleStates.PLAYERCHOICE;

break;

//CASE 2 = PLAYER CHOICE
case(BattleStates.PLAYERCHOICE):
			
	Debug.Log ("PLAYER CHOICE");

	//Disable defense button
	AttackButton.interactable = true; 
	DefenseButton.interactable = false; 
			
break;

//CASE 3 = ATTACK MINI GAME 
case(BattleStates.P_C_EX):
			// Attack animation
			// Roll and apply attack dmg

break;
		
case(BattleStates.ENEMYCHOICE):

AttackButton.interactable = false; 
DefenseButton.interactable = true; 
		

break;
		case(BattleStates.E_C_EX):
			// Attack animation
			// Active Defence mode

			break;
		case(BattleStates.WIN):
			// Win! success animation's
			// propt for win and rewards
			// ect?

			SceneManager.LoadScene("WinMenu");

			break;
		case(BattleStates.LOSE):
			// game over :( 
			// game over screen, end 

			SceneManager.LoadScene("GameOver");
			break;
		}
		
	}

	void onGUI(){
		if (GUILayout.Button ("Next State")) {
			if (currentState == BattleStates.START) {
				currentState = BattleStates.PLAYERCHOICE;
			} else if (currentState == BattleStates.PLAYERCHOICE) {
				currentState = BattleStates.ENEMYCHOICE;
			} else if (currentState == BattleStates.ENEMYCHOICE) {
				currentState = BattleStates.PLAYERCHOICE;
			} 
		}
	}
}
