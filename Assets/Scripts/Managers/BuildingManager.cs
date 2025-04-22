using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stageCoach_PreFab;
    public GameObject gunSmith_PreFab;
    public GameObject nurse_PreFab;
    public GameObject stables_PreFab;
    public GameObject store_PreFab;
        
    void Start()
    {
        Debug.Log("In Start");
        //Debug.Log(buildStageCoach);
        if(economy_manager.Instance.buildStageCoach){ // More will need to be added as we provide more Support for other buildings.
            Vector3 spawnPosition = new Vector3(4, 2.9f, 0);
            GameObject stagecoach = Instantiate(stageCoach_PreFab, spawnPosition, Quaternion.identity);
        }

        if(economy_manager.Instance.buildGunSmith){ // More will need to be added as we provide more Support for other buildings.
            Vector3 spawnPosition = new Vector3(-4, -2.9f, 0);
            GameObject gunSmith = Instantiate(gunSmith_PreFab, spawnPosition, Quaternion.identity);
        }

        if(economy_manager.Instance.buildNurse){ // More will need to be added as we provide more Support for other buildings.
            Vector3 spawnPosition = new Vector3(5.1f, -1.9f, 0);
            GameObject nurse = Instantiate(nurse_PreFab, spawnPosition, Quaternion.identity);
        }
        if(economy_manager.Instance.buildStable){ // More will need to be added as we provide more Support for other buildings.
            Vector3 spawnPosition = new Vector3(-5, 1.9f, 0);
            GameObject sable = Instantiate(stables_PreFab, spawnPosition, Quaternion.identity);
        }

        if(economy_manager.Instance.buildStore){ // More will need to be added as we provide more Support for other buildings.
            Vector3 spawnPosition = new Vector3(4, 2.9f, 0);
            GameObject store = Instantiate(store_PreFab, spawnPosition, Quaternion.identity);
        }

    }
}
