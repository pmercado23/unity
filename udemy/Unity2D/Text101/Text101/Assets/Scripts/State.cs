using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

    //This is a State, Scripable Object
    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateStory (){
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

}
