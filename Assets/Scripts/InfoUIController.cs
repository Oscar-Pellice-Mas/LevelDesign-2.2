using UnityEngine;
using UnityEngine.UI;

public class InfoUIController : MonoBehaviour
{
    public GameObject uiPanel;
    public Text Text;

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) && uiPanel != null)
        {
            uiPanel.SetActive(false);
        }
    }

    public void SetText(string text)
    {
        this.Text.text = text;
    }

    public void SetUIActive()
    {
        Debug.Log("Active");
        uiPanel.SetActive(true);
    }
}