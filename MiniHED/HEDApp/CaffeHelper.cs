using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Dnn;
using Emgu.CV.Structure;

namespace HEDApp
{
    public class CaffeHelper : ICaffe
    {
        public Net Net { get; private set; }
        public string Prototxt { get; set; }
        public string Model { get; set; }
        public bool EnableWatch { get; set; }
        public CaffeHelper()
        {
            _loaded = false;
        }
        public CaffeHelper(string prototxt, string model, bool enableWatch = false)
        {
            Prototxt = prototxt;
            Model = model;
            EnableWatch = enableWatch;
            if (!_check) throw new ArgumentNullException("model may be null");
            this.Net = DnnInvoke.ReadNetFromCaffe(Prototxt, Model);
            this.Net.SetPreferableBackend(Emgu.CV.Dnn.Backend.OpenCV);
            this.Net.SetPreferableTarget(Target.Cpu);
            _loaded = true;
        }

        private bool _check => File.Exists(Prototxt) && File.Exists(Model);
        private Stopwatch _sw = new Stopwatch();
        public long TimeRun { get; protected set; }
        

        public Mat OutputDnn(string outputName = "")
        {
            if (EnableWatch)
            {
                _sw.Start();
                var result = this.Net.Forward(outputName);
                _sw.Stop();
                TimeRun = _sw.ElapsedMilliseconds;
                return result;
            }
            return this.Net.Forward(outputName);
        }

        public void LoadModel(string prototxt, string modelCaffe = null)
        {
            Prototxt = prototxt;
            Model = modelCaffe;
            if (!_check) throw new ArgumentNullException("model may be null");
            this.Net = DnnInvoke.ReadNetFromCaffe(Prototxt, Model);
            _loaded = true;
        }

        public void Setinput(IInputArray blob, string name = "", double scaleFactor = 1, MCvScalar mean = default(MCvScalar))
        {
            this.Net.SetInput(blob, name, scaleFactor, mean);
        }

        public Mat ForwardDnn2Image(string outputName = "",int row = 0, DepthType type= DepthType.Cv8U, double alpha = 255.0, double beta = 0)
        {
            if (EnableWatch)
            {
                _sw.Start();
                var start = _sw.ElapsedMilliseconds;
                var oup = this.Net.Forward(outputName);
                var end = _sw.ElapsedMilliseconds;
                _sw.Stop();
                TimeRun = end-start;
                var result = new Mat();
                oup.Reshape(1, row).ConvertTo(result, type, alpha, beta);
                return result;
            }
            return this.Net.Forward(outputName);
            
        }

        public ICaffe Clone()
        {
            ICaffe cf = new CaffeHelper(this.Prototxt, this.Model);
            cf.EnableWatch = this.EnableWatch;
            return cf;
        }

        private bool _loaded = false;
        public bool Loaded => _loaded;

    }
}
