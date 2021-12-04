﻿using System;

namespace KataDoor
{
    public class Door
    {
        public string Key;
        public bool open = false;
        public bool closed = false;
        public bool unlocked = false;
        public bool locked = false;
        public Door ClosedAndUnlocked(string key)
        {
            Key = key;
            closed = true;
            unlocked = true;
            return this;
        }
        public Door ClosedAndLocked(string key)
        {
            Key = key;
            closed = true;
            locked = true;
            return this;
        }
        public Door OpenAndUnlocked(string key)
        {
            Key = key;
            open = true;
            unlocked = true;
            return this;
        }
        public Door Open()
        {
            if((open == false) && (closed == true) && (locked == false) && (unlocked == true))
            {
                open = true;
                closed = false;
                return this;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public bool IsOpen()
        {
            if(open == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
