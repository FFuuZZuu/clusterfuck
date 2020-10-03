/*
 * Debug Controller
 *
 * Controls the debug console and is where
 * commands are defined.
 *
 * Author: FFuuZZuu
 */

using System;
using System.Collections.Generic;
using UnityEngine;

namespace DebugConsole
{
    public class DebugController : MonoBehaviour
    {
        private bool showConsole;
        private bool updateConsole;
        private string input;
        private string recentMessage;
        private int messageIndex = 0;
        
        private Vector2 scroll;

        public static DebugCommand DEBUG_CMD;
        public static DebugCommand HELP;

        public List<object> commandList;
        public List<string> messageList;

        // Toggles console
        public void OnToggleConsole()
        {
            showConsole = !showConsole;
        }

        // Called when a user enters a command and presses "Enter"
        public void OnReturn()
        {
            if (showConsole)
            {
                HandleInput();
                input = "";
            }
        }

        // Used for handling GUIs in unity
        private void OnGUI()
        {
            if (!showConsole) { return; }
                
            float y = 0f;
            
            // Message box
            GUI.Box(new Rect(0, y, Screen.width, 100), "");
            y += 100;
            
            // Command box
            GUI.Box(new Rect(0, y, Screen.width, 30), "");
            GUI.backgroundColor = new Color(0, 0, 0, 0);
            input = GUI.TextField(new Rect(10f, y + 5f, Screen.width - 20f, 20f), input);
            
            
            if (updateConsole)
            {
                // Setup viewport across whole screen and begin scroll view
                Rect viewport = new Rect(0, 0, Screen.width - 30, 20 * messageList.Count);
                scroll = GUI.BeginScrollView(new Rect(0, 5f, Screen.width, 90), scroll, viewport);
            
                // Prints messages in "labelRect" box
                for (int i = 0; i < messageList.Count; i++)
                {
                    Rect labelRect = new Rect(5, 20 * i, viewport.width - 100, 20);
                    GUI.Label(labelRect, messageList[i]);
                }

                GUI.EndScrollView();
            }
        }

        // Logs messages to debug console as Info
        public void InfoLog(string message)
        {
            messageList.Add(message);
            updateConsole = true;
        }

        // Checks which command is entered and calls it
        public void HandleInput()
        {
            for (int i = 0; i < commandList.Count; i++)
            {
                DebugCommandBase commandBase = commandList[i] as DebugCommandBase;

                if (input.Contains(commandBase.commandID))
                {
                    if (commandList[i] as DebugCommand != null)
                    {
                        (commandList[i] as DebugCommand).Invoke();
                    }
                }
            }
        }
        
        // Called before OnEnable() when the script is initiated
        private void Awake()
        {
            DEBUG_CMD = new DebugCommand("debug_cmd", "Prints a debug message to the console.", "debug_cmd", () =>
            {
                InfoLog("Debug command sent and recieved.");
            });
            
            HELP = new DebugCommand("help", "Displays a list of all commands.", "help", () =>
            {
                showHelp();
            });

            commandList = new List<object>
            {
                DEBUG_CMD,
                HELP
            };
        }

        private void showHelp()
        {
            for (int i = 0; i < commandList.Count; i++)
            {
                DebugCommandBase command = commandList[i] as DebugCommandBase;
                    
                string message = $"{command.commandFormat} - {command.commandDescription}";

                InfoLog(message);
            }
        }
    }
}

