using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseEnemy : MonoBehaviour {
	public string enemyName;
	public float level;
	public int luck;

	//----
	// Enemy Stats
	//----

	public float HP;

	public float baseATK;

	public float curATK;

	public float baseDEF;

	public float curDEF;

}

