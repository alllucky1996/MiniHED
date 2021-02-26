--------------------------------------------------------------------------
Welcome to the SignalPop CudaControl! 
--------------------------------------------------------------------------

The CudaControl is an open-source technology used to easily interface 
Windows C# applications with NVIDIA's CUDA technology.  MyCaffe (curated by  
SignalPop) uses the CudaControl to communicate with the low-level GPU code.

***IMPORTANT***

CudaControl is 64-bit software, so in order to use it, you MUST make sure the 'Prefer 32-bit' build option
is UN-CHECKED.  To un-check this option, right click on your project, select 'Properties', select the
'Build' tab, and un-check the 'Prefer 32-bit' option. 

***************

FINAL INSTALLATION STEPS:

1.) Register the 'CudaControl.dll' by running the following in a CMD window
with Administrative privileges:
	a.) Go to the 'packages\CudaControl<version>\nativeBinaries\x64' directory
	b.) run 'regsvr32 CudaControl.dll' to register.

For more information on the CudaControl or the MyCaffe Deep Learning Platform
for Windows C# developers, please see the http://www.github.com/mycaffe site.

If you are using MyCaffe, make sure to get the MyCaffe Test App which provides tools 
to automatically load the MNIST and CIFAR-10 datasets, and provides access 
to over 1200 automated tests. To create the MyCaffe database, please install the MyCaffe
Test App which can be found at https://github.com/MyCaffe/MyCaffe/releases.

If you are looking for tools to visualize and debug your deep learning
models, check out the SignalPop AI Designer, where you can visually edit 
models, manage training sessions and debug your training in real-time. 
The SignalPop AI Designer now supports deep auto-encoder networks, 
domain adversarial neural networks (DANN), Policy Gradient and DQN reinforcement
learning.

You can try the SignalPop AI Designer demo version for free at: 
https://signalpop.blob.core.windows.net/dnnupdate/dnn.net.app.designer.setup.exe

You may also want to try the new SignalPop Universal Miner at:
https://signalpop.blob.core.windows.net/wpeupdate/wpe.net.app.setup.exe which 
allows you to mine cryptocurrencies like Ethereum.  In addition the 
Universal Miner has a great set of GPU management tools that help
manage each of your GPU's temperatures whether you are training AI
or mining a cryptocurrency.

For more information on innovative Deep Learning AI development tools that
use the MyCaffe AI Platform, such as the SignalPop Visual AI Designer, 
see https://www.signalpop.com.
***