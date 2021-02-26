using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Onnx;
using OnnxControl;

namespace OnnxSample
{
    /// <summary>
    /// This sample is provided to show how to initialize and use the OnnxControl.
    /// </summary>
    /// <remarks>
    /// @see [ONNX Syntax](https://github.com/onnx/onnx/blob/master/docs/IR.md) for more information on the ONNX model file format.
    /// </remarks>
    public class OnnxSample
    {
        public OnnxSample()
        {
        }

        /// <summary>
        /// This static function shows how to use the OnnxControl in with a very simple example.
        /// </summary>
        public static void RunSample()
        {
            // Download a small onnx model from https://github.com/onnx (dowload is 26.6kb)
            string strUrl = "https://github.com/onnx/models/raw/master/vision/classification/mnist/model/mnist-1.onnx";
            string strFile = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\OnnxControl\\models\\";

            if (!Directory.Exists(strFile))
                Directory.CreateDirectory(strFile);

            strFile += "mnist-1.onnx";

            if (!File.Exists(strFile))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(strUrl, strFile);
                }
            }

            // Load the model within the ONNX file.
            PersistOnnx persist = new PersistOnnx();
            ModelProto model = persist.Load(strFile);

            // Display the model contents
            Trace.WriteLine("Loaded model file '" + strFile + "'...");
            Trace.WriteLine("Version = " + model.IrVersion.ToString());
            Trace.WriteLine("Producer Name = " + model.ProducerName);
            Trace.WriteLine("Producer Version = " + model.ProducerVersion);
            Trace.WriteLine("Model Version = " + model.ModelVersion.ToString());
            Trace.WriteLine("Description = " + model.DocString);
            Trace.WriteLine("Domain = " + model.Domain);

            Trace.WriteLine("---Graph---");
            Trace.WriteLine("Name = " + model.Graph.Name);

            Trace.WriteLine("Inputs:");
            foreach (ValueInfoProto val in model.Graph.Input)
            {
                Trace.WriteLine(val.ToString());
            }

            Trace.WriteLine("Outputs:");
            foreach (ValueInfoProto val in model.Graph.Output)
            {
                Trace.WriteLine(val.ToString());
            }

            Trace.WriteLine("Nodes:");
            foreach (NodeProto val in model.Graph.Node)
            {
                Trace.WriteLine(val.ToString());
            }

            Trace.WriteLine("Quantization Annotation:");
            Trace.WriteLine(model.Graph.QuantizationAnnotation.ToString());

            Trace.WriteLine("Initializer Tensors:");
            foreach (TensorProto t in model.Graph.Initializer)
            {
                Trace.WriteLine(t.Name + " (data type = " + t.DataType.ToString() + ") " + t.Dims.ToString());
            }

            // Save the model to another file.
            string strFile2 = Path.GetDirectoryName(strFile) + "\\" + Path.GetFileNameWithoutExtension(strFile) + "2.onnx";

            if (File.Exists(strFile2))
                File.Delete(strFile2);

            persist.Save(model, strFile2);
        }
    }
}
