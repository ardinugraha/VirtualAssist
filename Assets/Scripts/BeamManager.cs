using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Sharing;
using HoloToolkit.Unity;
using VA.App.Scripts;

public class BeamManager : MonoBehaviour,IInputClickHandler {

    private SceneController sceneController;
	// Use this for initialization
	void Start () {
        sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnInputClicked(InputClickedEventData eventData)
    {
        SceneController.Instance.Model.GetComponent<ModelController>().beamState = BeamState.Inactive;
        Debug.Log("lol");
    }
}
