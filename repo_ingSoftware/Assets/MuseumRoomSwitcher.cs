using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuseumRoomSwitcher : MonoBehaviour
{

    public GameObject[] museumRooms;
    public int idRoom;
    public GameObject arrowUp;
    public GameObject arrowDown;
    public GameObject arrowLeft;
    public GameObject arrowRight;

    // Start is called before the first frame update
    void Start()
    {
        idRoom = 0;

    }

    // Update is called once per frame
    void Update()
    {

        

        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                #region idRoom0
                Debug.Log(raycastHit.collider.name);
                
                
                if (raycastHit.collider.name == "Arrow _N" && idRoom == 0)
                {
                    museumRooms[idRoom].SetActive(false);
                    idRoom = 1;
                    arrowUp.SetActive(false);
                    arrowRight.SetActive(false);
                    arrowLeft.SetActive(false);
                    museumRooms[idRoom].SetActive(true);
                    arrowDown.SetActive(true);
                    
                }
                if (raycastHit.collider.name == "Arrow_E" && idRoom == 0)
                {
                    museumRooms[idRoom].SetActive(false);
                    idRoom = 2;
                    arrowDown.SetActive(false);
                    arrowUp.SetActive(false);
                    arrowRight.SetActive(false);
                    museumRooms[idRoom].SetActive(true);
                    arrowLeft.SetActive(true);

                }
                if (raycastHit.collider.name == "Arrow_S" && idRoom == 0)
                {
                    museumRooms[idRoom].SetActive(false);
                    idRoom = 3;
                    arrowDown.SetActive(false);
                    arrowRight.SetActive(false);
                    arrowLeft.SetActive(false);
                    museumRooms[idRoom].SetActive(true);
                    arrowUp.SetActive(true);
                }

                if (raycastHit.collider.name == "Arrow_O" && idRoom == 0)
                {
                    museumRooms[idRoom].SetActive(false);
                    idRoom = 4;
                    arrowDown.SetActive(false);
                    arrowUp.SetActive(false);
                    arrowLeft.SetActive(false);
                    museumRooms[idRoom].SetActive(true);
                    arrowRight.SetActive(true);
                }
               
                
                #endregion
                #region idRoom1
                if (raycastHit.collider.name == "Arrow_S" && idRoom == 1)
                {
                    museumRooms[idRoom].SetActive(false);
                    idRoom = 0;
                    museumRooms[idRoom].SetActive(true);
                    arrowDown.SetActive(true);
                    arrowUp.SetActive(true);
                    arrowLeft.SetActive(true);
                    arrowRight.SetActive(true);
                }
                #endregion
                #region idRoom2
                if (raycastHit.collider.name == "Arrow_O" && idRoom == 2)
                {
                    museumRooms[idRoom].SetActive(false);
                    idRoom = 0;
                    museumRooms[idRoom].SetActive(true);
                    arrowDown.SetActive(true);
                    arrowUp.SetActive(true);
                    arrowLeft.SetActive(true);
                    arrowRight.SetActive(true);
                }
                #endregion
                #region idRoom3
                if (raycastHit.collider.name == "Arrow _N" && idRoom == 3)
                {
                    museumRooms[idRoom].SetActive(false);
                    idRoom = 0;
                    museumRooms[idRoom].SetActive(true);
                    arrowDown.SetActive(true);
                    arrowUp.SetActive(true);
                    arrowLeft.SetActive(true);
                    arrowRight.SetActive(true);
                }
                #endregion
                #region idRoom4
                if (raycastHit.collider.name == "Arrow_E" && idRoom == 4)
                {
                    museumRooms[idRoom].SetActive(false);
                    idRoom = 0;
                    museumRooms[idRoom].SetActive(true);
                    arrowDown.SetActive(true);
                    arrowUp.SetActive(true);
                    arrowLeft.SetActive(true);
                    arrowRight.SetActive(true);
                }
                #endregion
            }
        }

    }
}
