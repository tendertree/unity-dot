//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Settings/MOBAInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MOBAInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MOBAInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MOBAInput"",
    ""maps"": [
        {
            ""name"": ""GamePlayMap"",
            ""id"": ""7f53dfe3-8119-499d-a886-0b5a4789ce38"",
            ""actions"": [
                {
                    ""name"": ""SelectMovePosition"",
                    ""type"": ""Button"",
                    ""id"": ""42691a0f-1b84-421b-9e68-7b397ad04984"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Ablity"",
                    ""type"": ""Button"",
                    ""id"": ""d92a893d-4eaa-491f-b71d-78247910759c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shot"",
                    ""type"": ""Button"",
                    ""id"": ""520f1dd4-c42f-4a00-ba1e-e9e1367b23b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""492c2f2a-bf1d-432b-a678-5f8c07e9fcdf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""448fc5a3-b5d1-4684-930c-de17ae9963a1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectMovePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f740f905-6ca4-4405-934f-0d82ba65425c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ablity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bbb0397-b60f-4359-8672-57f146550443"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7304ed8-635e-4dfb-b2fc-0658199a42e7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlayMap
        m_GamePlayMap = asset.FindActionMap("GamePlayMap", throwIfNotFound: true);
        m_GamePlayMap_SelectMovePosition = m_GamePlayMap.FindAction("SelectMovePosition", throwIfNotFound: true);
        m_GamePlayMap_Ablity = m_GamePlayMap.FindAction("Ablity", throwIfNotFound: true);
        m_GamePlayMap_Shot = m_GamePlayMap.FindAction("Shot", throwIfNotFound: true);
        m_GamePlayMap_Confirm = m_GamePlayMap.FindAction("Confirm", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // GamePlayMap
    private readonly InputActionMap m_GamePlayMap;
    private List<IGamePlayMapActions> m_GamePlayMapActionsCallbackInterfaces = new List<IGamePlayMapActions>();
    private readonly InputAction m_GamePlayMap_SelectMovePosition;
    private readonly InputAction m_GamePlayMap_Ablity;
    private readonly InputAction m_GamePlayMap_Shot;
    private readonly InputAction m_GamePlayMap_Confirm;
    public struct GamePlayMapActions
    {
        private @MOBAInput m_Wrapper;
        public GamePlayMapActions(@MOBAInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @SelectMovePosition => m_Wrapper.m_GamePlayMap_SelectMovePosition;
        public InputAction @Ablity => m_Wrapper.m_GamePlayMap_Ablity;
        public InputAction @Shot => m_Wrapper.m_GamePlayMap_Shot;
        public InputAction @Confirm => m_Wrapper.m_GamePlayMap_Confirm;
        public InputActionMap Get() { return m_Wrapper.m_GamePlayMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayMapActions set) { return set.Get(); }
        public void AddCallbacks(IGamePlayMapActions instance)
        {
            if (instance == null || m_Wrapper.m_GamePlayMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamePlayMapActionsCallbackInterfaces.Add(instance);
            @SelectMovePosition.started += instance.OnSelectMovePosition;
            @SelectMovePosition.performed += instance.OnSelectMovePosition;
            @SelectMovePosition.canceled += instance.OnSelectMovePosition;
            @Ablity.started += instance.OnAblity;
            @Ablity.performed += instance.OnAblity;
            @Ablity.canceled += instance.OnAblity;
            @Shot.started += instance.OnShot;
            @Shot.performed += instance.OnShot;
            @Shot.canceled += instance.OnShot;
            @Confirm.started += instance.OnConfirm;
            @Confirm.performed += instance.OnConfirm;
            @Confirm.canceled += instance.OnConfirm;
        }

        private void UnregisterCallbacks(IGamePlayMapActions instance)
        {
            @SelectMovePosition.started -= instance.OnSelectMovePosition;
            @SelectMovePosition.performed -= instance.OnSelectMovePosition;
            @SelectMovePosition.canceled -= instance.OnSelectMovePosition;
            @Ablity.started -= instance.OnAblity;
            @Ablity.performed -= instance.OnAblity;
            @Ablity.canceled -= instance.OnAblity;
            @Shot.started -= instance.OnShot;
            @Shot.performed -= instance.OnShot;
            @Shot.canceled -= instance.OnShot;
            @Confirm.started -= instance.OnConfirm;
            @Confirm.performed -= instance.OnConfirm;
            @Confirm.canceled -= instance.OnConfirm;
        }

        public void RemoveCallbacks(IGamePlayMapActions instance)
        {
            if (m_Wrapper.m_GamePlayMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamePlayMapActions instance)
        {
            foreach (var item in m_Wrapper.m_GamePlayMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamePlayMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamePlayMapActions @GamePlayMap => new GamePlayMapActions(this);
    public interface IGamePlayMapActions
    {
        void OnSelectMovePosition(InputAction.CallbackContext context);
        void OnAblity(InputAction.CallbackContext context);
        void OnShot(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
    }
}
