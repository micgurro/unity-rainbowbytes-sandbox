//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""4266ab51-29ee-4f87-ac7b-7acf24f3f5eb"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9a393d95-6cc1-4153-8264-c95c0809d837"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a20008d5-5cc8-4fb6-8d78-479f2046fe64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ab161df4-984f-466f-8a66-d317dfde8b9b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""006c294a-63a1-43af-9cc3-ae22c12336a1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8cf00dde-5658-497f-89ca-a3b9f3340ef3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2fdbe919-0033-4c1d-9aef-219841f9b1ed"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""959bdbc7-e5ee-455f-ac69-fcf2fa665d45"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d743f0bf-1f7e-476c-947c-943f5187f3ce"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8dfdffaf-61d1-4818-ba13-74fcd38fcdba"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a26a9434-a95d-4b60-a038-9b8373e0487c"",
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
                    ""id"": ""b1060a71-97bb-4739-8d14-a25c29a56e0e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""819fa46d-286c-4676-858d-2a9fec844442"",
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
                    ""id"": ""cdec709a-151c-4cc3-9a16-5debc50f6c6d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerActions"",
            ""id"": ""c6763c29-0322-4570-8833-a60bcc93abaf"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""a63ce6cb-1ea7-4c76-9ae1-fc0e023a04de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Wake"",
                    ""type"": ""Button"",
                    ""id"": ""98840bff-660a-4fc3-8c1b-03818070810c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""cc5d7e1f-24f7-4284-8ac1-c9b9c7b881a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cf609d75-e5ff-4b41-a6d1-6fbe71e29343"",
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
                    ""id"": ""fc995ca9-34c6-462c-897c-fa45560b016a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09d5b8b5-39d7-41c4-a873-f80e0c31a832"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Wake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92daa690-463a-41e4-b312-a45e806c03b5"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Wake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1724f5a-e2a5-449f-b649-d3d267021c9e"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cf84e83-bbb0-4431-b8f5-4c9798b7edef"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerUI"",
            ""id"": ""9f19327c-17dd-405c-a042-2af9ccaa5c40"",
            ""actions"": [
                {
                    ""name"": ""Hotbar1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d8ecf7f5-e915-4c9e-876a-307a1b3d0850"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""59922cc8-a93f-4d90-986a-3d05218c89ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar3"",
                    ""type"": ""PassThrough"",
                    ""id"": ""15798ff8-56b2-4729-8b5e-0c4a21d80ae4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar4"",
                    ""type"": ""PassThrough"",
                    ""id"": ""532c7af3-668f-464b-82ff-8af7c8f65204"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar5"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0fa7bef9-061f-4602-8a35-9af0e628a802"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar6"",
                    ""type"": ""PassThrough"",
                    ""id"": ""334492ed-32ed-4cbb-9d25-0c1552c6b28c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Button"",
                    ""id"": ""579e87b3-559a-4227-bc61-d1a83a2baf54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d58aee77-6fa5-4b91-8e2e-e61487427e15"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""954d73fe-e083-41ec-b197-db7d03228b60"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hotbar1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01ca47b3-9a07-435a-a8c6-4a0604c15546"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hotbar2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ac6669e-78c2-474a-9c64-e9e5df72d437"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hotbar3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97eb3b76-4337-4534-9b96-a364f2d896fa"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hotbar4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af5f470a-21ba-4d4a-a4ef-bec6234f522a"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hotbar5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46406cf9-384d-4e48-8842-0cd6c3e2c165"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hotbar6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed238092-97c7-45c3-9ad8-628febfdcb27"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d08fe166-3b8d-4684-8f8d-64456a29ee60"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Move = m_PlayerMovement.FindAction("Move", throwIfNotFound: true);
        m_PlayerMovement_Jump = m_PlayerMovement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMovement_Look = m_PlayerMovement.FindAction("Look", throwIfNotFound: true);
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_Interact = m_PlayerActions.FindAction("Interact", throwIfNotFound: true);
        m_PlayerActions_Wake = m_PlayerActions.FindAction("Wake", throwIfNotFound: true);
        m_PlayerActions_Inventory = m_PlayerActions.FindAction("Inventory", throwIfNotFound: true);
        // PlayerUI
        m_PlayerUI = asset.FindActionMap("PlayerUI", throwIfNotFound: true);
        m_PlayerUI_Hotbar1 = m_PlayerUI.FindAction("Hotbar1", throwIfNotFound: true);
        m_PlayerUI_Hotbar2 = m_PlayerUI.FindAction("Hotbar2", throwIfNotFound: true);
        m_PlayerUI_Hotbar3 = m_PlayerUI.FindAction("Hotbar3", throwIfNotFound: true);
        m_PlayerUI_Hotbar4 = m_PlayerUI.FindAction("Hotbar4", throwIfNotFound: true);
        m_PlayerUI_Hotbar5 = m_PlayerUI.FindAction("Hotbar5", throwIfNotFound: true);
        m_PlayerUI_Hotbar6 = m_PlayerUI.FindAction("Hotbar6", throwIfNotFound: true);
        m_PlayerUI_UseItem = m_PlayerUI.FindAction("UseItem", throwIfNotFound: true);
        m_PlayerUI_MouseWheel = m_PlayerUI.FindAction("MouseWheel", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private List<IPlayerMovementActions> m_PlayerMovementActionsCallbackInterfaces = new List<IPlayerMovementActions>();
    private readonly InputAction m_PlayerMovement_Move;
    private readonly InputAction m_PlayerMovement_Jump;
    private readonly InputAction m_PlayerMovement_Look;
    public struct PlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerMovement_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerMovement_Jump;
        public InputAction @Look => m_Wrapper.m_PlayerMovement_Look;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        private void UnregisterCallbacks(IPlayerMovementActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        public void RemoveCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private List<IPlayerActionsActions> m_PlayerActionsActionsCallbackInterfaces = new List<IPlayerActionsActions>();
    private readonly InputAction m_PlayerActions_Interact;
    private readonly InputAction m_PlayerActions_Wake;
    private readonly InputAction m_PlayerActions_Inventory;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_PlayerActions_Interact;
        public InputAction @Wake => m_Wrapper.m_PlayerActions_Wake;
        public InputAction @Inventory => m_Wrapper.m_PlayerActions_Inventory;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Add(instance);
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Wake.started += instance.OnWake;
            @Wake.performed += instance.OnWake;
            @Wake.canceled += instance.OnWake;
            @Inventory.started += instance.OnInventory;
            @Inventory.performed += instance.OnInventory;
            @Inventory.canceled += instance.OnInventory;
        }

        private void UnregisterCallbacks(IPlayerActionsActions instance)
        {
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Wake.started -= instance.OnWake;
            @Wake.performed -= instance.OnWake;
            @Wake.canceled -= instance.OnWake;
            @Inventory.started -= instance.OnInventory;
            @Inventory.performed -= instance.OnInventory;
            @Inventory.canceled -= instance.OnInventory;
        }

        public void RemoveCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

    // PlayerUI
    private readonly InputActionMap m_PlayerUI;
    private List<IPlayerUIActions> m_PlayerUIActionsCallbackInterfaces = new List<IPlayerUIActions>();
    private readonly InputAction m_PlayerUI_Hotbar1;
    private readonly InputAction m_PlayerUI_Hotbar2;
    private readonly InputAction m_PlayerUI_Hotbar3;
    private readonly InputAction m_PlayerUI_Hotbar4;
    private readonly InputAction m_PlayerUI_Hotbar5;
    private readonly InputAction m_PlayerUI_Hotbar6;
    private readonly InputAction m_PlayerUI_UseItem;
    private readonly InputAction m_PlayerUI_MouseWheel;
    public struct PlayerUIActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerUIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Hotbar1 => m_Wrapper.m_PlayerUI_Hotbar1;
        public InputAction @Hotbar2 => m_Wrapper.m_PlayerUI_Hotbar2;
        public InputAction @Hotbar3 => m_Wrapper.m_PlayerUI_Hotbar3;
        public InputAction @Hotbar4 => m_Wrapper.m_PlayerUI_Hotbar4;
        public InputAction @Hotbar5 => m_Wrapper.m_PlayerUI_Hotbar5;
        public InputAction @Hotbar6 => m_Wrapper.m_PlayerUI_Hotbar6;
        public InputAction @UseItem => m_Wrapper.m_PlayerUI_UseItem;
        public InputAction @MouseWheel => m_Wrapper.m_PlayerUI_MouseWheel;
        public InputActionMap Get() { return m_Wrapper.m_PlayerUI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerUIActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerUIActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerUIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerUIActionsCallbackInterfaces.Add(instance);
            @Hotbar1.started += instance.OnHotbar1;
            @Hotbar1.performed += instance.OnHotbar1;
            @Hotbar1.canceled += instance.OnHotbar1;
            @Hotbar2.started += instance.OnHotbar2;
            @Hotbar2.performed += instance.OnHotbar2;
            @Hotbar2.canceled += instance.OnHotbar2;
            @Hotbar3.started += instance.OnHotbar3;
            @Hotbar3.performed += instance.OnHotbar3;
            @Hotbar3.canceled += instance.OnHotbar3;
            @Hotbar4.started += instance.OnHotbar4;
            @Hotbar4.performed += instance.OnHotbar4;
            @Hotbar4.canceled += instance.OnHotbar4;
            @Hotbar5.started += instance.OnHotbar5;
            @Hotbar5.performed += instance.OnHotbar5;
            @Hotbar5.canceled += instance.OnHotbar5;
            @Hotbar6.started += instance.OnHotbar6;
            @Hotbar6.performed += instance.OnHotbar6;
            @Hotbar6.canceled += instance.OnHotbar6;
            @UseItem.started += instance.OnUseItem;
            @UseItem.performed += instance.OnUseItem;
            @UseItem.canceled += instance.OnUseItem;
            @MouseWheel.started += instance.OnMouseWheel;
            @MouseWheel.performed += instance.OnMouseWheel;
            @MouseWheel.canceled += instance.OnMouseWheel;
        }

        private void UnregisterCallbacks(IPlayerUIActions instance)
        {
            @Hotbar1.started -= instance.OnHotbar1;
            @Hotbar1.performed -= instance.OnHotbar1;
            @Hotbar1.canceled -= instance.OnHotbar1;
            @Hotbar2.started -= instance.OnHotbar2;
            @Hotbar2.performed -= instance.OnHotbar2;
            @Hotbar2.canceled -= instance.OnHotbar2;
            @Hotbar3.started -= instance.OnHotbar3;
            @Hotbar3.performed -= instance.OnHotbar3;
            @Hotbar3.canceled -= instance.OnHotbar3;
            @Hotbar4.started -= instance.OnHotbar4;
            @Hotbar4.performed -= instance.OnHotbar4;
            @Hotbar4.canceled -= instance.OnHotbar4;
            @Hotbar5.started -= instance.OnHotbar5;
            @Hotbar5.performed -= instance.OnHotbar5;
            @Hotbar5.canceled -= instance.OnHotbar5;
            @Hotbar6.started -= instance.OnHotbar6;
            @Hotbar6.performed -= instance.OnHotbar6;
            @Hotbar6.canceled -= instance.OnHotbar6;
            @UseItem.started -= instance.OnUseItem;
            @UseItem.performed -= instance.OnUseItem;
            @UseItem.canceled -= instance.OnUseItem;
            @MouseWheel.started -= instance.OnMouseWheel;
            @MouseWheel.performed -= instance.OnMouseWheel;
            @MouseWheel.canceled -= instance.OnMouseWheel;
        }

        public void RemoveCallbacks(IPlayerUIActions instance)
        {
            if (m_Wrapper.m_PlayerUIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerUIActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerUIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerUIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerUIActions @PlayerUI => new PlayerUIActions(this);
    public interface IPlayerMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnWake(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
    }
    public interface IPlayerUIActions
    {
        void OnHotbar1(InputAction.CallbackContext context);
        void OnHotbar2(InputAction.CallbackContext context);
        void OnHotbar3(InputAction.CallbackContext context);
        void OnHotbar4(InputAction.CallbackContext context);
        void OnHotbar5(InputAction.CallbackContext context);
        void OnHotbar6(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
        void OnMouseWheel(InputAction.CallbackContext context);
    }
}
