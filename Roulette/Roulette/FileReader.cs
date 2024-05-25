using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Roulette
{
    static class FileReader
    {
        private static string directory = "../../../saves/";


        public static Player LoadSaveFile(SaveFile saveFile)
        {
            XDocument doc = XDocument.Load(directory+saveFile.FileName);

            var playerElement = doc.Descendants("Player").FirstOrDefault();

            if (playerElement != null)
            {
                return new Player(
                    playerElement.Element("Name").Value,
                    double.Parse(playerElement.Element("Balance").Value)
                );
            }

            throw new Exception("No player found in the XML file.");
        }

        public static SaveFile CreateSaveFile(Player player)
        {
            SaveFile saveFile = SaveFile.CreateSaveFile(player, directory);
            return saveFile;
        }

        public static List<SaveFile> ReadSaveFiles()
        {

            string[] xmlFiles = Directory.GetFiles(directory, "*.xml");
            string[] xmlFileNames = xmlFiles.Select(Path.GetFileName).ToArray();

            List<SaveFile> saveFiles = new List<SaveFile>() ;

            foreach (string fileName in xmlFileNames)
            {
                SaveFile saveFile = SaveFile.FindSaveFile(fileName, directory);   
                saveFiles.Add(saveFile);
            }

            return saveFiles ;
        }


    }
}
