using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Muks.DataBind
{
    public static class DataBind
    {
        private static Dictionary<string, BindData<string>> _dataBindingText;

        private static Dictionary<string, BindData<UnityAction>> _dataBindingUnityAction;

        private static Dictionary<string, BindData<Sprite>> _dataBindingSprite;

        private static Dictionary<string, BindData<object>> _dataBindingObject;

        /// <summary>
        /// �ؽ�Ʈ �������� ������ҿ� ���� ���� �����صδ� �Լ�(data���� ���� ��� GetTextValue�� ����� ���� ���� ����)
        /// </summary>
        public static void SetTextValue(string dataID, string data)
        {
            if (_dataBindingText == null)
                _dataBindingText = new Dictionary<string, BindData<string>>();

            if (!_dataBindingText.TryGetValue(dataID, out BindData<string> textData))
            {
                textData = new BindData<string>();
                _dataBindingText.Add(dataID, textData);
            }
            textData.Item = data;
        }


        /// <summary>
        /// ����� �ؽ�Ʈ �������� ������Ҹ� �ҷ��� �����ϴ� �Լ�
        /// </summary>
        public static BindData<string> GetTextValue(string dataID)
        {
            if (_dataBindingText == null)
                _dataBindingText = new Dictionary<string, BindData<string>>();

            if (!_dataBindingText.TryGetValue(dataID, out BindData<string> textData))
            {
                textData = new BindData<string>();
                _dataBindingText.Add(dataID, textData);
            }
            return textData;
        }


        /// <summary>
        /// ��ư �������� ������ҿ� �������� �����صδ� �Լ�(action���� ���� ��� GetButtonValue�� ����� ���� ���� ����)
        /// </summary>
        public static void SetButtonValue(string dataID, UnityAction action)
        {
            if (_dataBindingUnityAction == null)
                _dataBindingUnityAction = new Dictionary<string, BindData<UnityAction>>();

            if (!_dataBindingUnityAction.TryGetValue(dataID, out BindData<UnityAction> buttonData))
            {
                buttonData = new BindData<UnityAction>();
                _dataBindingUnityAction.Add(dataID, buttonData);
            }

            buttonData.Item = action;
        }


        /// <summary>
        /// ��ư �ؽ�Ʈ �������� ������Ҹ� �ҷ����� �Լ�
        /// </summary>
        public static BindData<UnityAction> GetButtonValue(string dataID)
        {
            if (_dataBindingUnityAction == null)
                _dataBindingUnityAction = new Dictionary<string, BindData<UnityAction>>();

            if (!_dataBindingUnityAction.TryGetValue(dataID, out BindData<UnityAction> buttonData))
            {
                buttonData = new BindData<UnityAction>();
                _dataBindingUnityAction.Add(dataID, buttonData);
            }
            return buttonData;
        }


        /// <summary>
        /// ��ư �������� ������ҿ� �������� �����صδ� �Լ�(action���� ���� ��� GetButtonValue�� ����� ���� ���� ����)
        /// </summary>
        public static void SetSpriteValue(string dataID, Sprite sprite)
        {
            if (_dataBindingSprite == null)
                _dataBindingSprite = new Dictionary<string, BindData<Sprite>>();

            if (!_dataBindingSprite.TryGetValue(dataID, out BindData<Sprite> imageData))
            {
                imageData = new BindData<Sprite>();
                _dataBindingSprite.Add(dataID, imageData);
            }
            imageData.Item = sprite;
        }


        /// <summary>dataID�� ���� �̹��� �������� ���� ��Ҹ� �ҷ����� �Լ� </summary>
        public static BindData<Sprite> GetSpriteValue(string dataID)
        {
            if (_dataBindingSprite == null)
                _dataBindingSprite = new Dictionary<string, BindData<Sprite>>();

            if (!_dataBindingSprite.TryGetValue(dataID, out BindData<Sprite> imageData))
            {
                imageData = new BindData<Sprite>();
                _dataBindingSprite.Add(dataID, imageData);
            }
            return imageData;
        }


        /// <summary>dataID�� ���� UnityAction �Լ��� ��ȯ�ϴ� �Լ� </summary>
        public static UnityAction GetAction(string dataID)
        {
            if (_dataBindingUnityAction == null)
                _dataBindingUnityAction = new Dictionary<string, BindData<UnityAction>>();

            if (!_dataBindingUnityAction.TryGetValue(dataID, out BindData<UnityAction> actionData))
            {
                actionData = new BindData<UnityAction>();
                _dataBindingUnityAction.Add(dataID, actionData);
            }
            return actionData.Item;
        }


        /// <summary>dataID�� ���� ������Ʈ �ڷ��� �����͸� �����ϴ� �Լ� </summary>
        public static void SetObjectValue(string dataID, object obj)
        {
            if (_dataBindingObject == null)
                _dataBindingObject = new Dictionary<string, BindData<object>>();

            if (!_dataBindingObject.TryGetValue(dataID, out BindData<object> objectData))
            {
                objectData = new BindData<object>();
                _dataBindingObject.Add(dataID, objectData);
            }
            objectData.Item = obj;
        }



        /// <summary>dataID�� ���� ����� ������Ʈ �ڷ��� �����͸� ��ȯ�ϴ� �Լ� </summary>
        public static object GetObjectValue(string dataID)
        {
            if (_dataBindingObject == null)
                _dataBindingObject = new Dictionary<string, BindData<object>>();

            if (!_dataBindingObject.TryGetValue(dataID, out BindData<object> objectData))
            {
                objectData = new BindData<object>();
                _dataBindingObject.Add(dataID, objectData);
            }

            return objectData.Item;
        }
    }
}