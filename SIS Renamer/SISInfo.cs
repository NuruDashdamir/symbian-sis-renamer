namespace SIS_Renamer
{
    class SISInfo
    {
        public string appName;
        public string appVersion;
        public string supportedDevices;
        public string appUID;
        public string vendorName;
        public string installType;
        public string applicationType;
        public bool isSignedApp;

        public SISInfo(string sisFileLocation)
        {
            //RESET DATA ABOUT PACKAGE
            appName = "";
            appVersion = "";
            supportedDevices = "";
            appUID = "";
            vendorName = "";
            installType = "";
            applicationType = "";

            //applicationType related boolean flags
            bool isFlashApp = false, isPyS60_v2_0_0_App = false, isPythonApp = false, isQtApp = false, isTheme = false;


            var sisFile = System.IO.File.Open(sisFileLocation, System.IO.FileMode.Open);
            var sisBinaryReader = new System.IO.BinaryReader(sisFile);
            SISX.SISXFile sis = new SISX.SISXFile(sisBinaryReader);
            appName = sis.cnt._controller.info.names.fields[0].ToString();
            appVersion = "v" + sis.cnt._controller.info.version.ToString().Replace(",", ".");
            vendorName = sis.cnt._controller.info.vendorName.aString.ToString();
            appUID = "[" + sis.cnt._controller.info.uid.ToString() + "]";
            isSignedApp = sis.cnt._controller.signatures.Count > 0;

            //detect if package depends on QT (test if app is QT app)
            foreach (SISX.Fields.SISDependency tmp in sis.cnt._controller.prerequisites.dependencies.fields)
            {
                if (tmp.dependencyNames.fields[0].ToString().ToLower() == "qt")
                {
                    isQtApp = true;
                    break;
                }
            }

            //set installation type
            int installTypeID = sis.cnt._controller.info.installType;
            switch (installTypeID)
            {
                case 0: installType = "[SA]"; break;
                case 1: installType = "[SP]"; break;
                case 2: installType = "[PU]"; break;
                case 3: installType = "[PA]"; break;
                case 4: installType = "[PP]"; break;
            }

            //set supported devices
            foreach (SISX.Fields.SISDependency tmp in sis.cnt._controller.prerequisites.targhetDevices.fields)
            {
                string tempDeviceUID = tmp.uid.ToString();

                //Change UIDs in supported package list to device type
                if (tempDeviceUID == "0x101F7961") tempDeviceUID = "[S60v3]";
                else if (tempDeviceUID == "0x102032BE") tempDeviceUID = "[S60v3FP1]";
                else if (tempDeviceUID == "0x102752AE") tempDeviceUID = "[S60v3FP2]";
                else if (tempDeviceUID == "0x1028315F") tempDeviceUID = "[S60v5]";
                else if (tempDeviceUID == "0x20022E6D") tempDeviceUID = "[S^3]";
                else if (tempDeviceUID == "0x20032DE7") tempDeviceUID = "[S^4]";
                else if (tempDeviceUID == "0x2003A678") tempDeviceUID = "[Belle]";
                else if (tempDeviceUID == "0x101F6300") tempDeviceUID = "[UIQ 3]";
                else if (tempDeviceUID == "0x101F63DF") tempDeviceUID = "[UIQ 3.1]";
                else tempDeviceUID = ""; //remove unnamed UIDs

                supportedDevices += tempDeviceUID;
            }
            if (supportedDevices == "") supportedDevices = "[NoDevice]";

            //APPLICATION TYPE SECTION
            //get file names and determine {appType}
            foreach (SISX.Fields.SISFileDescription tmp in sis.cnt._controller.installBlock.files.fields)
            {
                string currentFileLocation = tmp.target.aString.ToString().ToLower();

                if (!isTheme && currentFileLocation.EndsWith(".skn") && currentFileLocation.Contains("private\\10207114\\")) isTheme = true;
                else if (!isQtApp && currentFileLocation.EndsWith(".qml")) isQtApp = true;
                else if (!isFlashApp && currentFileLocation.EndsWith(".swf")) isFlashApp = true;
                else if (!isPyS60_v2_0_0_App && currentFileLocation.EndsWith(".py"))
                {
                    isPythonApp = true;
                    if (currentFileLocation.EndsWith("launcher.py")) isPyS60_v2_0_0_App = true;
                }
            }

            //add extradata tags
            if (isTheme) applicationType += "{THEME}";
            if (isFlashApp) applicationType += "{FLASH}";
            if (isQtApp) applicationType += "{QT}";

            if (isPythonApp)
            {
                if (isPyS60_v2_0_0_App) applicationType += "{PyS60 v2.0.0}";
                else applicationType += "{PyS60 v1.4.5}";
            }

            //APPLICATION TYPE section end

            sisBinaryReader.Close();
            sisFile.Dispose();
            sisFile.Close();
        }

        public void getData()
        {
            System.Windows.Forms.MessageBox.Show("App Name: " + appName + "\nApp Version: " + appVersion + "\nSupported Devices: " + supportedDevices + "\nUID: " + appUID + "\nVendor: " + vendorName + "\nType: " + installType + "\nExtra: " + applicationType);
        }
    }
}
