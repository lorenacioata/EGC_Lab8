using System;

using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
namespace OpenTK_winforms_z02
{
    class Punct
    {
		private float[] positions1 = new float[] { 45f, 65f, 55f, 1f };
		private float[] ambient1 = new float[] { 0f, 0f, 0f, 1f };
		private float[] diffuse1 = new float[] { 1f, 1f, 1f, 1f };
		private float[] specular1 = new float[] { 1f, 1f, 1f, 1f };
		private float[] direction1 = new float[] { 20f, 20f, 20f, 1f };
		private bool lightON = false;
		public bool getLight()
        {
			return lightON;
        }
		public void onLight() 
		{
			if (lightON) GL.Enable(EnableCap.Light1);
			else GL.Disable(EnableCap.Light1);
			lightON = !lightON;
		}
		public void miscareLumina(int val, char c)
		{
			switch (c)
			{
				case 'X':
					positions1[0] += val;
					break;
				case 'Y':
					positions1[1] += val;
					break;
				case 'Z':
					positions1[2] += val;
					break;
			}
		}
		public void MyLight()
		{
			GL.PointSize(10f);
			GL.Begin(PrimitiveType.Points);
			GL.Color3(Color.Green);
			GL.Vertex3(positions1);
			GL.End();
			GL.Light(LightName.Light1, LightParameter.Position, positions1);
			GL.Light(LightName.Light1, LightParameter.Specular, specular1);
			GL.Light(LightName.Light1, LightParameter.Ambient, ambient1);
			GL.Light(LightName.Light1, LightParameter.Diffuse, diffuse1);
			GL.Light(LightName.Light1, LightParameter.SpotDirection, direction1);
		}
	}
}
