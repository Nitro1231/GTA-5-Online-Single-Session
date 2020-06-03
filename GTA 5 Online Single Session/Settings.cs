using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace GTA_5_Online_Single_Session {
    class Settings {
        static public string ver = "0.0.1";
        static public string mainPath = @"C:\NitroStudio\";
        static public string projectName = "GTA5_OSS";

        static public int time = 7;
        static public int speed = 1;
        static public bool floatingMode = false;

        static public void startUp() {
            checkPath(mainPath);
            checkPath(mainPath + projectName);
            if (!File.Exists(mainPath + projectName + @"\setting.json"))
                saveSetting();
            readSetting();
        }

        static public void checkPath(string path) {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        static public bool readSetting() {
            try {
                if (!Directory.Exists(mainPath + projectName + @"\setting.json")) {
                    using (StreamReader sr = new StreamReader(mainPath + projectName + @"\setting.json")) {
                        string line = sr.ReadToEnd();
                        var json = JObject.Parse(line);
                        time = (int)json["time"];
                        floatingMode = (bool)json["floatingMode"];
                    }
                    return true;
                } else {
                    MessageBox.Show("The setting file is missing, the program will continue with default options.");
                }
            } catch (IOException e) {
                MessageBox.Show(e.ToString());
            }
            return false;
        }

        static public bool saveSetting() {
            try {
                JObject newJson = new JObject(
                    new JProperty("time", time),
                    new JProperty("floatingMode", floatingMode));
                File.WriteAllText(mainPath + projectName + @"\setting.json", newJson.ToString());
                return true;
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            return false;
        }

        static public bool checkUpdate() {
            var URL = "https://nitro1231.github.io/NitroStudio/Data/ver.json";
            try {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(URL);
                StreamReader reader = new StreamReader(stream);
                string info = reader.ReadToEnd();
                var json = JObject.Parse(info);
                string lastestVer = json["GTA-5-Session"]["ver"].ToString();
                if (!ver.Equals(lastestVer)) {
                    MessageBox.Show("A new version of the software is available!");
                    return true;
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            return false;
        }
    }
}
