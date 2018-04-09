using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Sharing;
using HoloToolkit.Unity;

public class BeamManager : MonoBehaviour {

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
        GameObject model = SceneController.Instance.Model;
        ModelController modelController = model.GetComponent<ModelController>();
    }
}
