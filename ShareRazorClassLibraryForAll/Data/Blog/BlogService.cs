using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareRazorClassLibraryForAll.Data.Blog
{
    public class BlogService : IBlogService
    {
        private readonly List<Blog> _blogList;
        public BlogService()
        {
            _blogList = new List<Blog>()
             { new Blog() { Id=1, Name="C#" ,
                Description = "C# - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client",
                Url="https://kartik786-git.github.io/TestStaticPage/Courses/visual studio.PNG"},
            new Blog() {Id=2, Name="Maui" ,
                Description = "Maui - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client" ,
                Url = "https://kartik786-git.github.io/TestStaticPage/Courses/dotnet maui.PNG"},
            new Blog() { Id=3, Name="Angular" ,
                Description = "Angular - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client" ,
                Url="https://kartik786-git.github.io/TestStaticPage/Courses/architecture.PNG" },
            new Blog() {Id=4, Name="web api" ,
                Description = "web api - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client",
                Url="https://kartik786-git.github.io/TestStaticPage/Courses/asp.net core.PNG"},
            new Blog() { Id=5, Name="EF" ,
                Description = "EF - My Name is kartik and you are waching my youtube channel here we will how we can easy develop app in a smart way so that we can deliver fast to our client" ,
                Url="https://kartik786-git.github.io/TestStaticPage/Courses/csharp.PNG"}
            };
        }
        public async Task<Blog> CreateAsync(Blog blog)
        {

            blog.Id = _blogList.Count + 1;
            _blogList.Add(blog);
            return blog;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var product = _blogList.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _blogList.Remove(product);
                id = product.Id;
            }
            return id > 0 ? id : 0;
        }

        public async Task<List<Blog>> GetAllAsync()
        {
            return _blogList;
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return  _blogList.Where(f => f.Id == id).FirstOrDefault();
        }

        public async Task<int> UpdateAsync(int id, Blog blog)
        {
            var existingProduct = _blogList.FirstOrDefault(p => p.Id == blog.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = blog.Name;
                existingProduct.Description = blog.Description;
            }
            return existingProduct.Id;
        }
    }
}
