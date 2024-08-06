using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;


// BaseRepositorydeki methodlari deyisirik entitystate yerine birdefelik context-in metholarini istifade edirik
// Sebeb product icinde brand ve ya product color elaqesi yaratmaq istedikde islemir
// ManyToMany ucun yaradilmis ucun yaradilmis entityler ucunde Dal ve Service lazimdirmi?
// Product icinden add eleye bilirik lakin silmek ucun productColor entitysini cagirib remove isletmeliyik. ??Ferqli yolu varmi bilmirem??

var productColor = new List<ProductColor>()
{
    new ProductColor()
    {
         Color= new Color()
         {
             Name="Red",
         },
         Product= new Product()
         {
             Name="Iphone",
             Description="latest version",
             Brand=new Brand()
             {
                 Name="Apple"
             },
             ProductSubCategories=new List<ProductSubCategory>()
             {
                 new ProductSubCategory()
                 {
                     SubCategory= new SubCategory()
                     {
                         Name="Telefonlar",
                         Category= new Category()
                         {
                             Name="Texnoloji avadandliqlar"
                         }
                     }
                 },
                 new ProductSubCategory()
                 {
                     SubCategory= new SubCategory()
                     {
                         Name="Agilli qurgular",
                         Category= new Category()
                         {
                             Name="Smart esyalar"
                         }
                     }
                 },
             }
         }
    },
    new ProductColor()
    {
         Color= new Color()
         {
             Name="Green",
         },
         Product= new Product()
         {
             Name="Tozsoran s24",
             Description="yeni dovrun tozsorani",
             Brand=new Brand()
             {
                 Name="becho"
             },
             ProductSubCategories=new List<ProductSubCategory>()
             {
                 new ProductSubCategory()
                 {
                     SubCategory= new SubCategory()
                     {
                         Name="Tozsoran",
                         Category= new Category()
                         {
                             Name="Meiset avadanligi"
                         }
                     }
                 }
             }
         }
    }
};

ProductManager productManager = new ProductManager(new EfProductDal());

Product product = new Product()
{
    Name = "Smasung galaxy",
    Description="adasdasd",
    Brand= new Brand()
    {
        Name="Honor"
    }
};
productManager.Add(product);
//var product = productManager.GetById(1);
//product.Brand = new Brand()
//{
//    Name = "samsung"
//};
//productManager.Update(product);
Console.WriteLine(product.Name);

//ECommerceContext context = new ECommerceContext();

//var brand = context.Brands.SingleOrDefault(b => b.Id == 2);
//var product = context.Products.SingleOrDefault(p => p.Id == 1);

//Console.WriteLine(brand.Name);
//Console.WriteLine(product.Name);
//if (product == null || brand==null)
//{
//    Console.WriteLine("brand ve/ya product tapilmadi");
//}
//else
//{
//    product.Brand = new Brand()
//    {
//        Name = "Xiaomi"
//    };
//    context.SaveChanges();
//}



//var product = context.Products.SingleOrDefault(p => p.Id == 1);
//Console.WriteLine(product.Name);

//var color = context.Colors.SingleOrDefault(c => c.Id == 2);
//Console.WriteLine(color.Name);

//product.ProductColors = new List<ProductColor>()
//{
//    new ProductColor()
//    {
//        Color=color
//    }
//};

//Console.Write("enter product id: ");
//int productId=int.Parse(Console.ReadLine());

//var product=context.Products.SingleOrDefault(p=>p.Id==productId);
//if (product == null)
//{
//    Console.WriteLine("Product tapilmadi");
//}
//else
//{
//    Console.WriteLine(product.Name);
//    Console.WriteLine("####Rengler####");
//    var colorIds=context.ProductColors.Where(pc => pc.ProductId == productId).Select(c=>c.Color).ToList();
//    foreach (var item in colorIds)
//    {
//        Console.WriteLine("Id: "+item.Id+"\n Rengin adi: "+item.Name);
//    }

//    Console.Write("Silmek istediyin rengin id-sini elave ele: ");
//    int colorId=int.Parse(Console.ReadLine());
//    var selectedPC=context.ProductColors.SingleOrDefault(pc => pc.ColorId == colorId && pc.ProductId==productId);
//    if (selectedPC != null)
//    {
//        Console.WriteLine(selectedPC.Product.Name);
//        Console.WriteLine(selectedPC.Color.Name);
//        context.ProductColors.Remove(selectedPC);
//        context.SaveChanges();
//    }
//}
