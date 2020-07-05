using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureDevOpsDemo.Models;

namespace AzureDevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            return new List<PostViewModel>()
            {
                new PostViewModel()
                {
                    PostId = 101,
                    Title = "DevOps Demo Title 1",
                    Description = "DevOps Demo Description 1",
                    Author = "Mahavirsinh Padhiyar"
                },
                new PostViewModel()
                {
                    PostId = 102,
                    Title = "DevOps Demo Title 2",
                    Description = "DevOps Demo Description 2",
                    Author = "Mukesh Kumar"
                },
                new PostViewModel()
                {
                    PostId = 103,
                    Title = "DevOps Demo Title 3",
                    Description = "DevOps Demo Description 3",
                    Author = "Digvijaysinh Padhiyar"
                }
            };
        }
    }
}
