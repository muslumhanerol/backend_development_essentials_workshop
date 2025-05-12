namespace project_second_formsApp.Models
{

    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category { CategorytId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategorytId = 2, Name = "Bilgisayar" });


            _products.Add(new Product { ProductId = 1, Name = "Macbook", Image = "1.jpg", Price = 80000, IsActive = true, CatagoryId = 2 });

            _products.Add(new Product { ProductId = 2, Name = "Macbook Pro", Image = "3.jpg", Price = 90000, IsActive = true, CatagoryId = 2 });

            _products.Add(new Product { ProductId = 3, Name = "IPhone 15 Pro", Image = "2.jpg", Price = 100000, IsActive = true, CatagoryId = 1 });

            _products.Add(new Product { ProductId = 4, Name = "IPhone 15 Pro Max", Image = "4.jpg", Price = 120000, IsActive = true, CatagoryId = 1 });
        }


        //Dış tarafa vermek için.
        public static List<Product> Products { get { return _products; } }
        public static List<Category> Catageries { get { return _categories; } }
        //Bu içeriği kullanmak için Controller>HomeController.cs 

    }

}





// private = tanımlandığı class içerisinde dışarıdan doğrudan erişilemez.
// static = Bu değişken bu class a aittir ama nesneye ait değilfir.
// readonly = sadece tanımlandığı anda atanabilir, sonrasından hiçbir şekilde referans alınamaz ve değiştirilemez.