﻿using System;

namespace CLInterfaces_01
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;
        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.texto = texto;
            this.color = color;
        }
    }
}
