using UnityEngine;
using System.Collections;

public class NetworkPlayer : Photon.MonoBehaviour
{
    [SerializeField]private GameObject myCamera;
	void Start ()
    {
        if (photonView.isMine)
        {
            myCamera.SetActive(true);
            GetComponent<CubeMovement>().enabled = true;
        }
        else
        {
            myCamera.SetActive(false);
            GetComponent<CubeMovement>().enabled = false;
        }
	}
}
