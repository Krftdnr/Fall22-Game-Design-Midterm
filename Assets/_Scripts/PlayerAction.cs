//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/_Scripts/PlayerAction.inputactions
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

public partial class @PlayerAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""48149007-4fbb-48c5-8ed0-50965b1c698f"",
            ""actions"": [
                {
                    ""name"": ""Turn"",
                    ""type"": ""Button"",
                    ""id"": ""a5f740d4-c14e-469c-ad47-0550aaeb2e58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""65622fbd-0344-44ae-a899-ea2432c569fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""acedc55f-60fe-43cb-a6a9-57b343e9d740"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8c5218ac-0b9f-4d10-9241-c919deb46e39"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdc3abe2-1b24-48ae-a966-9d72995593d8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""890484af-4e69-433b-8847-f38b7cf64f0b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Editor"",
            ""id"": ""d3a2c2cc-7001-45a4-8557-aa0a29eb968b"",
            ""actions"": [
                {
                    ""name"": ""EditorMode"",
                    ""type"": ""Button"",
                    ""id"": ""8918c4ef-27ec-43fc-b866-a47c06bc3196"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AddItem1"",
                    ""type"": ""Button"",
                    ""id"": ""7901af29-e2d3-49f7-a1f8-4442dea32d34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AddItem2"",
                    ""type"": ""Button"",
                    ""id"": ""4f321132-5b5d-4c54-b0f4-381683d27110"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DropItem"",
                    ""type"": ""Button"",
                    ""id"": ""f319c67e-6885-4d3e-bdfc-346b6e999074"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Undo"",
                    ""type"": ""Button"",
                    ""id"": ""ec25f06a-8e2f-4aee-a339-269e40271ede"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Redo"",
                    ""type"": ""Button"",
                    ""id"": ""b4b0773e-a5fe-406a-a1de-1aa5d05f5188"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Save"",
                    ""type"": ""Button"",
                    ""id"": ""beaae0ae-7c73-44ba-b21c-e243f44f8ae0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""246314dc-f11d-4c2b-8d29-d09663c996ba"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EditorMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ed48bc0-1075-4823-9ae6-d562166a38bd"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AddItem1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8902b38b-ecc4-40ce-921b-85a96c5f93ad"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74762b7b-a204-47bf-8f5f-18a4a634335b"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AddItem2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71a630f8-329a-42bd-bfc5-4c10aac5f453"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Undo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df97bf4b-45ea-425f-8e6f-522e14ddc4dc"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Redo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9091a119-4aeb-41b9-b08a-dcbec4ca2737"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
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
        m_Player_Turn = m_Player.FindAction("Turn", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        // Editor
        m_Editor = asset.FindActionMap("Editor", throwIfNotFound: true);
        m_Editor_EditorMode = m_Editor.FindAction("EditorMode", throwIfNotFound: true);
        m_Editor_AddItem1 = m_Editor.FindAction("AddItem1", throwIfNotFound: true);
        m_Editor_AddItem2 = m_Editor.FindAction("AddItem2", throwIfNotFound: true);
        m_Editor_DropItem = m_Editor.FindAction("DropItem", throwIfNotFound: true);
        m_Editor_Undo = m_Editor.FindAction("Undo", throwIfNotFound: true);
        m_Editor_Redo = m_Editor.FindAction("Redo", throwIfNotFound: true);
        m_Editor_Save = m_Editor.FindAction("Save", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Turn;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Shoot;
    public struct PlayerActions
    {
        private @PlayerAction m_Wrapper;
        public PlayerActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Turn => m_Wrapper.m_Player_Turn;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Turn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTurn;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Editor
    private readonly InputActionMap m_Editor;
    private IEditorActions m_EditorActionsCallbackInterface;
    private readonly InputAction m_Editor_EditorMode;
    private readonly InputAction m_Editor_AddItem1;
    private readonly InputAction m_Editor_AddItem2;
    private readonly InputAction m_Editor_DropItem;
    private readonly InputAction m_Editor_Undo;
    private readonly InputAction m_Editor_Redo;
    private readonly InputAction m_Editor_Save;
    public struct EditorActions
    {
        private @PlayerAction m_Wrapper;
        public EditorActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @EditorMode => m_Wrapper.m_Editor_EditorMode;
        public InputAction @AddItem1 => m_Wrapper.m_Editor_AddItem1;
        public InputAction @AddItem2 => m_Wrapper.m_Editor_AddItem2;
        public InputAction @DropItem => m_Wrapper.m_Editor_DropItem;
        public InputAction @Undo => m_Wrapper.m_Editor_Undo;
        public InputAction @Redo => m_Wrapper.m_Editor_Redo;
        public InputAction @Save => m_Wrapper.m_Editor_Save;
        public InputActionMap Get() { return m_Wrapper.m_Editor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EditorActions set) { return set.Get(); }
        public void SetCallbacks(IEditorActions instance)
        {
            if (m_Wrapper.m_EditorActionsCallbackInterface != null)
            {
                @EditorMode.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnEditorMode;
                @EditorMode.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnEditorMode;
                @EditorMode.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnEditorMode;
                @AddItem1.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem1;
                @AddItem1.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem1;
                @AddItem1.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem1;
                @AddItem2.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem2;
                @AddItem2.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem2;
                @AddItem2.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnAddItem2;
                @DropItem.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnDropItem;
                @DropItem.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnDropItem;
                @DropItem.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnDropItem;
                @Undo.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnUndo;
                @Undo.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnUndo;
                @Undo.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnUndo;
                @Redo.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnRedo;
                @Redo.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnRedo;
                @Redo.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnRedo;
                @Save.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
                @Save.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
                @Save.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
            }
            m_Wrapper.m_EditorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EditorMode.started += instance.OnEditorMode;
                @EditorMode.performed += instance.OnEditorMode;
                @EditorMode.canceled += instance.OnEditorMode;
                @AddItem1.started += instance.OnAddItem1;
                @AddItem1.performed += instance.OnAddItem1;
                @AddItem1.canceled += instance.OnAddItem1;
                @AddItem2.started += instance.OnAddItem2;
                @AddItem2.performed += instance.OnAddItem2;
                @AddItem2.canceled += instance.OnAddItem2;
                @DropItem.started += instance.OnDropItem;
                @DropItem.performed += instance.OnDropItem;
                @DropItem.canceled += instance.OnDropItem;
                @Undo.started += instance.OnUndo;
                @Undo.performed += instance.OnUndo;
                @Undo.canceled += instance.OnUndo;
                @Redo.started += instance.OnRedo;
                @Redo.performed += instance.OnRedo;
                @Redo.canceled += instance.OnRedo;
                @Save.started += instance.OnSave;
                @Save.performed += instance.OnSave;
                @Save.canceled += instance.OnSave;
            }
        }
    }
    public EditorActions @Editor => new EditorActions(this);
    public interface IPlayerActions
    {
        void OnTurn(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IEditorActions
    {
        void OnEditorMode(InputAction.CallbackContext context);
        void OnAddItem1(InputAction.CallbackContext context);
        void OnAddItem2(InputAction.CallbackContext context);
        void OnDropItem(InputAction.CallbackContext context);
        void OnUndo(InputAction.CallbackContext context);
        void OnRedo(InputAction.CallbackContext context);
        void OnSave(InputAction.CallbackContext context);
    }
}