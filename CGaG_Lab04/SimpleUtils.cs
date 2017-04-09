using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGaG_Lab04 {
    static class SimpleUtils {

        public static Random Rand { get; private set; } = new Random( );

        public static void Draw(SpriteBatch surface, Texture2D texture, Transform transform, Vector2 origin) {
            surface.Draw(texture, position: transform.Position, origin: origin, rotation: transform.Rotation, scale: transform.Scale, color: transform.Color);
        }

        public static void Draw(SpriteBatch surface, Texture2D texture, Transform transform) {
            Draw(surface, texture, transform, new Vector2(texture.Width / 2f, texture.Height / 2f));
        }

        public static Color GetRandomColor( ) {
            return new Color(Rand.Next( ) % 256, Rand.Next( ) % 256, Rand.Next( ) % 256);
        }

        public static Single PointDistance(Vector2 point1, Vector2 point2) {
            return (Single)Math.Sqrt(Math.Pow(point1.X - point2.X, 2d) + Math.Pow(point1.Y - point2.Y, 2d));
        }

        public static Texture2D GenerateRingTexture(UInt32 radius, Single width) {
            Single center_coords = radius + width / 2f + 1;
            Vector2 center = new Vector2(center_coords, center_coords);
            UInt32 texture_size = (UInt32)Math.Ceiling(center_coords * 2);
            Texture2D result = new Texture2D(Program.MainThread.GraphicsDevice, (Int32)texture_size, (Int32)texture_size);
            Color[ ] colorData = new Color[result.Width * result.Height];
            for (UInt32 x = 0; x < result.Width; x++) {
                for (UInt32 y = 0; y < result.Height; y++) {
                    UInt32 index = (UInt32)(x * result.Width + y);
                    Vector2 pos = new Vector2(x, y);
                    Single distance = PointDistance(pos, center);
                    if (Math.Abs(distance - radius) < width) {
                        colorData[index] = Color.White;
                    } else {
                        colorData[index] = Color.Transparent;
                    }
                }
            }
            result.SetData(colorData);
            return result;
        }

    }
}
