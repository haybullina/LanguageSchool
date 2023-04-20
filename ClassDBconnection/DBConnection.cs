using LearnLanguageSchool.AdoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLanguageSchool
{
    public class DBConnection
    {
        public static LangSchoolEntities Connection = new LangSchoolEntities();
    }
}
