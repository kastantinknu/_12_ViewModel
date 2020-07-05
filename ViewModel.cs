using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm;
using Model;
using Models;

namespace ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        private HexagonModel HEXAGON_MODEL = new HexagonModel();
        private TriangleModel TRIANGLE_MODEL = new TriangleModel();

        public string Points_of_polygon => HEXAGON_MODEL.Points_of_polygon;
        public string Points_of_star => HEXAGON_MODEL.Points_of_star;

        public string Points_of_triangle => TRIANGLE_MODEL.Points_of_triangle;






        private DelegateCommand<object> сommandRIGHT_p;
        public DelegateCommand<object> CommandRIGHT_p
        {
            get
            {
                return сommandRIGHT_p ??
                       (сommandRIGHT_p = new DelegateCommand<object>((obj) =>
                           {        
                               if(Convert.ToBoolean(obj))
                               HEXAGON_MODEL.MovingRIGHT(300);
                           }
                       ));
            }
        }


        private DelegateCommand<object> сommandRIGHT_t;
        public DelegateCommand<object> CommandRIGHT_t
        {
            get
            {
                return сommandRIGHT_t ??
                       (сommandRIGHT_t = new DelegateCommand<object>((obj) =>
                           {
                               if(Convert.ToBoolean(obj))
                               TRIANGLE_MODEL.MovingRIGHT(300);
                           }
                       ));
            }
        }

        private DelegateCommand<object> сommandLEFT_p;
        public DelegateCommand<object> CommandLEFT_p
        {
            get
            {
                return сommandLEFT_p ??
                       (сommandLEFT_p = new DelegateCommand<object>((obj) =>
                           {
                               if (Convert.ToBoolean(obj))
                                   HEXAGON_MODEL.MovingLEFT();
                           }
                       ));
            }
        }
        private DelegateCommand<object> сommandLEFT_t;
        public DelegateCommand<object> CommandLEFT_t
        {
            get
            {
                return сommandLEFT_t ??
                       (сommandLEFT_t = new DelegateCommand<object>((obj) =>
                           {
                               if (Convert.ToBoolean(obj))
                               TRIANGLE_MODEL.MovingLEFT();
                           }
                       ));
            }
        }


        private DelegateCommand<object> сommandDOWN_p;
        public DelegateCommand<object> CommandDOWN_p
        {
            get
            {
                return сommandDOWN_p ??
                       (сommandDOWN_p = new DelegateCommand<object>((obj) =>
                           {
                               if (Convert.ToBoolean(obj))
                               HEXAGON_MODEL.MovingDOWN(300);
                           }
                       ));
            }
        }
        private DelegateCommand<object> сommandDOWN_t;
        public DelegateCommand<object> CommandDOWN_t
        {
            get
            {
                return сommandDOWN_t ??
                       (сommandDOWN_t = new DelegateCommand<object>((obj) =>
                           {
                               if (Convert.ToBoolean(obj))
                               TRIANGLE_MODEL.MovingDOWN(300);
                           }
                       ));
            }
        }


        private DelegateCommand<object> сommandUP_p;
        public DelegateCommand<object> CommandUP_p
        {
            get
            {
                return сommandUP_p ??
                       (сommandUP_p = new DelegateCommand<object>((obj) =>
                           {
                               if (Convert.ToBoolean(obj))
                               HEXAGON_MODEL.MovingUP();
                           }
                       ));
            }
        }
        private DelegateCommand<object> сommandUP_t;
        public DelegateCommand<object> CommandUP_t
        {
            get
            {
                return сommandUP_t ??
                       (сommandUP_t = new DelegateCommand<object>((obj) =>
                           {
                               if (Convert.ToBoolean(obj))
                               TRIANGLE_MODEL.MovingUP();
                           }
                       ));
            }
        }


        private DelegateCommand<object> сommandUPRIGHT_p;
        public DelegateCommand<object> CommandUPRIGHT_p
        {
            get
            {
                return сommandUPRIGHT_p ??
                       (сommandUPRIGHT_p = new DelegateCommand<object>((obj) =>
                           {
                               if (Convert.ToBoolean(obj))
                               HEXAGON_MODEL.MovingUPRIGHT();
                           }
                       ));
            }
        }
        private DelegateCommand сommandUPRIGHT_t;
        public DelegateCommand CommandUPRIGHT_t
        {
            get
            {
                return сommandUPRIGHT_t ??
                       (сommandUPRIGHT_t = new DelegateCommand(() =>
                           {
                               TRIANGLE_MODEL.MovingUPRIGHT();
                           }
                       ));
            }
        }


        private DelegateCommand сommandDOWNRIGHT_p;
        public DelegateCommand CommandDOWNRIGHT_p
        {
            get
            {
                return сommandDOWNRIGHT_p ??
                       (сommandDOWNRIGHT_p = new DelegateCommand(() =>
                           {
                               HEXAGON_MODEL.MovingDOWNRIGHT();
                           }
                       ));
            }
        }
        private DelegateCommand сommandDOWNRIGHT_t;
        public DelegateCommand CommandDOWNRIGHT_t
        {
            get
            {
                return сommandDOWNRIGHT_t ??
                       (сommandDOWNRIGHT_t = new DelegateCommand(() =>
                           {
                               TRIANGLE_MODEL.MovingDOWNRIGHT();
                           }
                       ));
            }
        }


        private DelegateCommand сommandDOWNLEFT_p;
        public DelegateCommand CommandDOWNLEFT_p
        {
            get
            {
                return сommandDOWNLEFT_p ??
                       (сommandDOWNLEFT_p = new DelegateCommand(() =>
                           {
                               HEXAGON_MODEL.MovingDOWNLEFT();
                           }
                       ));
            }
        }
        private DelegateCommand сommandDOWNLEFT_t;
        public DelegateCommand CommandDOWNLEFT_t
        {
            get
            {
                return сommandDOWNLEFT_t ??
                       (сommandDOWNLEFT_t = new DelegateCommand(() =>
                           {
                               TRIANGLE_MODEL.MovingDOWNLEFT();
                           }
                       ));
            }
        }


        private DelegateCommand сommandUPLEFT_p;
        public DelegateCommand CommandUPLEFT_p
        {
            get
            {
                return сommandUPLEFT_p ??
                       (сommandUPLEFT_p = new DelegateCommand(() =>
                           {
                               HEXAGON_MODEL.MovingUPLEFT();
                           }
                       ));
            }
        }
        private DelegateCommand сommandUPLEFT_t;
        public DelegateCommand CommandUPLEFT_t
        {
            get
            {
                return сommandUPLEFT_t ??
                       (сommandUPLEFT_t = new DelegateCommand(() =>
                           {
                               TRIANGLE_MODEL.MovingUPLEFT();
                           }
                       ));
            }
        }

        public ViewModel()
        {
            HEXAGON_MODEL.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
            TRIANGLE_MODEL.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool SetAndRaisePropertyChanged<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
                return false;
            storage = value;
            this.RaisePropertyChanged(propertyName);
            return true;
        }
    }
}
