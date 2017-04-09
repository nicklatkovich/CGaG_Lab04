using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGaG_Lab04 {
    public abstract class Transformable {

        public Transform Transform;

        protected Transformable(Transform transform) {
            this.Transform = transform;
        }

    }
}
