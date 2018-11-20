using ECommerce.Database;
using ECommerce.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace ECommerce.Service
{
    public class CategoryServices
    {

        public Category GetCategory(int ID)
        {
            using (var context = new ECommerceDbContext())
            {
                return context.Categories.Find(ID);
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new ECommerceDbContext())
            {
                return context.Categories.ToList();
            }
        }

        public List<Category> GetFeaturedCategories()
        {
            using (var context = new ECommerceDbContext())
            {
                return context.Categories.Where(x => x.isFeatured && x.ImageURL != null).ToList();
            }
        }

        public void SaveCategory(Category category)
        {
            using (var context = new ECommerceDbContext())
            {
                context.Categories.Add(category);
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }

            }
        }
        public void UpdateCategory(Category category)
        {
            using (var context = new ECommerceDbContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int ID)
        {
            using (var context = new ECommerceDbContext())
            {

                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
