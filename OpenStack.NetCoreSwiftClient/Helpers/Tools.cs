using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OpenStack.NetCoreSwiftClient.Helpers
{
    public class Tools
    {

        [MethodImpl(MethodImplOptions.NoInlining)]
        public string GetMethodName(string className)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);

            return className + "." + sf.GetMethod().Name;
        }
        
    }
}