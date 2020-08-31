using System;
using System.Runtime.InteropServices;

namespace Raiden
{
    class RevealHack
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = true)]
        delegate int GetPlayerByIdDelegate(int a1, char a2);

        [DllImport("GameAssembly.dll")]
        static extern int GetPlayerById(int a1, char a2);

        static private int GetPlayerByIdHook(int a1, char a2)
        {
            int result = GetPlayerById(a1, a2);
            Program.client_form.Print(String.Format("Intercepted player info address: {0:X}", result));
            return result;
        }

        static public void Hook()
        {
            
        }
    }
}
