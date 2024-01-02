using Microsoft.EntityFrameworkCore;
using NoticeManagementApp.BusinessLayer.ViewModels;
using NoticeManagementApp.DataLayer;
using NoticeManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NoticeManagementApp.BusinessLayer.Services.Repository
{
    public class NoticeManagementRepository : INoticeManagementRepository
    {
        private readonly NoticeManagementAppDbContext _dbContext;
        public NoticeManagementRepository(NoticeManagementAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Notice> CreateNotice(Notice NoticeModel)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteNoticeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Notice> GetAllNotices()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Notice> GetNoticeById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

       
        public async Task<Notice> UpdateNotice(NoticeViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}