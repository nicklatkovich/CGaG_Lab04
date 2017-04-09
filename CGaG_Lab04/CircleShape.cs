using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace CGaG_Lab04 {
    class CircleShape : Shape {

        private const UInt32 BASE_RADIUS = 512u;
        private static Texture2D Texture;

        public Single Radius;

        public CircleShape(Single radius, Transform transform) : base(transform) {
            this.Radius = radius;
        }

        public override void Draw(SpriteBatch surface, Transform transform) {
            SimpleUtils.Draw(surface, Texture, new Transform(transform.Position, transform.Scale * 2f * Radius / BASE_RADIUS, transform.Rotation, transform.Color));
        }

        static CircleShape( ) {
            Texture = new Texture2D(Program.MainThread.GraphicsDevice, (Int32)BASE_RADIUS, (Int32)BASE_RADIUS);
            Color[ ] colorData = new Color[BASE_RADIUS * BASE_RADIUS];

            float diam = BASE_RADIUS / 2f;
            float diamsq = diam * diam;

            for (UInt32 x = 0; x < BASE_RADIUS; x++) {
                for (UInt32 y = 0; y < BASE_RADIUS; y++) {
                    UInt32 index = x * BASE_RADIUS + y;
                    Vector2 pos = new Vector2(x - diam, y - diam);
                    if (pos.LengthSquared( ) <= diamsq) {
                        colorData[index] = Color.White;
                    } else {
                        colorData[index] = Color.Transparent;
                    }
                }
            }

            Texture.SetData(colorData);
        }
    }
}
