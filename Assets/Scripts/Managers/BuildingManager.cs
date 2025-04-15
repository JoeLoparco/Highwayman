using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stageCoach_PreFab;
    void Start()
    {
        Debug.Log("In Start");
        //Debug.Log(buildStageCoach);
        if(economy_manager.Instance.buildStageCoach){ // More will need to be added as we provide more Support for other buildings.
            Vector3 spawnPosition = new Vector3(4, 2.9f, 0);
            GameObject stagecoach = Instantiate(stageCoach_PreFab, spawnPosition, Quaternion.identity);
        }

    }
}
