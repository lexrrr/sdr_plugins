CalicoCAT plugin for SDR# by N0TTL

	This plugin makes SDR# (SDRSharp) appear to other programs as a transceiver, specifically it emulates a Kenwood TS-2000.

	3rd-party plugins can control SDR# Frequency and/or Mode

Prerequisite:

	A virtual serial port emulator must be installed for this plugin to function.
	
	There are many free and commercial options available.
	
	A proven working and free one is "com0com" available here; https://sourceforge.net/projects/com0com/
	
Install:

	Copy SDRSharp.Calico.dll to your "SDRSharp" installation folder.
	
	Open MagicLine.txt in your favorite text editor and and copy the line and paste into your SDRSharp\Plugins.xml file inside the <sharpPlugins> element. 

	Example:

		<?xml version="1.0" encoding="utf-8"?>
		<sharpPlugins>
			<add key="AF DNR" value="SDRSharp.DNR.AFNoiseReductionPlugin,SDRSharp.DNR"/>
			<add key="IF DNR" value="SDRSharp.DNR.IFNoiseReductionPlugin,SDRSharp.DNR"/>
			<add key="Baseband Noise Blanker" value="SDRSharp.NoiseBlanker.BasebandNoiseBlankerPlugin,SDRSharp.NoiseBlanker"/>
			<add key="Demodulator Noise Blanker" value="SDRSharp.NoiseBlanker.DemodulatorNoiseBlankerPlugin,SDRSharp.NoiseBlanker"/>
			<add key="Calico" value="SDRSharp.Calico.CalicoPlugin,SDRSharp.Calico" />
		</sharpPlugins>
		
	Save the file then Start or Restart the SDR# program
	