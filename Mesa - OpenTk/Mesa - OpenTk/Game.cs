using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Mesa___OpenTk
{
    public class Game
    {
        GameWindow window;
        public Game(GameWindow window)
        {
            this.window = window;
            Start();
        }

        void Start()
        {
            window.Load += loaded;
            window.Resize += resize;
            window.RenderFrame += renderF;
            window.Run(1.0 / 60.0); //60fotogramas por segundo
        }

        void resize(object ob, EventArgs e)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            //sistemas de coordenadas
            GL.Ortho(-70.0, 70.0, -70.0, 70.0, -1.0, 1.0);

            GL.MatrixMode(MatrixMode.Modelview);
        }

        void renderF(object o, EventArgs e)
        {
            // GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit);

            //BASE
            GL.Begin(BeginMode.Quads);
            GL.Color3(0.5f, 0.1f, 0.0f);
            //GL.Color3(1.0, 0.0, 0.0);  // ROJO
            GL.Vertex2(50.0, 30.0);
            //GL.Color3(0.0, 2.0, .0);   // VERDE
            GL.Vertex2(-30.0, 30.0);
            //GL.Color3(0.0, 1.0, 0.0);  // AZUL
            GL.Vertex2(-60.0, -20.0);
            //GL.Color3(0.0, 0.0, 1.0);   // ROJO+verde
            GL.Vertex2(20.0, -20.0);

            GL.End();

            //BORDE DE FRENTE
            GL.Begin(BeginMode.Quads); 
            GL.Color3(0.6f, 0.2f, 0.0f);
            //GL.Color3(1.0, 0.0, 0.0);  // ROJO
            GL.Vertex2(20.0, -20.0);
            //GL.Color3(0.0, 1.0, 0.0);   // VERDE
            GL.Vertex2(-60.0f, -20.0);
            //GL.Color3(0.0, 0.0, 1.0);  // AZUL
            GL.Vertex2(-60.0f, -25.0);
            //GL.Color3(1.0, 1.0, 0.0);  // ROJO+verde
            GL.Vertex2(20.0, -25.0);

            //BORDE DE LADO
            GL.Begin(BeginMode.Quads);
            GL.Color3(0.6f, 0.2f, 0.0f);
            //GL.Color3(1.0, 0.0, 0.0);  // ROJO
            GL.Vertex2(50.0, 30.0);
            //GL.Color3(0.0, 1.0, 0.0);   // VERDE
            GL.Vertex2(20.0, -20.0);
            //GL.Color3(0.0, 0.0, 1.0);  // AZUL
            GL.Vertex2(20.0, -25.0);
            //GL.Color3(1.0, 1.0, 0.0);  // ROJO+verde
            GL.Vertex2(50.0, 25.0);

            //1ra. PATA DELANTERA
            GL.Begin(BeginMode.Quads);
            GL.Color3(0.5f, 0.1f, 0.0f);
            //GL.Color3(1.0, 1.0, 1.0);  // ROJO
            GL.Vertex2(-56.0, -25.0);
            //GL.Color3(0.0, 1.0, 0.0);   // VERDE
            GL.Vertex2(-60.0f, -25.0f);
            //GL.Color3(0.0, 0.0, 1.0);  // AZUL
            GL.Vertex2(-60.0f, -55.0);
            //GL.Color3(1.0, 1.0, 0.0);  // ROJO+verde
            GL.Vertex2(-56.0, -55.0);

            //1ra. PATA DELANTERA BORDE
            GL.Begin(BeginMode.Quads);
            GL.Color3(0.6f, 0.2f, 0.0f);
            //GL.Color3(1.0, 0.0, 0.0);  // ROJO
            GL.Vertex2(-55.0, -25.0);
            //GL.Color3(0.0, 1.0, 0.0);   // VERDE
            GL.Vertex2(-56.0f, -25.0f);
            //GL.Color3(0.0, 0.0, 1.0);  // AZUL
            GL.Vertex2(-56.0f, -55.0);
            //GL.Color3(1.0, 1.0, 0.0);  // ROJO+verde
            GL.Vertex2(-55.0, -54.0);

            //2da. PATA DELANTERA
            GL.Begin(BeginMode.Quads);
            GL.Color3(0.5f, 0.1f, 0.0f);
            //GL.Color3(1.0, 0.0, 0.0);  // ROJO
            GL.Vertex2(20.0, -25.0);
            //GL.Color3(0.0, 1.0, 0.0);   // VERDE
            GL.Vertex2(16.0, -25.0f);
            //GL.Color3(0.0, 0.0, 1.0);  // AZUL
            GL.Vertex2(16.0f, -55.0);
            //GL.Color3(1.0, 1.0, 0.0);  // ROJO+verde
            GL.Vertex2(20.0, -55.0);

            //2da. PATA DELANTERA BORDE
            GL.Begin(BeginMode.Quads);
            GL.Color3(0.6f, 0.2f, 0.0f);
            //GL.Color3(1.0, 20.0, 0.0);  // ROJO
            GL.Vertex2(21.0, -23.0);
            //GL.Color3(0.0, 20.0, 0.0);   // VERDE
            GL.Vertex2(20.0, -25.0f);
            //GL.Color3(0.0, 0.0, 1.0);  // AZUL
            GL.Vertex2(20.0f, -55.0);
            //GL.Color3(1.0, 1.0, 0.0);  // ROJO+verde
            GL.Vertex2(21.0, -54.0);

            //3ra. PATA DELANTERA BORDE
            GL.Begin(BeginMode.Quads);
            GL.Color3(0.5f, 0.1f, 0.0f);
            //GL.Color3(1.0, 0.0, 0.0);  // ROJO
            GL.Vertex2(50.0, 25.0);
            //GL.Color3(0.0, 1.0, 0.0);   // VERDE
            GL.Vertex2(46.0, 18.0);
            //GL.Color3(0.0, 0.0, 1.0);  // AZUL
            GL.Vertex2(46.0, -5.0);
            //GL.Color3(1.0, 1.0, 0.0);  // ROJO+verde
            GL.Vertex2(50.0, -5.0);

            GL.End();
            window.SwapBuffers();

        }

        void loaded(object o, EventArgs e)
        {
            GL.ClearColor(0.1f, 0.1f, 0.1f, 0.0f);
        }
    }
}
