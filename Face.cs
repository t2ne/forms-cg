using System;
using System.Collections;
using System.Drawing;

namespace desenhaFaces_v1
{
    internal class Face
    {
        private ArrayList vertices3D;
        public Face()
        {
            InicializaFace();
        }

        private void InicializaFace()
        {
            this.vertices3D = new ArrayList();
        }

        public Face(ArrayList vertices3D)
        {
            InicializaFace();
            this.vertices3D = vertices3D;
        }

        public ArrayList GetVerticesFace()
        {
            return this.vertices3D;
        }

        public void SaveVertice(Vector3D v)
        {
            vertices3D.Add(v);
        }

        public PointF[] GetVertices2D(float largura, float altura)
        {
            PointF[] pontos2D = new PointF[vertices3D.Count];
            for (int i = 0; i < vertices3D.Count; i++)
            {
                Vector3D v = (Vector3D)vertices3D[i];
                pontos2D[i] = v.ConvertePontoJanelaToViewport(largura, altura);
            }
            return pontos2D;
        }

        public Vector3D CalculaNormal()
        {
            if (vertices3D.Count >= 3)
            {
                Vector3D v1 = (Vector3D)vertices3D[0];
                Vector3D v2 = (Vector3D)vertices3D[1];
                Vector3D v3 = (Vector3D)vertices3D[2];

                Vector3D normal = (v2 - v1) ^ (v3 - v1);
                normal.Normalize();

                return normal;
            }
            return null;
        }

        public float ProdutoEscalar(Vector3D cameraVector)
        {
            Vector3D normal = CalculaNormal();
            if (normal != null)
            {
                return normal * cameraVector;
            }
            return 0.0f;
        }
    }
}
