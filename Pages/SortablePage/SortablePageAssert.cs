using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveDemoSeleniumAdvanced.Pages
{
    public partial class SortablePage
    {
        public void AssertTextByIndex(string expctedText, int index)
        {
            Assert.AreEqual(expctedText, listofOptions[index + 1].Text);
        }
    }
}
