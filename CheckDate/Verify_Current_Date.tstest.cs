using Telerik.WebAii.Controls.Xaml.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using ArtOfTest.WebAii.Wpf;


namespace DemoCalculatorTest
{
    public class Verify_Current_Date : BaseWebAiiTest
    {
        #region [ Dynamic Applications Reference ]

        private Applications _applications;

        /// <summary>
        /// Gets the Applications object that has references
        /// to all the elements, windows or regions
        /// in this project.
        /// </summary>
        public Applications Applications
        {
            get
            {
                if (_applications == null)
                {
                    _applications = new Applications(Manager.Current);
                }
                return _applications;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        public Verify_Current_Date() 
        {
            
        }
        
        [CodedStep(@"New Coded Step")]
        public void Verify_Current_Date_CodedStep()
        {
            Utilities u = new  Utilities();
            Assert.IsTrue(Applications.WPFAUTexe.WPF_Calculator.DateTextTextblock.Text == u.GetCurrentDate());
            Assert.IsTrue(Convert.ToString(GetExtractedValue("DateTextVariable")) == u.GetCurrentDate());
            // Hoist the variable
            u.extractedDate = Convert.ToString(GetExtractedValue("DateTextVariable"));
        }
    
       
    }
}
