using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemTemplatePropertySetting
{
    public class MyEntity
    {
        private readonly ICollection<MyEntity> _Children = new ObservableCollection<MyEntity>();

        public string Text { get; set; }

        public string Type { get; set; }

        public ICollection<MyEntity> Children
        {
            get
            {
                return _Children;
            }
        }

    }
}
