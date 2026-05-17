using UnityEngine;

public class Slot : MonoBehaviour
{
    public bool isOccupied = false;
    public int row = -1;
    public int column = -1;
    public float placeYOffset = 0f; 

    public void SetIndex(int r, int c)
    {
        row = r;
        column = c;
    }

    public bool Place(GameObject playerPrefab)
    {
        if (isOccupied || playerPrefab == null)
            return false;

        
        Unit unit = playerPrefab.GetComponent<Unit>();
        int cost = (unit != null) ? unit.cost : 0;

        
        if (!GameManager.Instance.SpendCoins(cost))
        {
            Debug.Log("Not enough coins to place!");
            return false;
        }

       
        Vector3 spawnPos = transform.position + Vector3.up * placeYOffset;
        GameObject placed = Instantiate(playerPrefab, spawnPos, Quaternion.identity);
        placed.transform.SetParent(transform);
        isOccupied = true;
        return true;
    }
}
