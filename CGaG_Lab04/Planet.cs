using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace CGaG_Lab04 {
    public class SpaceObject : Transformable, IPresentable {

        public Transformable Parent;
        public Single Radius;
        public Single Direction;
        public Single Speed;
        public Single Size;

        public SpaceObject(Transform transform, Transformable parent, Single radius, Single speed, Single Direction = 0f, Single size = 16f) : base(transform) {
            this.Parent = parent;
            this.Radius = radius;
            this.Speed = speed;
            this.Direction = Direction;
            this.Size = size;
        }

        public void Update(GameTime time) {
            Direction += Speed * (Single)time.ElapsedGameTime.TotalSeconds;
            Transform.Position = new Vector2((Single)Math.Sin(Direction) * Radius, (Single)Math.Cos(Direction) * Radius) + Parent.Transform.Position;
        }

        public void Draw(SpriteBatch surface) {
            new CircleShape(Size, this.Transform).Draw(surface);
        }

    }
}
