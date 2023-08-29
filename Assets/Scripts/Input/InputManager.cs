﻿using UnityEngine;

namespace AlirezaTarahomi.FightingGame.InputSystem
{
    public interface InputManager
    {
        bool IsPressed(string action);

        bool IsHeld(string action);

        bool IsReleased(string action);

        float GetAxis(string axis);
    }
}