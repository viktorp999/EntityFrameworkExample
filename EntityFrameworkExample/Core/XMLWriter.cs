using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace EntityFrameworkExample.Core
{
    public static class XMLWriter
    {
        public static void SaveFile(List<string> people, string path)
        {
            try
            {
                XmlSerializer xmlserializer = new XmlSerializer(typeof(List<string>));
                using (Stream filestram = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    xmlserializer.Serialize(filestram, people);
                }

            }

            catch(Exception)
            {
                MessageBox.Show("Error", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
