using Microsoft.AspNetCore.Mvc;
using SchoolControl.Core.Interfaces;

namespace SchoolControl.Mvc.Controllers
{
    public class Base: Controller
    {
        protected readonly ISchoolControlBl _schoolControlBl;

        public Base(ISchoolControlBl schoolControlBl)
        {
            _schoolControlBl = schoolControlBl;
        }
    }
}
