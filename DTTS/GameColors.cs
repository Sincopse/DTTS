﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTTS
{
    public static class GameColors
    {
        public static Color foreGround = Color.Gray;
        public static Color backGround = Color.LightGray;

        public static void UpdateColor(int score)
        {
            switch (score)
            {
                case  5:
                    foreGround = Color.SlateGray; 
                    backGround = Color.LightGray;
                    break;
                case 10:
                    foreGround = Color.Beige;
                    backGround = Color.LightGray;
                    break;
                case 15:
                    foreGround = Color.Yellow;
                    backGround = Color.LightYellow;
                    break;
                case 20:
                    foreGround = Color.Green;
                    backGround = Color.LightGreen;
                    break;
                case 25:
                    foreGround = Color.Cyan;
                    backGround = Color.LightCyan;
                    break;
                case 30:
                    foreGround = Color.DarkRed;
                    backGround = Color.IndianRed;
                    break;
                case 35:
                    foreGround = Color.Black;
                    backGround = Color.DarkGray;
                    break;
                case 69:
                    foreGround = Color.Black;
                    backGround = Color.DarkGray;
                    break;
            }
        }
    }
}
