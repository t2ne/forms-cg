using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using metodosMatriz3D;

namespace desenhaFaces_v1
{
    public class Objeto
    {
        private ArrayList vertices;
        private ArrayList indicesFaces;
        public ArrayList numvPorFace;

        private float larguraDesenho;
        private float alturaDesenho; 

        private Pen penContorno; 
        private SolidBrush brushPreenchimento;
        private bool wireframe; 

        private Stream s;

        int numFacesVisiveis = 0;

        public Objeto()
        {
            InicializaObjeto();
        }

        public void InicializaObjeto()
        {
            this.vertices = new ArrayList();
            this.indicesFaces = new ArrayList();
            this.numvPorFace = new ArrayList();

            penContorno = new Pen(Color.Black, 3);
            brushPreenchimento = new SolidBrush(Color.SteelBlue);

            this.wireframe = false;
            //Quadrado();

            Cubo();
            //Tetraedro();
            //PrismaHex();
            //TroncoCone(20.0f, 30.0f, 30.0f,30);
            //Cilindro(50.0f, 30f, 30);

        }

        private bool backfaceCulling;

        public bool BackfaceCulling
        {
            get { return backfaceCulling; }
            set { backfaceCulling = value; }
        }


        public void clear()
        {
            this.vertices.Clear();
            this.indicesFaces.Clear();
            this.numvPorFace.Clear();
        }

        public void Cubo()
        {

            clear();

            this.vertices.Add(new Vector3D(-70.0f, -70.0f, 70.0f));//v0
            this.vertices.Add(new Vector3D(70.0f, -70.0f, 70.0f));//v1
            this.vertices.Add(new Vector3D(-70.0f, 70.0f, 70.0f));//v2
            this.vertices.Add(new Vector3D(70.0f, 70.0f, 70.0f));//v3
            this.vertices.Add(new Vector3D(-70.0f, 70.0f, -70.0f));//v4
            this.vertices.Add(new Vector3D(70.0f, 70.0f, -70.0f));//v5
            this.vertices.Add(new Vector3D(-70.0f, -70.0f, -70.0f));//v6
            this.vertices.Add(new Vector3D(70.0f, -70.0f, -70.0f));//v7

            //indices face frente
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(1);
            this.indicesFaces.Add(3);
            this.indicesFaces.Add(2);

            this.numvPorFace.Add(4);

            //indices face direita
            this.indicesFaces.Add(1);
            this.indicesFaces.Add(7);
            this.indicesFaces.Add(5);
            this.indicesFaces.Add(3);

            this.numvPorFace.Add(4);

            //indices face esquerda
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(2);
            this.indicesFaces.Add(4);
            this.indicesFaces.Add(6);

            this.numvPorFace.Add(4);

            //indices face cima
            this.indicesFaces.Add(2);
            this.indicesFaces.Add(3);
            this.indicesFaces.Add(5);
            this.indicesFaces.Add(4);

            this.numvPorFace.Add(4);

            //indices face baixo
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(6);
            this.indicesFaces.Add(7);
            this.indicesFaces.Add(1);

            this.numvPorFace.Add(4);

            //indices face trás
            this.indicesFaces.Add(6);
            this.indicesFaces.Add(4);
            this.indicesFaces.Add(5);
            this.indicesFaces.Add(7);

            this.numvPorFace.Add(4);
        }

        public void Tetraedro(){
            clear();

            this.vertices.Add(new Vector3D(0f, 70.0f, 0f));//v0
            this.vertices.Add(new Vector3D(-70.0f, -70.0f, 70.0f));//v1
            this.vertices.Add(new Vector3D(70.0f, -70.0f, 70.0f));//v2
            this.vertices.Add(new Vector3D(0f, -70.0f, -70.0f));//v3

            // face da frente
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(1);
            this.indicesFaces.Add(2);

            this.numvPorFace.Add(3);

            // face da baixo
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(1);
            this.indicesFaces.Add(3);

            this.numvPorFace.Add(3);

            // face da esquerda
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(2);
            this.indicesFaces.Add(3);

            this.numvPorFace.Add(3);

            // face de direita
            this.indicesFaces.Add(1);
            this.indicesFaces.Add(2);
            this.indicesFaces.Add(3);

            this.numvPorFace.Add(3);
        }

        public void PrismaHex()
        {

            clear();

            this.vertices.Add(new Vector3D(0, 70f, 70f)); // v0
            this.vertices.Add(new Vector3D(70f, 70f, 35f));  // v1
            this.vertices.Add(new Vector3D(70f, 70f, -35f));   // v2
            this.vertices.Add(new Vector3D(0f, 70f, -70f));   // v3
            this.vertices.Add(new Vector3D(-70f, 70f, -35f));   // v4
            this.vertices.Add(new Vector3D(-70f, 70f, 35f));   // v5

            this.vertices.Add(new Vector3D(0, -70f, 70f)); // v6
            this.vertices.Add(new Vector3D(70f, -70f, 35f));  // v7
            this.vertices.Add(new Vector3D(70f, -70f, -35f));   // v8
            this.vertices.Add(new Vector3D(0f, -70f, -70f));   // v9
            this.vertices.Add(new Vector3D(-70f, -70f, -35f));   // v10
            this.vertices.Add(new Vector3D(-70f, -70f, 35f));   // v11

            // Face cima

            this.indicesFaces.Add(0);
            this.indicesFaces.Add(1);
            this.indicesFaces.Add(2);
            this.indicesFaces.Add(3);
            this.indicesFaces.Add(4);
            this.indicesFaces.Add(5);

            this.numvPorFace.Add(6);

            // Face inferior

            this.indicesFaces.Add(6);
            this.indicesFaces.Add(11);
            this.indicesFaces.Add(10);
            this.indicesFaces.Add(9);
            this.indicesFaces.Add(8);
            this.indicesFaces.Add(7);

            this.numvPorFace.Add(6);

            // face da frente
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(6);
            this.indicesFaces.Add(7);
            this.indicesFaces.Add(1);

            this.numvPorFace.Add(4);

            // frente direita
            this.indicesFaces.Add(2);
            this.indicesFaces.Add(8);
            this.indicesFaces.Add(7);
            this.indicesFaces.Add(1);

            this.numvPorFace.Add(4);

            // tras direita
            this.indicesFaces.Add(2);
            this.indicesFaces.Add(8);
            this.indicesFaces.Add(9);
            this.indicesFaces.Add(3);

            this.numvPorFace.Add(4);

            // tras 
            this.indicesFaces.Add(3);
            this.indicesFaces.Add(9);
            this.indicesFaces.Add(10);
            this.indicesFaces.Add(4);

            this.numvPorFace.Add(4);

            // tras esquerda
            this.indicesFaces.Add(4);
            this.indicesFaces.Add(10);
            this.indicesFaces.Add(11);
            this.indicesFaces.Add(5);

            this.numvPorFace.Add(4);

            // frente esquerda
            this.indicesFaces.Add(5);
            this.indicesFaces.Add(11);
            this.indicesFaces.Add(6);
            this.indicesFaces.Add(0);

        }

        public void TroncoCone(float raioBase, float raioTopo, float altura, int numSegmentos)
        {
            clear();
            double anguloIncremento = 2 * Math.PI / numSegmentos;

            // Adicionar os vértices para a base do tronco
            for (int i = 0; i < numSegmentos; i++)
            {
                double x = raioBase * Math.Cos(anguloIncremento * i);
                double z = raioBase * Math.Sin(anguloIncremento * i);
                double y = -altura / 2;
                this.vertices.Add(new Vector3D((float)x, (float)y, (float)z));
            }

            // Adicionar os vértices para o topo do tronco
            for (int i = 0; i < numSegmentos; i++)
            {
                double x = raioTopo * Math.Cos(anguloIncremento * i);
                double z = raioTopo * Math.Sin(anguloIncremento * i);
                double y = altura / 2;
                this.vertices.Add(new Vector3D((float)x, (float)y, (float)z));
            }

            // Adicionar os índices das faces laterais
            for (int i = 0; i < numSegmentos - 1; i++)
            {
                this.indicesFaces.Add(i);
                this.indicesFaces.Add(i + 1);
                this.indicesFaces.Add(i + numSegmentos);

                this.numvPorFace.Add(3);

                this.indicesFaces.Add(i + 1);
                this.indicesFaces.Add(i + 1 + numSegmentos);
                this.indicesFaces.Add(i + numSegmentos);

                this.numvPorFace.Add(3);
            }

            // Conectar o último ponto ao primeiro para fechar a lateral
            this.indicesFaces.Add(numSegmentos - 1);
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(numSegmentos - 1 + numSegmentos);

            this.numvPorFace.Add(3);

            this.indicesFaces.Add(0);
            this.indicesFaces.Add(numSegmentos);
            this.indicesFaces.Add(numSegmentos - 1 + numSegmentos);

            // Adicionar os índices das faces da base inferior
            for (int i = 0; i < numSegmentos - 1; i++)
            {
                this.indicesFaces.Add(i);
                this.indicesFaces.Add(i + 1);
                this.indicesFaces.Add(numSegmentos - 1);
                this.numvPorFace.Add(3);
            }

            this.indicesFaces.Add(numSegmentos - 1);
            this.indicesFaces.Add(0);
            this.indicesFaces.Add(numSegmentos - 1);

            this.numvPorFace.Add(3);

            // Adicionar os índices das faces da base superior
            int baseSuperiorOffset = numSegmentos;
            for (int i = 0; i < numSegmentos - 1; i++)
            {
                this.indicesFaces.Add(baseSuperiorOffset + i);
                this.indicesFaces.Add(baseSuperiorOffset + i + 1);
                this.indicesFaces.Add(baseSuperiorOffset + numSegmentos - 1);
                this.numvPorFace.Add(3);
            }

            this.indicesFaces.Add(baseSuperiorOffset + numSegmentos - 1);
            this.indicesFaces.Add(baseSuperiorOffset);
            this.indicesFaces.Add(baseSuperiorOffset + numSegmentos - 1);

            this.numvPorFace.Add(3);

            // Ajustar a posição dos vértices da base para o centro
            float baseCenterY = -altura / 2;
            for (int i = 0; i < numSegmentos; i++)
            {
                if (this.vertices[i] is Vector3D)
                {
                    Vector3D vertex = (Vector3D)this.vertices[i];
                    this.vertices[i] = new Vector3D(vertex.x, baseCenterY, vertex.z);
                }
            }

            // Ajustar a posição dos vértices do topo para o centro
            float topCenterY = altura / 2;
            for (int i = baseSuperiorOffset; i < baseSuperiorOffset + numSegmentos; i++)
            {
                if (this.vertices[i] is Vector3D)
                {
                    Vector3D vertex = (Vector3D)this.vertices[i];
                    this.vertices[i] = new Vector3D(vertex.x, topCenterY, vertex.z);
                }
            }
        }
        public Objeto(float largura, float altura)
        {
            SetJanela(largura, altura);
            InicializaObjeto();
        }

        public void SetJanela(float largura, float altura)
        {
            this.larguraDesenho = largura;
            this.alturaDesenho = altura;
        }

        public void SetWireframe()
        {
            this.wireframe = !this.wireframe;
        }

        public void SetCores(Pen penContorno, SolidBrush brushPreenchimento)
        {
            this.penContorno = penContorno;
            this.brushPreenchimento = brushPreenchimento;
        }

        public ArrayList GetVertices3D()
        {
            return this.vertices;
        }

        public ArrayList GetIndicesFaces()
        {
            return this.indicesFaces;
        }

        public ArrayList GetNumvPorFace()
        {
            return this.numvPorFace;
        }

        private ArrayList Transforma(float translacaoX, float translacaoY, float translacaoZ, float rotx, float roty, float rotz, float disCamara)
        {
            ArrayList res = new ArrayList(this.vertices.Count);

            foreach (Vector3D v in this.vertices)
            {
                res.Add(v.Clone());
            }

            metodosMatriz3D.Matriz3D mTrans = Matriz3D.translacao(translacaoX, translacaoY, translacaoZ);
            Matriz3D mRotX = Matriz3D.rotacaoX(rotx);
            Matriz3D mRotY = Matriz3D.rotacaoY(roty);
            Matriz3D mRotZ = Matriz3D.rotacaoZ(rotz);

            Matriz3D mProjParalela = Matriz3D.projParalela();

            Matriz3D mProjPerspetiva = Matriz3D.projPerspectiva(disCamara);

            for (int i = 0; i < res.Count; i++)
            {
                Vector3D v = (Vector3D)res[i];

                v.MultiplicaporMatriz_coordHomogeneas(mRotX);
                v.MultiplicaporMatriz_coordHomogeneas(mRotY);
                v.MultiplicaporMatriz_coordHomogeneas(mRotZ);
                v.MultiplicaporMatriz_coordHomogeneas(mTrans);
                // v.MultiplicaporMatriz_coordCartesianas(mProjParalela);
                v.MultiplicaporMatriz_coordCartesianas(mProjPerspetiva);
            }

            return res;
        }

        private ArrayList GeraFaces(ArrayList verticesTransf)
        {
            ArrayList faces = new ArrayList();
            int k = 0;

            for (int i = 0; i < numvPorFace.Count; i++)
            {
                Face f = new Face();

                for (int j = 0; j < (int)numvPorFace[i]; j++)
                {
                    Vector3D v = (Vector3D)verticesTransf[(int)indicesFaces[k++]];
                    f.SaveVertice(v);
                }
                faces.Add(f);
            }

            return faces;
        }

        private ArrayList TransformaPara(float translacaoX, float translacaoY, float translacaoZ, float rotx, float roty, float rotz)
        {
            ArrayList res = new ArrayList(this.vertices.Count);

            foreach (Vector3D v in this.vertices)
            {
                res.Add(v.Clone());
            }

            // Matrizes de transformação
            Matriz3D mTrans = Matriz3D.translacao(translacaoX, translacaoY, translacaoZ);
            Matriz3D mRotX = Matriz3D.rotacaoX(rotx);
            Matriz3D mRotY = Matriz3D.rotacaoY(roty);
            Matriz3D mRotZ = Matriz3D.rotacaoZ(rotz);
            Matriz3D mProjParalela = Matriz3D.projParalela(); // Projeção paralela

            // Aplicar as transformações
            for (int i = 0; i < res.Count; i++)
            {
                Vector3D v = (Vector3D)res[i];
                v.MultiplicaporMatriz_coordHomogeneas(mRotX);
                v.MultiplicaporMatriz_coordHomogeneas(mRotY);
                v.MultiplicaporMatriz_coordHomogeneas(mRotZ);
                v.MultiplicaporMatriz_coordHomogeneas(mTrans);
                v.MultiplicaporMatriz_coordCartesianas(mProjParalela); // Aplicar projeção paralela
            }

            return res;
        }

        public void Desenha(Graphics g, float translacaoX, float translacaoY, float translacaoZ, float rotacaoX, float rotacaoY, float rotacaoZ, float disCamara)
        {
            ArrayList verticesTransf = Transforma(translacaoX, translacaoY, translacaoZ, rotacaoX, rotacaoY, rotacaoZ, disCamara);
            ArrayList faces = GeraFaces(verticesTransf);

            for (int i = 0; i < faces.Count; i++)
            {
                Face f = (Face)faces[i];
                Vector3D normalFace = f.CalculaNormal();

                if (backfaceCulling)
                {
                    Vector3D cameraVector = new Vector3D(0, 0, -1);

                    float dotProduct = normalFace.ProdutoEscalar(cameraVector);

                    if (dotProduct > 0)
                    {
                        continue;
                    }
                    numFacesVisiveis++;
                }

                if (!this.wireframe)
                {
                    g.FillPolygon(this.brushPreenchimento, f.GetVertices2D(this.larguraDesenho, alturaDesenho));
                }
                g.DrawPolygon(penContorno, f.GetVertices2D(larguraDesenho, alturaDesenho));
            }
        }

        public int CalculaNumFacesVisiveis(float translacaoX, float translacaoY, float translacaoZ, float rotacaoX, float rotacaoY, float rotacaoZ, float disCamara)
        {
            int numFacesVisiveis = 0;
           
            ArrayList verticesTransf = Transforma(translacaoX, translacaoY, translacaoZ, rotacaoX, rotacaoY, rotacaoZ, disCamara);
           
            ArrayList faces = GeraFaces(verticesTransf);

            foreach (Face f in faces)
            {
                Vector3D normalFace = f.CalculaNormal();
                if (backfaceCulling)
                {
                    Vector3D cameraVector = new Vector3D(0, 0, -1);
                    float dotProduct = normalFace.ProdutoEscalar(cameraVector);
                    if (dotProduct > 0) continue;
                }
                numFacesVisiveis++;
            }
            return numFacesVisiveis;
        }


        public void DesenhaParalela(Graphics g, float translacaoX, float translacaoY, float translacaoZ, float rotacaoX, float rotacaoY, float rotacaoZ)
        {
            ArrayList verticesTransf = TransformaPara(translacaoX, translacaoY, translacaoZ, rotacaoX, rotacaoY, rotacaoZ);
            ArrayList faces = GeraFaces(verticesTransf);

            for (int i = 0; i < faces.Count; i++)
            {
                Face f = (Face)faces[i];
                if (!this.wireframe)
                {
                    g.FillPolygon(this.brushPreenchimento, f.GetVertices2D(this.larguraDesenho, alturaDesenho));
                }
                g.DrawPolygon(penContorno, f.GetVertices2D(larguraDesenho, alturaDesenho));
            }
        }

        // métodos para a leitura do objeto a partir de um ficheiro .txt

        public Objeto(float largura, float altura, Stream s)
        {
            this.s = s;
            this.LeFicheiro();
            this.LeObjeto();
            this.SetJanela(largura, altura);
        }
        public void SetObjeto(float largura, float altura, Stream s)
        {
            this.s = s;
            this.LeFicheiro();
            this.SetJanela(largura, altura);

        }

        public void SetFicheiro(float largura, float altura, Stream s)
        {
            this.s = s;
            this.LeObjeto();
            this.SetJanela(largura, altura);

        }

        private void LeFicheiro()
        {

            StreamReader readerObjeto = new StreamReader(this.s);  


            string linha = "";
            ArrayList pontos = new ArrayList();
            ArrayList indices = new ArrayList();

            while (linha != null)
            {
                linha = readerObjeto.ReadLine();
                if (linha != null)
                {
                    if (linha.StartsWith("v"))
                        pontos.Add(linha);
                    if (linha.StartsWith("f"))
                        indices.Add(linha);
                }

            }
            readerObjeto.Close();

            // extrair as coordenadas individuais dos vértices das linhas guardadas nos arraylist

            char[] separador = { ' ' }; // definir o separador: caractere espaço
            string[] coordenadas;
            foreach (string l in pontos)
            {
                coordenadas = l.Split(separador);
                this.vertices.Add(new Vector3D(float.Parse(coordenadas[1], System.Globalization.CultureInfo.InvariantCulture), float.Parse(coordenadas[2], System.Globalization.CultureInfo.InvariantCulture), float.Parse(coordenadas[3], System.Globalization.CultureInfo.InvariantCulture)));
            }

            // extrair os índices das faces, das linhas guardadas nos arraylist

            string[] indicesVertices;
            foreach (string l in indices)
            {
                indicesVertices = l.Split(separador);
                this.numvPorFace.Add(indicesVertices.Length - 1); //adicionar o nº de vértices/indices por face
                for (int i = 1; i < indicesVertices.Length; i++)
                {
                    this.indicesFaces.Add(int.Parse(indicesVertices[i]));
                }
            }

        }

        private void LeObjeto()
        {

            StreamReader readerObjeto = new StreamReader(this.s);  


            string linha = "";
            ArrayList pontos = new ArrayList();
            ArrayList indices = new ArrayList();

            while (linha != null)
            {
                linha = readerObjeto.ReadLine(); // Lê uma linha de caracteres da stream atual e retorna os dados como uma string 
                if (linha != null)
                {
                    if (linha.StartsWith("v "))
                        pontos.Add(linha);
                    if (linha.StartsWith("f"))
                        indices.Add(linha);
                }

            }
            readerObjeto.Close();

            // extrair as coordenadas individuais dos vértices das linhas guardadas nos arraylist

            char[] separador = { ' ' }; // definir o separador: caractere espaço
            string[] coordenadas;
            foreach (string l in pontos)
            {
                coordenadas = l.Split(separador);
                this.vertices.Add(new Vector3D(float.Parse(coordenadas[1], System.Globalization.CultureInfo.InvariantCulture), float.Parse(coordenadas[2], System.Globalization.CultureInfo.InvariantCulture), float.Parse(coordenadas[3], System.Globalization.CultureInfo.InvariantCulture)));
            }

            // extrair os índices das faces, das linhas guardadas nos arraylist

            string[] indicesVertices;
            foreach (string l in indices)
            {
                indicesVertices = l.Split(separador);
                this.numvPorFace.Add(indicesVertices.Length - 1); //adicionar o nº de vértices/indices por face
                for (int i = 1; i < indicesVertices.Length; i++)
                {
                    this.indicesFaces.Add(int.Parse(indicesVertices[i].Split('/')[0]) - 1);
                }
            }
        }
    }
}
