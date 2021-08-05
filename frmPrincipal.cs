using LAUNCHERMUWINDOWSFORMS.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
namespace LAUNCHERMUWINDOWSFORMS
{
    public partial class frmPrincipal : Form
    {
        int X = 0;
        int Y = 0;

        public frmPrincipal()
        {
            InitializeComponent();
            CmbResolution.Items.Add("640x480");
            CmbResolution.Items.Add("800x600");
            CmbResolution.Items.Add("1024x768");
            CmbResolution.Items.Add("1280x1024");
        }


        private void BtnJogar_Click(object sender, EventArgs e)
        {
            try
            {
                Registros.SetValor(TxtLogin, CmbResolution, ChkMusic, ChkWindowMode);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado ao registrar as informações : \n" + ex.Message);
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(FrmPrincipal_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmPrincipal_MouseMove);


            Registros.IniciarRegistro();
            Registros.GetValor(TxtLogin, CmbResolution, ChkMusic, ChkWindowMode);

            lblUpdate.Text = "Verificando arquivos...";
            Worker.RunWorkerAsync();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }


        private void FrmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }


        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var url = "https://juniormariano22.000webhostapp.com/Updates/";
            string Server = url + "Update.json";
            string Json;

            using (WebClient wc = new WebClient())
            {
                wc.Headers["Cookie"] = "security=true";
                Json = wc.DownloadString(new Uri(Server, UriKind.RelativeOrAbsolute));
            }
            var arquivos = JsonConvert.DeserializeObject<List<Arquivos>>(Json);
            var arquivosLocal = new List<string>(Directory.GetFiles(Directory.GetCurrentDirectory(), "*.*", SearchOption.AllDirectories));

            foreach (var update in arquivos)
            {
                string hash = update.Hash;
                string file = update.Nome.Replace("/", "\\");
                bool auth = true;


                if (arquivosLocal.FindAll(p => p.Contains(file.Replace(".zip", string.Empty))).Count > 0)
                {
                    var arq = arquivosLocal.Find(p => p.Contains(file.Replace(".zip", string.Empty)));
                    var ShaOne = new SHA1CryptoServiceProvider();
                    byte[] data = File.ReadAllBytes(arq);
                    var DataCrip = ShaOne.ComputeHash(data);
                    string hashLocal = BitConverter.ToString(DataCrip).Replace("-", string.Empty).ToLower();


                    if (hashLocal == hash)
                    {
                        auth = false;
                    }
                }

                var uri = url + update.Nome;
                Common.rootArq = AppDomain.CurrentDomain.BaseDirectory + file;
                string nomeArquivo = Common.rootArq.Substring(Common.rootArq.LastIndexOf("\\") + 1);
                Common.subpastas = Common.rootArq.Replace(nomeArquivo, string.Empty);

                if (auth)
                {
                    if (!Directory.Exists(Common.subpastas))
                    {
                        Directory.CreateDirectory(Common.subpastas);
                    }
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    response.Close();

                    Common.iSize = response.ContentLength;

                    Common.iRunningByteTotal = 0;

                    using (WebClient client = new System.Net.WebClient())
                    {
                        using (Stream streamRemote = client.OpenRead(new Uri(uri)))
                        {
                            using (Stream streamLocal = new FileStream(Common.rootArq, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                int iByteSize = 0;
                                byte[] byteBuffer = new byte[Common.iSize];
                                while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                                {
                                    streamLocal.Write(byteBuffer, 0, iByteSize);
                                    Common.iRunningByteTotal += iByteSize;

                                    double dIndex = (double)(Common.iRunningByteTotal);
                                    double dTotal = (double)byteBuffer.Length;
                                    double dProgressPercentage = (dIndex / dTotal);
                                    int iProgressPercentage = (int)(dProgressPercentage * 100);
                               
                                    Worker.ReportProgress(iProgressPercentage);
                                   
                                }

                                streamLocal.Close();
                            }

                            streamRemote.Close();
                        }
                    }

                    using (ZipFile zip = ZipFile.Read(file))
                    {
                        foreach (ZipEntry zipFiles in zip)
                        {
                            zipFiles.Extract(Common.subpastas + "", ExtractExistingFileAction.DoNotOverwrite);
                        }
                    }

                    

                    Common.DeleteFile(Common.rootArq);
                }
                
            }

        }

        private void Worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

            this.Invoke((MethodInvoker)(() =>
            {
                BtnJogar.Enabled = false;
                PbArq.Value = e.ProgressPercentage;               
                lblUpdate.Text = string.Format("Baixando atualizações... {0}% concluídos", Convert.ToString(e.ProgressPercentage));
            }));

        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                BtnJogar.Enabled = true;
                lblUpdate.Text = "Download Completo.";
                PbArq.Value = 100;
                PbArqTotal.Value = 100;
            }));
        }


    }
}



