﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    public class Graphics
    {
        public static readonly string[] smileFace = 
        {
            "           *******           ",
            "        ***       ***        ",
            "      **             **      ",
            "     *     #     #     *     ",
            "     *                 *     ",
            "     *      .    .     *     ",
            "      **     ....    **      ",
            "        ***       ***        ",
            "           *******           "
        };



        public static readonly string[] headrt =      
        {
            "                              ",
            "          ***     ***         ",
            "        **   ** **   **       ",
            "       *       *       *      ",
            "       *               *      ",
            "       *               *      ",
            "         *           *        ",
            "           *       *          ",
            "             *   *            ",
            "               *              ",
        };



        public static readonly string[] sadFace =
        {
            "           *******           ",
            "        ***       ***        ",
            "      **             **      ",
            "     *     #     #     *     ",
            "     *                 *     ",
            "     *       ...       *     ",
            "      **    .   .    **      ",
            "        ***       ***        ",
            "           *******           "
        };











        public static readonly string[][] gallows = 
        {
            new string[]
            {
                "                           ",
                "                           ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "                   +       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "            -------+       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "           +-------+       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "           +-------+       ",
                "           |       |       ",
                "           |       |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "           +-------+       ",
                "           |       |       ",
                "           |       |       ",
                "           0       |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "           +-------+       ",
                "           |       |       ",
                "           |       |       ",
                "           0       |       ",
                "           |       |       ",
                "                   |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "           +-------+       ",
                "           |       |       ",
                "           |       |       ",
                "           0       |       ",
                "           |       |       ",
                "          /        |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "           +-------+       ",
                "           |       |       ",
                "           |       |       ",
                "           0       |       ",
                "           |       |       ",
                "          / \\      |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "           +-------+       ",
                "           |       |       ",
                "           |       |       ",
                "          \\0       |       ",
                "           |       |       ",
                "          / \\      |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },
            new string[]
            {
                "                           ",
                "           +-------+       ",
                "           |       |       ",
                "           |       |       ",
                "          \\0/      |       ",
                "           |       |       ",
                "          / \\      |       ",
                "                   |       ",
                "                   |       ",
                "                  /|\\      ",
                "                           ",
            },

        };
    }
}
