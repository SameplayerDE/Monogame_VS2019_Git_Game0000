using Microsoft.Xna.Framework;

namespace Monogame_VS2019_Git_Game0000.GameObjects
{
    public abstract class GameObject
    {

        protected Vector2 _position = Vector2.Zero;

        public Vector2 Position { get { return _position; } set { _position = value; } }

        public virtual void Update(GameTime gameTime)
        {

        }

    }
}
