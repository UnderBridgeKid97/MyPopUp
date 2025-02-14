using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySample
{
    /// <summary>
    /// ���� ���� â : ��(��������), �ƴϿ�
    /// </summary>
    public class ExitGame : Popup
    {
        #region Variables
        [SerializeField] private CustomButton yes;
        #endregion

        private void OnEnable()
        {
            yes.onClick.AddListener(QuitGame);
        }

        private void QuitGame()
        {
            //��������
            Application.Quit();
            Debug.Log("Application.Quit");
        }
    }
}
