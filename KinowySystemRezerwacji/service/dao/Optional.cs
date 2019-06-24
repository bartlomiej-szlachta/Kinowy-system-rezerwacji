using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinowySystemRezerwacji.service.dao
{
    internal class Optional<T>
    {
        internal T ResultObject { get; private set; }
        internal bool Success { get; private set; }

        internal Optional(T resultObject)
        {
            ResultObject = resultObject;
            Success = !(resultObject == null);
        }

        internal T OrElseThrow(string message)
        {
            if (!Success)
            {
                throw new Exception(message);
            }
            else
            {
                return ResultObject;
            }
        }
    }
}
