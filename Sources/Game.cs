


namespace G.L.O.O_
{
    internal class Game : GameWindow
    {
        protected float[] vertices =
        {
            -0.5f, -0.5f, 0.0f, //Bottom left vertex
             0.5f, -0.5f, 0.0f, //Bottom right vertex
             0.0f,  0.5f, 0.0f, //Top vertex
        };

        public BufferHandle VertexBufferObject;

        public Game(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            if(KeyboardState.IsKeyPressed(Keys.Escape))
                this.Close();


            base.OnUpdateFrame(args);
        }

        protected override void OnLoad()
        {
            GL.ClearColor(0.2f,0.3f,0.3f,1.0f);

            VertexBufferObject = GL.GenBuffer();

            //GL.BindBuffer(BufferTargetARB.ArrayBuffer, VertexBufferObject);
            //GL.BufferData(BufferTargetARB.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageARB.StaticDraw);

            base.OnLoad();
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            //Code goes here

            Context.SwapBuffers();
            base.OnRenderFrame(args);
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, ClientSize.X, ClientSize.Y);
            //Console.WriteLine($"Window width is {ClientSize.X} and height is {ClientSize.Y}");

            base.OnResize(e);
        }

        protected override void OnUnload()
        {
            GL.BindBuffer(BufferTargetARB.ArrayBuffer, (BufferHandle)0);
            GL.DeleteBuffer(VertexBufferObject);

            base.OnUnload();
        }
    }
}
