using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizaFrotasInfra.Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public Guid Id { get; } = Guid.NewGuid();

        private Singleton(){}

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        } 


    }
}
