using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Konst_Transf
{
    class Pages
    {
        private static MainPage _mainPage = new MainPage();
        private static StartPlayerPage _startPlayerPage = new StartPlayerPage();
        private static StartManagerPage _startManagerPage = new StartManagerPage();
        private static RegPlayerPage _regPlayerPage = new RegPlayerPage();
        private static PlayerChangePage _playerChangePage = new PlayerChangePage();
        private static SearchManagerPage _searchManagerPage = new SearchManagerPage();
     


        public static MainPage MainPage
        {
            get
            {
                return _mainPage;
            }
        }

        public static StartPlayerPage StartPlayerPage
        {
            get
            {
                return _startPlayerPage;
            }
        }

        public static StartManagerPage StartManagerPage
        {
            get
            {
                return _startManagerPage;
            }
        }

        public static RegPlayerPage RegPLayerPage
        {
            get
            {
                return _regPlayerPage;
            }
        }


        public static PlayerChangePage PlayerChangePage
        {
            get
            {
                return _playerChangePage;
            }
        }

        public static SearchManagerPage SearchManagerPage
        {
            get
            {
                return _searchManagerPage;
            }
        }

      
    }
}
