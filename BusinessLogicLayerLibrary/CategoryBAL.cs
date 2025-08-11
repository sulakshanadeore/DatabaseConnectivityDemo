using DataAccessLayerLibrary;

namespace BusinessLogicLayerLibrary
{
    public class CategoryBAL
    {
        public int CategoryID { get; set; }

        string _catname;
       public string CategoryName 
        { 
            get 
            { 
                return _catname; 
            } 
            set 
            {
                if (!string.IsNullOrEmpty(value)) 
                { 
                _catname=value;
                
                }
                else
                {
                    throw new InvalidDataException("Categroy name cannot be empty");
                }
            
            } 
        
        }

        string _catdesc;
       public  string  CategoryDescription
        {
            get {
            return _catdesc;
            } 
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _catdesc = value;

                }
                else {
                    throw new InvalidDataException("Description cannot be null or emtpy");
                }
            } 
        
        }

        CategoriesOperations operations = new CategoriesOperations();

        public List<ProductsBAL> FindProductByCategoryIDAndOrderBySupplierid(int id)
        {
            List<Products> plist=operations.GetProductsByCategory(id);

             List<ProductsBAL> productListBal = new List<ProductsBAL>();
            foreach (var item in plist)
            {
                ProductsBAL product = new ProductsBAL();
                product.Productid = item.Prodid;
                product.Productname = item.Prodname;
                product.UnitPrice = item.Price;
                product.Supplierid = item.Suppid;
                productListBal.Add(product);
            }


            //var data = (from p in productListBal
            //           orderby p.Supplierid
            //           select p).ToList();

            var data=productListBal.OrderBy(p=>p.Supplierid).ToList();

            return data;

        }

        public List<ProductsBAL> FindProductByCategoryIDAndOrderByProductName(int id)
        {
            List<Products> plist = operations.GetProductsByCategory(id);

            List<ProductsBAL> productListBal = new List<ProductsBAL>();
            foreach (var item in plist)
            {
                ProductsBAL product = new ProductsBAL();
                product.Productid = item.Prodid;
                product.Productname = item.Prodname;
                product.UnitPrice = item.Price;
                product.Supplierid = item.Suppid;
                productListBal.Add(product);
            }


            //var data = (from p in productListBal
            //           orderby p.Supplierid
            //           select p).ToList();

            var data = productListBal.OrderBy(p => p.Productname).ToList();

            return data;

        }






        public List<CategoryBAL> CategoryList() 
        {
           List<Category> Categorieslist= operations.ShowAll();

            List<CategoryBAL> categoryBALs = new List<CategoryBAL>();
            foreach (var item in Categorieslist)
            {
                //  CategoryBAL bal = new CategoryBAL();
                //  bal.CategoryID = item.CatID;
                //  bal.CategoryName = item.Name;
                //  bal.CategoryDescription = item.Description;
                //categoryBALs.Add(bal);


                categoryBALs.Add(new CategoryBAL
                { CategoryID = item.CatID, 
                    CategoryName = item.Name, 
                    CategoryDescription = item.Description 
                });
                
            }
            return categoryBALs;

        }
        public void AddProduct(CategoryBAL category) 
        {
            Category cat = new Category();
            cat.Name = category.CategoryName;
            cat.Description = category.CategoryDescription;
            operations.NewCategory(cat);
            

        }
        public void RemoveProduct(int categoryID) 
        { 
        }
        public void EditProduct(int categroyID,CategoryBAL category) 
        { }
        //public CategoryBAL FindCategoryByID(int categoryid) { }
        //public CategoryBAL FindCategoryByName(string catname) { }
            




    }
}
