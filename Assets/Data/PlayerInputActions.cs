// GENERATED AUTOMATICALLY FROM 'Assets/Data/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerActionMap"",
            ""id"": ""72211db9-0af3-4b5e-b1e4-adcd3e8fccdd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""5df3b06c-a96f-4725-bf61-e58589d2d924"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CarThrottle"",
                    ""type"": ""Button"",
                    ""id"": ""d3700472-848a-4760-87e7-9684cbd0cc4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CarTurn"",
                    ""type"": ""Value"",
                    ""id"": ""dceace59-c31c-4c05-9e0a-d545489652d2"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3d29b3b1-234f-4468-ac58-d7ee822f82c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Button"",
                    ""id"": ""cb59344f-be2c-499e-af6d-ca4829efe60a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""65694086-bf5e-4592-8d3d-644cf2623a43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""037fe53a-21d5-4424-9e75-434bd9b7165c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnterCar"",
                    ""type"": ""Button"",
                    ""id"": ""6f4e4f78-2b1d-40e6-ae8f-a3c9a4b15ec3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""16e8d10a-fcc0-423d-94ee-544f9fa939c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""3e4a6ed7-8607-47d4-ba79-784906c45e59"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""491d0ef6-d649-4d37-8e07-7644fb78b868"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""37bf9cd0-ae16-4c47-86e1-58689b0ce7ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TurnRight"",
                    ""type"": ""Value"",
                    ""id"": ""159f79d8-bc81-4e15-8665-b8b72d8fbd63"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurnLeft"",
                    ""type"": ""Value"",
                    ""id"": ""c5bcb6cf-3bf9-447a-b3d2-8b778ed01170"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a9d7bcf2-c380-41b6-8c1b-ea17fb2ad6b0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c9d360bf-db3f-4dd3-9abc-a03dad5066d4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1737fdda-cd8c-4c53-a15c-99c6eee1655b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f14ab8e-25a2-4e29-b23d-e133e0ea79fd"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""815831d8-66e5-48ba-aca5-c603faea74ef"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94a15723-c7a7-46b9-8102-6fff6c5b5dd6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0597a350-4d20-4eb4-86fe-0d8478375a80"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d5ef32d-e47d-40d3-a78b-26725a23b940"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59f82833-2fa0-4085-9d3f-4e727f2088ad"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b3c1cd6b-4f6b-4a1f-8d38-4bca358bb49a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1df05ebf-df99-47c4-9ab3-4173e22c51dd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5ef34cdb-abea-4105-9c0f-22e277e5eb49"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cca0d9e7-bd57-4856-beda-3da324a271eb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""97f0a616-02b3-44a9-9417-d100e02009ff"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarThrottle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""021da486-8e22-4eef-9f1a-c7f0a8a900a7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarThrottle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0a7ac346-5dfe-471f-902d-9d4091032499"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarThrottle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2045618f-5596-4436-a228-f391f1aa95de"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarTurn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""47967f96-8084-4547-a268-8513762a5876"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f4df8e57-984d-48e7-9c19-ef867f4ca7bc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ab3a6369-5a7d-48fb-b7e5-7b1a6f37c449"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39141351-abcf-4cfa-8fc9-181df88da806"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActionMap
        m_PlayerActionMap = asset.FindActionMap("PlayerActionMap", throwIfNotFound: true);
        m_PlayerActionMap_Movement = m_PlayerActionMap.FindAction("Movement", throwIfNotFound: true);
        m_PlayerActionMap_CarThrottle = m_PlayerActionMap.FindAction("CarThrottle", throwIfNotFound: true);
        m_PlayerActionMap_CarTurn = m_PlayerActionMap.FindAction("CarTurn", throwIfNotFound: true);
        m_PlayerActionMap_Jump = m_PlayerActionMap.FindAction("Jump", throwIfNotFound: true);
        m_PlayerActionMap_Break = m_PlayerActionMap.FindAction("Break", throwIfNotFound: true);
        m_PlayerActionMap_Roll = m_PlayerActionMap.FindAction("Roll", throwIfNotFound: true);
        m_PlayerActionMap_Interact = m_PlayerActionMap.FindAction("Interact", throwIfNotFound: true);
        m_PlayerActionMap_EnterCar = m_PlayerActionMap.FindAction("EnterCar", throwIfNotFound: true);
        m_PlayerActionMap_Run = m_PlayerActionMap.FindAction("Run", throwIfNotFound: true);
        m_PlayerActionMap_Aim = m_PlayerActionMap.FindAction("Aim", throwIfNotFound: true);
        m_PlayerActionMap_Look = m_PlayerActionMap.FindAction("Look", throwIfNotFound: true);
        m_PlayerActionMap_Pause = m_PlayerActionMap.FindAction("Pause", throwIfNotFound: true);
        m_PlayerActionMap_TurnRight = m_PlayerActionMap.FindAction("TurnRight", throwIfNotFound: true);
        m_PlayerActionMap_TurnLeft = m_PlayerActionMap.FindAction("TurnLeft", throwIfNotFound: true);
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

    // PlayerActionMap
    private readonly InputActionMap m_PlayerActionMap;
    private IPlayerActionMapActions m_PlayerActionMapActionsCallbackInterface;
    private readonly InputAction m_PlayerActionMap_Movement;
    private readonly InputAction m_PlayerActionMap_CarThrottle;
    private readonly InputAction m_PlayerActionMap_CarTurn;
    private readonly InputAction m_PlayerActionMap_Jump;
    private readonly InputAction m_PlayerActionMap_Break;
    private readonly InputAction m_PlayerActionMap_Roll;
    private readonly InputAction m_PlayerActionMap_Interact;
    private readonly InputAction m_PlayerActionMap_EnterCar;
    private readonly InputAction m_PlayerActionMap_Run;
    private readonly InputAction m_PlayerActionMap_Aim;
    private readonly InputAction m_PlayerActionMap_Look;
    private readonly InputAction m_PlayerActionMap_Pause;
    private readonly InputAction m_PlayerActionMap_TurnRight;
    private readonly InputAction m_PlayerActionMap_TurnLeft;
    public struct PlayerActionMapActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActionMapActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerActionMap_Movement;
        public InputAction @CarThrottle => m_Wrapper.m_PlayerActionMap_CarThrottle;
        public InputAction @CarTurn => m_Wrapper.m_PlayerActionMap_CarTurn;
        public InputAction @Jump => m_Wrapper.m_PlayerActionMap_Jump;
        public InputAction @Break => m_Wrapper.m_PlayerActionMap_Break;
        public InputAction @Roll => m_Wrapper.m_PlayerActionMap_Roll;
        public InputAction @Interact => m_Wrapper.m_PlayerActionMap_Interact;
        public InputAction @EnterCar => m_Wrapper.m_PlayerActionMap_EnterCar;
        public InputAction @Run => m_Wrapper.m_PlayerActionMap_Run;
        public InputAction @Aim => m_Wrapper.m_PlayerActionMap_Aim;
        public InputAction @Look => m_Wrapper.m_PlayerActionMap_Look;
        public InputAction @Pause => m_Wrapper.m_PlayerActionMap_Pause;
        public InputAction @TurnRight => m_Wrapper.m_PlayerActionMap_TurnRight;
        public InputAction @TurnLeft => m_Wrapper.m_PlayerActionMap_TurnLeft;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionMapActions instance)
        {
            if (m_Wrapper.m_PlayerActionMapActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMovement;
                @CarThrottle.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnCarThrottle;
                @CarThrottle.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnCarThrottle;
                @CarThrottle.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnCarThrottle;
                @CarTurn.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnCarTurn;
                @CarTurn.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnCarTurn;
                @CarTurn.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnCarTurn;
                @Jump.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnJump;
                @Break.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnBreak;
                @Roll.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnRoll;
                @Interact.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnInteract;
                @EnterCar.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnEnterCar;
                @EnterCar.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnEnterCar;
                @EnterCar.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnEnterCar;
                @Run.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnRun;
                @Aim.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnAim;
                @Look.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnLook;
                @Pause.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnPause;
                @TurnRight.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnTurnRight;
                @TurnRight.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnTurnRight;
                @TurnRight.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnTurnRight;
                @TurnLeft.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnTurnLeft;
                @TurnLeft.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnTurnLeft;
            }
            m_Wrapper.m_PlayerActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @CarThrottle.started += instance.OnCarThrottle;
                @CarThrottle.performed += instance.OnCarThrottle;
                @CarThrottle.canceled += instance.OnCarThrottle;
                @CarTurn.started += instance.OnCarTurn;
                @CarTurn.performed += instance.OnCarTurn;
                @CarTurn.canceled += instance.OnCarTurn;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @EnterCar.started += instance.OnEnterCar;
                @EnterCar.performed += instance.OnEnterCar;
                @EnterCar.canceled += instance.OnEnterCar;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @TurnRight.started += instance.OnTurnRight;
                @TurnRight.performed += instance.OnTurnRight;
                @TurnRight.canceled += instance.OnTurnRight;
                @TurnLeft.started += instance.OnTurnLeft;
                @TurnLeft.performed += instance.OnTurnLeft;
                @TurnLeft.canceled += instance.OnTurnLeft;
            }
        }
    }
    public PlayerActionMapActions @PlayerActionMap => new PlayerActionMapActions(this);
    public interface IPlayerActionMapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCarThrottle(InputAction.CallbackContext context);
        void OnCarTurn(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnEnterCar(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnTurnRight(InputAction.CallbackContext context);
        void OnTurnLeft(InputAction.CallbackContext context);
    }
}
