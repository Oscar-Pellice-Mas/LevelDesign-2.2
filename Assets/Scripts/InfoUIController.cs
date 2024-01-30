using UnityEngine;
using UnityEngine.UI;

public class InfoUIController : MonoBehaviour
{
    public GameObject uiPanel;
    public Text Text;
    public Image Image;

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
        this.Image.sprite = null;
        this.Image.gameObject.SetActive(false);
    }

    public void SetUIActive()
    {
        uiPanel.SetActive(true);
    }

    public void SetImage(Sprite s)
    {
        this.Image.gameObject.SetActive(true);
        Image.sprite = s;
    }
}