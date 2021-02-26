using System;
using System.Drawing;
using System.IO;
using System.Linq;
using Emgu.CV;
using Emgu.CV.Dnn;
using Emgu.CV.Structure;
using Microsoft.Extensions.DependencyInjection;

namespace HEDApp
{
    class Program
    {
        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RegisterServices();
            var cf = _serviceProvider.GetService<ICaffe>();
            string path = @"F:\Project Runing\Git\MiniHED\HEDApp\Image\DataTest\input";
            string outPath = Path.Combine(@"F:\Project Runing\Git\MiniHED\HEDApp\Image\", "EDImg");
            if (!Directory.Exists(outPath))
            {
                Directory.CreateDirectory(outPath);
            }
            var files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            foreach (var f in files.Take(30))
            {
                var org = CvInvoke.Imread(f);
                var inp = DnnInvoke.BlobFromImage(org, 1.0, new Size(org.Width, org.Height),
                                                   mean: new MCvScalar(104.00698793, 116.66876762, 122.67891434),
                                                   swapRB: false, crop: false);
                cf.Setinput(inp);
                var imgOut = cf.ForwardDnn2Image("", org.Height);
                Console.WriteLine($"time run:{cf.TimeRun} ms - shape: 500x500 - name: {Path.GetFileName(f)} ");
                CvInvoke.Imwrite(Path.Combine(outPath, Path.GetFileName(f)), imgOut);
            }
            DisposeServices();
        }
        private static void RegisterServices()
        {
            var prototxt = "Model/deploy.prototxt";
            var model = "Model/hed_pretrained_bsds.caffemodel";
            var collection = new ServiceCollection();
            collection.AddSingleton<ICaffe, CaffeHelper>(o=> new CaffeHelper(prototxt, model, true));
            // ...
            // Add other services
            // ...
            _serviceProvider = collection.BuildServiceProvider();
        }
        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
