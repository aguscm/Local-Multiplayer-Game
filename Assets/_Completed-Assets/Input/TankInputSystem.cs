//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/_Completed-Assets/Input/TankInputSystem.inputactions
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

public partial class @TankInputSystem : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TankInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TankInputSystem"",
    ""maps"": [
        {
            ""name"": ""TankActionMap"",
            ""id"": ""e92c4ca8-6a96-4f36-b81c-876957319af9"",
            ""actions"": [
                {
                    ""name"": ""TankTurn"",
                    ""type"": ""Value"",
                    ""id"": ""0e32017a-6723-4866-ac89-5336bc68be92"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TankMove"",
                    ""type"": ""Value"",
                    ""id"": ""75e03cb5-463b-404b-a940-4bbb06bde96f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""dc7a09fb-d61e-4618-8519-2ba27b21ea75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold,Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""18441a0c-5479-4353-bfb0-91a8bd407b09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2e10742b-c000-4739-9c79-5625a06090bf"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard1"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""570de276-bdce-4834-8b90-b80d8827b8fe"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard2"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df8a7e22-806f-4a6b-8e37-9195a8b6b4d3"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard3"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d3bfd12-c931-4405-9d32-958845902893"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard4"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61db9dd3-3a86-400f-8add-d68569e3314a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40ab3f21-4c4a-4a86-a96d-201b18d2c388"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard1"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""998f81ee-ac4c-4f62-a1b8-5bfeafa7948d"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard2"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""256ac420-2804-4b79-a313-d1c9c2044d9e"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard3"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a50a1c7-b21e-486c-a3b2-c1f569a040b1"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard4"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e14a4477-7a1a-45e6-b91e-313a8a4b9c5a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""4f3d54fe-3b2b-4932-865b-1e24eedda74d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2fbd7653-eeda-4ebc-9f9b-28e74cdc231e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard1"",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""551c82a0-9bcf-4c51-8e41-6823561e8f87"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard1"",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1c04cdcd-5fb1-4889-8d0a-bcbfc86ed105"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c1a286ef-5583-4904-bf01-7e08237d12d2"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard2"",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1ca759c1-26d7-4184-87de-f3cd668fc9e5"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard2"",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""76309f4c-c0aa-4c07-9281-b8cc330a8b07"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b9c7784d-86a4-4bd1-b86d-82f3a6f85003"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard3"",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3c3c9825-1d7e-4a31-9e07-4145701f303c"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard3"",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""03689b78-4c4a-4634-8a8a-8491fb1def47"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8c275ed0-7dda-46a6-b5aa-dabd38062f99"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard4"",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c6b6d15a-7339-4c17-8526-875bdeb2fea4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard4"",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3850c61a-6fc0-4460-aae6-c3c27d07cc78"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""75b7601f-b4a4-40b8-915e-2c11284de9a7"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""eedd9506-338b-4214-bb61-4180268ff500"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""611f8bb2-cabd-4a5b-9aa9-43274fb4264d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankTurn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bda9885c-3a05-40d3-a800-5b6be4cc4b88"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard1"",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""acac3a28-a6ed-45ae-abe7-7ccb0057f1a6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard1"",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b300615b-27f4-4c57-bb22-d52dbb4a4b70"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankTurn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b14d8a50-2168-4d94-9104-ea3459bd3d76"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard2"",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a33e3d25-3e45-4271-9266-2ffc9fd75e78"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard2"",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f361df8a-c5b8-4f90-bd38-fc737c374962"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankTurn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2fa4aede-7fa7-41a6-8807-5c39df84abe4"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard3"",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3a61ddd1-e772-413c-88c8-f753f568e55b"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard3"",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7679edc1-60d0-495f-b343-87725c55fa1f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankTurn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""70d6b623-d342-429a-b5ed-6a148ba1431c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard4"",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8a036429-a297-49e1-b9b1-410b51dbd3dc"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard4"",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f0c7805a-d8f0-4044-bde4-1efa40989869"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankTurn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""22910f86-0c9d-4dc9-b6d2-0f3946ef8c74"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""60f865a7-8fea-44c8-8a2f-1bd9182ba6a5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankTurn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard1"",
            ""bindingGroup"": ""Keyboard1"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard2"",
            ""bindingGroup"": ""Keyboard2"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard3"",
            ""bindingGroup"": ""Keyboard3"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard4"",
            ""bindingGroup"": ""Keyboard4"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // TankActionMap
        m_TankActionMap = asset.FindActionMap("TankActionMap", throwIfNotFound: true);
        m_TankActionMap_TankTurn = m_TankActionMap.FindAction("TankTurn", throwIfNotFound: true);
        m_TankActionMap_TankMove = m_TankActionMap.FindAction("TankMove", throwIfNotFound: true);
        m_TankActionMap_Fire = m_TankActionMap.FindAction("Fire", throwIfNotFound: true);
        m_TankActionMap_Start = m_TankActionMap.FindAction("Start", throwIfNotFound: true);
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

    // TankActionMap
    private readonly InputActionMap m_TankActionMap;
    private ITankActionMapActions m_TankActionMapActionsCallbackInterface;
    private readonly InputAction m_TankActionMap_TankTurn;
    private readonly InputAction m_TankActionMap_TankMove;
    private readonly InputAction m_TankActionMap_Fire;
    private readonly InputAction m_TankActionMap_Start;
    public struct TankActionMapActions
    {
        private @TankInputSystem m_Wrapper;
        public TankActionMapActions(@TankInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @TankTurn => m_Wrapper.m_TankActionMap_TankTurn;
        public InputAction @TankMove => m_Wrapper.m_TankActionMap_TankMove;
        public InputAction @Fire => m_Wrapper.m_TankActionMap_Fire;
        public InputAction @Start => m_Wrapper.m_TankActionMap_Start;
        public InputActionMap Get() { return m_Wrapper.m_TankActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TankActionMapActions set) { return set.Get(); }
        public void SetCallbacks(ITankActionMapActions instance)
        {
            if (m_Wrapper.m_TankActionMapActionsCallbackInterface != null)
            {
                @TankTurn.started -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnTankTurn;
                @TankTurn.performed -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnTankTurn;
                @TankTurn.canceled -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnTankTurn;
                @TankMove.started -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnTankMove;
                @TankMove.performed -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnTankMove;
                @TankMove.canceled -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnTankMove;
                @Fire.started -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnFire;
                @Start.started -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_TankActionMapActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_TankActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TankTurn.started += instance.OnTankTurn;
                @TankTurn.performed += instance.OnTankTurn;
                @TankTurn.canceled += instance.OnTankTurn;
                @TankMove.started += instance.OnTankMove;
                @TankMove.performed += instance.OnTankMove;
                @TankMove.canceled += instance.OnTankMove;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public TankActionMapActions @TankActionMap => new TankActionMapActions(this);
    private int m_Keyboard1SchemeIndex = -1;
    public InputControlScheme Keyboard1Scheme
    {
        get
        {
            if (m_Keyboard1SchemeIndex == -1) m_Keyboard1SchemeIndex = asset.FindControlSchemeIndex("Keyboard1");
            return asset.controlSchemes[m_Keyboard1SchemeIndex];
        }
    }
    private int m_Keyboard2SchemeIndex = -1;
    public InputControlScheme Keyboard2Scheme
    {
        get
        {
            if (m_Keyboard2SchemeIndex == -1) m_Keyboard2SchemeIndex = asset.FindControlSchemeIndex("Keyboard2");
            return asset.controlSchemes[m_Keyboard2SchemeIndex];
        }
    }
    private int m_Keyboard3SchemeIndex = -1;
    public InputControlScheme Keyboard3Scheme
    {
        get
        {
            if (m_Keyboard3SchemeIndex == -1) m_Keyboard3SchemeIndex = asset.FindControlSchemeIndex("Keyboard3");
            return asset.controlSchemes[m_Keyboard3SchemeIndex];
        }
    }
    private int m_Keyboard4SchemeIndex = -1;
    public InputControlScheme Keyboard4Scheme
    {
        get
        {
            if (m_Keyboard4SchemeIndex == -1) m_Keyboard4SchemeIndex = asset.FindControlSchemeIndex("Keyboard4");
            return asset.controlSchemes[m_Keyboard4SchemeIndex];
        }
    }
    public interface ITankActionMapActions
    {
        void OnTankTurn(InputAction.CallbackContext context);
        void OnTankMove(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}
