using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragAndDrop : MonoBehaviour
{

    public GameObject selectedPiece;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Pieces"))
            {
                if (!hit.transform.GetComponent<SnapPieces>().inRightPos)
                {
                    selectedPiece = hit.transform.gameObject;
                    selectedPiece.GetComponent<SnapPieces>().selected = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (selectedPiece != null)
            {
                selectedPiece.GetComponent<SnapPieces>().selected = false;
                selectedPiece = null;
                SnapPieces.numPiecesInPos += 1;
            }
        }

        if (selectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }

        if (SnapPieces.numPiecesInPos == 6)
        {
            Invoke("NextScene", 2);
            Debug.Log("puzzle complete!");
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene("MissionComplete");
    }
}
