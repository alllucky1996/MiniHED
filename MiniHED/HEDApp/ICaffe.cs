using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEDApp
{
    public interface ICaffe
    {
        bool Loaded { get; }
        bool EnableWatch { get; set; }
        long TimeRun { get; }
        //Size InputSize { get; set; }
        Mat OutputDnn(string outputName = "");
        Mat ForwardDnn2Image(string outputName = "", int row = 0, DepthType type = DepthType.Cv8U, double alpha = 255.0, double beta = 0);
        void LoadModel(string prototxt, string modelCaffe = null);
        void Setinput(IInputArray blob, string name = "", double scaleFactor = 1, MCvScalar mean = default(MCvScalar));
        ICaffe Clone();
    }
}
