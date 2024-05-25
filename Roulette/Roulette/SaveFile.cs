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
    internal class SaveFile
    {
        private string directory;

        public string FileName { get; private set; }
        private SaveFile(string fileName, string directory) 
        {
            FileName = fileName;
            this.directory = directory;
        }

        public static SaveFile CreateSaveFile(Player player, string directory) 
        {
            XDocument doc = new XDocument(
                new XElement("Player",
                    new XElement("Name", player.Name),
                    new XElement("Balance", player.Balance)
                )      
            );
            string fileName = player.Name+".xml";
            doc.Save(directory + fileName);

            return new SaveFile(fileName, directory);
        }

        public static SaveFile? FindSaveFile(string fileName, string directory)
        {
            string path = directory + fileName;

            if (File.Exists(path))
            {

                return new SaveFile(fileName, directory);
            }
            else
            {
                return null;
            }
        }
    }
}
