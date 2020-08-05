using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    [SerializeField] float yOffset = 0.2f;
    [SerializeField] float xOffset = 0.2f;

    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }


    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }
    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnaptoGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnaptoGrid(Vector2 rawWorldPos)
    {

        float newX = Mathf.RoundToInt(rawWorldPos.x) + xOffset;
        float newY = Mathf.Floor(rawWorldPos.y) + yOffset;
        return new Vector2(newX, newY);
    }


    private void SpawnDefender(Vector2 roundedPos)
    {
        Defender newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as Defender;
    }



}
