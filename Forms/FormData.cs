using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Dtwo.API.View.Components.Forms.FormData;

namespace Dtwo.API.View.Components.Forms
{
    public class FormData
    {
        public class Field
        {
            public string FieldAsmName;
            public string Title;
            public Func<object?, bool> Validation;
        }

        private List<Field> m_fields { get; set; } = new List<Field>();
        public IReadOnlyList<Field> Fields => m_fields;

        public readonly string Title;

        public FormData(string title, List<Field> fields)
        {
            m_fields = fields;
            Title = title;
        }
    }

    public class FieldWithProperty
    {
        public FormData.Field Field;
        public readonly PropertyInfo PropertyInfo;
    }
}
