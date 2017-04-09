using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGaG_Lab04 {
    public class Transform {

        public Vector2 Position;
        public Vector2 Scale;
        public Single Rotation;
        public Color Color;

        public Transform(Vector2 position, Vector2 scale, Single rotation, Color color) {
            this.Position = position;
            this.Scale = scale;
            this.Rotation = rotation;
            this.Color = color;
        }

        public Transform(Vector2 position, Vector2? scale = null, Single rotation = 0f, Color? color = null) : this(position, scale == null ? new Vector2(1f, 1f) : scale.Value, rotation, color == null ? Color.White : color.Value) {

        }


    }
}
