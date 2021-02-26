--------------------------------------------------------------------------
Welcome to the SignalPop AleControl! 
--------------------------------------------------------------------------

The AleControl is an open-source technology that gives Windows C# 
developers easy access to the Arcade-Learning-Environment (ALE)[1].  ALE 
is based on the Atari-2600 Emulator[2] from the Stella Team to provide access 
to numerous ATARI games (such as Pong, Space Invaders, etc.) for Reinforcement 
Learning.  The games run actions provided by the user and produce their overall 
game visualizations and game state.

For the active ALE project on GitHub, please see 
https://github.com/mgbellemare/Arcade-Learning-Environment
For the active Stella project on Github, please see 
https://github.com/stella-emu/stella

The AleControl uses the 'atari_win64' source tree which is a fork of 
the ALE Github tree that has been modified to run as a Windows 64-bit DLL and 
is licensed under the GNU license.  The 'atari_win64' project uses the Simple
DirectMedia Layer (SDL for short) which is a cross-platform library designed
to make it easy to write multi-media software such as games and emulators. 
The Simple DirectMedia Layer library source code is available from:
http://www.libsdl.org, and the SDL library is distributed under the terms of
the GNU LGPL License http://www.gnu.org/copyleft/lesser.html.

The <b>AleControl</b>, written by SignalPop LLC, is a Windows 64-bit COM control 
that gives any OLE Automation enabled language (C#, Visual Basic, etc.) easy access 
to the ALE environment via OLE Automation and is licensed under the Apache 2.0 license.  
An extensive list of ATARI game ROM files is provided by OpenAI on Github at:
https://github.com/openai/atari-py/tree/master/atari_py/atari_rom and are distributed
under the GNU GPL License https://github.com/openai/atari-py/blob/master/License.txt.
You can also directly import the AleControl from Nuget at https://www.nuget.org/packages?q=AleControl

When used in combination with MyCaffe (A complete C# re-write of CAFFE[3]) the 
AleControl can help solve Reinforcement Learning related problems via the 
MyCaffeTrainerRL control which adds reinforcement learning to MyCaffe.

See https://github.com/mycaffe for more information on MyCaffe, or download the
MyCaffe Nuget package at https://www.nuget.org/packages?q=MyCaffe.

For more information on how the MyCaffeTrainerRL complements MyCaffe with
reinforcement learning, see https://www.signalpop.com/wp-content/uploads/2018/09/myCaffe_with_RL_paper.v0.9.pdf.

The SignalPop AI Designer (https://www.signalpop.com) provides a development 
environment allows you to quickly pull all of these parts together to visually design 
MyCaffe based models that are both compatible with native CAFFE and support 
Reinforcement Learning for the Arcade-Learning-Environment

FINAL INSTALLATION STEPS:

1.) Register the 'AleControl.dll' by running the following in a CMD window
with Administrative privileges:
	a.) Go to the 'packages\CudaControl<version>\nativeBinaries\x64' directory
	b.) run 'regsvr32 AleControl.dll' to register.

SIMPLE EXAMPLE

To try out the simple sample, just add the following line where you would like 
to initiate the Arcade-Learning-Environment

	AleSample.AleSample.RunSample();

Make sure to build your project in 64-bit (uncheck Prefer 32-bit in your project) 
and you are ready to go.

If you are using MyCaffe, make sure to get the MyCaffe Test App which includes the 
MyCaffeTrainerRL for Reinforcement Learning, Cart-Pole gym, and provides tools to 
automatically load the MNIST and CIFAR-10 datasets, and has access to over 800 automated 
tests. To create the MyCaffe database, please install the MyCaffe
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

[1] [The Arcade Learning EnvironmentAn Evaluation Platform for General Agents](https://arxiv.org/abs/1207.4708) by Marc G. Bellemare, 
Yavar Naddaf, Joel Veness and Michael Bowling, 2012-2013.  Source code available on GitHub at <a href="https://github.com/mgbellemare/Arcade-Learning-Environment">mgbellemare/Arcade-Learning-Envrionment</a>

[2] [Stella - A multi-platform Atari 2600 VCS emulator](https://stella-emu.github.io/) by Bradford W. Mott, Stephen Anthony and The Stella Team, 1995-2018
Source code available on GitHub at <a href="https://github.com/stella-emu/stella">stella-emu/stella</a>

[3] [CAFFE: Convolutional Architecture for Fast Feature Embedding](https://arxiv.org/abs/1408.5093) by Yangqing Jai, Evan Shelhamer, Jeff Donahue, 
Sergey Karayev, Jonathan Long, Ross Girshick, Sergio Guadarrama, and Trevor Darrell, 2014.  Source code available on Github at <a href="https://github.com/BVLC/caffe">BVLC/caffe</a>

***