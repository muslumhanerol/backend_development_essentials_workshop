//Veri tabanıa alanı

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_one.Models
{
    public class Bootcamp
    {
        public int id { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }

    }
}

// View taşınabilmesi için Modeldeki bilgileri Controller üzerinde tanımlamak lazım. Controller > BootcampController içerisinde nesne oluştur.

// ? = boş değer alabilir demek.