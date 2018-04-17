using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmTechServer.Models.Office
{
    public class SessionIdGenerator
    {
        private StringBuilder _builder;
        private Random _random;
        public static SessionIdGenerator Generator { get; } = new SessionIdGenerator();

        private SessionIdGenerator()
        {
            _builder = new StringBuilder();
            _random = new Random();
        }

        public string GetNewId()
        {
            _builder.Clear();
            char ch;
            for (int i = 0; i < 16; i++)
            {
                Int32 num = Convert.ToInt32(_random.Next(50, 90));
                ch = Convert.ToChar(num);

                _builder.Append(ch);
            }

            return _builder.ToString();
        }
    }
}
