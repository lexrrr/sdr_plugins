OmniRig Sync panadapter plugin for SDR# by N0TTL

	This plugin can synchronize SDR# Frequency and/or Mode with another Transceiver via OmniRig.

	This enables panadapter functionality familiar to the amateur radio community.

	Multiple programs can communicate with OmniRig at the same time, allowing each program to Get and Set the Frequency and/or Mode.

Prerequisite:

	OmniRig must be installed for this plugin to function. 
	
	Download OmniRig here; http://www.dxatlas.com/OmniRig/ then configure for your tranciever.
	
Install:

	Copy SDRSharp.OmniRigSync.dll to your "SDRSharp" installation folder.
	
	Open MagicLine.txt in your favorite text editor and copy the line and paste into your SDRSharp\Plugins.xml file inside the <sharpPlugins> element. 

	Example:

		<?xml version="1.0" encoding="utf-8"?>
		<sharpPlugins>
			<add key="AF DNR" value="SDRSharp.DNR.AFNoiseReductionPlugin,SDRSharp.DNR"/>
			<add key="IF DNR" value="SDRSharp.DNR.IFNoiseReductionPlugin,SDRSharp.DNR"/>
			<add key="Baseband Noise Blanker" value="SDRSharp.NoiseBlanker.BasebandNoiseBlankerPlugin,SDRSharp.NoiseBlanker"/>
			<add key="Demodulator Noise Blanker" value="SDRSharp.NoiseBlanker.DemodulatorNoiseBlankerPlugin,SDRSharp.NoiseBlanker"/>
			<add key="OmniRig Sync" value="SDRSharp.OmniRigSync.OmniRigSyncPlugin,SDRSharp.OmniRigSync" />
		</sharpPlugins>
		
	Save the file then Start or Restart the SDR# program
	