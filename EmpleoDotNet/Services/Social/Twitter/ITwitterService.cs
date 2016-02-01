﻿using System.Threading.Tasks;
using EmpleoDotNet.Models;

namespace EmpleoDotNet.Services.Social.Twitter
{
    public interface ITwitterService
    {
        Task PostTweet(string message);
        Task PostNewJobOpportunity(JobOpportunity jobOpportunity);
    }
}