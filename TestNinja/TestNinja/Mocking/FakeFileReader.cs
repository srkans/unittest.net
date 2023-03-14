using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return ""; //fake implementation
        }
    }
}
