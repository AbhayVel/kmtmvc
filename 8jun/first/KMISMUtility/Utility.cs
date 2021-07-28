using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMUtility
{
    public class Utility
    {

      public  static dynamic GetDefaultValue(Type t)
        {
            if (t.IsValueType)
                return Activator.CreateInstance(t);

            return null;
        }

      public  static dynamic ConverData(string str, string type)
        {
            Type ty = Type.GetType(type);
            try
            {
               Type t = Nullable.GetUnderlyingType(ty) ?? ty;

                return Convert.ChangeType(str, ty);
            }

            catch (Exception ex)
            {

                return GetDefaultValue(ty);
            }
        }
    }
}
