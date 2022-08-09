using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCrud.src
{
    public interface IMethodsService
    {
        public void Create();
        public void Read(List<string> list);
        public void Update(ref List<string> list);
        public void Delete(ref List<string> list);
        public bool ValidationName(string name);
    }
}
