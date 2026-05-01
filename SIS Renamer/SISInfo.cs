using System.Collections;
using System.Collections.Generic;
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

        public string filesInPackage;

        public SISInfo(string sisFileLocation, bool fileListIsNeeded = false)
        {
            var sisFile = System.IO.File.Open(sisFileLocation, System.IO.FileMode.Open);
            var sisBinaryReader = new System.IO.BinaryReader(sisFile);
            SISX.SISXFile sis = new SISX.SISXFile(sisBinaryReader);

            appName = getAppName(sis);
            appVersion = getAppVersion(sis);
            supportedDevices = getAppSupportedDevices(sis);
            appUID = getAppUID(sis);
            vendorName = getAppVendorName(sis);
            installType = getAppInstallationType(sis);
            applicationType = getAppType(sis);
            isSignedApp = isAppSigned(sis);
                        
            if (fileListIsNeeded) prepareFileListInPackage(sis);

            sisBinaryReader.Close();
            sisFile.Dispose();
            sisFile.Close();
        }


        private string getAppName(SISX.SISXFile sis)
        {
            return sis.cnt._controller.info.names.fields[0].ToString();
        }


        private string getAppVersion(SISX.SISXFile sis)
        {
            return "v" + sis.cnt._controller.info.version.ToString().Replace(",", ".");
        }


        private string getAppVendorName(SISX.SISXFile sis)
        {
            return sis.cnt._controller.info.vendorName.aString.ToString();
        }


        private string getAppUID(SISX.SISXFile sis)
        {
            return "[" + sis.cnt._controller.info.uid.ToString() + "]";
        }


        private string getAppInstallationType(SISX.SISXFile sis)
        {
            switch (sis.cnt._controller.info.installType) // integer installTypeID
            {
                case 0: return "[SA]";
                case 1: return "[SP]";
                case 2: return "[PU]";
                case 3: return "[PA]";
                case 4: return "[PP]";
                default: return "[UNKNOWN]";
            }
        }


        private string getAppSupportedDevices(SISX.SISXFile sis)
        {
            bool haveOtherUIDs = false;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (SISX.Fields.SISDependency sisdep in sis.cnt._controller.prerequisites.targhetDevices.fields)
            {
                switch (sisdep.uid.ToString())
                {
                    case "0x101F7961": sb.Append("[S60v3]"); break;
                    case "0x102032BE": sb.Append("[S60v3FP1]"); break;
                    case "0x102752AE": sb.Append("[S60v3FP2]"); break;
                    case "0x1028315F": sb.Append("[S60v5]"); break;
                    case "0x20022E6D": sb.Append("[S^3]"); break;
                    case "0x20032DE7": sb.Append("[S^4]"); break;
                    case "0x2003A678": sb.Append("[Belle]"); break;
                    case "0x101F6300": sb.Append("[UIQ 3]"); break;
                    case "0x101F63DF": sb.Append("[UIQ 3.1]"); break;
                    default: haveOtherUIDs = true; break; // ignore unknown UID
                }
            }

            string result = sb.ToString();

            if (string.IsNullOrEmpty(result))
            {
                return haveOtherUIDs ? "[OtherDevice]" : "[NoDevice]";
            } 

            return result;
        }


        private string getAppType(SISX.SISXFile sis)
        {
            // related boolean flags
            bool isFlashApp = false, isPyS60_v200_App = false, isPythonApp = false, isQtApp = false, isTheme = false, isSmartInstaller = false;

            // detect if package depends on QT
            foreach (SISX.Fields.SISDependency sisdep in sis.cnt._controller.prerequisites.dependencies.fields)
            {
                if (sisdep.dependencyNames.fields[0].ToString().ToLower() == "qt")
                {
                    isQtApp = true;
                    break;
                }
            }

            foreach (SISX.Fields.SISFileDescription sisfiledes in sis.cnt._controller.installBlock.files.fields)
            {
                string path = sisfiledes.target.aString.ToString().ToLower(); // lowercase

                if (!isTheme && path.EndsWith(".skn") && path.Contains("private\\10207114\\")) isTheme = true;
                else if (!isQtApp && path.EndsWith(".qml")) isQtApp = true;
                else if (!isFlashApp && path.EndsWith(".swf")) isFlashApp = true;
                else if (!isSmartInstaller && path.Contains(".sis") && path.Contains("private\\2002ccce\\")) isSmartInstaller = true; // .sisx too, detects 99.6% cases
                else if (!isPyS60_v200_App && path.EndsWith(".py"))
                {
                    isPythonApp = true;
                    if (path.EndsWith("launcher.py")) isPyS60_v200_App = true;
                }
            }

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (isTheme) sb.Append("{THEME}");
            if (isFlashApp) sb.Append("{FLASH}");
            if (isQtApp) sb.Append("{QT}");
            if (isSmartInstaller) sb.Append("{QT-SI}");
            if (isPythonApp) sb.Append(isPyS60_v200_App ? "{PyS60 v2.0.0}" : "{PyS60 v1.4.5}");

            return sb.ToString();
        }


        private bool isAppSigned(SISX.SISXFile sis)
        {
            return sis.cnt._controller.signatures.Count > 0;
        }


        private void prepareFileListInPackage(SISX.SISXFile sis, bool ignoreEmptyTargets = false)
        {
            var fieldsToHandle = new List<ArrayList>();
            fieldsToHandle.Add(sis.cnt._controller.installBlock.files.fields);

            var ifBlocksList = new List<SISX.Fields.SISIf>();
            foreach (SISX.Fields.SISIf sisIf in sis.cnt._controller.installBlock.ifBlocks.fields) ifBlocksList.Add(sisIf);

            while (ifBlocksList.Count > 0)
            {
                SISX.Fields.SISIf currentIfBlock = ifBlocksList[0];

                fieldsToHandle.Add(currentIfBlock.installBlock.files.fields);
                foreach (SISX.Fields.SISElseIf sisElseIf in currentIfBlock.elseIfs.fields)
                {
                    fieldsToHandle.Add(sisElseIf.installBlock.files.fields);
                }

                foreach (SISX.Fields.SISIf sisIf in currentIfBlock.installBlock.ifBlocks.fields)
                {
                    ifBlocksList.Add(sisIf);
                }
                ifBlocksList.RemoveAt(0);
            }

            var fileInfoList = new List<string>();
            foreach (ArrayList sisFileDescriptionArray in fieldsToHandle)
            {
                foreach (SISX.Fields.SISFileDescription sisFileDesc in sisFileDescriptionArray)
                {
                    string currentFileTarget = sisFileDesc.target.aString;
                    string hash = System.BitConverter.ToString(sisFileDesc.hash.hashData.data).Replace("-", "");
                    if (currentFileTarget == "" && ignoreEmptyTargets) continue;
                    fileInfoList.Add(hash + " - " + currentFileTarget);
                }
            }

            filesInPackage = string.Join("\n", fileInfoList.ToArray());
        }


        public void getData()
        {
            System.Windows.Forms.MessageBox.Show("App Name: " + appName + "\nApp Version: " + appVersion + "\nSupported Devices: " + supportedDevices + "\nUID: " + appUID + "\nVendor: " + vendorName + "\nType: " + installType + "\nExtra: " + applicationType);
            System.Windows.Forms.MessageBox.Show(filesInPackage);
        }

    }
}
