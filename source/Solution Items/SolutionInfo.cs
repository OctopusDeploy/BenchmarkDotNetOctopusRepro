using System.Reflection;
using System.Runtime.InteropServices;

[assembly:
    AssemblyDescription("Very Cool Thing")]
[assembly: AssemblyCompany("Cool Things Pty. Ltd.")]
[assembly: AssemblyProduct("Very Cool Thing")]
[assembly: AssemblyCopyright("Copyright © Very Cool Things Pty. Ltd. 1995-2020")]
[assembly: AssemblyCulture("")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: ComVisible(false)]