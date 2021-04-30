using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFc
{
    class Rating
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public float Rate { get; set; }
        public string UploadDate { get; set; }
        public string LastModified { get; set; }

    }
}
