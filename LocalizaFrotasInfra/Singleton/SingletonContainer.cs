using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizaFrotasInfra.Singleton
{
    public class SingletonContainer
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
