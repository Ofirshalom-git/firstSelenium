using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common
{
    public class BasePage : DriverUser
    {
        public HeaderContainer Header;
        public ColumnsContainer Columns;
        public FooterContainer Footer;

    }
}
