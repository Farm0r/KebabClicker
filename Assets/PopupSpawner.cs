using UnityEngine;

public class PopupSpawner : MonoBehaviour
{
    public GameObject popupPrefab;     // Dra in Popup-prefab här
    public Transform canvasTransform;  // Dra in Canvas här

    public void SpawnPopup()
    {
        // Skapa popup vid knappens position
        GameObject popup = Instantiate(popupPrefab, canvasTransform);
        popup.transform.position = transform.position + new Vector3(Random.Range(-45,45), Random.Range(-55, 55), 0); // vid knappen

        // Ta bort popup efter 1 sekund
        Destroy(popup, 0.5f);
    }
}
