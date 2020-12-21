using UnityEngine;
using UnityEngine.UI;

public class CombatUIManager : MonoBehaviour
{
    [SerializeField] private GameObject combatUI;
    [SerializeField] private Image combatUIPanel;
    [SerializeField] private Text combatLogText;
    
    public void CombatUiSetActive(bool activeState)
    {
        combatUI.SetActive(activeState);
    }
}
