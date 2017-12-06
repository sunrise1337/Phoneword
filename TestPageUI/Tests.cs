using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TestPageUI
{
    [TestFixture(Platform.Android)]
   // [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp.Android.
                ApkFile(@"C:\Users\sunrise\Desktop\com.companyname.Phoneword-Signed.apk").
                StartApp();
        }

        [Test]
        public void FirstTest()
        {
           // app.WaitForElement(c => c.Marked("MyButton"));
            //app.Screenshot("asd");
            app.Tap(c => c.Text("Change page"));
        }
    }
}

