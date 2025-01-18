using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desenhaFaces_v1
{
    public partial class Form1 : Form
    {
        private Objeto obj;
        private Pen pen1;
        private SolidBrush brush1;
        private string nomeFicheiro;
        int op = 1;

        public Form1()
        {
            InitializeComponent();
            
            obj = new Objeto(pb_desenho.Width, pb_desenho.Height);

            pen1 = new Pen(CorStroke_pb.BackColor, (float)Espessura_nud.Value);
            pen1.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            brush1 =new SolidBrush(CorFill_pb.BackColor);
            disCamara.ValueChanged += DisCamara_ValueChanged;

            obj.SetCores(pen1, brush1);

        }
        // Evento de desenho para projeção paralela
        private void pb_desenhoParalela_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (obj != null)
            {

                switch (op)
                {
                    case 1:
                        obj.Cubo();
                        obj.DesenhaParalela(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value);
                        break;

                    case 2:
                        obj.Tetraedro();
                        obj.DesenhaParalela(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value);
                        break;

                    case 3:
                        obj.PrismaHex();
                        obj.DesenhaParalela(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value);
                        break;

                    case 4:

                        float raioBase = (float)numericUpDown1.Value;
                        float raioTopo = raioBase / 2;
                        float altura = (float)numericUpDown2.Value;
                        int numSegmentos = (int)numericUpDown3.Value;

                        obj.TroncoCone(raioBase, raioTopo, altura, numSegmentos);
                        obj.DesenhaParalela(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value);
                        break;

                    case 5:
                        tb_transx.Value = 0;
                        tb_transy.Value = 0;
                        tb_transz.Value = 0;
                        Rotx_tb.Value = 0;
                        Roty_tb.Value = 0;
                        Rotz_tb.Value = 0;
                        Espessura_nud.Value = 0;
                        CorStroke_pb.BackColor = Color.Blue;
                        CorFill_pb.BackColor = Color.OrangeRed;
                        obj.Cubo();
                        obj.DesenhaParalela(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value);
                        break;

                    case 6:
                        obj.DesenhaParalela(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value);
                        break;

                    case 7:
                        obj.DesenhaParalela(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value);
                        break;
                }
            }
        }
        // Evento de desenho para projeção perspetiva
        private void pb_desenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Brush backgroundBrush = new SolidBrush(Color.White))
            {
                g.FillRectangle(backgroundBrush, pb_desenho.ClientRectangle);
            }

            if (obj != null)
            {
                switch (op)
                {
                    case 1:
                        obj.Cubo();
                        obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, disCamara.Value);
                        break;

                    case 2:
                        obj.Tetraedro();
                        obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, disCamara.Value);
                        break;

                    case 3:
                        obj.PrismaHex();
                        obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, disCamara.Value);
                        break;

                    case 4:
                        
                        float raioBase = (float)numericUpDown1.Value;
                        float raioTopo = raioBase / 2;
                        float altura = (float)numericUpDown2.Value;
                        int numSegmentos = (int)numericUpDown3.Value;

                        obj.TroncoCone(raioBase, raioTopo, altura, numSegmentos);
                        obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, disCamara.Value);
                        break;

                    case 5:
                        tb_transx.Value = 0;
                        tb_transy.Value = 0;
                        tb_transz.Value = 0;
                        Rotx_tb.Value = 0;
                        Roty_tb.Value = 0;
                        Rotz_tb.Value = 0;
                        disCamara.Value = 600;
                        Espessura_nud.Value = 0;
                        CorStroke_pb.BackColor = Color.Blue;
                        CorFill_pb.BackColor = Color.OrangeRed;
                        obj.Cubo();
                        obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, disCamara.Value);
                        break;

                    case 6:
                        obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, disCamara.Value);
                        break;

                    case 7:
                        obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, disCamara.Value);
                        break;
                }
            }
        }
        // Evento de desenho para projeção perspetiva
        private void SetCores()
        {
            if (pen1 != null && brush1 != null)
            {
                pen1.Color = CorStroke_pb.BackColor;
                pen1.Width = (float)Espessura_nud.Value;
                brush1.Color = CorFill_pb.BackColor;
                obj.SetCores(pen1, brush1);
            }
        }
        // Ativa ou desativa o modo wireframe e atualiza a visualização
        private void cb_wireframe_CheckedChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.SetWireframe();
                this.pb_desenho.Invalidate();
                this.pb_desenhoParalela.Invalidate();
            }
        }
        // Atualiza a espessura do contorno quando o valor do NumericUpDown é alterado
        private void Espessura_nud_ValueChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                SetCores();
                this.pb_desenho.Invalidate();
                this.pb_desenhoParalela.Invalidate();

            }
        }
        // Abre um seletor de cores para alterar a cor do contorno do objeto
        private void CorStroke_btn_Click(object sender, EventArgs e)
        {
            ColorDialog dialogo = new ColorDialog();
            dialogo.Color = this.CorStroke_pb.BackColor;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                this.CorStroke_pb.BackColor = dialogo.Color;
                if (obj != null)
                {
                    SetCores();
                    this.pb_desenho.Invalidate();
                    this.pb_desenhoParalela.Invalidate();
                }
            }
        }
        // Abre um seletor de cores para alterar a cor de preenchimento do objeto
        private void CorFill_btn_Click(object sender, EventArgs e)
        {
            ColorDialog dialogo = new ColorDialog();
            dialogo.Color = this.CorFill_pb.BackColor;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                
                this.CorFill_pb.BackColor = dialogo.Color;
                if (obj != null)
                {
                    SetCores();
                    this.pb_desenho.Invalidate();
                    this.pb_desenhoParalela.Invalidate();
                }
            }
        }
        // Redesenha o objeto quando o slider de translação no eixo Y é alterado
        private void tb_transy_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Redesenha o objeto quando o slider de translação no eixo X é alterado
        private void tb_transx_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Redesenha o objeto quando o slider de translação no eixo Z é alterado

        private void tb_transz_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Abre um ficheiro de modelo e atualiza o objeto

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream str;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)

                try
                {
                    if ((str = fileDialog.OpenFile()) != null)
                    {

                        using (str)
                        {
                            if (obj != null)
                            {                                
                                obj.GetVertices3D().Clear();
                                obj.GetIndicesFaces().Clear();
                                obj.GetNumvPorFace().Clear();
                                obj.SetObjeto(this.pb_desenho.Width, this.pb_desenho.Height, str); 
                            }

                            nomeFicheiro = fileDialog.SafeFileName;

                            SetCores();

                            if (cb_wireframe.Checked)
                            {
                                obj.SetWireframe();
                            }
                            this.pb_desenho.Invalidate();
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Não foi possível ler o ficheiro\n" + ex.Message);
                }
        }
        // Fecha a aplicação

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        // Exibe informações sobre o modelo

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float translacaoX = tb_transx.Value;
            float translacaoY = tb_transy.Value;
            float translacaoZ = tb_transz.Value;

            float rotacaoX = Rotx_tb.Value;
            float rotacaoY = Roty_tb.Value;
            float rotacaoZ = Rotz_tb.Value;

            float distanciaCamara = disCamara.Value; 

            int numFacesVisiveis = obj.CalculaNumFacesVisiveis(translacaoX, translacaoY, translacaoZ, rotacaoX, rotacaoY, rotacaoZ, distanciaCamara);

            string nomeModelo = string.IsNullOrEmpty(nomeFicheiro) ? "Modelo Interno" : nomeFicheiro;

            string titulo = "Informações do Modelo - Projeção Perspetiva";
            string mensagem = $"Nome do modelo: {nomeModelo}\n" +
                              $"Número total de faces: {obj.numvPorFace.Count}\n" +
                              $"Número de faces visíveis: {numFacesVisiveis}";

            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Evento acionado quando o formulário é redimensionado
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.SetJanela(this.pb_desenho.Width, this.pb_desenho.Height);
                this.pb_desenho.Invalidate();
                this.pb_desenhoParalela.Invalidate();
            }
        }
        // Evento acionado quando o valor do slider de rotação no eixo X é alterado
        private void Rotx_tb_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Evento acionado quando o valor do slider de rotação no eixo Y é alterado
        private void Roty_tb_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Evento acionado quando o valor do slider de rotação no eixo Z é alterado

        private void Rotz_tb_ValueChanged(object sender, EventArgs e)
        {
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Evento acionado quando o valor do controle numericUpDown1 (raio da base) é alterado
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            AtualizarTroncoCone();
        }
        // Evento acionado quando o valor do controle numericUpDown2 (altura) é alterado
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTroncoCone();
        }
        // Evento acionado quando o valor do controle numericUpDown3 (número de segmentos) é alterado
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTroncoCone();
        }
        // Atualiza o tronco de cone com novos parâmetros
        private void AtualizarTroncoCone()
        {
            float raioBase = (float)numericUpDown1.Value;
            float raioTopo = raioBase / 2;
            float altura = (float)numericUpDown2.Value;
            int numSegmentos = (int)numericUpDown3.Value;

            Objeto objeto = new Objeto();

            objeto.TroncoCone(raioBase, raioTopo, altura, numSegmentos);
        }

        // Muda o modo para desenhar um cubo
        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = 1;
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Muda o modo para desenhar um tetraedro
        private void tetraedroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = 2;
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Muda o modo para desenhar um prisma hexagonal
        private void prismaHexagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = 3;
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }

        private void troncoConeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = 4;
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Ativa ou desativa o modo de remoção de faces traseiras
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (obj != null)
            {
                obj.BackfaceCulling = checkBox1.Checked;
                this.pb_desenho.Invalidate();
                this.pb_desenhoParalela.Invalidate();
            }
        }
        // Reseta todas as configurações para o estado inicial
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = 5;
            this.pb_desenho.Invalidate();
            this.pb_desenhoParalela.Invalidate();
        }
        // Abre um ficheiro OBJ e atualiza o objeto
        private void abrirOBJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = 6;
            Stream str;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.obj)|*.obj|All files(*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    if ((str = fileDialog.OpenFile()) != null)
                    {
                        using (str)
                        {
                            if (obj != null)
                            {
                                obj.GetVertices3D().Clear();
                                obj.GetIndicesFaces().Clear();
                                obj.GetNumvPorFace().Clear();
                                obj.SetFicheiro(this.pb_desenho.Width, this.pb_desenho.Height, str); 
                            }

                            nomeFicheiro = fileDialog.SafeFileName;

                            SetCores(); 

                            if (cb_wireframe.Checked)
                            {
                                obj.SetWireframe();
                            }
                            this.pb_desenho.Invalidate();
                            this.pb_desenhoParalela.Invalidate();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Não foi possível ler o ficheiro\n" + ex.Message);
                }
        }
        // Evento chamado quando o valor da distância da câmera é alterado (projeção perspetiva)
        public void DisCamara_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ValueChanged event triggered!");
            
            float novaDistancia = disCamara.Value;

            Console.WriteLine($"New camera distance: {novaDistancia}");

            PaintEventArgs paintEventArgs = new PaintEventArgs(CreateGraphics(), new Rectangle());

            RedesenhaObjeto(novaDistancia, paintEventArgs);

            this.pb_desenho.Invalidate();
        }
        // Evento chamado quando o valor da distância da câmera é alterado (projeção paralela)
        public void disCamara_ValueChanged(object sender, EventArgs e)
        {
            float novaDistancia = disCamara.Value;

            PaintEventArgs paintEventArgs = new PaintEventArgs(CreateGraphics(), new Rectangle());

            RedesenhaObjeto(novaDistancia, paintEventArgs);
        }

        // Redesenha o objeto quando a distância da câmera muda
        public void RedesenhaObjeto(float novaDistancia, PaintEventArgs e)
        {
            Console.WriteLine($"Updating camera distance: {novaDistancia}");
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            obj.Desenha(g, tb_transx.Value, tb_transy.Value, tb_transz.Value, Rotx_tb.Value, Roty_tb.Value, Rotz_tb.Value, novaDistancia);
        }

        // Mostra informações sobre os desenvolvedores do projeto

        private void desenvolvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string desenvolvedores = "António Rebelo - Nº 28837\n" +
                                     "Diogo Pinto - Nº 28899\n" +
                                     "Renato Madeira - Nº 29683";

            MessageBox.Show(desenvolvedores, "Informações dos Desenvolvedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Renicia as transformações, tanto a Translação como a Rotação e a Camera
        private void ResetT_btn_Click(object sender, EventArgs e)
        {
            tb_transx.Value = 0;
            tb_transy.Value = 0;
            tb_transz.Value = 0;

            Rotx_tb.Value = 0;
            Roty_tb.Value = 0;
            Rotz_tb.Value = 0;

            disCamara.Value = 600; 

            SetCores();

            if (obj != null)
            {
                this.pb_desenho.Invalidate(); 
                this.pb_desenhoParalela.Invalidate(); 
            }
        }

    }
}
