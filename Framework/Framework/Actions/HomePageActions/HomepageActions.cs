using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Actions.Common;
     

namespace Framework.Actions.HomePageActions
{
   public class HomepageActions:CommonActions
    {
        public void NavigateToURL(string URL)
        {
            GoToUrl(URL);
        }
    }
}
