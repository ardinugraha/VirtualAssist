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
        model
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject model = SceneController.Instance.Model;
        ModelController modelController = model.GetComponent<ModelController>();

        if (runAsStandAloneOrMPasMaster && SceneController.Instance.GameStage != GameStage.LobbyMenuStage &&
            modelController.BeamMode == BeamState.Active)
        {
            modelController.BeamMode = BeamState.Inactive;
            modelController.Show(true);
            model.transform.position = DefaultCursorManager.Instance.transform.position;

            DefaultCursorManager.Instance.SetCursorIconToDefault(true);

            // Broadcast Object Position over Network 
            RemoteHeadManager.Instance.BeamObjectPosition(model);
        }
    }
}
