We could not find a data exchange file at the path Unhandled Exception: System.NotSupportedException: An attempt was made to load an assembly from a network location which would have caused the assembly to be sandboxed in previous versions of the .NET Framework. This release of the .NET Framework does not enable CAS policy by default, so this load may be dangerous. If this load is not intended to sandbox the assembly, please enable the loadFromRemoteSources switch. See http://go.microsoft.com/fwlink/?LinkId=155569 for more information.

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 

Unhandled Exception: System.NotSupportedException: An attempt was made to load an assembly from a network location which would have caused the assembly to be sandboxed in previous versions of the .NET Framework. This release of the .NET Framework does not enable CAS policy by default, so this load may be dangerous. If this load is not intended to sandbox the assembly, please enable the loadFromRemoteSources switch. See http://go.microsoft.com/fwlink/?LinkId=155569 for more information.
   at System.Reflection.RuntimeAssembly.nLoadFile(String path, Evidence evidence)
   at System.Reflection.Assembly.LoadFile(String path)
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.CommandLineHandling.PreLoadAssemblies()
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.CommandLineHandling.PreLoadAssemblies()
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Program.Main(String[] args)



Command: C:\Users\Ylenia\AppData\Local\Microsoft\VisualStudio\15.0_d05ddc2a\Extensions\ibigjfrp.2yr\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\Ylenia\AppData\Local\Temp\tmpB08.tmp --outputdirectory C:\ --projectsettingsfile C:\Users\Ylenia\AppData\Local\Temp\tmpA7A.tmp
Working Directory: C:\Users\Ylenia\Desktop\TestYleniaMenolascina\DLtest\packages\SpecFlow.2.4.1\tools