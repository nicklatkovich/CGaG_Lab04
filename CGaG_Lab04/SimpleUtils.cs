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

    }
}
