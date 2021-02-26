using MyCaffe.basecode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCaffeSampleUI
{
    public partial class FormMyCaffeSamples : Form
    {
        Log m_log = new Log("MyCaffe Samples");
        CancelEvent m_evtCancel = new CancelEvent();
        ManualResetEvent m_evtRunning = new ManualResetEvent(false);
        bool m_bAllowCancelButton = true;

        delegate void FNSTATUS(string str);

        public FormMyCaffeSamples()
        {
            InitializeComponent();
        }

        private void FormMyCaffeSamples_Load(object sender, EventArgs e)
        {
            m_log.OnWriteLine += m_log_OnWriteLine;
            m_log.EnableTrace = true;
        }

        private void m_log_OnWriteLine(object sender, LogArg e)
        {
            if (InvokeRequired)
                Invoke(new FNSTATUS(setStatus), e.Message);
            else
                setStatus(e.Message);
        }

        private void setStatus(string str)
        {
            edtStatus.Text += Environment.NewLine;
            edtStatus.Text += str;
            edtStatus.SelectionLength = 0;
            edtStatus.SelectionStart = edtStatus.Text.Length;
            edtStatus.ScrollToCaret();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_evtCancel.Set();
        }

        private void enableButtons(bool bRunning)
        {
            btnAtariBreakout.Enabled = !bRunning;
            btnAtariPong.Enabled = !bRunning;
            btnCancel.Enabled = bRunning && m_bAllowCancelButton;
            btnCartPole.Enabled = !bRunning;
            btnCharRnn.Enabled = !bRunning;
            btnLeNet.Enabled = !bRunning;
            btnONNX.Enabled = !bRunning;
            btnSiamese.Enabled = !bRunning;
            btnStyleTransfer.Enabled = !bRunning;
            btnTriplet.Enabled = !bRunning;
            btnWebCam.Enabled = !bRunning;
        }

        private void btnLeNet_Click(object sender, EventArgs e)
        {
            MyCaffeSample.MyCaffeSample.RunClassificationSample(MyCaffeSample.MyCaffeSample.SAMPLE.LENET, m_log, m_evtCancel, m_evtRunning);
        }

        private void btnSiamese_Click(object sender, EventArgs e)
        {
            MyCaffeSample.MyCaffeSample.RunClassificationSample(MyCaffeSample.MyCaffeSample.SAMPLE.SIAMESE, m_log, m_evtCancel, m_evtRunning);
        }

        private void btnTriplet_Click(object sender, EventArgs e)
        {
            MyCaffeSample.MyCaffeSample.RunClassificationSample(MyCaffeSample.MyCaffeSample.SAMPLE.TRIPLET, m_log, m_evtCancel, m_evtRunning);
        }

        private void btnCharRnn_Click(object sender, EventArgs e)
        {
            MyCaffeSample.MyCaffeRNNSample.RunSample(this, m_evtCancel, m_log, m_evtRunning);
        }

        private void btnCartPole_Click(object sender, EventArgs e)
        {
            MyCaffeSample.MyCaffeRLpgSample.RunSample(this, m_evtCancel, MyCaffeSample.MyCaffeRLpgSample.GYM.CARTPOLE, m_log, m_evtRunning);
        }

        private void btnAtariPong_Click(object sender, EventArgs e)
        {
            MyCaffeSample.MyCaffeRLpgSample.RunSample(this, m_evtCancel, MyCaffeSample.MyCaffeRLpgSample.GYM.ATARI, m_log, m_evtRunning);
        }

        private void btnAtariBreakout_Click(object sender, EventArgs e)
        {
            MyCaffeSample.MyCaffeRLdqnSample.RunSample(this, m_evtCancel, MyCaffeSample.MyCaffeRLdqnSample.GYM.ATARI, m_log, m_evtRunning);
        }

        private void btnStyleTransfer_Click(object sender, EventArgs e)
        {
            MyCaffeSample.MyCaffeNeuralStyleSample.RunSample(this, m_evtCancel, m_log, m_evtRunning);
        }

        private void btnONNX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOTE: The ONNX output is only sent to the Visual Studio output window.", "ONNX Output", MessageBoxButtons.OK, MessageBoxIcon.Information);

            m_evtRunning.Set();

            try
            {
                m_bAllowCancelButton = false;
                OnnxSample.OnnxSample.RunSample();
            }
            catch (Exception excpt)
            {
                MessageBox.Show("ONNX Error: " + excpt.Message);
            }
            finally
            {
                m_bAllowCancelButton = true;
                m_evtRunning.Reset();
            }
        }

        private void btnWebCam_Click(object sender, EventArgs e)
        {
            string strDefaultFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MyCaffe\\test_data\\data\\video\\";
            string strDefaultFile = "PET717_Var3.300x225.wmv";

            WebCamSample.WebCamDialog dlg = new WebCamSample.WebCamDialog(strDefaultFolder, strDefaultFile);
            dlg.ShowDialog();
        }

        private void timerUI_Tick(object sender, EventArgs e)
        {
            enableButtons(m_evtRunning.WaitOne(0));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            edtStatus.Text = "";
        }
    }
}
