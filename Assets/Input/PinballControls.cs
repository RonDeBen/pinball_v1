// GENERATED AUTOMATICALLY FROM 'Assets/Input/PinballControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PinballControls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PinballControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PinballControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f84fe4d4-8b84-48f7-9b5f-8c5cf1a92cf6"",
            ""actions"": [
                {
                    ""name"": ""LeftTriggerPressed"",
                    ""type"": ""Button"",
                    ""id"": ""6231272f-f5a7-49af-a881-e9df22f34c11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTriggerPressed"",
                    ""type"": ""Button"",
                    ""id"": ""be991e0f-6788-40b2-a73e-db11d2e85bb3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTriggerReleased"",
                    ""type"": ""Button"",
                    ""id"": ""20b94c2d-a999-4826-87d2-131efbcd2fc2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftTriggerReleased"",
                    ""type"": ""Button"",
                    ""id"": ""7aeff1d5-a754-4314-8d89-2250ea6a700e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Plunger"",
                    ""type"": ""Value"",
                    ""id"": ""907745be-4685-4baf-8a26-3997839aa772"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f578354e-86a1-4fc2-b072-17f15225a305"",
                    ""path"": ""<HID::VirtuaPin Controller>/button10"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTriggerPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98149302-17d1-4812-9914-44ec9f28f4ff"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTriggerPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db29e346-a069-4afe-9826-c9976a7100c1"",
                    ""path"": ""<HID::VirtuaPin Controller>/button2"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTriggerPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""add6745b-9e62-4c95-b0b4-a0abd4e7abd7"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTriggerPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0df06350-e067-40e5-983c-732a8b45675a"",
                    ""path"": ""<HID::VirtuaPin Controller>/button2"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTriggerReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38b799bc-91a7-443b-8317-f0402233f582"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTriggerReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d54e2dae-34cd-4344-b023-4605e3d337da"",
                    ""path"": ""<HID::VirtuaPin Controller>/button10"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTriggerReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5745596-5ee7-4d48-bba7-adbcafd5ba23"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTriggerReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c0797d6-4e55-45a1-91ce-2e2324a98702"",
                    ""path"": ""<HID::VirtuaPin Controller>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Plunger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_LeftTriggerPressed = m_Player.FindAction("LeftTriggerPressed", throwIfNotFound: true);
        m_Player_RightTriggerPressed = m_Player.FindAction("RightTriggerPressed", throwIfNotFound: true);
        m_Player_RightTriggerReleased = m_Player.FindAction("RightTriggerReleased", throwIfNotFound: true);
        m_Player_LeftTriggerReleased = m_Player.FindAction("LeftTriggerReleased", throwIfNotFound: true);
        m_Player_Plunger = m_Player.FindAction("Plunger", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_LeftTriggerPressed;
    private readonly InputAction m_Player_RightTriggerPressed;
    private readonly InputAction m_Player_RightTriggerReleased;
    private readonly InputAction m_Player_LeftTriggerReleased;
    private readonly InputAction m_Player_Plunger;
    public struct PlayerActions
    {
        private @PinballControls m_Wrapper;
        public PlayerActions(@PinballControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftTriggerPressed => m_Wrapper.m_Player_LeftTriggerPressed;
        public InputAction @RightTriggerPressed => m_Wrapper.m_Player_RightTriggerPressed;
        public InputAction @RightTriggerReleased => m_Wrapper.m_Player_RightTriggerReleased;
        public InputAction @LeftTriggerReleased => m_Wrapper.m_Player_LeftTriggerReleased;
        public InputAction @Plunger => m_Wrapper.m_Player_Plunger;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @LeftTriggerPressed.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftTriggerPressed;
                @LeftTriggerPressed.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftTriggerPressed;
                @LeftTriggerPressed.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftTriggerPressed;
                @RightTriggerPressed.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightTriggerPressed;
                @RightTriggerPressed.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightTriggerPressed;
                @RightTriggerPressed.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightTriggerPressed;
                @RightTriggerReleased.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightTriggerReleased;
                @RightTriggerReleased.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightTriggerReleased;
                @RightTriggerReleased.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightTriggerReleased;
                @LeftTriggerReleased.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftTriggerReleased;
                @LeftTriggerReleased.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftTriggerReleased;
                @LeftTriggerReleased.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftTriggerReleased;
                @Plunger.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlunger;
                @Plunger.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlunger;
                @Plunger.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlunger;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftTriggerPressed.started += instance.OnLeftTriggerPressed;
                @LeftTriggerPressed.performed += instance.OnLeftTriggerPressed;
                @LeftTriggerPressed.canceled += instance.OnLeftTriggerPressed;
                @RightTriggerPressed.started += instance.OnRightTriggerPressed;
                @RightTriggerPressed.performed += instance.OnRightTriggerPressed;
                @RightTriggerPressed.canceled += instance.OnRightTriggerPressed;
                @RightTriggerReleased.started += instance.OnRightTriggerReleased;
                @RightTriggerReleased.performed += instance.OnRightTriggerReleased;
                @RightTriggerReleased.canceled += instance.OnRightTriggerReleased;
                @LeftTriggerReleased.started += instance.OnLeftTriggerReleased;
                @LeftTriggerReleased.performed += instance.OnLeftTriggerReleased;
                @LeftTriggerReleased.canceled += instance.OnLeftTriggerReleased;
                @Plunger.started += instance.OnPlunger;
                @Plunger.performed += instance.OnPlunger;
                @Plunger.canceled += instance.OnPlunger;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnLeftTriggerPressed(InputAction.CallbackContext context);
        void OnRightTriggerPressed(InputAction.CallbackContext context);
        void OnRightTriggerReleased(InputAction.CallbackContext context);
        void OnLeftTriggerReleased(InputAction.CallbackContext context);
        void OnPlunger(InputAction.CallbackContext context);
    }
}
