IronAutoItX
===========

Simply calling AutoItX without COM registrations 



You have to create right manifest. I have created C# lib which was useful for me to instantiate Reg Free COM objects (available via NuGet install NRegFreeCom):

    [Test]
    public void TestCreateNativeCOM()
    {
        var nativeImplementation = new Guid("538ECD5D-8A57-4F1C-AEB1-EBC425641F0B");
        var obj = NRegFreeCom.ActivationContext.CreateInstanceWithManifest(nativeImplementation,
                                                                           "Win32/RegFreeComNativeImplementer.dll.manifest");
        var obj2 = obj as ILoadedByManagedImplementedByNative;
        var str = obj2.Get();
        Console.WriteLine(str);
    }
Next source contains samples of Reg Free COM objects and their creation: https://github.com/asd-and-Rizzo/NRegFreeCom

There is article about reg free ActiveX in C# from which I started: http://www.atalasoft.com/blogs/spikemclarty/february-2012/dynamically-testing-an-activex-control-from-c-and

Sxstrace is utility can help to diagnose reg free COM problems.