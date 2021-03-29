using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class SupportRequestRepository : ISupportRequestRepository
    {
        public IQueryable<SupportRequest> SupportRequests
        {
            get
            {
                var result = new List<SupportRequest>();
                for (int i = 1; i <= 500; i++)
                {
                    var sr = new SupportRequest
                    {
                        SupportRequestId = i,
                        Date = DateTime.Now.AddMinutes(-500).AddMinutes(i),
                        Subject = $"Subject {i}",
                        Description = $"Description {i} Description Description Description Description",
                        Email = $"user{i}@example.com"
                    };

                    result.Add(sr);
                }

                return result.AsQueryable();
            }
        }
    }
}