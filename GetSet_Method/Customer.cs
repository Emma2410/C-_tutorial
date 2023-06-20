using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet_Method
{

    public class Customer
    {
        int _Custid;
        bool _Status;
        string _Cname;
        double _Balance;

        public Customer(int _Custid, bool _Status, string _Cname, double _Balance)
        {
            this._Custid = _Custid;
            this._Status = _Status;
            this._Cname = _Cname;
            this._Balance = _Balance;
        }

        public int Custid
        {
            get { return _Custid; }
            // set { _Custid = value; }        Customer id should not be modify
        }
        public bool Status
        {

            get { return _Status; }


        }
        public string Cname
        {
            set { 
                    if (_Status == true)
                     {
                          _Cname = value;
                     }
                 }

            get { return _Cname; }
        }
                
                

            public double Balance
            { get { return _Balance; }
              set { _Balance = value; }
            }
        }
 }

