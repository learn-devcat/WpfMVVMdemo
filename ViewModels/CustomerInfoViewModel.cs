namespace WpfMVVMdemo.ViewModels
    {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;


    internal class CustomerInfoViewModel : INotifyPropertyChanged
        {

        private string info;

        /// <summary>
        /// Gets or sets Customer Information.
        /// </summary>
        public String Info
            {
            get
                {
                return info;
                }
            set
                {
                info = value;
                OnPropertyChanged("Info");
                }
            }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged( string propertyName )
            {
            PropertyChangedEventHandler handler = PropertyChanged;

            if ( handler != null )
                {
                handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        #endregion
        }
    }
