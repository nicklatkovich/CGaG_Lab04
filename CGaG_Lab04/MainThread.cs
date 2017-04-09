using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace CGaG_Lab04 {
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class MainThread : Game {

        private GraphicsDeviceManager Graphics;
        private SpriteBatch SpriteBatch;
        //private SortedList<Single, IPresentable> ListOfInstances = new SortedList<float, IPresentable>( );
        private List<IPresentable> ListOfInstances = new List<IPresentable>( );

        public MainThread( ) {
            Graphics = new GraphicsDeviceManager(this);
            Graphics.PreferredBackBufferWidth = Graphics.PreferredBackBufferHeight = 704;
            IsMouseVisible = true;
            Window.Title = "CGaG Lab04";
            Content.RootDirectory = "Content";

            Center center = new Center(new Transform(new Vector2(352f, 352f), color: Color.Transparent), 64f);
            SpaceObject sun = new SpaceObject(new Transform(new Vector2(0f, 0f), color: Color.Red), center, 0f, 0f, size: 24f);
            InstanceCreate(sun);
            SpaceObject planet1 = new SpaceObject(new Transform(new Vector2(0f, 0f), color: Color.Green), sun, 144f, 0.5f, size: 12f);
            InstanceCreate(planet1);
            InstanceCreate(new SpaceObject(new Transform(new Vector2(0f, 0f), color: Color.Blue), planet1, 32f, 4.3f, size: 8f));
            InstanceCreate(new SpaceObject(new Transform(new Vector2(0f, 0f), color: Color.YellowGreen), sun, 256f, -0.3f, size: 16f));

        }

        public void InstanceCreate(IPresentable instance, Single depth = 0f) {
            ListOfInstances.Add(instance);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize( ) {
            // TODO: Add your initialization logic here

            base.Initialize( );
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent( ) {
            // Create a new SpriteBatch, which can be used to draw textures.
            SpriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent( ) {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="time">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime time) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState( ).IsKeyDown(Keys.Escape))
                Exit( );

            // TODO: Add your update logic here
            foreach (var instance in ListOfInstances) {
                instance.Update(time);
            }

            base.Update(time);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="time">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime time) {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            SpriteBatch.Begin( );
            foreach (var instance in ListOfInstances) {
                instance.Draw(SpriteBatch);
            }
            SpriteBatch.End( );

            base.Draw(time);
        }
    }
}
