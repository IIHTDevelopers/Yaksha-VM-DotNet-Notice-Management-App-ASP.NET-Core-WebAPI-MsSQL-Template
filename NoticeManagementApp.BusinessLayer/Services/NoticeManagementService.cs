using NoticeManagementApp.BusinessLayer.Interfaces;
using NoticeManagementApp.BusinessLayer.Services.Repository;
using NoticeManagementApp.BusinessLayer.ViewModels;
using NoticeManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoticeManagementApp.BusinessLayer.Services
{
    public class NoticeManagementService : INoticeManagementService
    {
        private readonly INoticeManagementRepository _repo;

        public NoticeManagementService(INoticeManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Notice> CreateNotice(Notice employeeNotice)
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
