using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GCIEL.Toolkit;

public class GameStart : MonoBehaviour {

    [SerializeField]
    GameEvent StartEvent;

	// Use this for initialization
	void Start () {
        StartEvent.Raise();
	}
}
