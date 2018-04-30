using UnityEngine;
using System.Collections;

[System.Serializable]
public class BasePlayer : MonoBehaviour {

	public string playerName;
	public float level;
	public int luck;

	public const float maxHealth = 100;

	public float HP;

	public float maxMP= 100; //MP = magical power

	public float MP;

	public bool AkMode;
	//Don't know if these variables are created by the level but I'm gonna create them anyway

	public int stamina;
	public int intellect;

	public int dexterity;

	public int agility;
	
}

