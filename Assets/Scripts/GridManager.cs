using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int rows = 5;           
    public int columns = 9;        
    public float cellSize = 1.2f; 
    public GameObject slotPrefab; 

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                Vector3 pos = transform.position + new Vector3(c * cellSize, 0, r * cellSize);
                GameObject slotObj = Instantiate(slotPrefab, pos, Quaternion.identity, transform);

                Slot slot = slotObj.GetComponent<Slot>();
                slot.SetIndex(r, c);
            }
        }
    }
}
