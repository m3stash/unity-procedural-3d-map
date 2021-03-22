// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Movements"",
            ""id"": ""bc440f22-fef3-45bd-8646-3ed2934e3889"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6dd002d0-0c40-4629-bab8-82d6e76f56d2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""12bed406-ae4c-42da-862f-ce0a0c4debb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5c1d446b-78f2-4540-83ad-4fac676d3612"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""89c5422f-1763-44a0-9207-d4a3a00335e2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e8a59376-4c5d-482a-b085-994c0fcbb477"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""40afd151-33b9-41ae-bfe8-839c890aedab"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""489789b5-8aef-40ef-982d-a4a50e9a5d55"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""813d6458-a3fc-4640-ae0a-b79ac0afd71e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""09bdd39f-a4c4-41c0-8665-7d5f3af5134b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""55ce864d-3348-442d-bdd4-3efe8e403bf6"",
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
                    ""id"": ""23b1af78-4f44-4c51-9fef-7634688bd547"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2050abb-c639-4094-8215-8c950099b8b3"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movements
        m_Movements = asset.FindActionMap("Movements", throwIfNotFound: true);
        m_Movements_Horizontal = m_Movements.FindAction("Horizontal", throwIfNotFound: true);
        m_Movements_Jump = m_Movements.FindAction("Jump", throwIfNotFound: true);
        m_Movements_MouseX = m_Movements.FindAction("MouseX", throwIfNotFound: true);
        m_Movements_MouseY = m_Movements.FindAction("MouseY", throwIfNotFound: true);
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

    // Movements
    private readonly InputActionMap m_Movements;
    private IMovementsActions m_MovementsActionsCallbackInterface;
    private readonly InputAction m_Movements_Horizontal;
    private readonly InputAction m_Movements_Jump;
    private readonly InputAction m_Movements_MouseX;
    private readonly InputAction m_Movements_MouseY;
    public struct MovementsActions
    {
        private @PlayerControls m_Wrapper;
        public MovementsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Movements_Horizontal;
        public InputAction @Jump => m_Wrapper.m_Movements_Jump;
        public InputAction @MouseX => m_Wrapper.m_Movements_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Movements_MouseY;
        public InputActionMap Get() { return m_Wrapper.m_Movements; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementsActions set) { return set.Get(); }
        public void SetCallbacks(IMovementsActions instance)
        {
            if (m_Wrapper.m_MovementsActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnHorizontal;
                @Jump.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnJump;
                @MouseX.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnMouseY;
            }
            m_Wrapper.m_MovementsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
            }
        }
    }
    public MovementsActions @Movements => new MovementsActions(this);
    public interface IMovementsActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
}
