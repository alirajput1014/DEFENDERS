using UnityEngine;

public class PlacementController : MonoBehaviour
{
    public Camera mainCamera;       
    public LayerMask slotLayer;     

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            if (GameManager.Instance == null || GameManager.Instance.selectedPrefab == null)
                return;

            
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f, slotLayer))
            {
                Slot slot = hit.collider.GetComponent<Slot>();

                if (slot != null && !slot.isOccupied)
                {
                    slot.Place(GameManager.Instance.selectedPrefab);

                    
                    GameManager.Instance.OnPlayerDeployed();
                }
            }
        }
    }
}
