using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MySample
{
    /// <summary>
    /// Ŀ���� ��ư : ���� ��ư ��� �޾� ��� Ȯ��
    /// </summary>
    [RequireComponent(typeof(Animator), typeof(CanvasGroup))]
    public class CustomButton : Button
    {
        #region Variables
        //public AudioClip overrideClickSound;        

        private bool isClicked;                         //��ư�� ��������?
        private readonly float cooldownTime = 0.5f;     //��ٿ� �ð����� ��ư�� �������� ������ �� ����

        public new ButtonClickedEvent onClick;          //��ư Ŭ���� ��ϵ� �Լ� ȣ��
        private new Animator animator;

        private static bool blockInput;                 //��� Ŀ���� ��ư ��� ����
        #endregion

        protected override void OnEnable()
        {
            base.OnEnable();
            animator = GetComponent<Animator>();
        }


        public override void OnPointerClick(PointerEventData eventData)
        {
            if (blockInput || isClicked)
            {
                return;
            }

            //TODO:������ ȿ���� �÷���

            Press();

            isClicked = true;

            if (gameObject.activeInHierarchy)
            {
                StartCoroutine(Cooldown());
            }

            base.OnPointerClick(eventData);
        }

        private void Press()
        {
            if (blockInput)
            {
                return;
            }

            onClick?.Invoke();
        }

        IEnumerator Cooldown()
        {
            yield return new WaitForSeconds(cooldownTime);
            isClicked = false;
        }

        //��ư �ִϸ��̼� üũ
        private bool IsAnimationPlay()
        {
            var stateInfo = animator.GetCurrentAnimatorStateInfo(0);
            return stateInfo.loop || stateInfo.normalizedTime < 1;
        }

        //��� Ŀ���� ��ư ��� ����/����
        public static void SetBlockInput(bool block)
        {
            blockInput = block;
        }
    }
}
