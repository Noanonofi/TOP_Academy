using System;

namespace Classwork_8_november
{
    class StudyClassWork
    {
        interface IPropertyChanged
        {
            event PropertyEventHandler PropertyChanged;
        }

        public class PropertyEventArgs : EventArgs
        {
            public string PropertyName { get; set; }
        }

        public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

        public class PropertyChanged__ : IPropertyChanged
        {
            public event PropertyEventHandler PropertyChanged;

            private string temp;
            public string Temp
            {
                get { return temp; }
                set
                {
                    if (temp != value)
                    {
                        temp = value;
                        PropertyEventArgs propertyEventArgs = new PropertyEventArgs { PropertyName = nameof(value) };
                        PropertyChanged?.Invoke(this, propertyEventArgs);
                    }
                }
            }
        }
    }
}