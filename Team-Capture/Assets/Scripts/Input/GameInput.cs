// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Team_Capture
{
    public class @GameInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Console"",
            ""id"": ""f3429d8d-a20d-46da-8941-3d1f3b19159d"",
            ""actions"": [
                {
                    ""name"": ""ToggleConsole"",
                    ""type"": ""Button"",
                    ""id"": ""81d8bfb3-06a9-484a-841b-9598944a1ecd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""AutoComplete"",
                    ""type"": ""Button"",
                    ""id"": ""f172c47a-cba5-4b1c-b153-c802d6978817"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HistoryUp"",
                    ""type"": ""Button"",
                    ""id"": ""d8d6bf72-842e-4440-b42a-10610510fad6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HistoryDown"",
                    ""type"": ""Button"",
                    ""id"": ""c798c230-b894-4124-9324-c637d5e4c894"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SubmitInput"",
                    ""type"": ""Button"",
                    ""id"": ""7ed22b2a-26cf-4580-bb4a-8ccfeb3e83ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3261766d-74ae-421f-be12-f893cc2ae8ed"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""ToggleConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d33f864-3bad-4e60-908d-6a60dea8dc1f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""AutoComplete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d15723b0-8349-4dc5-bb63-97be50dea492"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""HistoryUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2544f27d-8483-45f7-b4ae-dd29db35de1f"",
                    ""path"": ""<Keyboard>/pageUp"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""HistoryUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c5c4fab-3aeb-4850-a214-4e1778acc549"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""HistoryDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3960e645-6fbe-4e4c-b945-e5774dce1620"",
                    ""path"": ""<Keyboard>/pageDown"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""HistoryDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba755523-c1bf-449a-90bb-aad0fb5700a3"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""SubmitInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4092c7c-f047-4334-82b1-0f77701e7484"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""SubmitInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
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
            // Console
            m_Console = asset.FindActionMap("Console", throwIfNotFound: true);
            m_Console_ToggleConsole = m_Console.FindAction("ToggleConsole", throwIfNotFound: true);
            m_Console_AutoComplete = m_Console.FindAction("AutoComplete", throwIfNotFound: true);
            m_Console_HistoryUp = m_Console.FindAction("HistoryUp", throwIfNotFound: true);
            m_Console_HistoryDown = m_Console.FindAction("HistoryDown", throwIfNotFound: true);
            m_Console_SubmitInput = m_Console.FindAction("SubmitInput", throwIfNotFound: true);
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

        // Console
        private readonly InputActionMap m_Console;
        private IConsoleActions m_ConsoleActionsCallbackInterface;
        private readonly InputAction m_Console_ToggleConsole;
        private readonly InputAction m_Console_AutoComplete;
        private readonly InputAction m_Console_HistoryUp;
        private readonly InputAction m_Console_HistoryDown;
        private readonly InputAction m_Console_SubmitInput;
        public struct ConsoleActions
        {
            private @GameInput m_Wrapper;
            public ConsoleActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @ToggleConsole => m_Wrapper.m_Console_ToggleConsole;
            public InputAction @AutoComplete => m_Wrapper.m_Console_AutoComplete;
            public InputAction @HistoryUp => m_Wrapper.m_Console_HistoryUp;
            public InputAction @HistoryDown => m_Wrapper.m_Console_HistoryDown;
            public InputAction @SubmitInput => m_Wrapper.m_Console_SubmitInput;
            public InputActionMap Get() { return m_Wrapper.m_Console; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ConsoleActions set) { return set.Get(); }
            public void SetCallbacks(IConsoleActions instance)
            {
                if (m_Wrapper.m_ConsoleActionsCallbackInterface != null)
                {
                    @ToggleConsole.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnToggleConsole;
                    @ToggleConsole.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnToggleConsole;
                    @ToggleConsole.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnToggleConsole;
                    @AutoComplete.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnAutoComplete;
                    @AutoComplete.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnAutoComplete;
                    @AutoComplete.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnAutoComplete;
                    @HistoryUp.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryUp;
                    @HistoryUp.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryUp;
                    @HistoryUp.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryUp;
                    @HistoryDown.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryDown;
                    @HistoryDown.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryDown;
                    @HistoryDown.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryDown;
                    @SubmitInput.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnSubmitInput;
                    @SubmitInput.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnSubmitInput;
                    @SubmitInput.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnSubmitInput;
                }
                m_Wrapper.m_ConsoleActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ToggleConsole.started += instance.OnToggleConsole;
                    @ToggleConsole.performed += instance.OnToggleConsole;
                    @ToggleConsole.canceled += instance.OnToggleConsole;
                    @AutoComplete.started += instance.OnAutoComplete;
                    @AutoComplete.performed += instance.OnAutoComplete;
                    @AutoComplete.canceled += instance.OnAutoComplete;
                    @HistoryUp.started += instance.OnHistoryUp;
                    @HistoryUp.performed += instance.OnHistoryUp;
                    @HistoryUp.canceled += instance.OnHistoryUp;
                    @HistoryDown.started += instance.OnHistoryDown;
                    @HistoryDown.performed += instance.OnHistoryDown;
                    @HistoryDown.canceled += instance.OnHistoryDown;
                    @SubmitInput.started += instance.OnSubmitInput;
                    @SubmitInput.performed += instance.OnSubmitInput;
                    @SubmitInput.canceled += instance.OnSubmitInput;
                }
            }
        }
        public ConsoleActions @Console => new ConsoleActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        public interface IConsoleActions
        {
            void OnToggleConsole(InputAction.CallbackContext context);
            void OnAutoComplete(InputAction.CallbackContext context);
            void OnHistoryUp(InputAction.CallbackContext context);
            void OnHistoryDown(InputAction.CallbackContext context);
            void OnSubmitInput(InputAction.CallbackContext context);
        }
    }
}
