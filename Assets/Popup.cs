using UnityEngine;

public class PopupSpawner : MonoBehaviour
{
    public GameObject popupPrefab;     // Dra in Popup-prefab h�r
    public Transform canvasTransform;  // Dra in Canvas h�r

    public void SpawnPopup()
    {
        // Skapa popup vid knappens position
        GameObject popup = Instantiate(popupPrefab, canvasTransform);
        popup.transform.position = transform.position; // vid knappen

        // Ta bort popup efter 1 sekund
        Destroy(popup, 1f);
    }
}
