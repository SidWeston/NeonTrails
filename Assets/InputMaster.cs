// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1ef4a223-740e-41bd-b358-4e655916d228"",
            ""actions"": [
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Button"",
                    ""id"": ""2c0f4f0b-c8bd-426f-8801-3b2402d8a3e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""373d8aaf-e7ed-4090-8c51-70d02c487338"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turning"",
                    ""type"": ""Value"",
                    ""id"": ""df021234-5900-4141-8539-53c9e10e9031"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""144a2481-4aa4-4a27-8f49-fe85a29f5796"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42bbeccc-37e9-4a7a-9e98-f726180e3cd2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Acceleration - Controller"",
                    ""id"": ""ac968a38-36da-43ed-b8e9-e2c4981e6981"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c2ca161e-c27c-40a6-b8e7-016a1b17f36e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""da2aec16-146d-4b60-b5ae-78eb512cb29f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Acceleration - KB/M"",
                    ""id"": ""9a202184-bb0c-4544-8ebe-e8803033959f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d91fa1af-26db-4e24-b7a4-5e39dfbb48ec"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6efdb92c-1fe6-4be7-bea1-f30e5822f757"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Turning - Controller"",
                    ""id"": ""8df883e1-8597-4c8f-85b3-c0faa4808a7a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c42f1587-0120-4de7-a66f-c785f87e68e5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f1547e8b-5df4-4146-a952-b409d8c4b9cd"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Turning - KB/M"",
                    ""id"": ""72046590-f04d-496d-8900-4fac4e16a82b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""687934ad-6a3d-4195-a290-f278a9dabef4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6bf5931a-17a7-4f43-a1a9-eae7f7526400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player Keyboard"",
            ""id"": ""411fb663-c607-4425-ad3d-9723bd61336c"",
            ""actions"": [
                {
                    ""name"": ""Turning - KB/M"",
                    ""type"": ""Button"",
                    ""id"": ""64e21e94-ea29-4873-89d8-2114aca7c544"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Acceleration - KB/M"",
                    ""type"": ""Button"",
                    ""id"": ""47c8dbfd-29d9-4395-9e09-40561be40cad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Handbrake - KB/M"",
                    ""type"": ""Button"",
                    ""id"": ""8dc1fe6d-a759-44b1-af7f-e7713f47a519"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4693e87-0b8f-4759-a57c-97955948f4dc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake - KB/M"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Acceleration - KB/M"",
                    ""id"": ""533654c9-93c2-409f-8baf-1c3a3056c711"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration - KB/M"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""01c08452-6651-4705-a476-150d7dc4fbae"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration - KB/M"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""043e1109-524f-46b9-ae70-b1edc6f14328"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration - KB/M"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Turning - KB/M"",
                    ""id"": ""f2afdb03-69e6-4077-ae8a-affc311fdb46"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning - KB/M"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""70f4d185-0c90-4fa4-ac4e-0fe437a19379"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning - KB/M"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""02b086e0-a61f-42dd-8576-1cb9955d0705"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning - KB/M"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""a46a355a-22b2-4627-8fc8-1d91d51d7c8c"",
            ""actions"": [
                {
                    ""name"": ""NextCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""a6ae4df1-72b7-4d36-a068-b524cf344c04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PreviousCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""6919313e-2b8d-4e25-a4b1-db7e10b67174"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""732443f3-4656-4efa-8854-ec6fd46c9a08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b818479c-b2fe-4f3d-808c-886d6996aed3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""256aa178-2d45-430f-af32-4fd7e313e387"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfe8c176-b280-4bef-be85-54d48016a354"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51b536c2-d18c-44c4-944a-5413432cd6a3"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0a5b8f9-f43f-46ba-8d9f-19f91d2eb602"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75e08781-2dd9-42ef-8290-6f9d964ffa36"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0ac6fad-7876-4bd6-b038-e6a1c5b6118d"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bdd6a33-fe97-46b0-99de-3c79de7a0541"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb74b47f-ea7e-4dd1-96ed-89b517490375"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox Control Scheme"",
            ""bindingGroup"": ""Xbox Control Scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Handbrake = m_Player.FindAction("Handbrake", throwIfNotFound: true);
        m_Player_Accelerate = m_Player.FindAction("Accelerate", throwIfNotFound: true);
        m_Player_Turning = m_Player.FindAction("Turning", throwIfNotFound: true);
        // Player Keyboard
        m_PlayerKeyboard = asset.FindActionMap("Player Keyboard", throwIfNotFound: true);
        m_PlayerKeyboard_TurningKBM = m_PlayerKeyboard.FindAction("Turning - KB/M", throwIfNotFound: true);
        m_PlayerKeyboard_AccelerationKBM = m_PlayerKeyboard.FindAction("Acceleration - KB/M", throwIfNotFound: true);
        m_PlayerKeyboard_HandbrakeKBM = m_PlayerKeyboard.FindAction("Handbrake - KB/M", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_NextCharacter = m_UI.FindAction("NextCharacter", throwIfNotFound: true);
        m_UI_PreviousCharacter = m_UI.FindAction("PreviousCharacter", throwIfNotFound: true);
        m_UI_SelectCharacter = m_UI.FindAction("SelectCharacter", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Handbrake;
    private readonly InputAction m_Player_Accelerate;
    private readonly InputAction m_Player_Turning;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Handbrake => m_Wrapper.m_Player_Handbrake;
        public InputAction @Accelerate => m_Wrapper.m_Player_Accelerate;
        public InputAction @Turning => m_Wrapper.m_Player_Turning;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Handbrake.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHandbrake;
                @Handbrake.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHandbrake;
                @Handbrake.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHandbrake;
                @Accelerate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAccelerate;
                @Turning.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurning;
                @Turning.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurning;
                @Turning.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurning;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Handbrake.started += instance.OnHandbrake;
                @Handbrake.performed += instance.OnHandbrake;
                @Handbrake.canceled += instance.OnHandbrake;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Turning.started += instance.OnTurning;
                @Turning.performed += instance.OnTurning;
                @Turning.canceled += instance.OnTurning;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Player Keyboard
    private readonly InputActionMap m_PlayerKeyboard;
    private IPlayerKeyboardActions m_PlayerKeyboardActionsCallbackInterface;
    private readonly InputAction m_PlayerKeyboard_TurningKBM;
    private readonly InputAction m_PlayerKeyboard_AccelerationKBM;
    private readonly InputAction m_PlayerKeyboard_HandbrakeKBM;
    public struct PlayerKeyboardActions
    {
        private @InputMaster m_Wrapper;
        public PlayerKeyboardActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @TurningKBM => m_Wrapper.m_PlayerKeyboard_TurningKBM;
        public InputAction @AccelerationKBM => m_Wrapper.m_PlayerKeyboard_AccelerationKBM;
        public InputAction @HandbrakeKBM => m_Wrapper.m_PlayerKeyboard_HandbrakeKBM;
        public InputActionMap Get() { return m_Wrapper.m_PlayerKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerKeyboardActions instance)
        {
            if (m_Wrapper.m_PlayerKeyboardActionsCallbackInterface != null)
            {
                @TurningKBM.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnTurningKBM;
                @TurningKBM.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnTurningKBM;
                @TurningKBM.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnTurningKBM;
                @AccelerationKBM.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnAccelerationKBM;
                @AccelerationKBM.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnAccelerationKBM;
                @AccelerationKBM.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnAccelerationKBM;
                @HandbrakeKBM.started -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnHandbrakeKBM;
                @HandbrakeKBM.performed -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnHandbrakeKBM;
                @HandbrakeKBM.canceled -= m_Wrapper.m_PlayerKeyboardActionsCallbackInterface.OnHandbrakeKBM;
            }
            m_Wrapper.m_PlayerKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TurningKBM.started += instance.OnTurningKBM;
                @TurningKBM.performed += instance.OnTurningKBM;
                @TurningKBM.canceled += instance.OnTurningKBM;
                @AccelerationKBM.started += instance.OnAccelerationKBM;
                @AccelerationKBM.performed += instance.OnAccelerationKBM;
                @AccelerationKBM.canceled += instance.OnAccelerationKBM;
                @HandbrakeKBM.started += instance.OnHandbrakeKBM;
                @HandbrakeKBM.performed += instance.OnHandbrakeKBM;
                @HandbrakeKBM.canceled += instance.OnHandbrakeKBM;
            }
        }
    }
    public PlayerKeyboardActions @PlayerKeyboard => new PlayerKeyboardActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_NextCharacter;
    private readonly InputAction m_UI_PreviousCharacter;
    private readonly InputAction m_UI_SelectCharacter;
    public struct UIActions
    {
        private @InputMaster m_Wrapper;
        public UIActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextCharacter => m_Wrapper.m_UI_NextCharacter;
        public InputAction @PreviousCharacter => m_Wrapper.m_UI_PreviousCharacter;
        public InputAction @SelectCharacter => m_Wrapper.m_UI_SelectCharacter;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @NextCharacter.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNextCharacter;
                @NextCharacter.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNextCharacter;
                @NextCharacter.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNextCharacter;
                @PreviousCharacter.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPreviousCharacter;
                @PreviousCharacter.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPreviousCharacter;
                @PreviousCharacter.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPreviousCharacter;
                @SelectCharacter.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSelectCharacter;
                @SelectCharacter.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSelectCharacter;
                @SelectCharacter.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSelectCharacter;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextCharacter.started += instance.OnNextCharacter;
                @NextCharacter.performed += instance.OnNextCharacter;
                @NextCharacter.canceled += instance.OnNextCharacter;
                @PreviousCharacter.started += instance.OnPreviousCharacter;
                @PreviousCharacter.performed += instance.OnPreviousCharacter;
                @PreviousCharacter.canceled += instance.OnPreviousCharacter;
                @SelectCharacter.started += instance.OnSelectCharacter;
                @SelectCharacter.performed += instance.OnSelectCharacter;
                @SelectCharacter.canceled += instance.OnSelectCharacter;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_XboxControlSchemeSchemeIndex = -1;
    public InputControlScheme XboxControlSchemeScheme
    {
        get
        {
            if (m_XboxControlSchemeSchemeIndex == -1) m_XboxControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Xbox Control Scheme");
            return asset.controlSchemes[m_XboxControlSchemeSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnHandbrake(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnTurning(InputAction.CallbackContext context);
    }
    public interface IPlayerKeyboardActions
    {
        void OnTurningKBM(InputAction.CallbackContext context);
        void OnAccelerationKBM(InputAction.CallbackContext context);
        void OnHandbrakeKBM(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNextCharacter(InputAction.CallbackContext context);
        void OnPreviousCharacter(InputAction.CallbackContext context);
        void OnSelectCharacter(InputAction.CallbackContext context);
    }
}
