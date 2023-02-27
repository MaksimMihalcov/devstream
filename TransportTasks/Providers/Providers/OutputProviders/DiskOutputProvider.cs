using Providers.Abstractions;
using System.Collections;
using System.Text;

namespace Providers.Providers.OutputProviders
{
    public class DiskOutputProvider : IOutputProvider
    {
        public string Path { get; set; }
        public DiskOutputProvider()
        {
            Path = "output.txt";
        }

        public void Write<T>(T obj)
        {
            try
            {
                using (FileStream fstream = new FileStream(Path, FileMode.OpenOrCreate))
                {
                    string answ = "";
                    foreach(var item in (IEnumerable)obj)
                        answ += item.ToString() + "\n";
                    byte[] buffer = Encoding.Default.GetBytes(answ);
                    fstream.Write(buffer, 0, buffer.Length);
                }
            }
            catch
            {
                //здесь должен быть лог
            }
        }
    }
}