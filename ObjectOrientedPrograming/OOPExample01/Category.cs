using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample01
{
    internal class Category
    {
        public Category()
        {
            CreatedDate = DateTime.Now;
        }

        private string _name; // kategori adı 
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //if (value == null)
                //{
                //    value = string.Empty;
                //}
                //veya şöyle yazılabilir
                _name = value ?? string.Empty; // anlamı : ?? operatörünün sol tarafıdaki değer null ise operatörün sağ tarafındaki
                                               // değeri eşitliğin sol tarafına gönderir 
                                               // null değilse operatörün solundaki orjinaldeğer eşittir operatörün solundaki değer 
            }

        }
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                //terany
                //_name = value == null ? string.Empty:value;
                //_name = value ?? string.Empty
            }
        }

        private DateTime _createdDate;

        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {

                {
                    _createdDate = value > DateTime.Now  //set edilen değer büyükse 
                        ? DateTime.Now                   //şuanki zamanı kabul et
                        : value;                         //set edilen value kabul edilsin yani şuankizamandan küçük olduğu için şartı sağlıyor 
                }
            }
        }
    }
}
