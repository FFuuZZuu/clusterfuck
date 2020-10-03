// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Actions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Actions"",
    ""maps"": [
        {
            ""name"": ""DebugConsole"",
            ""id"": ""292fbede-1624-4bc1-b78a-38d46c461999"",
            ""actions"": [
                {
                    ""name"": ""ToggleConsole"",
                    ""type"": ""Button"",
                    ""id"": ""dfb101f1-8138-47b9-91ab-944b048da364"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""334856c7-2123-479c-8506-c7ed075a5369"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""daf3a296-e3f3-4775-89dc-3f39e1ddf015"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""ToggleConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34397bc9-61bf-491b-8ea3-05a48c58e58b"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard+Mouse"",
            ""bindingGroup"": ""Keyboard+Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // DebugConsole
        m_DebugConsole = asset.FindActionMap("DebugConsole", throwIfNotFound: true);
        m_DebugConsole_ToggleConsole = m_DebugConsole.FindAction("ToggleConsole", throwIfNotFound: true);
        m_DebugConsole_Enter = m_DebugConsole.FindAction("Enter", throwIfNotFound: true);
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

    // DebugConsole
    private readonly InputActionMap m_DebugConsole;
    private IDebugConsoleActions m_DebugConsoleActionsCallbackInterface;
    private readonly InputAction m_DebugConsole_ToggleConsole;
    private readonly InputAction m_DebugConsole_Enter;
    public struct DebugConsoleActions
    {
        private @Actions m_Wrapper;
        public DebugConsoleActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleConsole => m_Wrapper.m_DebugConsole_ToggleConsole;
        public InputAction @Enter => m_Wrapper.m_DebugConsole_Enter;
        public InputActionMap Get() { return m_Wrapper.m_DebugConsole; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugConsoleActions set) { return set.Get(); }
        public void SetCallbacks(IDebugConsoleActions instance)
        {
            if (m_Wrapper.m_DebugConsoleActionsCallbackInterface != null)
            {
                @ToggleConsole.started -= m_Wrapper.m_DebugConsoleActionsCallbackInterface.OnToggleConsole;
                @ToggleConsole.performed -= m_Wrapper.m_DebugConsoleActionsCallbackInterface.OnToggleConsole;
                @ToggleConsole.canceled -= m_Wrapper.m_DebugConsoleActionsCallbackInterface.OnToggleConsole;
                @Enter.started -= m_Wrapper.m_DebugConsoleActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_DebugConsoleActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_DebugConsoleActionsCallbackInterface.OnEnter;
            }
            m_Wrapper.m_DebugConsoleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleConsole.started += instance.OnToggleConsole;
                @ToggleConsole.performed += instance.OnToggleConsole;
                @ToggleConsole.canceled += instance.OnToggleConsole;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
            }
        }
    }
    public DebugConsoleActions @DebugConsole => new DebugConsoleActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard+Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IDebugConsoleActions
    {
        void OnToggleConsole(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
    }
}
