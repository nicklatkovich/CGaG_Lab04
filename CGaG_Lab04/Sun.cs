using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CGaG_Lab04 {
    class Center : Transformable, IPresentable {

        public Single Size;

        public Center(Transform transform, Single size = 16f) : base(transform) {
            Size = size;
        }

        public void Draw(SpriteBatch surface) {
            new CircleShape(Size, this.Transform).Draw(surface);
        }

        public void Update(GameTime time) {

        }
    }
}
