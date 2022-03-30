using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_SideThread
{
    internal static class Files
    {
        public static string FileName { get; set; } = "";
        public static string Text { get; set; } = "";
        
        public static void ReadFile(string fileName)
        {
            FileName = fileName;
            string text;
            using (StreamReader reader = new StreamReader(FileName))
            {
                 text = reader.ReadToEnd();
            }
            Text = text;
        }
        public static void WriteFile(string text, string fileName)
        {
            FileName = fileName;
            WriteFile(text);
        }
        public static async void WriteFile(string text)
        {
            Text = text;
            using (StreamWriter writer = new StreamWriter(FileName, false))
            {
                await writer.WriteAsync(Text);
            }

        }
    }
}
