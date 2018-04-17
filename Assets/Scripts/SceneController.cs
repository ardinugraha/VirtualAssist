using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.XR.WSA;
using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using System.Linq; //.Core;
using UnityEngine.UI;
using HoloToolkit.Sharing;

public class SceneController : Singleton<SceneController>
{

    private GameObject DefaultCursor;
    public GameObject Model;
    
	// Use this for initialization
	void Start () {
        Model = GameObject.Find("Model");
        //Model.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
