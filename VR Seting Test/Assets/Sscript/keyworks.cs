using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class keyworks : MonoBehaviour
{
    public Text displayText;
    public Button[] certificateButtons;
    public Button[] subCertificateButtons;
    public Button[] optionButtons;
    public Button[] quantityButtons;

    private string selectedCertificate;
    private string selectedSubCertificate;
    private string selectedOption;

    private void Start()
    {
        // Initialize the UI
        InitializeUI();
    }

    private void InitializeUI()
    {
        // Set up button click events
        foreach (Button button in certificateButtons)
        {
            button.onClick.AddListener(() => OnCertificateButtonClick(button));
        }

        foreach (Button button in subCertificateButtons)
        {
            button.onClick.AddListener(() => OnSubCertificateButtonClick(button));
        }

        foreach (Button button in optionButtons)
        {
            button.onClick.AddListener(() => OnOptionButtonClick(button));
        }

        foreach (Button button in quantityButtons)
        {
            button.onClick.AddListener(() => OnQuantityButtonClick(button));
        }

        // Display the initial message
        displayText.text = "발급을 원하시는 증명서를 선택하십시오";
    }

    private void OnCertificateButtonClick(Button button)
    {
        selectedCertificate = button.GetComponentInChildren<Text>().text;
        displayText.text = $"선택된 증명서: {selectedCertificate}\n하위 증명서를 선택하십시오";
        ToggleButtonGroup(certificateButtons, false);
        ToggleButtonGroup(subCertificateButtons, true);
    }

    private void OnSubCertificateButtonClick(Button button)
    {
        selectedSubCertificate = button.GetComponentInChildren<Text>().text;
        displayText.text = $"선택된 증명서: {selectedCertificate} - {selectedSubCertificate}\n옵션을 선택하십시오";
        ToggleButtonGroup(subCertificateButtons, false);
        ToggleButtonGroup(optionButtons, true);
    }

    private void OnOptionButtonClick(Button button)
    {
        selectedOption = button.GetComponentInChildren<Text>().text;
        displayText.text = $"신청증명서: {selectedCertificate} - {selectedSubCertificate}\n수수료: {selectedOption}\n장수를 선택하십시오";
        ToggleButtonGroup(optionButtons, false);
        ToggleButtonGroup(quantityButtons, true);
    }

    private void OnQuantityButtonClick(Button button)
    {
        string quantity = button.GetComponentInChildren<Text>().text;
        displayText.text = $"{quantity}장 인쇄합니다.";
        ToggleButtonGroup(quantityButtons, false);
    }

    private void ToggleButtonGroup(Button[] buttons, bool isActive)
    {
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(isActive);
        }
    }

}
