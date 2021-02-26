--------------------------------------------------------------------------
Welcome to MyCaffe - The Deep Learning solution for Windows C# Developers! 
Now supporting:
	CUDA 11.0,   cuDNN 8.0.2 and native Caffe up to 10/24/2018 (default)
	Note (Compute 5.3 and higher now required to support __half sized memory)

	CUDA 10.2.89,   cuDNN 7.6.5 and native Caffe up to 10/24/2018 (default)
	Note (Compute 5.3 and higher now required to support __half sized memory)
--------------------------------------------------------------------------

The MyCaffe NuGet package contains the binary release of the open-source 
MyCaffe project at http://www.github.com/mycaffe.

This NuGet package contains the MyCaffe control, MyCaffe image database, 
MyCaffe basecode, MyCaffe extras, MyCaffe trainers and the MyCaffe gyms,
and now has full online help available at https://www.signalpop.com/help.

To get started, please see the MyCaffe Programming Guide at https://www.signalpop.com/mycaffe/ and
check out the samples at https://github.com/MyCaffe/MyCaffe-Samples.

***IMPORTANT***

MyCaffe is 64-bit software, so in order to use it, you MUST make sure the 'Prefer 32-bit' build option
is UN-CHECKED.  To un-check this option, right click on your project, select 'Properties', select the
'Build' tab, and un-check the 'Prefer 32-bit' option. 

Some of the MyCaffe Samples noted below expect that you have already installed the MyCaffe Test Application and
loaded both the MNIST and CIFAR datasets into your SQL EXPRESS database.  To learn more about this, please
see the MyCaffe Test Application at https://github.com/MyCaffe/MyCaffe/releases.

***************

REQUIRED SOFTWARE:

1.) Download and Install the latest MyCaffe Test Application from https://github.com/MyCaffe/MyCaffe/releases (includes CUDA and cuDNN distributable DLL's)

- or -

1.a) Install NVIDIA CUDA 11.0 which you can download from https://developer.nvidia.com/cuda-downloads

1.b) Install NVIDIA cuDNN 8.0.2 which you can download from https://developer.nvidia.com/cudnn

- next -

3.) Download and install Microsoft SQL Express 2016 (or later).
 
FINAL INSTALLATION STEPS:

1.) Register the 'CudaControl.dll' by running the following in a CMD window
with Administrative privileges:
	a.) Go to the 'packages\CudaControl<version>\nativeBinaries\x64' directory
	b.) run 'regsvr32 CudaControl.dll' to register.

2.) Register the 'AleControl.dll' by running the following in a CMD window
with Administrative privileges:
	a.) Go to the 'packages\AleControl<version>\nativeBinaries\x64' directory
	b.) run 'regsvr32 AleControl.dll' to register.

3.) Download and install the MyCaffe Test Application located at
https://github.com/MyCaffe/MyCaffe/releases.  Before using MyCaffe, you will
need to create a new MyCaffe database - the MyCaffe Test Application will
do tis for you automatically.  In addition, you can use the MyCaffe Test
Application to load the MNIST dataset into your MyCaffe database.

4.) A sample dialog 'FormMyCaffeSamples' and file 'MyCaffeSample.cs' have been added to 
your project.  These files demonstrates how to create and use MyCaffe to solve several 
common tasks such as the following:

To run the sample, just add the following code to your 64-bit C# project:

        MyCaffeSampleUI.FormMyCaffeSamples dlg = new MyCaffeSampleUI.FormMyCaffeSamples();
        dlg.ShowDialog();
	

This sample contains the following demonstrations:

-- CLASSIFICATION --

* LeNet - train a classification problem by learning the MNIST dataset with the
'LeNet' model.

* SiameseNet - train a classification problem by learning the MNIST dataset with 
the 'Siamese Net' which feeds positive and negative images against an anchor to 
learn a distance separation between classes by learning with two parallel networks.

* TripletNet - train a classification problem by learning the MNIST dataset with 
the 'Triplet Net' which feeds anchor, positive and negative images simultaneously to
learn a distance separation between classes by learning with three parallel networks.


-- RECURRENT LEARNING --

* CharNet - train the recurrent CharNet to learn how to write a Shakespeare sonnet.


-- REINFORCEMENT LEARNING --

* Policy Gradient - train a policy gradient reinforcement learning model to learn how 
to balance the pole in the Cart Pole gym.

* Policy Gradient - train a policy gradient reinforcement learning model to learn how 
to play and beat the ATARI game Pong.

* DQN - train a DQN reinforcement learning model to learn how to play and beat the
ATARI game Breakout.


-- NEURAL STYLE TRANSFER --

* Neural Style Transfer - learn the artistic style of Vincent van Gogh and paint 
a photograph in his artistic style to produce a new piece of art.


-- CONTROL TESTS --

* ONNX - test the ONNX model format.

* ALE - test the ALE ATARI Game Simulator.

* WebCam - test the WebCam control used to input video data.


Each sample sends their output and status to the Visual Studio output
windows, so when first running these samples you may want to run them
in Debug mode.

To use any of the samples, just call one of the methods listed above,
build with the 'Prefer 32-bit' Build Setting as UNCHECKED, build and run.

Follow the instructions in this file to get started using MyCaffe!  

NOTE: Make sure to build in x64! Uncheck 'Prefer 32-bit' in your Build settings
or errors will occur.

For more information on the MyCaffe implementation of Policy Gradient Reinforcement Learning, 
see [MyCaffe: A Complete C# Re-Write of Caffe with Reinforcement Learning](https://arxiv.org/abs/1810.02272) 
by D. Brown, 2018. 

If you use MyCaffe in your application, feel free to also use either of the 
'Powered by MyCaffe' logos added to your project to show that you are using MyCaffe!

NOTE: By default MyCaffe uses CUDA 11.0 with cuDNN 8.0.2. To use the 
CUDA 10.2/cuDNN 7.6.5 version of the CudaDnnDLL, just remove all but the 
version of the CudaDnnDLL and NCCL dll that you want to use.

MyCaffe, looks for the highest version and if not found, continues looking 
for the next highest version.

--------------------------------------------------------------------------
MyCaffe uses Microsoft SQL (including the free Microsoft SQL Express) for 
data storage.  To create the MyCaffe database, please install the MyCaffe
Test App which can be found at https://github.com/MyCaffe/MyCaffe/releases.

In addition to database management, the MyCaffe Test App provides tools 
to automatically load the MNIST and CIFAR-10 datasets, and provides access 
to over 1200 automated tests.

If you are looking for tools to visualize and debug your deep learning
models, check out the SignalPop AI Designer, where you can visually edit 
models, manage training sessions and debug your training in real-time. 
The SignalPop AI Designer now supports deep auto-encoder networks, 
domain adversarial neural networks (DANN), policy gradient reinforcement
learning, recurrent LSTM learning (using cuDNN), Neural Style Transfer,
Siamese Nets and Triplet Nets for metric learning.

If you would like to help improve MyCaffe with your input, add a pull
request or comment to the open-source project at: 
https://github.com/MyCaffe/MyCaffe

You can try the SignalPop AI Designer demo version for free at: 
https://www.signalpop.com/products

You may also want to try mining Ethereum with the new SignalPop Universal Miner at:
https://www.signalpop.com/products 

The SignalPop Universal Miner has a great set of GPU management tools that help manage 
each of your GPU's temperatures whether you are training AI or mining a cryptocurrency.

For more information on innovative Deep Learning AI development tools that
use the MyCaffe AI Platform, such as the SignalPop Visual AI Designer, 
see https://www.signalpop.com.
***