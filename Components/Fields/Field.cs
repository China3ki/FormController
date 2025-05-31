using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormController.Components.Fields
{
    internal abstract class Field
    {

        protected Field(int a)
        {
            
        }
        public abstract void Write();
        public abstract string ReturnFieldValue();
        protected abstract StringBuilder ReturnTheStateOfField();
        protected abstract void SaveStateOfField();
    }
}
