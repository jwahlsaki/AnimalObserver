﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AnimalObserver
{
    public class EntitiesConfig
    {
        public EntitiesConfig()
        {

        }

        public EntitiesConfig(int x, int y, int width, int height, float rotation = 0f)
        {

            X = x;
            Y = y;
            Width = width;
            Height = height;
            Rotation = rotation;
        }

        public Color Color { get; set; } = Color.White;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public float Rotation { get; set; }

        public float Scale { get; set; }

        public Vector2 Origin { get; set; } = Vector2.Zero;
        public Vector2 Offset { get; set; } = Vector2.Zero;

        public SpriteEffects SpriteEffects { get; set; } = SpriteEffects.None;


    }
}
