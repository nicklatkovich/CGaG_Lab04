using Microsoft.Xna.Framework.Graphics;

namespace CGaG_Lab04 {

    abstract class Shape : Transformable {

        public Shape(Transform transform) : base(transform) {

        }

        public abstract void Draw(SpriteBatch surface, Transform transform);

        public void Draw(SpriteBatch surface) {
            Draw(surface, this.Transform);
        }

    }

}
